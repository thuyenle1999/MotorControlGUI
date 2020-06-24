using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace MotionControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configure serial port default properties
            PortNameComboBox.DataSource = SerialPort.GetPortNames();
            BaudRateComboBox.SelectedIndex = 12;
            DataBitsComboBox.SelectedIndex = 5;
            ParityComboBox.SelectedIndex = 0;
            StopBitsComboBox.SelectedIndex = 1;

            KpTextBox.Text = Convert.ToString(defaultPositionKp);
            KiTextBox.Text = Convert.ToString(defaultPositionKi);
            KdTextBox.Text = Convert.ToString(defaultPositionKd);


            InitializeTable();

            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceive);

            //timer1.Enabled = true;

            InitializeGraphs();

            //5SerialPortTerminal.AppendText(Convert.ToString(Color.SlateGray.R) + Convert.ToString(Color.SlateGray.G) + Convert.ToString(Color.SlateGray.B));
        }

        DataTable dataTable = new DataTable();
        ExcelExport excelExport = new ExcelExport();
        delegate void SetTextCallback();
        byte[] receiveBuffer = new byte[27];
        byte[] sendBuffer = new byte[24];
        //double count;
        double time = 0;
        double speedSetpoint, currentSpeed, positionSetpoint, currentPosition;
        GraphMode graphMode = GraphMode.Follow;
        GraphControl positionGraphControl = new GraphControl();
        GraphControl speedGraphControl = new GraphControl();
        float Kp, Ki, Kd;
        const float defaultPositionKp = 5.5F, defaultPositionKi = 1.3F, defaultPositionKd = 5F;
        const float defaultSpeedKp = 0.175F, defaultSpeedKi = 0.95F, defaultSpeedKd = 0.005F;
        const byte stx = 100, etx = 101;
        byte[] ack = { 100, 102, 101 };

        bool lastFrame = true;
        //lastFrame = true: last frame is a set frame
        //lastFrame = false: last frame is a stop frame


        private void InitializeTable()
        {
            dataTable.Columns.Add("Time", typeof(double));
            dataTable.Columns.Add("Control Mode", typeof(string));
            dataTable.Columns.Add("Setpoint", typeof(double));
            dataTable.Columns.Add("Current Position", typeof(double));
            dataTable.Columns.Add("Current Speed", typeof(double));
            DataTableGridView.DataSource = dataTable;
            DataTableGridView.Columns[0].Width = 82;
            DataTableGridView.Columns[1].Width = 82;
            DataTableGridView.Columns[2].Width = 82;
            DataTableGridView.Columns[3].Width = 82;
            DataTableGridView.Columns[4].Width = 82;
        }

        private void ConnectSerialPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = PortNameComboBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serialPort.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), ParityComboBox.Text);
            serialPort.DataBits = Convert.ToInt32(DataBitsComboBox.Text);
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBitsComboBox.Text);
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    SerialPortConnectionStatusTextBox.Text = "Connected";
                    SerialPortConnectionStatusTextBox.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("The serial port is running");
            }
        }

        private void DisconnectSerialPortButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    SerialPortConnectionStatusTextBox.Text = "Disonnected";
                    SerialPortConnectionStatusTextBox.BackColor = Color.Red;
                    timer1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            Thread ExportExcelThread = new Thread(ExportToExcel);
            ExportExcelThread.IsBackground = true;
            ExportExcelThread.Start();
            //ExportToExcel();
        }

        private void ExportToExcel()
        {
            excelExport.SaveToExcel(dataTable);
        }

        private void ClearTableButton_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            //SerialPortTerminal.Clear();
            //serialPort.DiscardInBuffer();
        }

        private void SerialPortSendButton_Click(object sender, EventArgs e)
        {
            SerialPortTerminal.Clear();
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                if (serialPort.BytesToRead > 27)
                {
                    serialPort.Read(receiveBuffer, 0, 27);
                    ProcessData();
                }
            } else
            {
                //if (serialPort.BytesToRead > 3)
                {
                    serialPort.Read(receiveBuffer, 0, 3);
                    VerifyACK();
                }
            }
            
        }

        private void VerifyACK()
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(VerifyACK);
                this.Invoke(d, new object[] { });
            } else
            {
                SerialPortTerminal.AppendText(BitConverter.ToString(receiveBuffer) + "\n");
                if ((receiveBuffer[0] == stx) & (receiveBuffer[1] == ack[1]) & (receiveBuffer[2] == etx))
                {
                    timer1.Enabled = false;
                } else
                {
                    serialPort.DiscardInBuffer();
                }
            }        
        }

        private void ProcessData ()
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ProcessData);
                this.Invoke(d, new object[] { });
            }
            else
            {
                SerialPortTerminal.AppendText(BitConverter.ToString(receiveBuffer) + "\n");
                time += 0.025;
                if (VerifyFrame(receiveBuffer)) 
                {  
                    currentPosition = BitConverter.ToDouble(receiveBuffer,1);
                    currentSpeed = BitConverter.ToDouble(receiveBuffer, 9);
                    positionGraphControl.UpdateGraph(PositionGraph, 1, time, currentPosition, graphMode);
                    speedGraphControl.UpdateGraph(SpeedGraph, 1, time, currentSpeed, graphMode);
                    if (PositionRadioButton.Checked)
                    {
                        dataTable.Rows.Add(time, "Position", positionSetpoint, currentPosition, currentSpeed);
                        positionGraphControl.UpdateGraph(PositionGraph, 0, time, positionSetpoint, graphMode);
                    }
                    if (SpeedRadioButton.Checked)
                    {
                        dataTable.Rows.Add(time, "Speed", speedSetpoint, currentPosition, currentSpeed);
                        speedGraphControl.UpdateGraph(SpeedGraph, 0, time, speedSetpoint, graphMode);
                    }
                    PowerTextBox.Text = Convert.ToString(Math.Round(BitConverter.ToDouble(receiveBuffer, 17),2)) + "%";
                    CurrentPositionTextBox.Text = Convert.ToString(currentPosition);
                    CurrentSpeedTextBox.Text = Convert.ToString(currentSpeed);
                    //serialPort.Write(ack, 0, 3);
                    //SerialPortTerminal.AppendText(BitConverter.ToString(ack) + "\n");
                }
                else
                {
                    serialPort.DiscardInBuffer();
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                if (lastFrame == true)
                {
                    Set();
                } else
                {
                    Stop();
                }
            }
                
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop();
            timer1.Enabled = true;
            StatusLabel.Text = "Status: Stopped";
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            Set();
            timer1.Enabled = true;
            StatusLabel.Text = "Status: Running";
        }

        private void PositionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PositionSetpointTextBox.ReadOnly = false;
            SpeedSetpointTextBox.Text = "";
            SpeedSetpointTextBox.ReadOnly = true;
            SetButton.Text = "SET POSITION";
            if (DefaultPIDRadioButton.Checked)
            {
                KpTextBox.Text = Convert.ToString(defaultPositionKp);
                KiTextBox.Text = Convert.ToString(defaultPositionKi);
                KdTextBox.Text = Convert.ToString(defaultPositionKd);
            }
        }

        private void SpeedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SpeedSetpointTextBox.ReadOnly = false;
            PositionSetpointTextBox.Text = "";
            PositionSetpointTextBox.ReadOnly = true;
            SetButton.Text = "SET SPEED";
            if (DefaultPIDRadioButton.Checked)
            {
                KpTextBox.Text = Convert.ToString(defaultSpeedKp);
                KiTextBox.Text = Convert.ToString(defaultSpeedKi);
                KdTextBox.Text = Convert.ToString(defaultSpeedKd);
            }
        }

        private void FollowRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            graphMode = GraphMode.Follow;
        }

        private void AutoScaleRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            graphMode = GraphMode.AutoScale;
        }

        private void HoldRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            graphMode = GraphMode.Hold;
        }

        private void DefaultPIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PositionRadioButton.Checked)
            {
                KpTextBox.Text = Convert.ToString(defaultPositionKp);
                KiTextBox.Text = Convert.ToString(defaultPositionKi);
                KdTextBox.Text = Convert.ToString(defaultPositionKd);
            }
            if (SpeedRadioButton.Checked)
            {
                KpTextBox.Text = Convert.ToString(defaultSpeedKp);
                KiTextBox.Text = Convert.ToString(defaultSpeedKi);
                KdTextBox.Text = Convert.ToString(defaultSpeedKd);
            }
            KpTextBox.ReadOnly = true;
            KiTextBox.ReadOnly = true;
            KdTextBox.ReadOnly = true;
        }

        private void CustomPIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KpTextBox.ReadOnly = false;
            KiTextBox.ReadOnly = false;
            KdTextBox.ReadOnly = false;
        }

        private void ClearGraphButton_Click(object sender, EventArgs e)
        {
            positionGraphControl.ClearGraph(PositionGraph);
            speedGraphControl.ClearGraph(SpeedGraph);
            InitializeGraphs();
            time = 0;
        }

        private void InitializeGraphs()
        {
            positionGraphControl.Initialize(PositionGraph, 10, 0, 50, -50, "Position Graph", "Time(s)", "Position (Degree)");
            speedGraphControl.Initialize(SpeedGraph, 10, 0, 50, -50, "Speed Graph", "Time(s)", "Speed (rpm)");
            positionGraphControl.AddGraph(PositionGraph, "Setpoint", Color.Red);
            positionGraphControl.AddGraph(PositionGraph, "Current Position", Color.Blue);
            speedGraphControl.AddGraph(SpeedGraph, "Setpoint", Color.Red);
            speedGraphControl.AddGraph(SpeedGraph, "Current Speed", Color.Blue);
        }

        private double TextToDouble(string text)
        {
            try
            {
                return (Convert.ToDouble(text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (0);
            }
        }

        private float TextToFloat(string text)
        {
            try
            {
                return (Convert.ToSingle(text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (0);
            }
        }

        private byte GetCRC(byte[] preCRC, int end)
        {
            int sum = 0;
            for (int i = 1; i < end; i++)
            {
                sum += preCRC[i];
            }
            byte[] sumByte = BitConverter.GetBytes(sum);
            //PowerTextBox.Text = Convert.ToString(sumByte[0]);
            return (sumByte[0]);
        }

        private bool VerifyFrame(byte[] preVeryfing)
        {
            byte crc = GetCRC(preVeryfing, 25);
            if ((preVeryfing[0]==stx)&(preVeryfing[26]==etx)&(preVeryfing[25]==crc))
            {
                return (true);
            } else
            {
                return (false);
            }
        }

        private void Set()
        {
            sendBuffer[0] = stx;
            sendBuffer[23] = etx;
            if (PositionRadioButton.Checked)
            {
                positionSetpoint = TextToDouble(PositionSetpointTextBox.Text);
                Array.Copy(BitConverter.GetBytes(positionSetpoint), 0, sendBuffer, 2, 8);
                sendBuffer[1] = 2;
            }
            if (SpeedRadioButton.Checked)
            {
                speedSetpoint = TextToDouble(SpeedSetpointTextBox.Text);
                Array.Copy(BitConverter.GetBytes(speedSetpoint), 0, sendBuffer, 2, 8);
                sendBuffer[1] = 1;
            }
            Kp = TextToFloat(KpTextBox.Text);
            Array.Copy(BitConverter.GetBytes(Kp), 0, sendBuffer, 10, 4);
            Ki = TextToFloat(KiTextBox.Text);
            Array.Copy(BitConverter.GetBytes(Ki), 0, sendBuffer, 14, 4);
            Kd = TextToFloat(KdTextBox.Text);
            Array.Copy(BitConverter.GetBytes(Kd), 0, sendBuffer, 18, 4);
            byte[] preCRC = new byte[22];
            Array.Copy(sendBuffer, 0, preCRC, 0, 22);
            sendBuffer[22] = GetCRC(preCRC,22);
            try
            {
                serialPort.Write(sendBuffer, 0, 24);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //SerialPortTerminal.AppendText(BitConverter.ToString(sendBuffer) + "\n");
            //positionGraphControl.ClearGraph(PositionGraph);
            //speedGraphControl.ClearGraph(SpeedGraph);
            //InitializeGraphs();
            //time = 0;
            lastFrame = true;
        }
         private void Stop()
        {
            sendBuffer[0] = stx;
            sendBuffer[23] = etx;
            sendBuffer[1] = 0;
            byte[] blank = { 0, 0, 0, 0, 0, 0, 0, 0 };
            Array.Copy(blank, 0, sendBuffer, 2, 8);
            Kp = TextToFloat(KpTextBox.Text);
            Array.Copy(BitConverter.GetBytes(Kp), 0, sendBuffer, 10, 4);
            Ki = TextToFloat(KiTextBox.Text);
            Array.Copy(BitConverter.GetBytes(Ki), 0, sendBuffer, 14, 4);
            Kd = TextToFloat(KdTextBox.Text);
            Array.Copy(BitConverter.GetBytes(Kd), 0, sendBuffer, 18, 4);
            byte[] preCRC = new byte[22];
            Array.Copy(sendBuffer, 0, preCRC, 0, 22);
            sendBuffer[22] = GetCRC(preCRC, 22);
            try
            {
                serialPort.Write(sendBuffer, 0, 24);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lastFrame = false;
            //SerialPortTerminal.AppendText(BitConverter.ToString(sendBuffer) + "\n");
        }
    }
}
