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
using System.Security.Cryptography;

namespace BibliotecaRemake
{
    public partial class Funcionarios : UserControl
    {
        public Funcionarios()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lbofuncionarios.Items.Clear();
            FuncionariosTableAdapter FuncionariosDados = new FuncionariosTableAdapter();
            var dados = from linha in FuncionariosDados.GetData()
                        select linha;
            foreach (FuncionariosRow dado in dados) lbofuncionarios.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtNome.Text = "";
            txtCargo.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }

        private void lbofuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbofuncionarios.SelectedItem == null) return;
            FuncionariosRow funcionario = lbofuncionarios.SelectedItem as FuncionariosRow;
            if (funcionario == null) return;
           
            btnAjuste.Text = "Atualizar";
            btnAcoes.Text = "Excluir";
            txtNome.Text = funcionario.NomeCompleto;
            txtCargo.Text = funcionario.Cargo;
            txtEmail.Text = funcionario.Email;
            txtSenha.Text = Convert.ToString(funcionario.SenhaHash);

        }

        private void btnAJuste_Click(object sender, EventArgs e)
        {
            if (btnAjuste.Text == "Cadastrar")
            {
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                try
                {
                    FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                    byte[] senhaHash = Encoding.UTF8.GetBytes(txtSenha.Text);
                    funcionarios.Insert(nome, cargo, email, senhaHash);
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
                if (lbofuncionarios.SelectedItem == null)
                {
                    AtualizarLista();
                    limparElementos();
                    lbofuncionarios.ClearSelected();
                    return;
                }
                FuncionariosRow funcionario = lbofuncionarios.SelectedItem as FuncionariosRow;
                if (funcionario == null) return;
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;

                try
                {
                    FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                    funcionarios.Update(funcionarios.ID_funcionario, nome, cargo, email, senha);
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
            lbofuncionarios.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAcoes.Text = "Atualizar lista";
            btnAjuste.Text = "Cadastrar";
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lbofuncionarios.SelectedItem == null) return;
                FuncionariosRow usuario = lbofuncionarios.SelectedItem as FuncionariosRow;
                if (usuario == null) return;
                FuncionariosTableAdapter livros = new FuncionariosTableAdapter();
                livros.Delete(usuario.ID_Usuario);
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
            lbofuncionarios.Items.Clear();
            string textoDigitado = txtPesquisar.Text;
            FuncionariosTableAdapter dados = new FuncionariosTableAdapter();
            var usuario = from linha in dados.GetData()
                          where linha.Nome.ToLower()
                                  .Contains(textoDigitado.ToLower())//o ToLower ignora o maiusculo e o minusculo.
                          select linha;
            foreach (var usuarios in usuario) lbofuncionarios.Items.Add(usuarios);
        }
    }
}
