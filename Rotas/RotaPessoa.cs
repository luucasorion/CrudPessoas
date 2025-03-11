using CrudPessoa.Dados;
using CrudPessoa.Modelos;

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
        }
    }
}
