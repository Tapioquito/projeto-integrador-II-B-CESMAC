namespace Projeto_Integrador_II_B_2023.Models.Entities
{
    public class Servidor : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }

        public Servidor()
        {

        }

        public Servidor(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
        }
        public string ExibirNomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
