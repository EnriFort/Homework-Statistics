using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName = textBox1.Text;

            // simple error handling
            if (textBox1.Text != "")
            {
                TextFieldParser parser = new TextFieldParser(@"..\..\..\" + FileName + ".csv");
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");


                //Process first row
                string[] fields = parser.ReadFields();

                foreach (string field in fields) // for every field of first raw
                {
                    dataGridView1.Columns.Add(field, field); // add the field in the table
                }

                while (!parser.EndOfData) // for the others rows
                {
                    string[] raw = parser.ReadFields();
                    dataGridView1.Rows.Add(raw);
                }
            }
        }

        // when you click on the column header 
        private void dataGridView1_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            chart1.Series["Relative Frequency"].IsVisibleInLegend = false;
            var univ = new Dictionary<string, int>();
            int col = e.ColumnIndex;

            foreach (DataGridViewRow row in dataGridView1.Rows) // scroll all raws
            {
                object obj = row.Cells[col].Value; // i get table[row][col] object
                if (obj == null)
                    continue;

                string val = obj.ToString().ToLower();
                if (val != "")
                {
                    if (univ.ContainsKey(val)) // if it is already in the dictionary 
                        univ[val] += 1;
                    else
                        univ.Add(val, 1);
                }

            }

            // clear the chart
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            // load value in the chart
            foreach (var item in univ)
            {
                this.chart1.Series["Relative Frequency"].Points.AddXY(item.Key.ToString(), item.Value);
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Insert CSV file name...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Insert CSV file name...";
            }
        }
    }
}
