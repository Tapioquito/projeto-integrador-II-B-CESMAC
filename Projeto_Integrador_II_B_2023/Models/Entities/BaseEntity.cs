namespace Projeto_Integrador_II_B_2023.Models.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }

    }
}
