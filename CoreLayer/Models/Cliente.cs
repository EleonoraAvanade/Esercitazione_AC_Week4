using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CoreLayer.Models
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string CodiceCliente { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cognome { get; set; }
        public ICollection<Ordine> Ordini { get; set; } = new List<Ordine>();
    }
}
