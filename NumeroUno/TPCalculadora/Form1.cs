using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCalculadora
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inicializa dos metodos.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            CargarComboOperacion();
        }

        /// <summary>
        /// Adjunta los operadores matematicos (a utilizar) al metodo.
        /// </summary>
        private void CargarComboOperacion()
        {
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
            cmbOperacion.Items.Add("-");
        }

        /// <summary>
        /// Limpia la pantalla (Los TextBox de la pantalla).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNumero1.Clear();
            textNumero2.Clear();
            lblResultado.Text = "0";
        }

        private void textNumero2_TextChanged(object sender, EventArgs e)
        {

            //double num2 = double.Parse(textNumero1.Text);
        }

        private void textNumero1_TextChanged(object sender, EventArgs e)
        {
            //double num1 = double.Parse(textNumero1.Text);
            
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string operacion = "";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora Calcudora1 = new Calculadora();
           
            Numero num1 = new Numero(double.Parse(textNumero1.Text));
            Numero num2 = new Numero(double.Parse(textNumero2.Text));

            double n1 = num1.getNumero();
            double n2 = num1.getNumero();

            double num = 0; 
            double.TryParse(textNumero1.Text, out num);

            string oper = cmbOperacion.Text;
            oper = Calculadora.validarOperador(oper);
           

            lblResultado.Text = Calculadora.Operar(num1, num2,oper).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
