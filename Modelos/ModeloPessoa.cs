namespace CrudPessoa.Modelos
{
    public class ModeloPessoa
    {
        public ModeloPessoa(string name) 
        {
            Name= name;
            Id = Guid.NewGuid();
        
        }
        
        public Guid Id { get; init; }
        public string Name { get; private set; }
        
    }
}
