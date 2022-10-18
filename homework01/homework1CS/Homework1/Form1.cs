using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Homework1
{
    public partial class Form1 : Form
    {
        private void btnCreate_Click(object sender, EventArgs e)
        {

            // change color 
            txtHair.BackColor = Color.FromName(cbHair.SelectedItem.ToString()); 
            txtBody.BackColor = Color.FromName(cbBody.SelectedItem.ToString());
            txtArmDx.BackColor = Color.FromName(cbBody.SelectedItem.ToString());
            txtArmSx.BackColor = Color.FromName(cbBody.SelectedItem.ToString());
            txtLegDx.BackColor = Color.FromName(cbLegs.SelectedItem.ToString());
            txtLegSx.BackColor = Color.FromName(cbLegs.SelectedItem.ToString());

            // change head color
            if (cbHead.SelectedItem.ToString() == "LIGHT SKIN")
            {
                txtHead.BackColor = Color.LightPink;
            }
            else if (cbHead.SelectedItem.ToString() == "MEDIUM SKIN")
            {
                txtHead.BackColor = Color.Tan;
            }
            else if (cbHead.SelectedItem.ToString() == "DARK SKIN")
            {
                txtHead.BackColor = Color.Brown;
            }
            else if (cbHead.SelectedItem.ToString() == "LEGO SKIN")
            {
                txtHead.BackColor = Color.FromArgb(255,227,48);
            }
        }


        private void btnCreate_MouseMove(object sender, MouseEventArgs e)
        {
            btnCreate.BackColor = Color.Coral;
        }
        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.White;
        }



        private void cbHair_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Color HeadColor { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void gbLego_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBuildLego_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHead_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArmDx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
