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
            Process.Start ("https://www.google.com/search?q=foto+do+capit%C3%A3o+jack+sparrow&sca_esv=af156264804c4707&rlz=1C1MYPO_pt-BRBR1178BR1192&sxsrf=ANbL-n41vFmBbm1DP_6CmAUrsy3osQlcww%3A1778458173163&ei=PR4BatPWCenK1sQP-_LmAQ&biw=1366&bih=633&oq=foto+do+capitao+j&gs_lp=Egxnd3Mtd2l6LXNlcnAiEWZvdG8gZG8gY2FwaXRhbyBqKgIIADIGEAAYFhgeMgYQABgWGB4yBhAAGBYYHjIGEAAYFhgeMggQABgWGB4YCjIIEAAYgAQYogQyBRAAGO8FMgUQABjvBUiMWVDOBFicTHACeAGQAQCYAcQBoAGcDqoBBDEuMTG4AQHIAQD4AQGYAg6gAqUQwgIKEAAYRxjWBBiwA8ICDRAAGIAEGIoFGEMYsAPCAhMQLhiABBiKBRhDGMgDGLAD2AEBwgITEC4YQxiABBiKBRjIAxiwA9gBAcICChAjGIAEGIoFGCfCAgoQABiABBiKBRhDwgIIEAAYgAQYsQPCAgUQABiABMICCxAAGIAEGLEDGIMBwgIKEAAYgAQYFBiHAsICBRAhGKABmAMAiAYBkAYSugYGCAEQARgIkgcFMi44LjSgB787sgcFMC44LjS4B-8PwgcHMi0yLjkuM8gHzAGACAE&sclient=gws-wiz-serp");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarUsuarioTableAdapter consulta = new VerificarUsuarioTableAdapter();
            var usuario = (from linha in consulta.GetData(txtUsuario.Text, txtSenha.Text)
                           select linha).FirstOrDefault();
            if (usuario == null)
            {
              // MessageBox.Show("o login esta incorreto ou nao existe");
               // return;
            }
            saida = true;
            Close();
        }
    }
}
