using CrudPessoa.Modelos;

namespace CrudPessoa.Rotas
{
    public static class RotaPessoa
    {
        public static void RotaPessoas(this WebApplication app)
        {
            app.MapGet("Pessoa", () => new ModeloPessoa(name:"lucas"));


        }




    }
}
