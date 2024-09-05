using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;
namespace Charting
{
    public partial class frmSetting : Form
    {
        public frmSetting(Chart chart2)
        {
            InitializeComponent();
            chart = chart2;
        }
        Chart chart;
        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double valueToFind = 0;
            DataPoint maxPoint = chart.Series[0].Points.FindMaxByValue("Y");
            valueToFind = maxPoint.GetValueByName("Y");
            foreach (DataPoint dataPoint in chart.Series[0].Points.FindAllByValue(valueToFind, "Y"))
                dataPoint.Color = Color.Yellow;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double valueToFind = 0;
            DataPoint minPoint = chart.Series[0].Points.FindMinByValue("Y");
            valueToFind = minPoint.GetValueByName("Y");
            foreach (DataPoint dataPoint in chart.Series[0].Points.FindAllByValue(valueToFind, "Y"))
                dataPoint.Color = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataPoint max = chart.Series[0].Points.FindMaxByValue();
            max.Color = Color.YellowGreen;
            DataPoint min = chart.Series[0].Points.FindMinByValue();
            min.Color = Color.MediumOrchid;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chart.Printing.Print(true);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chart.Printing.PrintPreview();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveChart = new SaveFileDialog();
            saveChart.Filter = "Bitmap(*.BMP)|*.BMP";
            if(saveChart.ShowDialog()==DialogResult.OK)
            {
                ChartImageFormat format = ChartImageFormat.Bmp;
                format = ChartImageFormat.Bmp;
                chart.SaveImage(saveChart.FileName, format);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MemoryStream strem = new MemoryStream();
            chart.SaveImage(strem, ImageFormat.Bmp);
            Bitmap bmp = new Bitmap(strem);
            Clipboard.SetDataObject(bmp);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = chart.DataManipulator.ExportSeriesValues();
            dgridValue.DataSource = ds;
            dgridValue.DataMember = "series1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chart.DataManipulator.Sort(PointSortOrder.Ascending, "Y", "Series1");
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex == 0)
                chart.Series[0]["LabelStyle"] = "Top";
            else if (cmbPosition.SelectedIndex == 1)
                chart.Series[0]["LabelStyle"] = "Bottom";
            else if (cmbPosition.SelectedIndex == 2)
                chart.Series[0]["LabelStyle"] = "Center";
            else if (cmbPosition.SelectedIndex == 3)
                chart.Series[0]["LabelStyle"] = "Right";
            else  
                chart.Series[0]["LabelStyle"] = "Left";
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0].Font = new Font(cmbFont.Text,8);
        }

        private void cmbFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFontColor.SelectedIndex == 0)
                chart.Series[0].LabelForeColor = Color.Red;
           else if (cmbFontColor.SelectedIndex == 1)
                chart.Series[0].LabelForeColor = Color.Blue;
            else 
                chart.Series[0].LabelForeColor = Color.GreenYellow;
        }

        private void cmbackcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbackcolor.SelectedIndex == 0)
                chart.Series[0].LabelBackColor = Color.Red;
            else if (cmbackcolor.SelectedIndex == 1)
                chart.Series[0].LabelBackColor = Color.Blue;
            else
                chart.Series[0].LabelBackColor = Color.GreenYellow;
        }

        private void cmbLabelBorColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLabelBorColor.SelectedIndex == 0)
                chart.Series[0].LabelBorderColor = Color.Red;
            else if (cmbLabelBorColor.SelectedIndex == 1)
                chart.Series[0].LabelBorderColor = Color.Blue;
            else
                chart.Series[0].LabelBorderColor = Color.GreenYellow;
        }

        private void cbxShowLable_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series[0].IsValueShownAsLabel = cbxShowLable.Checked;
        }

        private void cmbPlottBackcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlottBackcolor.SelectedIndex == 0)
                chart.ChartAreas[0].BackColor = Color.Yellow;
            else if (cmbPlottBackcolor.SelectedIndex == 1)
                chart.ChartAreas[0].BackColor = Color.Red;
            else if (cmbPlottBackcolor.SelectedIndex == 2)
                chart.ChartAreas[0].BackColor = Color.GreenYellow;
            else
            {
                chart.ChartAreas[0].AxisY.IsInterlaced = true;
                chart.ChartAreas[0].AxisY.InterlacedColor = Color.Violet;
            }
        }

        private void cmbPlottGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlottGrad.SelectedIndex == 0)
                chart.ChartAreas[0].BackGradientStyle = GradientStyle.None;
            else if(cmbPlottGrad.SelectedIndex ==1)
                chart.ChartAreas[0].BackGradientStyle = GradientStyle.LeftRight;
            else if (cmbPlottGrad.SelectedIndex == 2)
                chart.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
            else 
                chart.ChartAreas[0].BackGradientStyle = GradientStyle.Center;
            chart.ChartAreas[0].BackSecondaryColor = Color.Yellow;
        }

        private void cmbPlottShadow_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStyle.SelectedIndex == 0)
                chart.Series[0]["DrawingStyle"] = "Default";
           else if (cmbStyle.SelectedIndex == 1)
                chart.Series[0]["DrawingStyle"] = "Emboss";
            else if (cmbStyle.SelectedIndex == 2)
                chart.Series[0]["DrawingStyle"] = "Cylinder";
            else
                chart.Series[0]["DrawingStyle"] = "Wedge";
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColor.SelectedIndex == 0)
                chart.Series[0].Color = Color.Red;
            else if (cmbColor.SelectedIndex == 1)
                chart.Series[0].Color = Color.Yellow;
            else
                chart.Series[0].Color = Color.Blue;
        }

        private void cmbBorderColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBorderColor.SelectedIndex == 0)
                chart.Series[0].BorderColor = Color.Red;
            else if (cmbBorderColor.SelectedIndex == 1)
                chart.Series[0].BorderColor = Color.Yellow;
            else
                chart.Series[0].BorderColor = Color.Blue;
        }

        private void cmbBorderSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0].BorderWidth = cmbBorderSize.SelectedIndex;
        }

        private void cmbShadow_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0].ShadowOffset = cmbShadow.SelectedIndex;
        }

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0]["PointWidth"] = cmbWidth.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chart.Titles.Add("سود سال");
        }

        private void txtChartTitleText_TextChanged(object sender, EventArgs e)
        {
            chart.Titles[0].Text = txtChartTitleText.Text;
        }

        private void cmbChartTitleFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Titles[0].Font = new Font(cmbChartTitleFont.Text, 12, FontStyle.Bold);
        }

        private void cmbChartTitleForColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChartTitleForColor.SelectedIndex == 0)
                chart.Titles[0].ForeColor = Color.Yellow;
           else if (cmbChartTitleForColor.SelectedIndex == 1)
                chart.Titles[0].ForeColor = Color.Red; 
            else
                chart.Titles[0].ForeColor = Color.Blue;
        }

        private void cmbChartTitleBackcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChartTitleBackcolor.SelectedIndex == 0)
                chart.Titles[0].BackColor = Color.Yellow;
            if (cmbChartTitleBackcolor.SelectedIndex == 1)
                chart.Titles[0].BackColor = Color.Red;
           else
                chart.Titles[0].BackColor = Color.GreenYellow;
        }

        private void cmbChartTitleBorderColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChartTitleBorderColor.SelectedIndex == 0)
                chart.Titles[0].BorderColor = Color.Yellow;
            if (cmbChartTitleBorderColor.SelectedIndex == 1)
                chart.Titles[0].BorderColor = Color.Red;
            else
                chart.Titles[0].BorderColor = Color.GreenYellow;
        }

        private void cmbChartTitleAli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChartTitleAli.SelectedIndex == 0)
                chart.Titles[0].Alignment = ContentAlignment.TopRight;
            else if (cmbChartTitleAli.SelectedIndex == 1)
                chart.Titles[0].Alignment = ContentAlignment.TopCenter;
        else
                chart.Titles[0].Alignment = ContentAlignment.TopLeft;
        }

        private void cmbLegendBackcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendBackcolor.SelectedIndex == 0)
                chart.Legends[0].BackColor = Color.Yellow;
            else if (cmbLegendBackcolor.SelectedIndex == 1)
                chart.Legends[0].BackColor = Color.Red;
            else
                chart.Legends[0].BackColor = Color.GreenYellow;
        }

        private void cmbLegendGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendGrad.SelectedIndex == 0)
                chart.Legends[0].BackGradientStyle = GradientStyle.None;
            else if (cmbLegendGrad.SelectedIndex == 1)
                chart.Legends[0].BackGradientStyle = GradientStyle.LeftRight;
            else if (cmbLegendGrad.SelectedIndex == 2)
                chart.Legends[0].BackGradientStyle = GradientStyle.TopBottom;
            else
                chart.ChartAreas[0].BackGradientStyle = GradientStyle.Center;
            chart.ChartAreas[0].BackSecondaryColor = Color.Yellow;
        }

        private void cmbLegendBorderColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendBorderColor.SelectedIndex == 0)
                chart.Legends[0].BorderColor = Color.Yellow;
            else if (cmbLegendBorderColor.SelectedIndex == 1)
                chart.Legends[0].BorderColor = Color.Red;
            else
                chart.Legends[0].BorderColor = Color.GreenYellow;
        }

        private void cmbLegendBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendBorderStyle.SelectedIndex == 0)
                chart.Legends[0].BorderDashStyle = ChartDashStyle.Dash;
            else if (cmbLegendBorderStyle.SelectedIndex == 1)
                chart.Legends[0].BorderDashStyle = ChartDashStyle.Dot;
            else
                chart.Legends[0].BorderDashStyle = ChartDashStyle.Solid;
        }

        private void cmbLegendBorderSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Legends[0].BorderWidth = int.Parse(cmbLegendBorderSize.Text);
        }

        private void cmbLegendShadow_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Legends[0].ShadowOffset = int.Parse(cmbLegendShadow.Text);
        }

        private void cbxLegendShow_CheckedChanged(object sender, EventArgs e)
        {
            chart.Legends[0].Enabled = cbxLegendShow.Checked;
        }

        private void cmbLegendItemsStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendItemsStyle.SelectedIndex == 0)
                chart.Legends[0].LegendStyle = LegendStyle.Row;
            else
                chart.Legends[0].LegendStyle = LegendStyle.Column;
        }

        private void cmbLegendItemsPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendItemsPlace.SelectedIndex == 0)
                chart.Legends[0].Docking = Docking.Top;
           else if (cmbLegendItemsPlace.SelectedIndex == 1)
                chart.Legends[0].Docking = Docking.Bottom;
            else if (cmbLegendItemsPlace.SelectedIndex == 2)
                chart.Legends[0].Docking = Docking.Right;
            else  
                chart.Legends[0].Docking = Docking.Left;
        }

        private void cmbLegendItemsAli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendItemsAli.SelectedIndex == 0)
                chart.Legends[0].Alignment = StringAlignment.Far;
           else if (cmbLegendItemsAli.SelectedIndex == 1)
                chart.Legends[0].Alignment = StringAlignment.Center;
            else
                chart.Legends[0].Alignment = StringAlignment.Near;
        }

        private void cmbLegendFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Legends[0].Font = new Font(cmbLegendFont.Text, 12, FontStyle.Bold);
        }

        private void cmbLegendFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendFontColor.SelectedIndex == 0)
                chart.Legends[0].ForeColor = Color.Yellow;
            else if (cmbLegendFontColor.SelectedIndex == 1)
                chart.Legends[0].ForeColor = Color.Red;
            else
                chart.Legends[0].ForeColor = Color.YellowGreen;
        }

        private void txtLegendTitleText_TextChanged(object sender, EventArgs e)
        {
            chart.Legends[0].Title = txtLegendTitleText.Text;
        }

        private void cmbLegendTitleColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendTitleColor.SelectedIndex == 0)
                chart.Legends[0].TitleForeColor = Color.Yellow;
            else if (cmbLegendTitleColor.SelectedIndex == 1)
                chart.Legends[0].TitleForeColor = Color.Red;
            else
                chart.Legends[0].TitleForeColor = Color.YellowGreen;
        }

        private void cmbLegendTitleAli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendTitleAli.SelectedIndex == 0)
                chart.Legends[0].TitleAlignment = StringAlignment.Far;
            else if (cmbLegendTitleAli.SelectedIndex == 1)
                chart.Legends[0].TitleAlignment = StringAlignment.Center;
            else
                chart.Legends[0].TitleAlignment = StringAlignment.Near;
        }

        private void cmbLegendTitleSepStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendTitleSepStyle.SelectedIndex == 0)
                chart.Legends[0].TitleSeparator = LegendSeparatorStyle.None;
            else if (cmbLegendTitleSepStyle.SelectedIndex == 1)
                chart.Legends[0].TitleSeparator = LegendSeparatorStyle.DoubleLine;
            else
                chart.Legends[0].TitleSeparator = LegendSeparatorStyle.DotLine;
        }

        private void cmbLegendTitleSepColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLegendTitleSepColor.SelectedIndex == 0)
                chart.Legends[0].TitleSeparatorColor = Color.Yellow;
            else if (cmbLegendTitleSepColor.SelectedIndex == 1)
                chart.Legends[0].TitleSeparatorColor = Color.Red;
            else
                chart.Legends[0].TitleSeparatorColor = Color.YellowGreen;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LegendCellColumn colorColumn = new LegendCellColumn();
            colorColumn.ColumnType = LegendCellColumnType.SeriesSymbol;
            colorColumn.HeaderBackColor = Color.Violet;
            colorColumn.HeaderText = "رنگ";
            chart.Legends[0].CellColumns.Add(colorColumn);

            LegendCellColumn nameColumn = new LegendCellColumn();
            nameColumn.ColumnType = LegendCellColumnType.Text;
            nameColumn.HeaderBackColor = Color.Violet;
            nameColumn.Text = "#LEGENDTEXT";
            nameColumn.HeaderText = "نام";
            chart.Legends[0].CellColumns.Add(nameColumn);

            LegendCellColumn avgColumn = new LegendCellColumn();
            avgColumn.ColumnType = LegendCellColumnType.Text;
            avgColumn.HeaderBackColor = Color.Violet;
            avgColumn.Text = "#AVG{N2}";
            avgColumn.HeaderText = "میانگین";
            avgColumn.Name = "avgColumn";
            chart.Legends[0].CellColumns.Add(avgColumn);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
 
        }

        private void button6_Click(object sender, EventArgs e)
        {
   
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cbx3d_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
