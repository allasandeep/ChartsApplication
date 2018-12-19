/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 6 								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) Gayathri Sanikommu (z1822939) Venkata SuryaVamsi Maddukuri (z1855404)    *  
 *																										           *
 *  Date Due  : November 29, 2018			File :	Form1.cs     					     				           *                          
 *																										           *
 *  Purpose   : A Form application to populate charts   													       *
 *																							                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uncharted
{
    public partial class Form1 : Form
    {
		//Declaring Variables
		public static List<string> barChartData;
		public static List<string> pieChartData;
		public static List<string> lineChartData;

        public Form1()
        {
            InitializeComponent();
			loadData();
		}

		public void loadData()
		{
			barChartData = new List<string>();
			pieChartData = new List<string>();
			lineChartData = new List<string>();
			//If the File exists
			if (File.Exists(Directory.GetCurrentDirectory() + "\\barChartData.txt"))
			{
				//Reading the file and storing all the values as objects of directoryData class into a list
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\barChartData.txt")) // StreamReader is used to read data from a text file
				{
					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						barChartData.Add(data);
						data = inFile.ReadLine();
					}

					inFile.Close(); // Closing the file
				}
			}

			if (File.Exists(Directory.GetCurrentDirectory() + "\\pieChartData.txt"))
			{
				//Reading the file and storing all the values as objects of directoryData class into a list
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\pieChartData.txt")) // StreamReader is used to read data from a text file
				{
					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						pieChartData.Add(data);
						data = inFile.ReadLine();
					}

					inFile.Close(); // Closing the file
				}
			}

			if (File.Exists(Directory.GetCurrentDirectory() + "\\lineChartData.txt"))
			{
				//Reading the file and storing all the values as objects of directoryData class into a list
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\lineChartData.txt")) // StreamReader is used to read data from a text file
				{
					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						lineChartData.Add(data);
						data = inFile.ReadLine();
					}

					inFile.Close(); // Closing the file
				}
			}
		}

		//Method for Exit Button click
		private void exitBtn_Click(object sender, EventArgs e)
        {
			Environment.Exit(1);
        }

		//Method for barChart button click
        private void barBtn_Click(object sender, EventArgs e)
        {
			//Creating an object for bar chart form
            Bar bar = new Bar();
			//Hiding the current form
			this.Hide();
            bar.FormClosed += (s, args) => this.Close();
			//Showing Bar Form and setting the focus to it
			bar.Show();
            bar.Focus();
        }

		//Method for line chart button click
        private void lineBtn_Click(object sender, EventArgs e)
        {
			//Creating an object for line chart form
			Line line = new Line();
			//Hiding the current form
            this.Hide();
            line.FormClosed += (s, args) => this.Close();
			//Showing line form and setting the focus to it
			line.Show();
            line.Focus();
        }

		//Method for pie chart button click
        private void pieBtn_Click(object sender, EventArgs e)
        {
			//Creating an object for pie chart form
			Pie pie = new Pie();
			//Hiding the current form
			this.Hide();
            pie.FormClosed += (s, args) => this.Close();
			//Showing pie Form and setting the focus to it
			pie.Show();
            pie.Focus();
        }

		//Method for stock chart button click
        private void stockBtn_Click(object sender, EventArgs e)
        {
			//Creating an object for stock chart form
			Stock stock = new Stock();
			//Hiding the current form
			this.Hide();
            stock.FormClosed += (s, args) => this.Close();
			//Showing Stock Form and setting the focus to it
			stock.Show();
            stock.Focus();
        }

		//Method that is executed on closing the form
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(1);
		}

	}
}
