namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
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
    }
}
