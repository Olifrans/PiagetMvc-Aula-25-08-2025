namespace PiagetMvc.Models
{
    public class Aluno : Base
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public int Idade { get; set; }

        public decimal Notas { get; set; }

    }
}
