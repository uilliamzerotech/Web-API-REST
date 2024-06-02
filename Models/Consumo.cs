using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web_API_REST.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]
        public TipoCombustivel Tipo { get; set; }
        public int VeiculoId { get; set; }
    }

    public enum TipoCombustivel
    {
        Diesel,
        Etanol,
        Gasolina
    }
}
