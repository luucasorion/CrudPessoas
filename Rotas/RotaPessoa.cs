using CrudPessoa.Dados;
using CrudPessoa.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CrudPessoa.Rotas
{
    public static class RotaPessoa
    {
        public static void RotaPessoas(this WebApplication app)
        {
            var rota = app.MapGroup("pessoa");

            rota.MapPost("", async (RequisicaoPessoa req, ContextoPessoa contexto) =>
            {
                var pessoa = new ModeloPessoa(req.nome);
                await contexto.AddAsync(pessoa);
                await contexto.SaveChangesAsync();

            });

            rota.MapGet("", async (ContextoPessoa contexto) =>
            {
                var pessoas = await contexto.Pessoas.ToListAsync();
                return Results.Ok(pessoas);
            });

            rota.MapPut("{id:guid}", async (Guid id,RequisicaoPessoa req, ContextoPessoa contexto) =>
            {

                    var pessoa = await contexto.Pessoas.FindAsync(id);
                    
                    if (pessoa == null)
                    {
                        return Results.NotFound();
                    }
                    
                    pessoa.MudaNome(req.nome);
                    await contexto.SaveChangesAsync();
                    
                    return Results.Ok(pessoa);
            });


        }
    }
}
