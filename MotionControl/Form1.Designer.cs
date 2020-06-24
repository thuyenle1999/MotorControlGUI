namespace MotionControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PositionGroup = new System.Windows.Forms.GroupBox();
            this.PositionSetpointTextBox = new System.Windows.Forms.TextBox();
            this.PositionSetpointLabel = new System.Windows.Forms.Label();
            this.CurrentPositionLabel = new System.Windows.Forms.Label();
            this.CurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.SpeedGroup = new System.Windows.Forms.GroupBox();
            this.SpeedSetpointTextBox = new System.Windows.Forms.TextBox();
            this.SpeedSetpointLabel = new System.Windows.Forms.Label();
            this.CurrentSpeedLabel = new System.Windows.Forms.Label();
            this.CurrentSpeedTextBox = new System.Windows.Forms.TextBox();
            this.ControlModeGroup = new System.Windows.Forms.GroupBox();
            this.SpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionRadioButton = new System.Windows.Forms.RadioButton();
            this.StopButton = new System.Windows.Forms.Button();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.DisconnectSerialPortButton = new System.Windows.Forms.Button();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.DataTableGridView = new System.Windows.Forms.DataGridView();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.SerialPortTerminal = new System.Windows.Forms.RichTextBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.PortNameComboBox = new System.Windows.Forms.ComboBox();
            this.ClearTerminalButton = new System.Windows.Forms.Button();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectSerialPortButton = new System.Windows.Forms.Button();
            this.SerialPortConnectionStatusTextBox = new System.Windows.Forms.TextBox();
            this.PortConfigurationGroup = new System.Windows.Forms.GroupBox();
            this.TerminalGroup = new System.Windows.Forms.GroupBox();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.DataTableGroup = new System.Windows.Forms.GroupBox();
            this.ClearTableButton = new System.Windows.Forms.Button();
            this.PositionGraph = new ZedGraph.ZedGraphControl();
            this.SpeedGraph = new ZedGraph.ZedGraphControl();
            this.GraphGroup = new System.Windows.Forms.GroupBox();
            this.FollowRadioBox = new System.Windows.Forms.RadioButton();
            this.HoldRadioBox = new System.Windows.Forms.RadioButton();
            this.AutoScaleRadioBox = new System.Windows.Forms.RadioButton();
            this.ClearGraphButton = new System.Windows.Forms.Button();
            this.PIDGroup = new System.Windows.Forms.GroupBox();
            this.CustomPIDRadioButton = new System.Windows.Forms.RadioButton();
            this.DefaultPIDRadioButton = new System.Windows.Forms.RadioButton();
            this.KdLabel = new System.Windows.Forms.Label();
            this.KiLabel = new System.Windows.Forms.Label();
            this.KpLabel = new System.Windows.Forms.Label();
            this.KdTextBox = new System.Windows.Forms.TextBox();
            this.KiTextBox = new System.Windows.Forms.TextBox();
            this.KpTextBox = new System.Windows.Forms.TextBox();
            this.PowerGroup = new System.Windows.Forms.GroupBox();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.PositionGroup.SuspendLayout();
            this.SpeedGroup.SuspendLayout();
            this.ControlModeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableGridView)).BeginInit();
            this.PortConfigurationGroup.SuspendLayout();
            this.TerminalGroup.SuspendLayout();
            this.ControlGroup.SuspendLayout();
            this.DataTableGroup.SuspendLayout();
            this.GraphGroup.SuspendLayout();
            this.PIDGroup.SuspendLayout();
            this.PowerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM10";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(474, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(204, 33);
            this.Title.TabIndex = 15;
            this.Title.Text = "Motor Control";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PositionGroup
            // 
            this.PositionGroup.BackColor = System.Drawing.Color.White;
            this.PositionGroup.Controls.Add(this.PositionSetpointTextBox);
            this.PositionGroup.Controls.Add(this.PositionSetpointLabel);
            this.PositionGroup.Controls.Add(this.CurrentPositionLabel);
            this.PositionGroup.Controls.Add(this.CurrentPositionTextBox);
            this.PositionGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PositionGroup.Location = new System.Drawing.Point(267, 49);
            this.PositionGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PositionGroup.Name = "PositionGroup";
            this.PositionGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PositionGroup.Size = new System.Drawing.Size(235, 87);
            this.PositionGroup.TabIndex = 0;
            this.PositionGroup.TabStop = false;
            this.PositionGroup.Text = "Position (Degree)";
            // 
            // PositionSetpointTextBox
            // 
            this.PositionSetpointTextBox.Location = new System.Drawing.Point(96, 55);
            this.PositionSetpointTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PositionSetpointTextBox.Name = "PositionSetpointTextBox";
            this.PositionSetpointTextBox.Size = new System.Drawing.Size(116, 23);
            this.PositionSetpointTextBox.TabIndex = 3;
            this.PositionSetpointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PositionSetpointLabel
            // 
            this.PositionSetpointLabel.AutoSize = true;
            this.PositionSetpointLabel.Location = new System.Drawing.Point(7, 59);
            this.PositionSetpointLabel.Name = "PositionSetpointLabel";
            this.PositionSetpointLabel.Size = new System.Drawing.Size(63, 16);
            this.PositionSetpointLabel.TabIndex = 2;
            this.PositionSetpointLabel.Text = "Setpoint";
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.AutoSize = true;
            this.CurrentPositionLabel.Location = new System.Drawing.Point(7, 27);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(58, 16);
            this.CurrentPositionLabel.TabIndex = 1;
            this.CurrentPositionLabel.Text = "Current";
            // 
            // CurrentPositionTextBox
            // 
            this.CurrentPositionTextBox.Location = new System.Drawing.Point(96, 22);
            this.CurrentPositionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentPositionTextBox.Name = "CurrentPositionTextBox";
            this.CurrentPositionTextBox.ReadOnly = true;
            this.CurrentPositionTextBox.Size = new System.Drawing.Size(116, 23);
            this.CurrentPositionTextBox.TabIndex = 0;
            this.CurrentPositionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpeedGroup
            // 
            this.SpeedGroup.BackColor = System.Drawing.Color.White;
            this.SpeedGroup.Controls.Add(this.SpeedSetpointTextBox);
            this.SpeedGroup.Controls.Add(this.SpeedSetpointLabel);
            this.SpeedGroup.Controls.Add(this.CurrentSpeedLabel);
            this.SpeedGroup.Controls.Add(this.CurrentSpeedTextBox);
            this.SpeedGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SpeedGroup.Location = new System.Drawing.Point(267, 142);
            this.SpeedGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedGroup.Name = "SpeedGroup";
            this.SpeedGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedGroup.Size = new System.Drawing.Size(235, 87);
            this.SpeedGroup.TabIndex = 4;
            this.SpeedGroup.TabStop = false;
            this.SpeedGroup.Text = "Speed (rpm)";
            // 
            // SpeedSetpointTextBox
            // 
            this.SpeedSetpointTextBox.Location = new System.Drawing.Point(96, 55);
            this.SpeedSetpointTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedSetpointTextBox.Name = "SpeedSetpointTextBox";
            this.SpeedSetpointTextBox.ReadOnly = true;
            this.SpeedSetpointTextBox.Size = new System.Drawing.Size(116, 23);
            this.SpeedSetpointTextBox.TabIndex = 3;
            this.SpeedSetpointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpeedSetpointLabel
            // 
            this.SpeedSetpointLabel.AutoSize = true;
            this.SpeedSetpointLabel.Location = new System.Drawing.Point(7, 59);
            this.SpeedSetpointLabel.Name = "SpeedSetpointLabel";
            this.SpeedSetpointLabel.Size = new System.Drawing.Size(63, 16);
            this.SpeedSetpointLabel.TabIndex = 2;
            this.SpeedSetpointLabel.Text = "Setpoint";
            // 
            // CurrentSpeedLabel
            // 
            this.CurrentSpeedLabel.AutoSize = true;
            this.CurrentSpeedLabel.Location = new System.Drawing.Point(7, 27);
            this.CurrentSpeedLabel.Name = "CurrentSpeedLabel";
            this.CurrentSpeedLabel.Size = new System.Drawing.Size(58, 16);
            this.CurrentSpeedLabel.TabIndex = 1;
            this.CurrentSpeedLabel.Text = "Current";
            // 
            // CurrentSpeedTextBox
            // 
            this.CurrentSpeedTextBox.Location = new System.Drawing.Point(96, 22);
            this.CurrentSpeedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSpeedTextBox.Name = "CurrentSpeedTextBox";
            this.CurrentSpeedTextBox.ReadOnly = true;
            this.CurrentSpeedTextBox.Size = new System.Drawing.Size(116, 23);
            this.CurrentSpeedTextBox.TabIndex = 0;
            this.CurrentSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlModeGroup
            // 
            this.ControlModeGroup.BackColor = System.Drawing.Color.White;
            this.ControlModeGroup.Controls.Add(this.SpeedRadioButton);
            this.ControlModeGroup.Controls.Add(this.PositionRadioButton);
            this.ControlModeGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlModeGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ControlModeGroup.Location = new System.Drawing.Point(508, 257);
            this.ControlModeGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ControlModeGroup.Name = "ControlModeGroup";
            this.ControlModeGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ControlModeGroup.Size = new System.Drawing.Size(160, 45);
            this.ControlModeGroup.TabIndex = 5;
            this.ControlModeGroup.TabStop = false;
            this.ControlModeGroup.Text = "Control Mode";
            // 
            // SpeedRadioButton
            // 
            this.SpeedRadioButton.AutoSize = true;
            this.SpeedRadioButton.Location = new System.Drawing.Point(88, 18);
            this.SpeedRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedRadioButton.Name = "SpeedRadioButton";
            this.SpeedRadioButton.Size = new System.Drawing.Size(66, 20);
            this.SpeedRadioButton.TabIndex = 6;
            this.SpeedRadioButton.Text = "Speed";
            this.SpeedRadioButton.UseVisualStyleBackColor = true;
            this.SpeedRadioButton.CheckedChanged += new System.EventHandler(this.SpeedRadioButton_CheckedChanged);
            // 
            // PositionRadioButton
            // 
            this.PositionRadioButton.AutoSize = true;
            this.PositionRadioButton.Checked = true;
            this.PositionRadioButton.Location = new System.Drawing.Point(6, 18);
            this.PositionRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PositionRadioButton.Name = "PositionRadioButton";
            this.PositionRadioButton.Size = new System.Drawing.Size(77, 20);
            this.PositionRadioButton.TabIndex = 5;
            this.PositionRadioButton.TabStop = true;
            this.PositionRadioButton.Text = "Position";
            this.PositionRadioButton.UseVisualStyleBackColor = true;
            this.PositionRadioButton.CheckedChanged += new System.EventHandler(this.PositionRadioButton_CheckedChanged);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(30, 83);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(103, 32);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(10, 125);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(47, 16);
            this.ParityLabel.TabIndex = 5;
            this.ParityLabel.Text = "Parity";
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Location = new System.Drawing.Point(11, 157);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(66, 16);
            this.StopBitsLabel.TabIndex = 6;
            this.StopBitsLabel.Text = "Stop Bits";
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(10, 95);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(67, 16);
            this.DataBitsLabel.TabIndex = 4;
            this.DataBitsLabel.Text = "Data Bits";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(10, 63);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(75, 16);
            this.BaudRateLabel.TabIndex = 3;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // DisconnectSerialPortButton
            // 
            this.DisconnectSerialPortButton.BackColor = System.Drawing.Color.SlateGray;
            this.DisconnectSerialPortButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DisconnectSerialPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectSerialPortButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectSerialPortButton.ForeColor = System.Drawing.Color.White;
            this.DisconnectSerialPortButton.Location = new System.Drawing.Point(13, 181);
            this.DisconnectSerialPortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisconnectSerialPortButton.Name = "DisconnectSerialPortButton";
            this.DisconnectSerialPortButton.Size = new System.Drawing.Size(104, 32);
            this.DisconnectSerialPortButton.TabIndex = 8;
            this.DisconnectSerialPortButton.Text = "Disconnect";
            this.DisconnectSerialPortButton.UseVisualStyleBackColor = false;
            this.DisconnectSerialPortButton.Click += new System.EventHandler(this.DisconnectSerialPortButton_Click);
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(10, 29);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(75, 16);
            this.PortNameLabel.TabIndex = 2;
            this.PortNameLabel.Text = "Port Name";
            // 
            // DataTableGridView
            // 
            this.DataTableGridView.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DataTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableGridView.Location = new System.Drawing.Point(7, 23);
            this.DataTableGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataTableGridView.Name = "DataTableGridView";
            this.DataTableGridView.ReadOnly = true;
            this.DataTableGridView.Size = new System.Drawing.Size(453, 175);
            this.DataTableGridView.TabIndex = 9;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.ParityComboBox.Location = new System.Drawing.Point(91, 117);
            this.ParityComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(140, 24);
            this.ParityComboBox.TabIndex = 1;
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.BackColor = System.Drawing.Color.SlateGray;
            this.ExportToExcelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExportToExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToExcelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToExcelButton.ForeColor = System.Drawing.Color.White;
            this.ExportToExcelButton.Location = new System.Drawing.Point(236, 206);
            this.ExportToExcelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(119, 38);
            this.ExportToExcelButton.TabIndex = 10;
            this.ExportToExcelButton.Text = "Export To Excel";
            this.ExportToExcelButton.UseVisualStyleBackColor = false;
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.DataBitsComboBox.Location = new System.Drawing.Point(91, 85);
            this.DataBitsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(140, 24);
            this.DataBitsComboBox.TabIndex = 1;
            // 
            // SerialPortTerminal
            // 
            this.SerialPortTerminal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPortTerminal.Location = new System.Drawing.Point(6, 24);
            this.SerialPortTerminal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPortTerminal.Name = "SerialPortTerminal";
            this.SerialPortTerminal.Size = new System.Drawing.Size(236, 114);
            this.SerialPortTerminal.TabIndex = 11;
            this.SerialPortTerminal.Text = "";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.StopBitsComboBox.Location = new System.Drawing.Point(91, 149);
            this.StopBitsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(140, 24);
            this.StopBitsComboBox.TabIndex = 1;
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNameComboBox.FormattingEnabled = true;
            this.PortNameComboBox.Location = new System.Drawing.Point(91, 21);
            this.PortNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PortNameComboBox.Size = new System.Drawing.Size(140, 24);
            this.PortNameComboBox.TabIndex = 1;
            // 
            // ClearTerminalButton
            // 
            this.ClearTerminalButton.BackColor = System.Drawing.Color.SlateGray;
            this.ClearTerminalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearTerminalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTerminalButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTerminalButton.ForeColor = System.Drawing.Color.White;
            this.ClearTerminalButton.Location = new System.Drawing.Point(74, 146);
            this.ClearTerminalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearTerminalButton.Name = "ClearTerminalButton";
            this.ClearTerminalButton.Size = new System.Drawing.Size(114, 32);
            this.ClearTerminalButton.TabIndex = 13;
            this.ClearTerminalButton.Text = "Clear Terminal";
            this.ClearTerminalButton.UseVisualStyleBackColor = false;
            this.ClearTerminalButton.Click += new System.EventHandler(this.SerialPortSendButton_Click);
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "1400",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "152000",
            "128000",
            "256000"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(91, 53);
            this.BaudRateComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(140, 24);
            this.BaudRateComboBox.TabIndex = 1;
            // 
            // ConnectSerialPortButton
            // 
            this.ConnectSerialPortButton.BackColor = System.Drawing.Color.SlateGray;
            this.ConnectSerialPortButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConnectSerialPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectSerialPortButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectSerialPortButton.ForeColor = System.Drawing.Color.White;
            this.ConnectSerialPortButton.Location = new System.Drawing.Point(128, 181);
            this.ConnectSerialPortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectSerialPortButton.Name = "ConnectSerialPortButton";
            this.ConnectSerialPortButton.Size = new System.Drawing.Size(103, 32);
            this.ConnectSerialPortButton.TabIndex = 0;
            this.ConnectSerialPortButton.Text = "Connect";
            this.ConnectSerialPortButton.UseVisualStyleBackColor = false;
            this.ConnectSerialPortButton.Click += new System.EventHandler(this.ConnectSerialPortButton_Click);
            // 
            // SerialPortConnectionStatusTextBox
            // 
            this.SerialPortConnectionStatusTextBox.BackColor = System.Drawing.Color.Red;
            this.SerialPortConnectionStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerialPortConnectionStatusTextBox.ForeColor = System.Drawing.Color.White;
            this.SerialPortConnectionStatusTextBox.Location = new System.Drawing.Point(14, 221);
            this.SerialPortConnectionStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPortConnectionStatusTextBox.Name = "SerialPortConnectionStatusTextBox";
            this.SerialPortConnectionStatusTextBox.ReadOnly = true;
            this.SerialPortConnectionStatusTextBox.Size = new System.Drawing.Size(217, 23);
            this.SerialPortConnectionStatusTextBox.TabIndex = 7;
            this.SerialPortConnectionStatusTextBox.Text = "Disconnected";
            this.SerialPortConnectionStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortConfigurationGroup
            // 
            this.PortConfigurationGroup.BackColor = System.Drawing.Color.White;
            this.PortConfigurationGroup.Controls.Add(this.StopBitsComboBox);
            this.PortConfigurationGroup.Controls.Add(this.ParityLabel);
            this.PortConfigurationGroup.Controls.Add(this.SerialPortConnectionStatusTextBox);
            this.PortConfigurationGroup.Controls.Add(this.StopBitsLabel);
            this.PortConfigurationGroup.Controls.Add(this.DataBitsLabel);
            this.PortConfigurationGroup.Controls.Add(this.BaudRateLabel);
            this.PortConfigurationGroup.Controls.Add(this.ConnectSerialPortButton);
            this.PortConfigurationGroup.Controls.Add(this.PortNameLabel);
            this.PortConfigurationGroup.Controls.Add(this.BaudRateComboBox);
            this.PortConfigurationGroup.Controls.Add(this.ParityComboBox);
            this.PortConfigurationGroup.Controls.Add(this.DisconnectSerialPortButton);
            this.PortConfigurationGroup.Controls.Add(this.DataBitsComboBox);
            this.PortConfigurationGroup.Controls.Add(this.PortNameComboBox);
            this.PortConfigurationGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortConfigurationGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PortConfigurationGroup.Location = new System.Drawing.Point(12, 49);
            this.PortConfigurationGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortConfigurationGroup.Name = "PortConfigurationGroup";
            this.PortConfigurationGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortConfigurationGroup.Size = new System.Drawing.Size(249, 253);
            this.PortConfigurationGroup.TabIndex = 15;
            this.PortConfigurationGroup.TabStop = false;
            this.PortConfigurationGroup.Text = "Port Configuration";
            // 
            // TerminalGroup
            // 
            this.TerminalGroup.BackColor = System.Drawing.Color.White;
            this.TerminalGroup.Controls.Add(this.SerialPortTerminal);
            this.TerminalGroup.Controls.Add(this.ClearTerminalButton);
            this.TerminalGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TerminalGroup.Location = new System.Drawing.Point(11, 425);
            this.TerminalGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TerminalGroup.Name = "TerminalGroup";
            this.TerminalGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TerminalGroup.Size = new System.Drawing.Size(250, 186);
            this.TerminalGroup.TabIndex = 16;
            this.TerminalGroup.TabStop = false;
            this.TerminalGroup.Text = "Terminal";
            // 
            // ControlGroup
            // 
            this.ControlGroup.BackColor = System.Drawing.Color.White;
            this.ControlGroup.Controls.Add(this.StatusLabel);
            this.ControlGroup.Controls.Add(this.StopButton);
            this.ControlGroup.Controls.Add(this.SetButton);
            this.ControlGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ControlGroup.Location = new System.Drawing.Point(508, 125);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(160, 126);
            this.ControlGroup.TabIndex = 17;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "Control";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(0, 17);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(160, 21);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status: Stopped";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetButton
            // 
            this.SetButton.BackColor = System.Drawing.Color.SlateGray;
            this.SetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.ForeColor = System.Drawing.Color.White;
            this.SetButton.Location = new System.Drawing.Point(30, 42);
            this.SetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(103, 32);
            this.SetButton.TabIndex = 9;
            this.SetButton.Text = "SET POSITION";
            this.SetButton.UseVisualStyleBackColor = false;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // DataTableGroup
            // 
            this.DataTableGroup.BackColor = System.Drawing.Color.White;
            this.DataTableGroup.Controls.Add(this.DataTableGridView);
            this.DataTableGroup.Controls.Add(this.ClearTableButton);
            this.DataTableGroup.Controls.Add(this.ExportToExcelButton);
            this.DataTableGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTableGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DataTableGroup.Location = new System.Drawing.Point(674, 49);
            this.DataTableGroup.Name = "DataTableGroup";
            this.DataTableGroup.Size = new System.Drawing.Size(469, 253);
            this.DataTableGroup.TabIndex = 18;
            this.DataTableGroup.TabStop = false;
            this.DataTableGroup.Text = "Data Table";
            // 
            // ClearTableButton
            // 
            this.ClearTableButton.BackColor = System.Drawing.Color.SlateGray;
            this.ClearTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTableButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTableButton.ForeColor = System.Drawing.Color.White;
            this.ClearTableButton.Location = new System.Drawing.Point(111, 206);
            this.ClearTableButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearTableButton.Name = "ClearTableButton";
            this.ClearTableButton.Size = new System.Drawing.Size(119, 38);
            this.ClearTableButton.TabIndex = 10;
            this.ClearTableButton.Text = "Clear Table";
            this.ClearTableButton.UseVisualStyleBackColor = false;
            this.ClearTableButton.Click += new System.EventHandler(this.ClearTableButton_Click);
            // 
            // PositionGraph
            // 
            this.PositionGraph.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.PositionGraph.Location = new System.Drawing.Point(266, 308);
            this.PositionGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PositionGraph.Name = "PositionGraph";
            this.PositionGraph.ScrollGrace = 0D;
            this.PositionGraph.ScrollMaxX = 0D;
            this.PositionGraph.ScrollMaxY = 0D;
            this.PositionGraph.ScrollMaxY2 = 0D;
            this.PositionGraph.ScrollMinX = 0D;
            this.PositionGraph.ScrollMinY = 0D;
            this.PositionGraph.ScrollMinY2 = 0D;
            this.PositionGraph.Size = new System.Drawing.Size(435, 304);
            this.PositionGraph.TabIndex = 19;
            this.PositionGraph.UseExtendedPrintDialog = true;
            // 
            // SpeedGraph
            // 
            this.SpeedGraph.Location = new System.Drawing.Point(708, 308);
            this.SpeedGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeedGraph.Name = "SpeedGraph";
            this.SpeedGraph.ScrollGrace = 0D;
            this.SpeedGraph.ScrollMaxX = 0D;
            this.SpeedGraph.ScrollMaxY = 0D;
            this.SpeedGraph.ScrollMaxY2 = 0D;
            this.SpeedGraph.ScrollMinX = 0D;
            this.SpeedGraph.ScrollMinY = 0D;
            this.SpeedGraph.ScrollMinY2 = 0D;
            this.SpeedGraph.Size = new System.Drawing.Size(435, 304);
            this.SpeedGraph.TabIndex = 20;
            this.SpeedGraph.UseExtendedPrintDialog = true;
            // 
            // GraphGroup
            // 
            this.GraphGroup.BackColor = System.Drawing.Color.White;
            this.GraphGroup.Controls.Add(this.FollowRadioBox);
            this.GraphGroup.Controls.Add(this.HoldRadioBox);
            this.GraphGroup.Controls.Add(this.AutoScaleRadioBox);
            this.GraphGroup.Controls.Add(this.ClearGraphButton);
            this.GraphGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.GraphGroup.Location = new System.Drawing.Point(266, 235);
            this.GraphGroup.Name = "GraphGroup";
            this.GraphGroup.Size = new System.Drawing.Size(236, 67);
            this.GraphGroup.TabIndex = 21;
            this.GraphGroup.TabStop = false;
            this.GraphGroup.Text = "Graph";
            // 
            // FollowRadioBox
            // 
            this.FollowRadioBox.AutoSize = true;
            this.FollowRadioBox.Checked = true;
            this.FollowRadioBox.Location = new System.Drawing.Point(127, 9);
            this.FollowRadioBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FollowRadioBox.Name = "FollowRadioBox";
            this.FollowRadioBox.Size = new System.Drawing.Size(65, 20);
            this.FollowRadioBox.TabIndex = 14;
            this.FollowRadioBox.TabStop = true;
            this.FollowRadioBox.Text = "Follow";
            this.FollowRadioBox.UseVisualStyleBackColor = true;
            this.FollowRadioBox.CheckedChanged += new System.EventHandler(this.FollowRadioBox_CheckedChanged);
            // 
            // HoldRadioBox
            // 
            this.HoldRadioBox.AutoSize = true;
            this.HoldRadioBox.Location = new System.Drawing.Point(127, 44);
            this.HoldRadioBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HoldRadioBox.Name = "HoldRadioBox";
            this.HoldRadioBox.Size = new System.Drawing.Size(54, 20);
            this.HoldRadioBox.TabIndex = 13;
            this.HoldRadioBox.Text = "Hold";
            this.HoldRadioBox.UseVisualStyleBackColor = true;
            this.HoldRadioBox.CheckedChanged += new System.EventHandler(this.HoldRadioBox_CheckedChanged);
            // 
            // AutoScaleRadioBox
            // 
            this.AutoScaleRadioBox.AutoSize = true;
            this.AutoScaleRadioBox.Location = new System.Drawing.Point(127, 27);
            this.AutoScaleRadioBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoScaleRadioBox.Name = "AutoScaleRadioBox";
            this.AutoScaleRadioBox.Size = new System.Drawing.Size(96, 20);
            this.AutoScaleRadioBox.TabIndex = 7;
            this.AutoScaleRadioBox.Text = "Auto Scale";
            this.AutoScaleRadioBox.UseVisualStyleBackColor = true;
            this.AutoScaleRadioBox.CheckedChanged += new System.EventHandler(this.AutoScaleRadioBox_CheckedChanged);
            // 
            // ClearGraphButton
            // 
            this.ClearGraphButton.BackColor = System.Drawing.Color.SlateGray;
            this.ClearGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearGraphButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearGraphButton.ForeColor = System.Drawing.Color.White;
            this.ClearGraphButton.Location = new System.Drawing.Point(11, 23);
            this.ClearGraphButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearGraphButton.Name = "ClearGraphButton";
            this.ClearGraphButton.Size = new System.Drawing.Size(103, 33);
            this.ClearGraphButton.TabIndex = 12;
            this.ClearGraphButton.Text = "Clear";
            this.ClearGraphButton.UseVisualStyleBackColor = false;
            this.ClearGraphButton.Click += new System.EventHandler(this.ClearGraphButton_Click);
            // 
            // PIDGroup
            // 
            this.PIDGroup.BackColor = System.Drawing.Color.White;
            this.PIDGroup.Controls.Add(this.CustomPIDRadioButton);
            this.PIDGroup.Controls.Add(this.DefaultPIDRadioButton);
            this.PIDGroup.Controls.Add(this.KdLabel);
            this.PIDGroup.Controls.Add(this.KiLabel);
            this.PIDGroup.Controls.Add(this.KpLabel);
            this.PIDGroup.Controls.Add(this.KdTextBox);
            this.PIDGroup.Controls.Add(this.KiTextBox);
            this.PIDGroup.Controls.Add(this.KpTextBox);
            this.PIDGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PIDGroup.Location = new System.Drawing.Point(12, 308);
            this.PIDGroup.Name = "PIDGroup";
            this.PIDGroup.Size = new System.Drawing.Size(249, 110);
            this.PIDGroup.TabIndex = 22;
            this.PIDGroup.TabStop = false;
            this.PIDGroup.Text = "PID";
            // 
            // CustomPIDRadioButton
            // 
            this.CustomPIDRadioButton.AutoSize = true;
            this.CustomPIDRadioButton.Location = new System.Drawing.Point(19, 67);
            this.CustomPIDRadioButton.Name = "CustomPIDRadioButton";
            this.CustomPIDRadioButton.Size = new System.Drawing.Size(74, 20);
            this.CustomPIDRadioButton.TabIndex = 5;
            this.CustomPIDRadioButton.Text = "Custom";
            this.CustomPIDRadioButton.UseVisualStyleBackColor = true;
            this.CustomPIDRadioButton.CheckedChanged += new System.EventHandler(this.CustomPIDRadioButton_CheckedChanged);
            // 
            // DefaultPIDRadioButton
            // 
            this.DefaultPIDRadioButton.AutoSize = true;
            this.DefaultPIDRadioButton.Checked = true;
            this.DefaultPIDRadioButton.Location = new System.Drawing.Point(19, 37);
            this.DefaultPIDRadioButton.Name = "DefaultPIDRadioButton";
            this.DefaultPIDRadioButton.Size = new System.Drawing.Size(73, 20);
            this.DefaultPIDRadioButton.TabIndex = 4;
            this.DefaultPIDRadioButton.TabStop = true;
            this.DefaultPIDRadioButton.Text = "Default";
            this.DefaultPIDRadioButton.UseVisualStyleBackColor = true;
            this.DefaultPIDRadioButton.CheckedChanged += new System.EventHandler(this.DefaultPIDRadioButton_CheckedChanged);
            // 
            // KdLabel
            // 
            this.KdLabel.AutoSize = true;
            this.KdLabel.Location = new System.Drawing.Point(98, 83);
            this.KdLabel.Name = "KdLabel";
            this.KdLabel.Size = new System.Drawing.Size(24, 16);
            this.KdLabel.TabIndex = 3;
            this.KdLabel.Text = "Kd";
            // 
            // KiLabel
            // 
            this.KiLabel.AutoSize = true;
            this.KiLabel.Location = new System.Drawing.Point(98, 54);
            this.KiLabel.Name = "KiLabel";
            this.KiLabel.Size = new System.Drawing.Size(19, 16);
            this.KiLabel.TabIndex = 3;
            this.KiLabel.Text = "Ki";
            // 
            // KpLabel
            // 
            this.KpLabel.AutoSize = true;
            this.KpLabel.Location = new System.Drawing.Point(98, 25);
            this.KpLabel.Name = "KpLabel";
            this.KpLabel.Size = new System.Drawing.Size(24, 16);
            this.KpLabel.TabIndex = 3;
            this.KpLabel.Text = "Kp";
            // 
            // KdTextBox
            // 
            this.KdTextBox.Location = new System.Drawing.Point(128, 76);
            this.KdTextBox.Name = "KdTextBox";
            this.KdTextBox.ReadOnly = true;
            this.KdTextBox.Size = new System.Drawing.Size(100, 23);
            this.KdTextBox.TabIndex = 2;
            this.KdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KiTextBox
            // 
            this.KiTextBox.Location = new System.Drawing.Point(128, 47);
            this.KiTextBox.Name = "KiTextBox";
            this.KiTextBox.ReadOnly = true;
            this.KiTextBox.Size = new System.Drawing.Size(100, 23);
            this.KiTextBox.TabIndex = 1;
            this.KiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KpTextBox
            // 
            this.KpTextBox.Location = new System.Drawing.Point(128, 18);
            this.KpTextBox.Name = "KpTextBox";
            this.KpTextBox.ReadOnly = true;
            this.KpTextBox.Size = new System.Drawing.Size(100, 23);
            this.KpTextBox.TabIndex = 0;
            this.KpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PowerGroup
            // 
            this.PowerGroup.BackColor = System.Drawing.Color.White;
            this.PowerGroup.Controls.Add(this.PowerTextBox);
            this.PowerGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PowerGroup.Location = new System.Drawing.Point(508, 49);
            this.PowerGroup.Name = "PowerGroup";
            this.PowerGroup.Size = new System.Drawing.Size(160, 70);
            this.PowerGroup.TabIndex = 24;
            this.PowerGroup.TabStop = false;
            this.PowerGroup.Text = "Power";
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(23, 30);
            this.PowerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.ReadOnly = true;
            this.PowerTextBox.Size = new System.Drawing.Size(116, 23);
            this.PowerTextBox.TabIndex = 4;
            this.PowerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.PowerGroup);
            this.Controls.Add(this.PIDGroup);
            this.Controls.Add(this.GraphGroup);
            this.Controls.Add(this.ControlModeGroup);
            this.Controls.Add(this.SpeedGraph);
            this.Controls.Add(this.PositionGraph);
            this.Controls.Add(this.DataTableGroup);
            this.Controls.Add(this.ControlGroup);
            this.Controls.Add(this.TerminalGroup);
            this.Controls.Add(this.PortConfigurationGroup);
            this.Controls.Add(this.SpeedGroup);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PositionGroup);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Motor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PositionGroup.ResumeLayout(false);
            this.PositionGroup.PerformLayout();
            this.SpeedGroup.ResumeLayout(false);
            this.SpeedGroup.PerformLayout();
            this.ControlModeGroup.ResumeLayout(false);
            this.ControlModeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableGridView)).EndInit();
            this.PortConfigurationGroup.ResumeLayout(false);
            this.PortConfigurationGroup.PerformLayout();
            this.TerminalGroup.ResumeLayout(false);
            this.ControlGroup.ResumeLayout(false);
            this.DataTableGroup.ResumeLayout(false);
            this.GraphGroup.ResumeLayout(false);
            this.GraphGroup.PerformLayout();
            this.PIDGroup.ResumeLayout(false);
            this.PIDGroup.PerformLayout();
            this.PowerGroup.ResumeLayout(false);
            this.PowerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox ControlModeGroup;
        private System.Windows.Forms.RadioButton SpeedRadioButton;
        private System.Windows.Forms.RadioButton PositionRadioButton;
        private System.Windows.Forms.GroupBox SpeedGroup;
        private System.Windows.Forms.TextBox SpeedSetpointTextBox;
        private System.Windows.Forms.Label SpeedSetpointLabel;
        private System.Windows.Forms.Label CurrentSpeedLabel;
        private System.Windows.Forms.TextBox CurrentSpeedTextBox;
        private System.Windows.Forms.GroupBox PositionGroup;
        private System.Windows.Forms.TextBox PositionSetpointTextBox;
        private System.Windows.Forms.Label PositionSetpointLabel;
        private System.Windows.Forms.Label CurrentPositionLabel;
        private System.Windows.Forms.TextBox CurrentPositionTextBox;
        private System.Windows.Forms.TextBox SerialPortConnectionStatusTextBox;
        private System.Windows.Forms.RichTextBox SerialPortTerminal;
        private System.Windows.Forms.Button ConnectSerialPortButton;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Button ClearTerminalButton;
        private System.Windows.Forms.ComboBox PortNameComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Button ExportToExcelButton;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.DataGridView DataTableGridView;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Button DisconnectSerialPortButton;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.GroupBox PortConfigurationGroup;
        private System.Windows.Forms.GroupBox TerminalGroup;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.GroupBox DataTableGroup;
        private ZedGraph.ZedGraphControl PositionGraph;
        private ZedGraph.ZedGraphControl SpeedGraph;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox GraphGroup;
        private System.Windows.Forms.RadioButton FollowRadioBox;
        private System.Windows.Forms.RadioButton HoldRadioBox;
        private System.Windows.Forms.RadioButton AutoScaleRadioBox;
        private System.Windows.Forms.Button ClearGraphButton;
        private System.Windows.Forms.GroupBox PIDGroup;
        private System.Windows.Forms.RadioButton CustomPIDRadioButton;
        private System.Windows.Forms.RadioButton DefaultPIDRadioButton;
        private System.Windows.Forms.Label KdLabel;
        private System.Windows.Forms.Label KiLabel;
        private System.Windows.Forms.Label KpLabel;
        private System.Windows.Forms.TextBox KdTextBox;
        private System.Windows.Forms.TextBox KiTextBox;
        private System.Windows.Forms.TextBox KpTextBox;
        private System.Windows.Forms.Button ClearTableButton;
        private System.Windows.Forms.GroupBox PowerGroup;
        private System.Windows.Forms.TextBox PowerTextBox;
    }
}

