using CoreLayer.Models;
using CoreLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication
{
    //public class OrdineRepository:IOrdineRepository
    //{
    //    public bool Add(Ordine item)
    //    {
    //        using (var ctx = new GestionaleContext())
    //        {

    //            if (item == null)
    //                return false;

    //            try
    //            {
    //                ctx.Ordini.Add(item);
    //                ctx.SaveChanges();
    //                return true;
    //            }
    //            catch (Exception)
    //            {
    //                return false;
    //            }
    //        }
    //    }

    //    public bool Delete(Ordine item)
    //    {
    //        using (var ctx = new GestionaleContext())
    //        {
    //            if (item == null)
    //                return false;

    //            try
    //            {
    //                var ordine = ctx.Ordini.Find(item.Id);

    //                if (ordine != null)
    //                    ctx.Ordini.Remove(ordine);

    //                ctx.SaveChanges();

    //                return true;
    //            }
    //            catch (Exception)
    //            {
    //                return false;
    //            }
    //        }
    //    }

    //    public Ordine GetById(int id)
    //    {
    //        using (var ctx = new GestionaleContext())
    //        {
    //            if (id <= 0)
    //                return null;

    //            return ctx.Ordini.Find(id);
    //        }
    //    }

    //    public List<Ordine> Read()
    //    {
    //        using (var ctx = new GestionaleContext())
    //        {
    //            try
    //            {
    //                return ctx.Ordini.ToList();
    //            }
    //            catch (Exception)
    //            {
    //                return new List<Ordine>();
    //            }
    //        }
    //    }

    //    public bool Update(Ordine item)
    //    {
    //        using (var ctx = new GestionaleContext())
    //        {
    //            if (item == null)
    //                return false;

    //            try
    //            {
    //                ctx.Ordini.Update(item);
    //                ctx.SaveChanges();
    //                return true;
    //            }
    //            catch (Exception)
    //            {
    //                return false;
    //            }
    //        }
    //    }
    //}
}
