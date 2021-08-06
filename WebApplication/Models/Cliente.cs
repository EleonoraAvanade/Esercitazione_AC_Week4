using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebApplication.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string CodiceCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public ICollection<Ordine> Ordini { get; set; } = new List<Ordine>();
    }
}
