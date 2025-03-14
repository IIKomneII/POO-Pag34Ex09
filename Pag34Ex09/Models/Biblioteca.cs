namespace Pag34Ex09.Models;

public class Biblioteca
{
    public bool FazerEmprestimos(Livro livro)
    {
        if (livro.status == true)
        {
            livro.status = false;
            return true;
        }
        return false;
    }

    public bool DevolverLivro(Livro livro)
    {
        if (livro.status == false)
        {
            livro.status = true;
            return true;
        }
        return false;
    }
}