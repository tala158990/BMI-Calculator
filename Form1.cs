using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            float lengte = float.Parse(lblLengte.Text);
            float gewicht = float.Parse(lblGewicht.Text);
            float leeftijd = float.Parse(lblLeeftijd.Text);

            float BMI = gewicht / (lengte * lengte);

            string advies; 

            if (BMI < 19)

            {
                advies = "Ondergewicht, probeer aan te komen.";
            }

            else if (BMI <= 25)

            {
                advies = "Gezond, probeer op gewicht te blijven.";
            }

            else if (BMI < 30)

            {
                advies = "Overgewicht, probeer af te vallen.";
            }

            else

            {
                 advies = "Ernistig overgewicht, probeer onder begeleiding af te vallen";
            }

        

            lblBMI.Text = BMI.ToString();
            lblAdvies.Text = advies ;


        }

        private void manButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
