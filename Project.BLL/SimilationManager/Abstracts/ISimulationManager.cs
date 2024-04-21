using Project.BLL.DTOClasses;
using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SimilationManager.Abstracts
{
    public interface ISimulationManager<T,X> where T : BaseDTO where X : IEntity
    {
        List<T> GetAll();

        string Add(T item);
    }
}
