using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Form1 : Form
    {
        private Erros erros;
        private Livros livros;
        public Form1()
        {
            InitializeComponent();
            erros = new Erros();
            erros.Dock = DockStyle.Fill; 
            tpErro.Controls.Add(erros);
            erros.Controls.Find("btnErro", true).First().Click += VoltarTelaPrincipal;
            //localiza o botao btnErro, verifica se existe, se existir, retorna o primeiro e adiciona a funcao de click.

            livros = new Livros();
            livros.Dock = DockStyle.Fill;

            tpLivros.Controls.Add(livros);
            //livros.Controls.Find("btnLivros", true).First().Click += VoltarTelaPrincipal;


        }
        private void VoltarTelaPrincipal (object sender, EventArgs e)
        {
            tcControle.SelectTab(tpTelaPrincipal);
        }
    

        private void btnErro_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpErro);
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpLivros);
            Size = new System.Drawing.Size(800, 600); 
        }
    }
}
