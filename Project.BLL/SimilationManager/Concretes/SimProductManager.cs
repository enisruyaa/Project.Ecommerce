using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.SimilationManager.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SimilationManager.Concretes
{
    public class SimProductManager : BaseSimulationManager<ProductDTO ,Product> , ISimProductManager
    {
        IProductRepository _proRep;
        IMapper _mapper;

        public SimProductManager(IProductRepository proRep, IMapper mapper) :base(proRep,mapper)
        {
            _proRep = proRep;
            _mapper = mapper;
        }

        public override string Add(ProductDTO item)
        {
            if (item.StartYear == DateTime.Now.Year && item.StartMount == DateTime.Now.Month)
            {
                item.UnitPrice -= 20;
                Product p = _mapper.Map<Product>(item);
                _proRep.Add(p);
                return "Ekleme İndirimli Bir Şekilde Başarılı Oldu";
            }

            _proRep.Add(_mapper.Map<Product>(item));
            return "İndirimsiz Eklendi";
        }
    }
}
