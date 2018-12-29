/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 6 								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331)    *  
 *																										           *
 *  Date Due  : November 29, 2018			File :	Line.cs     					     				           *                          
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
    public partial class Line : Form
    {

        public Line()
        {
            InitializeComponent();
        }

		string[] Month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

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
		private void Line_Load(object sender, EventArgs e)
        {
			lineChart.ChartAreas["ChartArea1"].AxisX.Title = "Month";
			lineChart.ChartAreas["ChartArea1"].AxisY.Title = "Temperature(Fahrenheit)";
			lineChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
			for (int i = 0; i < 11; i++)
			{
				lineChart.Series["Tokyo"].Points.AddXY(Month[i],Form1.lineChartData[i]);
			}

			for (int i = 12; i < 24; i++)
			{
				lineChart.Series["NewYork"].Points.AddXY(Month[i-12], Form1.lineChartData[i]);
			}

			for (int i = 25; i < 36; i++)
			{
				lineChart.Series["Berlin"].Points.AddXY(Month[i-25], Form1.lineChartData[i]);
			}

			for (int i = 37; i < 48; i++)
			{
				lineChart.Series["London"].Points.AddXY(Month[i-37], Form1.lineChartData[i]);
			}

		}

		//Method that is executed on closing the form
		private void Line_FormClosing(object sender, FormClosingEventArgs e)
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
