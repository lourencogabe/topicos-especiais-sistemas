using System.Security.Cryptography.X509Certificates;
using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


Produto produto = new Produto();

// Console.WriteLine(produto.getNome());
Console.WriteLine(produto.Nome);

List<Produto> produtos = new List<Produto>();

//EndPoints - Funcionalidades
//GET: http://localhost:5225/
app.MapGet("/", () => "Minha primeira API em C# com watch");

//GET: http://localhost:5225/api/produto/listar
app.MapGet("/api/produto/listar", () => 
    produtos);

//GET: http://localhost:5225/api/produto/buscar/id_do_produto
app.MapGet("/api/produto/buscar/{id}", (string id) => 
{
    foreach (Produto produtoCadastrado in produtos)
    {
        if(produtoCadastrado.Id == id)
        {
            return Results.Ok(produtoCadastrado);
        }
    }
    // Produto não encontrado
    return Results.NotFound("Produto não encontrado!");
});

//POST: http://localhost:5225/api/produto/cadastrar
app.MapPost("/api/produto/cadastrar/", 
    //Variaveis que serão preenchidas de acordo com a URL
    (Produto novoProduto) => 
    //Utilize as chaves para criar um bloco de código extra
    {   
        //Adiciona o produto na list de produtos criada no inicio do código
        produtos.Add(novoProduto);
        //Verifica se o objeto foi criado
        return Results.Ok(novoProduto);
    });

app.MapDelete("/api/produto/remover/{id}", (string id) =>{
    foreach (Produto produto in produtos)
    {
        if(produto.Id == id)
        {
            produtos.Remove(produto);
            return Results.Ok(produto);
        }   
    }
    //Produto nao foi encontrado para excluir
    return Results.NotFound("Produto não encontrado para remoção!");
});

app.MapPut("/api/produto/atualizar/", (Produto produtoAtualizado) =>{
    foreach (Produto produto in produtos)
    {
        if(produto.Nome == produtoAtualizado.Nome)
        {
            produto.Nome = produtoAtualizado.Nome;
            return Results.Ok(produtoAtualizado);
        }
    }
    //Produto nao foi encontrado para atualizar
    return Results.NotFound("Produto não encontrado para ajuste");
});

app.Run();