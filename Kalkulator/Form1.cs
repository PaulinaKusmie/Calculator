using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';


     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            switch (RodzajDzialania)
            {
                case ('+'):
                    txtBoxWynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                break;

                case ('-'):
                    txtBoxWynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;

                case ('*'):
                    txtBoxWynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;

                case ('/'):
                    txtBoxWynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;

            }


            LiczbaDruga = " ";
            LiczbaPierwsza = " ";
            RodzajDzialania = ' ';
                
           

                
                
        }





        private void btnDziel_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
            txtBoxWynik.Text = " ";
        }

        private void btnRazy_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
            txtBoxWynik.Text = " ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
            txtBoxWynik.Text = " ";
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
            txtBoxWynik.Text = " ";
        }





        private void btn0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        

        private void btn2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }



        private void btn3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }
        


        private void btn5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
          
        }




        private void Dzialanie(int liczba)

        {

            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += liczba;
                txtBoxWynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                txtBoxWynik.Text = LiczbaDruga;
            }
        }

      
        
    }
}
