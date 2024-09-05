using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;
namespace Charting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Chart chart;
        private void button1_Click(object sender, EventArgs e)
        {
            chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);
            if(rbtnAria.Checked)
            {
                series.Points.Add(60000).AxisLabel = "87";
                series.Points.Add(75000).AxisLabel = "88";
                series.Points.Add(80000).AxisLabel = "89";
                series.Points.Add(95000).AxisLabel = "90";
                series.Points.Add(100000).AxisLabel = "91";
                series.Points.Add(120000).AxisLabel = "92";
                chart.Series[0].ChartType = SeriesChartType.SplineArea;
                chart.Legends.Add("num");
                chart.Series[0].LegendText = "قیمت هر گرم طلا";
                chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            }
            else if(rbtnBar.Checked)
            {
                series.Points.Add(10).AxisLabel = "علی";
                series.Points.Add(15).AxisLabel = "محمد";
                series.Points.Add(20).AxisLabel = "صادق";
                series.Points.Add(12).AxisLabel = "شهرام";
                series.Points.Add(11).AxisLabel = "یوسف";
                series.Points.Add(18).AxisLabel = "مهدی";
                chart.Series[0].ChartType = SeriesChartType.Column;
                chart.Legends.Add("num");
                chart.Series[0].LegendText = "معدل";
                chart.Series[0].ToolTip = "#VAL";
            }
            else if (rbtnFunnel.Checked)
            {
                series.Points.Add(120000).AxisLabel = "سبزیجات";
                series.Points.Add(110000).AxisLabel = "خشکبار";
                series.Points.Add(100000).AxisLabel = "لبنیات";
                series.Points.Add(95000).AxisLabel = "غلات";
                series.Points.Add(50000).AxisLabel = "گوشت";
                series.Points.Add(30000).AxisLabel = "فست فود";
                chart.Series[0].ChartType = SeriesChartType.Funnel;
                chart.Legends.Add("num");
            }
            else if (rbtnLine.Checked)
            {
                series.Points.Add(60000).AxisLabel = "87";
                series.Points.Add(75000).AxisLabel = "88";
                series.Points.Add(80000).AxisLabel = "89";
                series.Points.Add(95000).AxisLabel = "90";
                series.Points.Add(100000).AxisLabel = "91";
                series.Points.Add(120000).AxisLabel = "92";
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Legends.Add("num");
                chart.Series[0].LegendText = "قیمت هر گرم طلا";
            }
            else if (rbtnPie.Checked)
            {
                int[] yVal = {5,2,10,20,15 };
                string[] xVal = { "شیراز", "قم", "مشهد", "تهران", "اصفهان", };
                chart.Series[0].Points.DataBindXY(xVal, yVal);
                chart.Series[0].ChartType = SeriesChartType.Pie;
                cmbExplodedPoint.DataSource = xVal;
                chart.MouseMove+=new MouseEventHandler ( chart_MouseMove);
                chart.MouseDown+=new MouseEventHandler(chart_MouseDown);
            }
            else if (rbtnPoint.Checked)
            {
                series.Points.Add(60000).AxisLabel = "87";
                series.Points.Add(75000).AxisLabel = "88";
                series.Points.Add(80000).AxisLabel = "89";
                series.Points.Add(95000).AxisLabel = "90";
                series.Points.Add(100000).AxisLabel = "91";
                series.Points.Add(120000).AxisLabel = "92";
                chart.Series[0].ChartType = SeriesChartType.Point;
                chart.Legends.Add("num");
                chart.Series[0].LegendText = "قیمت هر گرم طلا";
            }
            else if (rbtnPrice.Checked)
            {
                series.Points.Add(60000).AxisLabel = "87";
                series.Points.Add(75000).AxisLabel = "88";
                series.Points.Add(80000).AxisLabel = "89";
                series.Points.Add(95000).AxisLabel = "90";
                series.Points.Add(100000).AxisLabel = "91";
                series.Points.Add(120000).AxisLabel = "92";
                chart.Series[0].ChartType = SeriesChartType.Kagi;
                chart.Legends.Add("num");
                chart.Series[0].LegendText = "سود هر ماه";
                chart.Series[0]["PriceUpColor"] = "Blue";
                chart.Series[0].Color = Color.Red;
                chart.Series[0].BorderWidth = 3;
            }
            else if (rbtnPyramid.Checked)
            {
                series.Points.Add(120000).AxisLabel = "سبزیجات";
                series.Points.Add(110000).AxisLabel = "خشکبار";
                series.Points.Add(100000).AxisLabel = "لبنیات";
                series.Points.Add(95000).AxisLabel = "غلات";
                series.Points.Add(50000).AxisLabel = "گوشت";
                series.Points.Add(30000).AxisLabel = "فست فود";
                chart.Series[0].ChartType = SeriesChartType.Pyramid;
                chart.Legends.Add("num");
            }
            chart.Location = new System.Drawing.Point(10,15);
            chart.Size = new System.Drawing.Size(800,430);
            this.Controls["gbxChart"].Controls.Clear();
            this.Controls["gbxChart"].Controls.Add(chart);
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private void chart_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart.HitTest(e.X, e.Y);
            bool exp = (chart.Series[0].Points[result.PointIndex].CustomProperties == "Exploded=true") ? true : false;
            foreach (DataPoint point in chart.Series[0].Points)
                point.CustomProperties = "";
            if (exp)
                return;
            if (result.ChartElementType == ChartElementType.DataPoint || result.ChartElementType == ChartElementType.LegendItem)
            {
                DataPoint point = chart.Series[0].Points[result.PointIndex];
                point.CustomProperties = "Exploded=true";
            }
        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart.HitTest(e.X, e.Y);
            foreach (DataPoint point in chart.Series[0].Points)
                point.BackHatchStyle = ChartHatchStyle.None;
            if (result.ChartElementType == ChartElementType.DataPoint || result.ChartElementType == ChartElementType.LegendItem)
            {
                this.Cursor = Cursors.Hand;
                DataPoint point = chart.Series[0].Points[result.PointIndex];
                point.BackHatchStyle = ChartHatchStyle.Percent25;
            }
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
 
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeAria.SelectedIndex == 0)
                chart.Series[0].ChartType = SeriesChartType.StackedArea;
            else
                chart.Series[0].ChartType = SeriesChartType.SplineArea;
        }

        private void nudPointGap_ValueChanged(object sender, EventArgs e)
        {
            chart.Series[0]["FunnelPointGap"] = nudPointGap.Value.ToString();
        }

        private void nudAngle_ValueChanged(object sender, EventArgs e)
        {
            chart.Series[0]["Funnel3DRptationAngle"] = nudAngle.Value.ToString();
        }

        private void cmbchartStyleFunnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbchartStyleFunnel.SelectedIndex == 0)
                chart.Series[0]["Funnel3DDrawingStyle"] = "SquareBase";
            else
                chart.Series[0]["Funnel3DDrawingStyle"] = "CircularBase";
        }

        private void cmbTypeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeLine.SelectedIndex == 0)
                chart.Series[0].ChartType = SeriesChartType.Line;
            else
                chart.Series[0].ChartType = SeriesChartType.Spline;
        }

        private void cmbTypePie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypePie.SelectedIndex == 0)
                chart.Series[0].ChartType = SeriesChartType.Pie;
            else
                chart.Series[0].ChartType = SeriesChartType.Doughnut;
        }

        private void cmbLabelStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLabelStyle.SelectedIndex == 0)
                chart.Series[0]["PieLabelStyle"] = "Inside";
           else if (cmbLabelStyle.SelectedIndex == 1)
                chart.Series[0]["PieLabelStyle"] = "outside";
else
                chart.Series[0]["PieLabelStyle"] = "Disabled";
        }

        private void cmbDoughnutRadius_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbDesignPie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesignPie.SelectedIndex == 0)
                chart.Series[0]["PieDrawingStyle"] = "Default";
           else if (cmbDesignPie.SelectedIndex == 1)
                chart.Series[0]["PieDrawingStyle"] = "SoftEdge";
         else
                chart.Series[0]["PieDrawingStyle"] = "Concave";
        }

        private void cmbExplodedPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
 foreach(DataPoint point in chart.Series[0].Points)
 {
     point["Exploded"] = "false";
     if(point.AxisLabel==cmbExplodedPoint.Text)
         point["Exploded"] = "true";
 }
        }

        private void cbxRotate_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = cbxRotate.Checked;
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
 if(cbxRotate.Checked)
 {
     i += 1;
     if (i >= 360)
         i = 0;
     chart.Series[0]["PieStartAngle"] = i.ToString();
 }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points[0].Color=Color.Yellow;
        }

        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShape.SelectedIndex == 0)
                chart.Series[0].MarkerStyle = MarkerStyle.Square;
           else if (cmbShape.SelectedIndex == 1)
                chart.Series[0].MarkerStyle = MarkerStyle.Diamond;
            else
                chart.Series[0].MarkerStyle = MarkerStyle.Circle;
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0].MarkerSize = int.Parse(cmbSize.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);

            double yVal = 50;
            Random random = new Random();
            for (int i = 0; i < 2000; i++)
            {
                yVal = yVal + (random.NextDouble() * 10 - 5);
                chart.Series[0].Points.AddY(yVal);
            }
            chart.Legends.Add("num");
            chart.Series[0].LegendText = "نوار قلب";
            chart.Series[0].ChartType = SeriesChartType.FastPoint;
            chart.Location = new System.Drawing.Point(10, 15);
            chart.Size = new System.Drawing.Size(800, 430);
            this.Controls["gbxChart"].Controls.Clear();
            this.Controls["gbxChart"].Controls.Add(chart);
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private void nudPointPyramid_ValueChanged(object sender, EventArgs e)
        {
            chart.Series[0]["PyramidPointGap"] = nudPointPyramid.Value.ToString();
        }

        private void nudAnglePyramid_ValueChanged(object sender, EventArgs e)
        {
            chart.Series[0]["Pyramid3DRotationAngle"] = nudAnglePyramid.Value.ToString();
        }


        private void cmbTypePyramid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypePyramid.SelectedIndex == 0)
                chart.Series[0]["Pyramid3DDrawingStyle"] = "SquareBase";
            else
                chart.Series[0]["Pyramid3DDrawingStyle"] = "CircularBase";
        }


        private void button2_Click(object sender, EventArgs e)
        {
                        chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);
         
  
                chart.Series[0].ChartType = SeriesChartType.StackedArea;
                chart.Legends.Add("num");
                chart.Series[0].LegendText = "مصرف cpu";
                chart.ChartAreas[0].AxisX.IsMarginVisible = false;

                chart.Location = new System.Drawing.Point(10, 15);
                chart.Size = new System.Drawing.Size(800, 430);
                this.Controls["gbxChart"].Controls.Clear();
                this.Controls["gbxChart"].Controls.Add(chart);
                timer2.Enabled = true;
        }

        PerformanceCounter cpu = new PerformanceCounter();
        private void timer2_Tick(object sender, EventArgs e)
        {
            cpu.CategoryName = "Processor";
            cpu.CounterName = "% Processor Time";
            cpu.InstanceName = "_Total";
            double round = Math.Round(cpu.NextValue());
            chart.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), round);
            if (chart.Series[0].Points.Count > 20)
                chart.Series[0].Points.RemoveAt(0);
        }

        private void rbtnPrice_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = false;
            gbxBar.Enabled = false;
        }

     

        private void rbtnAria_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = true;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = false;
            gbxBar.Enabled = false;
        }

        private void rbtnFunnel_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = true;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = false;
            gbxBar.Enabled = false;
        }

        private void rbtnPoint_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = true;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = false;
            gbxBar.Enabled = false;
        }

        private void rbtnLine_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = true;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = false;
            gbxBar.Enabled = false;
        }

        private void rbtnPyramid_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = true;
            gbxPie.Enabled = false;
            gbxBar.Enabled = false;
        }

        private void rbtnPie_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = true;
            gbxBar.Enabled = false;
        }

        private void rbtnBar_CheckedChanged(object sender, EventArgs e)
        {
            gbxAria.Enabled = false;
            gbxFunnel.Enabled = false;
            gbxPoint.Enabled = false;
            gbxLine.Enabled = false;
            gbxPyramid.Enabled = false;
            gbxPie.Enabled = false;
            gbxBar.Enabled = true;
        }

        private void cbx3D_CheckedChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].Area3DStyle.Enable3D = cbx3D.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSetting seting = new frmSetting(chart)
                ;
            seting.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);
            string fileName = Application.StartupPath + @"\Data\chartdata.mdb";
            string myCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source" + fileName;
            OleDbConnection con = new OleDbConnection(myCon);
            string query = "Select * from tblMonth";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            chart.DataSource = cmd.ExecuteReader();
            chart.Series[0].XValueMember = "MonthName";
            chart.Series[0].YValueMembers = "Amount";
            chart.DataBind();
            con.Close();

            chart.Series[0].ChartType = SeriesChartType.Column;
            chart.Location = new System.Drawing.Point(10,15);
            chart.Size = new System.Drawing.Size(800,430);

            chart.Legends.Add("num");
            chart.Series[0].LegendText = "سود هر ماه";
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            this.Controls["gbxChart"].Controls.Clear();
            this.Controls["gbxChart"].Controls.Add(chart);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);
            string fileName = Application.StartupPath + @"\Data\MyDatabase.xml";

            XmlReader xmlFile = XmlReader.Create(fileName,new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            DataTable dt = new DataTable();
            dt=ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].ToString() != "")
                    series.Points.Add(int.Parse(dr[0].ToString())).AxisLabel = dr[1].ToString();
            }
            xmlFile.Close();
  

            chart.Series[0].ChartType = SeriesChartType.Column;
            chart.Location = new System.Drawing.Point(10, 15);
            chart.Size = new System.Drawing.Size(800, 430);

            chart.Legends.Add("num");
            chart.Series[0].LegendText = "سن";
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            this.Controls["gbxChart"].Controls.Clear();
            this.Controls["gbxChart"].Controls.Add(chart);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);
            string fileName = Application.StartupPath + @"\Data\ExcelData.xls";
            string myCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source" + fileName+";Extended Properties=Excel 4.0";

            OleDbConnection con = new OleDbConnection(myCon);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [data1$]", con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].ToString() != "")
                    series.Points.Add(int.Parse(dr[0].ToString())).AxisLabel = dr[1].ToString();
            }
            con.Close();


            chart.Series[0].ChartType = SeriesChartType.Column;
            chart.Location = new System.Drawing.Point(10, 15);
            chart.Size = new System.Drawing.Size(800, 430);

            chart.Legends.Add("num");
            chart.Series[0].LegendText = "نمره";
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            this.Controls["gbxChart"].Controls.Clear();
            this.Controls["gbxChart"].Controls.Add(chart);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart = new Chart();
            ChartArea chartAria = new ChartArea();
            chart.ChartAreas.Add(chartAria);
            Series series = new Series();
            chart.Series.Add(series);

            int[] Yval = {23,25,40,6 };
            string[] xVal = {"عبداله","احسان","حسین","علی" };
            chart.Series[0].Points.DataBindXY(xVal, Yval);


            chart.Series[0].ChartType = SeriesChartType.Column;
            chart.Location = new System.Drawing.Point(10, 15);
            chart.Size = new System.Drawing.Size(800, 430);

            chart.Legends.Add("num");
            chart.Series[0].LegendText = "سن";
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            this.Controls["gbxChart"].Controls.Clear();
            this.Controls["gbxChart"].Controls.Add(chart);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
 
      
    }
}
