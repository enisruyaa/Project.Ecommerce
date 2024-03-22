using Project.BLL.Manager.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager.Concretes
{
    public class ProfileManager : BaseManager<AppUserProfile> , IProfileManager
    {
        readonly IProfileRepository _proRep;

        public ProfileManager(IProfileRepository proRep) : base(proRep) 
        {
            _proRep = proRep;
        }
    }
}
