namespace Uncharted
{
    partial class Bar
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.backBtn = new System.Windows.Forms.Button();
			this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
			this.SuspendLayout();
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(12, 12);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(91, 23);
			this.backBtn.TabIndex = 0;
			this.backBtn.Text = "Back to Portal";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// barChart
			// 
			chartArea2.Name = "ChartArea1";
			this.barChart.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.barChart.Legends.Add(legend2);
			this.barChart.Location = new System.Drawing.Point(12, 41);
			this.barChart.Name = "barChart";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series2.Legend = "Legend1";
			series2.Name = "Salary";
			this.barChart.Series.Add(series2);
			this.barChart.Size = new System.Drawing.Size(860, 385);
			this.barChart.TabIndex = 1;
			this.barChart.Text = "chart1";
			title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			title2.Name = "Title1";
			title2.Text = "Employee Salary per Annum";
			this.barChart.Titles.Add(title2);
			// 
			// Bar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 438);
			this.Controls.Add(this.barChart);
			this.Controls.Add(this.backBtn);
			this.Name = "Bar";
			this.Text = "Bar";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bar_FormClosing_1);
			this.Load += new System.EventHandler(this.Bar_Load);
			((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
	}
}