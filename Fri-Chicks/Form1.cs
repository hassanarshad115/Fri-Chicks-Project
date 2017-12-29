using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fri_Chicks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetMethod();
        }

        private void ResetMethod()
        {
            lattetextBox.Text = "0";
            costdrinklabel3.Text = "0";
            coffeecaketextBox.Text = "0";
            costcakelabel7.Text = "0";
            servicechargeslabel9.Text = "1.75";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetMethod();
            lattetextBox.Enabled = false;
            coffeecaketextBox.Enabled = false;
        }

        private void chklatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chklatte.Checked == true)
            {
                lattetextBox.Enabled = true;
                lattetextBox.Text = "";
                lattetextBox.Focus();
            }
            if (chklatte.Checked == false)
            {
                lattetextBox.Enabled = false;
                lattetextBox.Text = "0";
            }
        }

        private void chkcoffeecake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcoffeecake.Checked == true)
            {
                coffeecaketextBox.Enabled = true;
                coffeecaketextBox.Text = "";
                coffeecaketextBox.Focus();
            }
            if (chkcoffeecake.Checked == false)
            {
                coffeecaketextBox.Enabled = false;
                coffeecaketextBox.Text = "0";
            }
        }

        private void lattetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }

        private static void EnterOnlyNumberMethod(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void coffeecaketextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }
    }
}
