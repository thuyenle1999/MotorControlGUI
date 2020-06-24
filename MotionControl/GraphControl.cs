using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace MotionControl
{
    public enum GraphMode
    {
        Follow, AutoScale, Hold
    }
    class GraphControl
    {
        public List<RollingPointPairList> CurveData = new List<RollingPointPairList>(); 
        public void Initialize(ZedGraphControl graph, double XMax, double XMin, double YMax,double YMin, string title = "Title", string XTitle = "", string YTitle = "")
        {
            GraphPane pane = graph.GraphPane;
            pane.Title.Text = title;
            pane.XAxis.Scale.Max = XMax;
            pane.XAxis.Scale.Min = XMin;
            pane.XAxis.Title.Text = XTitle;
            pane.YAxis.Scale.Max = YMax;
            pane.YAxis.Scale.Min = XMin;
            pane.YAxis.Title.Text = YTitle;
            pane.AxisChange();
            graph.Invalidate();
            graph.Refresh();
        }
        public void AddGraph(ZedGraphControl graph, string name, System.Drawing.Color color, SymbolType symbol = SymbolType.None)
        {
            GraphPane pane = graph.GraphPane;
            CurveData.Add(new RollingPointPairList(60000));
            pane.AddCurve(name, CurveData[CurveData.Count -1], color, symbol);
            graph.Invalidate();
            graph.Refresh();
        }
        public void UpdateGraph(ZedGraphControl graph, int index, double x, double y, GraphMode mode, double paneWidth = 5.0)
        {
            GraphPane pane = graph.GraphPane;
            if (pane.CurveList.Count <= index)
                return;
            LineItem line = pane.CurveList[index] as LineItem;
            if (line == null)
                return;
            IPointListEdit point_list = line.Points as IPointListEdit;
            point_list.Add(x, y);
            Scale xScale = pane.XAxis.Scale;
            Scale yScale = pane.YAxis.Scale;
            switch (mode)
            {
                case GraphMode.Follow:
                    if (x > xScale.Max - xScale.MajorStep)
                    {
                        xScale.Max = x + xScale.MajorStep;
                        xScale.Min = xScale.Max - paneWidth;
                    }
                    if (y < yScale.Min + yScale.MajorStep)
                    {
                        yScale.Min = y - yScale.MajorStep;
                    }
                    if (y > yScale.Max - yScale.MajorStep)
                    {
                        yScale.Max = y + yScale.MajorStep;
                    }
                    DrawGraph(graph);
                    break;
                case GraphMode.AutoScale:
                    if (x < xScale.Min + xScale.MajorStep)
                    {
                        xScale.Min = x - xScale.MajorStep;
                    }
                    if (x > xScale.Max - xScale.MajorStep)
                    {
                        xScale.Max = x + xScale.MajorStep;
                    }
                    if (y < yScale.Min + yScale.MajorStep)
                    {
                        yScale.Min = y - yScale.MajorStep;
                    }
                    if (y > yScale.Max - yScale.MajorStep)
                    {
                        yScale.Max = y + yScale.MajorStep;
                    }
                    DrawGraph(graph);
                    break;
                case GraphMode.Hold:
                    break;             
            }
        }
        public void DrawGraph(ZedGraphControl graph)
        {
            graph.Invalidate();
            graph.Refresh();
            graph.AxisChange();
        }
        public void ClearGraph(ZedGraphControl graph)
        {
            graph.GraphPane.CurveList.Clear();
            graph.GraphPane.GraphObjList.Clear();
            CurveData.Clear();
        }

    }
}
