using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace ControllerLayer
{
    public class ControllerService : IControllerService
    {
        private readonly IBusinessService _businessService;
        public ControllerService(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        public List<string> GetFilteredList()
        {
            return _businessService.GetPersonList().Where(i => !(new List<string> { "Barak Obama", "William Clinton" }).
                        Contains(i.FullName)).Select(j => j.FullName).ToList();
        }
    }
}
