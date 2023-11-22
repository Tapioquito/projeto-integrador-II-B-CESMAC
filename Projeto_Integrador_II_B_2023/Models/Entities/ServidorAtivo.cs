namespace Projeto_Integrador_II_B_2023.Models.Entities
{
    public class ServidorAtivo : Servidor
    {
        public ServidorAtivo()
        {

        }
        public ServidorAtivo(DateTime periodo, double remuneracao, double comissao,
            double beneficios, double eventuais, double horasExtras, double judiciais,
            double tetoRedutor, double irrf, double contribuicaoPrevidenciaria,
            double totalLiquido)
        {
            Periodo = periodo;
            Remuneracao = remuneracao;
            Comissao = comissao;
            Beneficios = beneficios;
            Eventuais = eventuais;
            HorasExtras = horasExtras;
            Judiciais = judiciais;
            TetoRedutor = tetoRedutor;
            IRRF = irrf;
            ContribuicaoPrevidenciaria = contribuicaoPrevidenciaria;
            TotalLiquido = totalLiquido;
        }
        public double CalcularTotalLiquido(double remuneracao, double comissao,
            double beneficios, double eventuais, double horasExtras, double judiciais,
            double tetoRedutor, double irrf, double contribuicaoPrevidenciaria)
        {
            double total = remuneracao + comissao + beneficios + eventuais + horasExtras + judiciais
                - irrf - contribuicaoPrevidenciaria;
            if (total > tetoRedutor) total = tetoRedutor;
            return total;
        }

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
