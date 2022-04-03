using PW3_2022_1C_Clase_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3_2022_1C_Clase1_Bola8_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{Respuestas.Preguntar()}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPregunta.Text = "";
            label1.Text = "";
        }
    }
}
