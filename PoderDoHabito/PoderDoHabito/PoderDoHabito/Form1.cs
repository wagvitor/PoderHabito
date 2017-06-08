using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderDoHabito
{
    public partial class Form1 : Form
    {

        double soma = 0;
        double peso= 0;
        double altura = 0;
            
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            peso = double.Parse(txtPeso.Text);//duas maneiras de converter
            altura = double.Parse(txtAltura.Text);




            soma = (peso / (altura * altura));



            lblImc.Text = Convert.ToString(soma);

            if (soma < 18.5)
            {

                var ma = new Magro();
                ma.ShowDialog();

                txtAltura.Text = "";
                txtPeso.Text = "";
                lblImc.Text = "";
                this.Close();




            }
            else if (soma >= 18.6 && soma <= 24.9)
            {
                var peso = new PesoIdeal();

                peso.ShowDialog();
                txtAltura.Text = "";
                txtPeso.Text = "";
                this.Close();

            }

            else if (soma >= 25 && soma <= 29.9)
            {


                var tela2 = new Incetivo();

                tela2.ShowDialog();
                txtAltura.Text = "";
                txtPeso.Text = "";
                this.Close();

            }
            else if (soma >= 30 && soma <= 34.9)
            {

                var tela4 = new Incetivo();
                tela4.ShowDialog();
                txtAltura.Text = "";
                txtPeso.Text = "";
                this.Close();

            }
            else if (soma >= 35 && soma <= 39.9)
            {

                var tela5 = new Incetivo();
                tela5.ShowDialog();
                txtAltura.Text = "";
                txtPeso.Text = "";
                this.Close();

            }
            else if (soma >= 40)
            {

                var tela6 = new Incetivo();
                tela6.ShowDialog();
                txtAltura.Text = "";
                txtPeso.Text = "";
                this.Close();


            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }


        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
