using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System.Linq;

namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        partial class LivrosDataTable
        {
        }

        partial class UsuariosDataTable
        {
        }

        partial class FuncionariosDataTable
        {
        }

        partial class EmprestimosDataTable
        {
        }

        partial class FuncionariosRow
        {
            public override string ToString()
            {
                return NomeCompleto;
            }
        }

        partial class UsuariosRow
        {
            public override string ToString()
            {
                return Nome;
            }
        }

        partial class LivrosRow
        {
            public override string ToString()
            {
                return Titulo;
            }
        }




        partial class EmprestimosRow
        {
            public string Devolucao
            {
                get
                {
                    try
                    {
                        return DataDevolucao.ToString();
                        
                    }
                    catch
                    {
                        return "Devolvido";
                    }
                }
            }
            public override string ToString()
            {
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData()
                                   where linha.LivroID == this.LivroID
                                   select linha).FirstOrDefault();
                if (livro == null)
                {
                    return "O livro foi excluido";
                }

                return livro.Titulo;
            }
        }
        
    }
}
