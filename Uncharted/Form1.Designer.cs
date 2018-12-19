namespace Uncharted
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
			this.barBtn = new System.Windows.Forms.Button();
			this.lineBtn = new System.Windows.Forms.Button();
			this.pieBtn = new System.Windows.Forms.Button();
			this.stockBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// barBtn
			// 
			this.barBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.barBtn.Location = new System.Drawing.Point(328, 99);
			this.barBtn.Name = "barBtn";
			this.barBtn.Size = new System.Drawing.Size(232, 28);
			this.barBtn.TabIndex = 0;
			this.barBtn.Text = "BAR CHART";
			this.barBtn.UseVisualStyleBackColor = true;
			this.barBtn.Click += new System.EventHandler(this.barBtn_Click);
			// 
			// lineBtn
			// 
			this.lineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lineBtn.Location = new System.Drawing.Point(328, 147);
			this.lineBtn.Name = "lineBtn";
			this.lineBtn.Size = new System.Drawing.Size(232, 28);
			this.lineBtn.TabIndex = 1;
			this.lineBtn.Text = "LINE CHART";
			this.lineBtn.UseVisualStyleBackColor = true;
			this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
			// 
			// pieBtn
			// 
			this.pieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pieBtn.Location = new System.Drawing.Point(328, 197);
			this.pieBtn.Name = "pieBtn";
			this.pieBtn.Size = new System.Drawing.Size(232, 28);
			this.pieBtn.TabIndex = 2;
			this.pieBtn.Text = "PIE CHART";
			this.pieBtn.UseVisualStyleBackColor = true;
			this.pieBtn.Click += new System.EventHandler(this.pieBtn_Click);
			// 
			// stockBtn
			// 
			this.stockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.stockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stockBtn.Location = new System.Drawing.Point(328, 248);
			this.stockBtn.Name = "stockBtn";
			this.stockBtn.Size = new System.Drawing.Size(232, 28);
			this.stockBtn.TabIndex = 3;
			this.stockBtn.Text = "STOCK CHART";
			this.stockBtn.UseVisualStyleBackColor = true;
			this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBtn.Location = new System.Drawing.Point(328, 301);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(232, 28);
			this.exitBtn.TabIndex = 4;
			this.exitBtn.Text = "EXIT";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(272, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(367, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Click on any button to show a chart";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 438);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.stockBtn);
			this.Controls.Add(this.pieBtn);
			this.Controls.Add(this.lineBtn);
			this.Controls.Add(this.barBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button barBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button pieBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Label label1;
	}
}

