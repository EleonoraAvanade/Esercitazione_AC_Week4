using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebApplication.Models
{
    [DataContract]
    public class Ordine
    {
        public int Id { get; set; }
        public string CodiceOrdine { get; set; }
        public DateTime DataOrdine { get; set; }
        public string CodiceProdotto { get; set; }
        public decimal Importo { get; set; }
        //public int IdCliente { get; set; }
        public Cliente cliente { get; set; }

    }
}
