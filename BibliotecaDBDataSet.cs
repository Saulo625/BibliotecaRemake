namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
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
    }
}
