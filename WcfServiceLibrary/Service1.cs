using CoreLayer.BusinessLayer;
using CoreLayer.Models;
using EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class Service1 : IService1
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        static ClienteRepository clienteRepository = new ClienteRepository();
        static OrdineRepository ordineRepository = new OrdineRepository();
        MainBusinessLayer mainBusinessLayer = new MainBusinessLayer(clienteRepository, ordineRepository);
        public bool Add(Cliente item)
        {
            return mainBusinessLayer.Add(item);
        }

        public bool Delete(Cliente item)
        {
            return mainBusinessLayer.Delete(item);
        }

        public Cliente GetById(int id)
        {
            return mainBusinessLayer.GetById(id);
        }

        public List<Cliente> Read()
        {
            return mainBusinessLayer.Read();
        }

        public bool Update(Cliente item)
        {
            return mainBusinessLayer.Update(item);
        }
    }
}
