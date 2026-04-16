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
        private Livros livros;
        private Usuarios Usuarios;
        private Emprestimos Emprestimos;
        private Funcionarios Funcionarios;
        
        public Form1()
        {
            InitializeComponent();
                        
            livros = new Livros();
            livros.Dock = DockStyle.Fill;
            tpLivros.Controls.Add(livros);
            livros.Controls.Find("btnLivros", true).First().Click += VoltarTelaPrincipal;
            //localiza o botao btnLivros, verifica se existe, se existir, retorna o primeiro e adiciona a funcao de click.

            Usuarios = new Usuarios();
            Usuarios.Dock = DockStyle.Fill;
            tpUsuarios.Controls.Add(Usuarios);
            Usuarios.Controls.Find("button1", true).First().Click += VoltarTelaPrincipal;

            Emprestimos = new Emprestimos();
            Emprestimos.Dock = DockStyle.Fill;
            tpEmprestimos.Controls.Add(Emprestimos);
            Emprestimos.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal;

            Funcionarios = new Funcionarios();
            Funcionarios.Dock = DockStyle.Fill;
            tpFuncionarios.Controls.Add(Funcionarios);
            Funcionarios.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal;
            
        }
        private void VoltarTelaPrincipal (object sender, EventArgs e)// esse sao os botoes de voltar 
        {
            tcControle.SelectTab(tpTelaPrincipal);
            tpLivros.Controls.Clear(); //O botao de voltar vai limpar os dados dentro do tpLivros
            livros = null; //livros vai ser igual a nada
            
            tcControle.SelectTab(tpTelaPrincipal);
            tpUsuarios.Controls.Clear(); //O botao de voltar vai limpar os dados dentro do tpLivros
            Usuarios = null; //livros vai ser igual a nada

            tcControle.SelectTab(tpTelaPrincipal);
            tpEmprestimos.Controls.Clear(); //O botao de voltar vai limpar os dados dentro do tpLivros
            Emprestimos = null; //livros vai ser igual a nada

            tcControle.SelectTab(tpTelaPrincipal);
            tpFuncionarios.Controls.Clear(); //O botao de voltar vai limpar os dados dentro do tpLivros
            Funcionarios = null; //livros vai ser igual a nada

        }
      


        private void btnLivros_Click(object sender, EventArgs e)
        {
            livros = new Livros();
            tpLivros.Controls.Add(livros);                     
            livros.Controls.Find("btnLivros", true).First().Click += VoltarTelaPrincipal;
            tcControle.SelectTab(tpLivros);
            Size = new System.Drawing.Size(800, 650); 
            //Todos esses dados pegam a programaco e liga novamente os componentes que nao existiam antes.
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios = new Usuarios();          
            tpUsuarios.Controls.Add(Usuarios);
            Usuarios.Controls.Find("button1", true).First().Click += VoltarTelaPrincipal;
            tcControle.SelectTab(tpUsuarios);
            Size = new System.Drawing.Size(800, 600);

        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            Emprestimos = new Emprestimos();
            tpEmprestimos.Controls.Add(Emprestimos);
            Emprestimos.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal;
            tcControle.SelectTab(tpEmprestimos);
            Size = new System.Drawing.Size(800, 600);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios = new Funcionarios();
            tpFuncionarios.Controls.Add(Funcionarios);
            Funcionarios.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal;
            tcControle.SelectTab(tpFuncionarios);
            Size = new System.Drawing.Size(800, 600);
        }


    }
}
