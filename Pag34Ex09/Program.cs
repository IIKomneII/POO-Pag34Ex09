using Pag34Ex09.Models;

Livro livro = new();


livro.tituloDoLivro = "Percy Jackson";

livro.autor = "Rick Riordan";

livro.numeroDePaginas = 1816;

livro.editora = "Editora Intrínseca";

Biblioteca biblioteca = new Biblioteca();

bool emprestimoSucesso = biblioteca.FazerEmprestimos(livro);
if (emprestimoSucesso)
{
    Console.WriteLine("Livro emprestado com sucesso!");
}
else
{
    Console.WriteLine("Livro não disponivel para emprestimo.");
}

bool devolucaoSucesso = biblioteca.DevolverLivro(livro);
if (devolucaoSucesso)
{
    Console.WriteLine("Livro devolvido com sucesso!");
}
else
{
    Console.WriteLine("Livro ja estava disponivel.");
}