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
    public partial class Emprestimos : UserControl
    {
        public Emprestimos()
        {
            InitializeComponent();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach(var funcionario in obterFuncionarios) cboFuncionarios.Items.Add(funcionario);
            cboFuncionarios.SelectedIndex = 0;
            
            //livros aqui!!
            LivrosTableAdapter livros = new LivrosTableAdapter();
            var obterLivros = from linha in livros.GetData()
                              where linha.QuantidadeDisponivel > 0
                              select linha;
            foreach(var livro in obterLivros) lboLivros.Items.Add(livro);

            //Usuarios aqui!!
            UsuariosTableAdapter Usuarios = new UsuariosTableAdapter();
            var obterUsuario = from linha in Usuarios.GetData()                         
                              select linha;
            foreach (var usuario in obterUsuario) lboUsuarios.Items.Add(Usuarios);


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LivrosRow livroSelecionado = lboLivros.SelectedItem as LivrosRow;
                UsuariosRow usuarioSelecionado = lboUsuarios.SelectedItem as UsuariosRow;
                FuncionariosRow funcionariosSelecionado = cboFuncionarios.SelectedItem as FuncionariosRow;
            if (funcionariosSelecionado != null ) return;
            else if (livroSelecionado  == null) return;
            else if (funcionariosSelecionado == null) return ;
            QueriesTableAdapter consulta = new QueriesTableAdapter();// LivroIDmprestado @FuncionarioIDEmprestado @UsuarioIDEmprestado, colocar na ordem da procedure.
            consulta.EmprestarLivro(
            livroSelecionado.LivroID,
            funcionariosSelecionado.ID_funcionario,
            usuarioSelecionado.ID_Usuario
            );
            MessageBox.Show($"O emprestimo ficou para ser desenvolvido no dia {DateTime.Now.AddDays(7)}");




        }
    }
}
