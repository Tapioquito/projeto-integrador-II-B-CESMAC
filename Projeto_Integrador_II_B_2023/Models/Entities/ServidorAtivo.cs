namespace Projeto_Integrador_II_B_2023.Models.Entities
{
    public class ServidorAtivo : Servidor
    {
        public DateTime Periodo { get; set; }
        public double Remuneracao { get; set; }
        public double Comissao { get; set; }
        public double Beneficios { get; set; }
        public double Eventuais { get; set; }
        public double HorasExtras { get; set; }
        public double Judiciais { get; set; }
        public double TetoRedutor { get; set; }
        public double IRRF { get; set; }
        public double ContribuicaoPrevidenciaria { get; set; }
        public double TotalLiquido { get; set; }
    }
}
