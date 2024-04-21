﻿using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concrets
{
    public class CompaignRepository : BaseRepository<Compaign>
    {
        public CompaignRepository(MyContext db) : base(db)
        {

        }
    }
}
