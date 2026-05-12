using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class consultando : UserControl
    {
        public consultando()
        {
            InitializeComponent();
            EmprestimosTableAdapter emprestimos = new EmprestimosTableAdapter();
            lboConsulta.Items.AddRange(emprestimos.GetData().ToArray());
        }
        private void livroIndisponivel()
        {

            lblTitulo.Text = "Livro nao existe";
            lblFuncionario.Text = "Livro nao existe";
            lblUsuario.Text = "Livro nao existe";
            lblDataEmprestimo.Text = "Livro nao existe";
            lblDataDevolucao.Text = "Livro nao existe";
            lblStatus.Text = "Livro nao existe";
        }
     



        private void lboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmprestimosRow emprestimos = lboConsulta.SelectedItem as EmprestimosRow;
            if (emprestimos == null ) return;
            lblDataEmprestimo.Text = emprestimos.DataRequisicao.ToString();
            lblDataDevolucao.Text = emprestimos.Devolucao;
            lblStatus.Text = emprestimos.Status;


            LivrosTableAdapter livros = new LivrosTableAdapter();
            LivrosRow livro = (from linha in livros.GetData()
                              where linha.LivroID == emprestimos.LivroID
                              select linha).FirstOrDefault();
            lblTitulo.Text = emprestimos.Status;

            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            UsuariosRow usuario = (from linha in usuarios.GetData()
                               where linha.ID_Usuario == emprestimos.ID_Usuario
                               select linha).FirstOrDefault();
            if (livro == null)
            {

                livroIndisponivel();
                return;
            }

            if (usuario == null)

                livroIndisponivel();

           
            lblUsuario.Text = usuario.ToString();

            if (livro == null) return;
            lblTitulo.Text = livro.Titulo;
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                           where linha.ID_funcionario == emprestimos.ID_Funcionario
                                           select linha).FirstOrDefault();
            lblFuncionario.Text = funcionario.ToString();
            if (funcionario == null)
                livroIndisponivel();







        }

        private void txtLivro_TextChanged(object sender, EventArgs e)
        {
            if (txtLivro.Text == "" )
            {
                EmprestimosTableAdapter dados = new EmprestimosTableAdapter();
                lboConsulta.Items.AddRange(dados.GetData().ToArray());
                return;
            }
            EmprestimosTableAdapter emprestimos = new EmprestimosTableAdapter();
            lboConsulta.Items.Clear();
            lboConsulta.Items.AddRange(
                (from linha in emprestimos.GetData()
                where emprestimos.ToString().ToLower().Contains(txtLivro.Text)
                select linha).ToArray()
            );

            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
