using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Grafica_datos_de_un_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            txt_nota4.Clear();
            txtpromedio.Clear();
            txt_condicion.Clear();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            double nota1, nota2, nota3, nota4, promedio;
            string condicion;

            nota1 = double.Parse(txt_nota1.Text);
            nota2 = double.Parse(txt_nota2.Text);
            nota3 = double.Parse(txt_nota3.Text);
            nota4 = double.Parse(txt_nota4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio >= 70)
            {
                condicion = "Aprobado";
                txtpromedio.Text = promedio.ToString();
                txt_condicion.Text = condicion;
                txtpromedio.ForeColor = Color.Green;
                txt_condicion.ForeColor = Color.Green;
            }
            else
            {
                condicion = " Reprobado";
                txtpromedio.Text = promedio.ToString();
                txt_condicion.Text = condicion;
                txtpromedio.ForeColor = Color.Red;
                txt_condicion.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
