using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scafold1.Models
{
    [PrimaryKey(nameof(IdPassageiro), nameof(IdPassagem))]
    public class PassageiroPassagem
    {
        public int IdPassageiro { get; set; }

        [ForeignKey(nameof(IdPassageiro))]
        public Passageiro? passageiro { get; set; }

        public int IdPassagem { get; set; }
        [ForeignKey(nameof(IdPassagem))]
        public Passagem? passagem { get; set; }

        public DateTime DataCompra { get; set; } = DateTime.Now;
        public DateTime DataCancelamento { get; set; }

        }
}