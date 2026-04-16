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
            btnAjuste.Text = "excluir";
            btnAcoes.Text = "Atualizar";
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
            btnAcoes.Text = "Cadastrar";
            btnAjuste.Text = "Atualizar lista";
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
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Insert(titulo, genero, autor, editora, isbn, quantidade);
                    limparElementos();
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
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
                    livros.Update(livro.LivroID, livro.Titulo, livro.Autor, livro.Editora, livro.Genero, livro.ISBN, livro.QuantidadeDisponivel);
                    btnAcoes.Text = "Cadastro";
                    btnAjuste.Text = "Atualizar";
                    AtualizarLista();
                    limparElementos();
                }
                catch
                {
                    MessageBox.Show("Numero invalido", "Eero de digitacao");
                }
            }
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboLivros != null) return;
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);
                AtualizarLista();
                limparElementos();
                btnAcoes.Text = "Atualizar Lista";
                btnAjuste.Text = "cadastrar";
            }


        }
    }
}