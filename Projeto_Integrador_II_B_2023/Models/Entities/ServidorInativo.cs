namespace Projeto_Integrador_II_B_2023.Models.Entities
{
    public class ServidorInativo : Servidor
    {
        public ServidorInativo()
        {

        }
        public ServidorInativo(string vinculo, double totalLiquido)
        {
            Vinculo = vinculo;
            TotalLiquido = totalLiquido;
        }

        public string Vinculo { get; set; }
        public double TotalLiquido { get; set; }
    }
}
