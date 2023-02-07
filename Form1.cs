using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4._2_CastingNumeros_DL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Bentero_Click(object sender, EventArgs e)
        {
            double enteron = Convert.ToDouble(entero.Text);
            double doblen = enteron * 2;
            double mitadn = enteron / 2;
      
            doble.Text = doblen.ToString();

            mitad.Text = mitadn.ToString();
        }

        private void Breal_Click(object sender, EventArgs e)
        {
            double realn =(double)Convert.ToDouble(real.Text); //Hay que utilizar coma ,no punto
            double doblen=realn* 2;
            double mitadn = (double) realn/2;

            doble.Text = doblen.ToString();

            mitad.Text=mitadn.ToString();
        }
       
        private void Bsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
