using System.ComponentModel.DataAnnotations.Schema;

namespace Viagens.Model
{
    [Table("Viagens")]
    public class Viagem
    {  
       [Column("id")]
       public int Id { get; set; }

        [Column("nome")]
       public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
       public string CPF { get; set; } = string.Empty;

        [Column("destino")]
       public string Destino { get; set; } = string.Empty;

        [Column("valor")] 
       public decimal Valor { get; set; }

        [Column("data_ida")] 
       public DateTime Data_ida { get; set; }

        [Column("data_volta")] 
       public DateTime Data_volta { get; set; }
    }
}