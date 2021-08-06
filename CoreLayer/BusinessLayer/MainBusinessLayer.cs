using CoreLayer.Models;
using CoreLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLayer.BusinessLayer
{
    public class MainBusinessLayer
    {
        IClienteRepository clienteRepository;
        IOrdineRepository ordineRepository;
        public MainBusinessLayer(IClienteRepository cliente, IOrdineRepository ordine)
        {
            clienteRepository = cliente;
            ordineRepository = ordine;
        }

        public List<Cliente> Read()
        {
            return clienteRepository.Read();
        }
        public Cliente GetById(int id)
        {
            return clienteRepository.GetById(id);
        }
        public bool Add(Cliente item)
        {
            return clienteRepository.Add(item);
        }
        public bool Update(Cliente item)
        {
            return clienteRepository.Update(item);
        }
        public bool Delete(Cliente item)
        {
            return clienteRepository.Delete(item);
        }

        public List<Ordine> ReadOrdine()
        {
            return ordineRepository.Read();
        }
        public Ordine GetByIdOrdine(int id)
        {
            return ordineRepository.GetById(id);
        }
        public bool AddOrdine(Ordine item)
        {
            return ordineRepository.Add(item);
        }
        public bool UpdateOrdine(Ordine item)
        {
            return ordineRepository.Update(item);
        }
        public bool DeleteOrdine(Ordine item)
        {
            return ordineRepository.Delete(item);
        }
    }
}
