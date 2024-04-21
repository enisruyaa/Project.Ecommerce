using Project.BLL.DTOClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SimilationManager.Abstracts
{
    public interface ISimProductManager : ISimulationManager<ProductDTO,Product>
    {
    }
}
