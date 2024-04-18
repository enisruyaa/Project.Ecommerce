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
    public class SubjectManager : BaseManager<Subject> , ISubjectManager
    {
        readonly ISubjectRepository _sRep;

        public SubjectManager(ISubjectRepository sRep) : base(sRep) 
        {
            _sRep = sRep;
        }
    }
}
