namespace ProjectApiF.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados {get; set;}
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }

    }
}
