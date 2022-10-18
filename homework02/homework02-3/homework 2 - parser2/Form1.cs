using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Reflection;

namespace homework_2___parser2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName = textBox1.Text;
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        // when you click on the column header 
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            richTextBox1.Clear();
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

            richTextBox1.AppendText("The univariate distributon is:" + "\n");
            foreach (var item in univ)
            {
                richTextBox1.AppendText(item.Key.ToString() + " --> " + item.Value + "\n");
            }
        }
    }
}


