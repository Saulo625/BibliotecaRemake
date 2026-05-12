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
using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;

namespace BibliotecaRemake
{
    public partial class Livros : UserControl
    {
        public Livros()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lboLivros.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;
            foreach (LivrosRow dado in dados) lboLivros.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtGenero.Text = "";
            txtISBN.Text = "";
            txtQuantidade.Text = "";
        }

       

        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null) return;
            LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
            if (livro == null) return;
            btnAcoes.Text = "Excluir";
            btnAjuste.Text = "Atualizar";
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            txtEditora.Text = livro.Editora;
            txtGenero.Text = livro.Genero;
            txtISBN.Text = livro.ISBN;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            lboLivros.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAjuste.Text = "Atualizar lista";
            btnAcoes.Text = "Cadastrar";
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            //lboLivros.ClearSelected();
            if (btnAjuste.Text == "Cadastrar")
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editora = txtEditora.Text;
                string genero = txtGenero.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    QueriesTableAdapter livros = new QueriesTableAdapter();
                    
                        livros.inserirDados(titulo, genero, autor, editora, isbn, quantidade);
                    limparElementos();
                    AtualizarLista();
                }
                catch

                {
                    MessageBox.Show("Erro de codigo");
                }
            }
            else
            {
                if (lboLivros.SelectedItem == null)
                {
                    AtualizarLista();
                    limparElementos();
                    lboLivros.ClearSelected();
                    return;
                }
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editora = txtEditora.Text;
                string genero = txtGenero.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Update(livro.LivroID, titulo, genero, autor, editora, isbn, quantidade);
                    AtualizarLista();
                    limparElementos();
                    btnAjuste.Text = "Atualizar lista";
                    btnAcoes.Text = "Cadastrar";

                }
                catch
                {
                    MessageBox.Show("Numero invalido", "Erro de digitacao");
                }
            }
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboLivros.SelectedItem == null) return;
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                EmprestimosTableAdapter emprestando = new EmprestimosTableAdapter();

                EmprestimosRow empresta =
                    (from linha in emprestando.GetData()
                     where linha.LivroID == livro.LivroID
                     && linha.Status != "Devolvido"
                     select linha).FirstOrDefault();

                if (empresta != null)
                {
                    MessageBox.Show("Livro emprestado, nao pode ser excluido!");
                }
                else
                {
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                   livros.Delete(livro.LivroID);
                    MessageBox.Show("Livro excluído com sucesso!");
                    AtualizarLista();
                    limparElementos();
                    btnAjuste.Text = "Atualizar lista";
                    btnAcoes.Text = "Cadastrar";
                }
            }
            else
            {
                AtualizarLista();
            }

        }   
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisar = sender as TextBox;
            if (pesquisar.Text == "")
            {
                AtualizarLista();
                return;
            }    
            lboLivros.Items.Clear();
            string textoDigitado = txtPesquisar.Text;
            LivrosTableAdapter dados = new LivrosTableAdapter();
            var livros = from linha in dados.GetData()
                        where linha.Titulo.ToLower()
                                .Contains(textoDigitado.ToLower())//o ToLower ignora o maiusculo e o minusculo.
                         select linha;
            foreach (var livro in livros) lboLivros.Items.Add(livro);
        }
    }
}