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
    public partial class MenuPrincipall : Form
    {
        public MenuPrincipall()
        {
            InitializeComponent();
            string usuario = " Juninho";
            user.Text = user.Text + usuario;
            
        }

        private void btnAdc_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipalvoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipalvoltar.BackColor = Color.RoyalBlue;
            
        }

        private void FormFuncionario_Click(object sender, EventArgs e)
        {
            var formfunc = new FormulFunc();

            formfunc.Show();

            this.Visible = false;
        }

        private void FormCidade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void FormProduto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void NegVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void FormVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void resumoCaixa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
