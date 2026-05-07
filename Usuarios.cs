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
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter UsuariosDados = new UsuariosTableAdapter();
            var dados = from linha in UsuariosDados.GetData()
                        select linha;
            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;
           UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuario == null) return;
            btnAjuste.Text = "Atualizar";
            btnAcoes.Text = "Excluir";
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            //lboLivros.ClearSelected();
            if (btnAjuste.Text == "Cadastrar")
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                try
                {
                  
                    UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                    usuarios.Insert(nome, email, telefone);
                    limparElementos();
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (lboUsuarios.SelectedItem == null)
                {
                    AtualizarLista();
                    limparElementos();
                    lboUsuarios.ClearSelected();
                    return;
                }
                UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
                if (usuario == null) return;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;

                try
                {              
                    UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                    usuarios.Update(usuario.ID_Usuario, nome, email, telefone);
                    AtualizarLista();
                    limparElementos();
                    btnAcoes.Text = "Atualizar lista";
                    btnAjuste.Text = "Cadastrar";

                }
                catch
                {
                    MessageBox.Show("Numero invalido", "Erro de digitacao");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboUsuarios.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAcoes.Text = "Atualizar lista";
            btnAjuste.Text = "Cadastrar";
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboUsuarios.SelectedItem == null) return;
                UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
                if (usuario == null) return;
                QueriesTableAdapter livros = new QueriesTableAdapter();
                livros.DeletarUsuarios(usuario.ID_Usuario);
                AtualizarLista();
                limparElementos();
                btnAcoes.Text = "Atualizar lista";
                btnAjuste.Text = "Cadastrar";
            }
            else
            {
                AtualizarLista();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisar = sender as TextBox;
            if (pesquisar.Text == "")
            {
                AtualizarLista();
                return;
            }
            lboUsuarios.Items.Clear();
            string textoDigitado = txtPesquisar.Text;
            UsuariosTableAdapter dados = new UsuariosTableAdapter();
            var usuario = from linha in dados.GetData()
                         where linha.Nome.ToLower()
                                 .Contains(textoDigitado.ToLower())//o ToLower ignora o maiusculo e o minusculo.
                         select linha;
            foreach (var usuarios in usuario) lboUsuarios.Items.Add(usuarios);
        }
    }
}


