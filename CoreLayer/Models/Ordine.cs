using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CoreLayer.Models
{
    [DataContract]
    public class Ordine
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CodiceOrdine { get; set; }
        [DataMember]
        public DateTime DataOrdine { get; set; }
        [DataMember]
        public string CodiceProdotto { get; set; }
        [DataMember]
        public decimal Importo { get; set; }
        //public int IdCliente { get; set; }
        public Cliente cliente { get; set; }

    }
}
