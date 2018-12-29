/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 6 								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331)   *  
 *																										           *
 *  Date Due  : November 29, 2018			File :	Pie.cs      					     				           *                          
 *																										           *
 *  Purpose   : A Form application to populate charts   													       *
 *																							                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uncharted
{
    public partial class Pie : Form
    {
        public Pie()
        {
            InitializeComponent();
        }

		//Method for back button
		private void backBtn_Click(object sender, EventArgs e)
        {
			//Creating an object for Form1
			Form1 f1 = new Form1();
			//Hiding this form
			this.Hide();
            f1.FormClosed += (s, args) => this.Close();
			//Showing Form1 and setting the focus to it
			f1.Show();
            f1.Focus();
        }	

		//Method that is executed on the start of this form
		private void Pie_Load(object sender, EventArgs e)
		{
			//Setting the labels to be outside of the circle
			pieChart.Series["Demographics"]["PieLabelStyle"] = "Outside";
			pieChart.Series["Demographics"].IsValueShownAsLabel = true;
			//Assigning width for the line to point the labels
			pieChart.Series[0].BorderWidth = 1;
			pieChart.Series[0].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

			// Set the pie label as well as legend text to be displayed as percentage
			// The P2 indicates a precision of 2 decimals
			pieChart.Series[0].Label = "#PERCENT{P2}";
			pieChart.Series[0].LegendText = "#VALX";
			//Looping through pieChartData and adding data points to the piechart
			foreach (var x in Form1.pieChartData)
			{
				string[] result = x.Split('-');				
				pieChart.Series["Demographics"].Points.AddXY(result[0],result[1]);				
			}			
		}

		//Method that is executed on closing the form
		private void Pie_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			//Cancelling the close operation and opening the portal form
			e.Cancel = true;
			Form1 f1 = new Form1();
			this.Hide();
			f1.FormClosed += (s, args) => this.Close();
			f1.Show();
			f1.Focus();
		}
	}
}
