namespace Uncharted
{
    partial class Stock
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
			this.stockChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.stockChart)).BeginInit();
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
			// stockChart
			// 
			chartArea2.Name = "ChartArea1";
			this.stockChart.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.stockChart.Legends.Add(legend2);
			this.stockChart.Location = new System.Drawing.Point(12, 41);
			this.stockChart.Name = "stockChart";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
			series2.Legend = "Legend1";
			series2.Name = "Salary";
			series2.YValuesPerPoint = 4;
			this.stockChart.Series.Add(series2);
			this.stockChart.Size = new System.Drawing.Size(860, 385);
			this.stockChart.TabIndex = 2;
			this.stockChart.Text = "chart1";
			title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			title2.Name = "stock";
			title2.Text = "Employee Salaries";
			this.stockChart.Titles.Add(title2);
			// 
			// Stock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 438);
			this.Controls.Add(this.stockChart);
			this.Controls.Add(this.backBtn);
			this.Name = "Stock";
			this.Text = "Stock";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_FormClosing_1);
			this.Load += new System.EventHandler(this.Stock_Load);
			((System.ComponentModel.ISupportInitialize)(this.stockChart)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart stockChart;
    }
}