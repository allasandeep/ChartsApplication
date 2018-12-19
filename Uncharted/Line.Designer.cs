namespace Uncharted
{
    partial class Line
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.backBtn = new System.Windows.Forms.Button();
			this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
			this.SuspendLayout();
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(12, 12);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(91, 23);
			this.backBtn.TabIndex = 1;
			this.backBtn.Text = "Back to Portal";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// lineChart
			// 
			chartArea1.Name = "ChartArea1";
			this.lineChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.lineChart.Legends.Add(legend1);
			this.lineChart.Location = new System.Drawing.Point(12, 41);
			this.lineChart.Name = "lineChart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Tokyo";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "NewYork";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Legend = "Legend1";
			series3.Name = "Berlin";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Legend = "Legend1";
			series4.Name = "London";
			this.lineChart.Series.Add(series1);
			this.lineChart.Series.Add(series2);
			this.lineChart.Series.Add(series3);
			this.lineChart.Series.Add(series4);
			this.lineChart.Size = new System.Drawing.Size(860, 385);
			this.lineChart.TabIndex = 2;
			this.lineChart.Text = "chart1";
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			title1.Name = "avgTemperature";
			title1.Text = "Monthly Average Temperature";
			this.lineChart.Titles.Add(title1);
			// 
			// Line
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 438);
			this.Controls.Add(this.lineChart);
			this.Controls.Add(this.backBtn);
			this.Name = "Line";
			this.Text = "Line";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Line_FormClosing);
			this.Load += new System.EventHandler(this.Line_Load);
			((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
    }
}