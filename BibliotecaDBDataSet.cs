namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        partial class FuncionariosDataTable
        {
        }

        partial class Funcionarios
        {

        }
        partial class UsuariosDataTable
        {
        }

        partial class LivrosDataTable
        {
        }
        partial class LivrosRow
        {
            public override string ToString()
            {
                return LivroID.ToString() + "-" + Titulo;
            }

        }
        partial class UsuariosRow
        {
            public override string ToString()
            {
                return ID_Usuario.ToString() + "-" + Nome;
            }
        }
        partial class FuncionariosRow
        {
            public override string ToString()
            {
                return ID_funcionario.ToString() + "-" + NomeCompleto;
            }
        }
    }
}
