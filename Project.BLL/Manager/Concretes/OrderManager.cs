﻿using Project.BLL.Manager.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager.Concretes
{
    public class OrderManager : BaseManager<Order> , IOrderManager
    {
        readonly IOrderRepository _oRep;

        public OrderManager(IOrderRepository oRep) : base(oRep) 
        {
            _oRep = oRep;
        }

        public override string Add(Order item)
        {
            //BL (Kdv , Gümrük , Kargo vs. işlemleri (Ücret İşlemleri))
           return base.Add(item);
        }
    }
}
