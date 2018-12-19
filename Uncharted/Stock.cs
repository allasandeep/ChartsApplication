/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 6 								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) Gayathri Sanikommu (z1822939) Venkata SuryaVamsi Maddukuri (z1855404)    *  
 *																										           *
 *  Date Due  : November 29, 2018			File : Stock.cs     					     				           *                          
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
    public partial class Stock : Form
    {
        public Stock()
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
		private void Stock_Load(object sender, EventArgs e)
		{
			//Setting the titles for x ans y axis 
			stockChart.ChartAreas["ChartArea1"].AxisX.Title = "Employee";
			stockChart.ChartAreas["ChartArea1"].AxisY.Title = "Dollars($)";
			//Setting the interval to 1
			stockChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
			//Looping through the barChartData list and adding the data points to the chart series
			foreach (var x in Form1.barChartData)
			{
				string[] result = x.Split('-');
				stockChart.Series["Salary"].Points.AddXY(result[0], 0, result[1], result[1]);
			}
		}

		//Method that is executed on closing the form
		private void Stock_FormClosing_1(object sender, FormClosingEventArgs e)
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
