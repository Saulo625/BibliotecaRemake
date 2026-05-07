using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Login : Form
    {
        public bool saida;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {

        }

        private void llblSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start ("https://www.google.com");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarUsuarioTableAdapter consulta = new VerificarUsuarioTableAdapter();
            var usuario = (from linha in consulta.GetData(txtUsuario.Text, txtSenha.Text)
                           select linha).FirstOrDefault();
            if (usuario == null)
            {
                //MessageBox.Show("o login esta incorreto ou nao existe");
                //return;
            }
            saida = true;
            Close();
        }
    }
}
