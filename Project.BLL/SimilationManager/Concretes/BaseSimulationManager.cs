using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.SimilationManager.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SimilationManager.Concretes
{
    public class BaseSimulationManager<T, X> : ISimulationManager<T, X> where T : BaseDTO where X : IEntity
    {
        protected readonly IRepository<X> _repository;
        protected readonly IMapper _mapper;

        public BaseSimulationManager(IRepository<X> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual string Add(T item)
        {
            throw new NotImplementedException();
        }

        public  List<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
