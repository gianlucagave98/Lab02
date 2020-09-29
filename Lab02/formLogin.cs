using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        string[] usuarios = { "Gianluca", "Hugo" };
        string[] passwords = { "tecsup123", "tecsup456" };
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(usuarios.Contains(txtUsuario.Text) && passwords.Contains(txtPassword.Text))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrectas");
            }
           

        }
    }
}
