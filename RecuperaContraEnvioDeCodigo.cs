using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGymnasio
{
    public partial class RecuperaContraEnvioDeCodigo : Form
    {
        string codigo = "123";
        public RecuperaContraEnvioDeCodigo()
        {
            InitializeComponent();
            Panel_Contraseña.Visible = false;
        }

        private void btn_VerificarCodigo_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == codigo)
            {
                MessageBox.Show("Codigo verificado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Panel_Codigo.Visible = false;
                Panel_Contraseña.Visible = true;
            }
            else
            {
                MessageBox.Show("Codigo erroneo", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            txt_Codigo.Clear();
            txt_Codigo.Focus();
        }

        private void btn_EnviarCodigo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //EnviarCodigo();
            MessageBox.Show("Codigo enviado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
