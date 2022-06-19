using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211377_211077
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "teste" && txtSenha.Text == "teste123")
                {
                    
                    var mp = new MenuPrincipal();
                    mp.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos!",
                                    "✘ ERRO ✘",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    
                    txtSenha.Clear();
                    txtUser.SelectAll();
                    txtUser.Focus();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                                    "✘ ERRO ✘",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }

                
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.LightCyan;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightCyan;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }
    }
}
