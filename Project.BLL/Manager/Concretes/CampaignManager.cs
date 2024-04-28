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
    public class CampaignManager : BaseManager<Campaign> , ICampaignManager
    {
        readonly ICampaignRepository _campaignRepository;
        public CampaignManager(ICampaignRepository campaignRepository) : base(campaignRepository) 
        {
            _campaignRepository = campaignRepository;
        }
    }
}
