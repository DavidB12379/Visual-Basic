using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Name: David Badrak
Date: 2/22/24
Program: Mannys Music Form
Program Description: Calculates the total for different discount levels
*/

namespace MannysMusicForm
{
    public partial class MainFrm : Form

        //Variables
    {
        double violaQuantity;
        double pianoQuantity;

        double mult_piano;
        double mult_viola;

        double violaDisMult;
        double pianoDisMult;

        double subtotal;
        double discount;
        double total;

        //Constant

        const double VIOLA_PRICE = 295;
        const double PIANO_PRICE = 795;

        const double PLATINUM = .2;
        const double GOLD = .15;
        const double SILVER = .1;
        
        public MainFrm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resets everything
            txtViola.Text = "";
            txtViola.Focus();
            txtElecPiano.Text = "";

            rbtnSilver.Checked = false;
            rbtnGold.Checked = false;
            rbtnPlatinum.Checked = false;

            lblSubtotal.Text = "";
            lblDiscount.Text = "";
            lblTotal.Text = "";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //Calculates the total for each intrument
            //Viola
            violaQuantity = double.Parse(txtViola.Text);
            mult_viola = violaQuantity * VIOLA_PRICE;
            //Electric Piano
            pianoQuantity = double.Parse(txtElecPiano.Text);
            mult_piano = pianoQuantity * PIANO_PRICE;


            if (rbtnSilver.Checked == true)
            {
                violaDisMult = SILVER * mult_viola;
                pianoDisMult = SILVER * mult_piano;
            }
            else if (rbtnGold.Checked == true)
            {
                violaDisMult = GOLD * mult_viola;
                pianoDisMult = GOLD * mult_piano;
            }
            else if (rbtnPlatinum.Checked == true)
            {
                violaDisMult = PLATINUM * mult_viola;
                pianoDisMult = PLATINUM * mult_piano;
            }

            subtotal = mult_piano + mult_viola;
            discount = violaDisMult + pianoDisMult;
            total = subtotal - discount;

            lblSubtotal.Text = subtotal.ToString("n");
            lblDiscount.Text = discount.ToString("n");
            lblTotal.Text = total.ToString("c");
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Clsoes the app
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Resets everything
            txtViola.Text = "";
            txtViola.Focus();
            txtElecPiano.Text = "";

            rbtnSilver.Checked = false;
            rbtnGold.Checked = false;
            rbtnPlatinum.Checked = false;

            lblSubtotal.Text = "";
            lblDiscount.Text = "";
            lblTotal.Text = "";
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
