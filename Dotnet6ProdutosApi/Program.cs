using Microsoft.AspNetCore.Mvc;
using ProdutosApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IProdutosService, ProdutosService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("produtos", async ([FromServices] IProdutosService _service) =>
{
    var lista = _service.GetAll();
    return Results.Ok(lista);
});

app.MapGet("produtos/{id}", async ([FromServices] IProdutosService _service,
        [FromRoute] int id ) => 
{
    var item = _service.GetOne(id);
    return Results.Ok(item);
});

app.MapPost("produtos", async([FromServices] IProdutosService _service,
       ProdutosPostRequestModel produto ) => 
{
    var resposta = _service.Inserir(produto);          
    return Results.Ok(resposta);
});


app.UseSwagger();
app.UseSwaggerUI();
app.Run();
