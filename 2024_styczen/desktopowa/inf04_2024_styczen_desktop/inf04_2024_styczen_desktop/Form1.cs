using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf04_2024_styczen_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNumber_Leave(object sender, EventArgs e)
        {
            string number = textBoxNumber.Text;
            if (number == "111" || number == "222" || number == "000")
            {
                pictureBoxObraz.Image = Image.FromFile(number + "-zdjecie.jpg");
                pictureBoxOdcisk.Image = Image.FromFile(number + "-odcisk.jpg");
            }
            else
            {
                pictureBoxObraz.Image = null;
                pictureBoxOdcisk.Image = null;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string imie = textBoxName.Text;
            string nazwisko = textBoxSurname.Text;

            if (!string.IsNullOrEmpty(imie) && !string.IsNullOrEmpty(nazwisko))
            {
                string eyeColor = string.Empty;
                if (radioButtonPiwne.Checked)
                {
                    eyeColor = radioButtonPiwne.Text;
                }
                else if(radioButtonGreen.Checked)
                {
                    eyeColor = radioButtonGreen.Text;
                }
                else if(radioButtonBlue.Checked)
                {
                    eyeColor = radioButtonBlue.Text;
                }
                MessageBox.Show(imie + " " + nazwisko + " kolor oczu " + eyeColor);
                //Można wykorzystać też drugi sposób łączenia stringa
                //MessageBox.Show($"{imie} {nazwisko} kolor oczu {eyeColor}");
            }
            else
            {
                MessageBox.Show("Wprowadź dane");
            }
        }
    }
}
