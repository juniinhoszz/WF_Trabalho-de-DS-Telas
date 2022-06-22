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
    public partial class FormulFunc : Form
    {
        public FormulFunc()
        {
            InitializeComponent();
            string usuario = " Juninho";
            user.Text = user.Text + usuario;
            



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

        private void btnAdc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função ainda não está disponivel!",
                            "Ops...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void MenuPrincipalvoltar_Click(object sender, EventArgs e)
        {
            var mnp = new MenuPrincipall();

            mnp.Show();
            this.Visible = false;
        }
        string admin;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            if(adm.Checked == true)
            {
                    admin = "é administrador";
            }else
            {
                admin = "não é administrador";
            }
            


            System.Windows.Forms.ListViewItem lista = new System.Windows.Forms.ListViewItem(new string[] {
            nomee.Text,
            userAcesso.Text,
            senhaa.Text,
            admin}, -1);

            this.listUsers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            lista});

        }
    }
}
