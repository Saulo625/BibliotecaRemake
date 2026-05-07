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
    public partial class Devolvendo : UserControl
    {
        public Devolvendo()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            LivrosRow livroSelecionado = lboLivros.SelectedItem as LivrosRow;
            UsuariosRow usuarioSelecionado = lboUsuarios.SelectedItem as UsuariosRow;
            FuncionariosRow funcionariosSelecionado = cboFuncionarios.SelectedItem as FuncionariosRow;
            if (funcionariosSelecionado == null) return;
            else if (livroSelecionado == null) return;
            else if (funcionariosSelecionado == null) return;
            QueriesTableAdapter consulta = new QueriesTableAdapter();// LivroIDmprestado @FuncionarioIDEmprestado @UsuarioIDEmprestado, colocar na ordem da procedure.
            consulta.DevolverLivro(           
            livroSelecionado.LivroID,
            funcionariosSelecionado.ID_funcionario,
            usuarioSelecionado.ID_Usuario
            );
            MessageBox.Show($"O emprestimo ficou para ser desenvolvido no dia {DateTime.Now.AddDays(7)}");

        }
    }
}
