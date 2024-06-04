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
    public partial class Login : Form
    {
        Admin admin;
        public Login()
        {
            InitializeComponent();
            admin = new Admin();
            btn_OcultarContraseña.Visible = false;
            txt_Pass.PasswordChar = 'x';
        }
        
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(admin.verificarAdmin(txt_User.Text, txt_Pass.Text))
            {
                MessageBox.Show("Bienvenido " + txt_User.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlDeAcceso a = new ControlDeAcceso();
                this.Hide();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario " + txt_User.Text + " no encontrado", "Error !!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_VerContraseña_Click(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = '\0';
            btn_VerContraseña.Visible = false;
            btn_OcultarContraseña.Visible = true;
        }

        private void btn_OcultarContraseña_Click(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = 'x';
            btn_VerContraseña.Visible = true;
            btn_OcultarContraseña.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void link_RecuperaciónContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperaContraEnvioDeCodigo r = new RecuperaContraEnvioDeCodigo();
            this.Hide();
            r.ShowDialog();
        }
    }
}
