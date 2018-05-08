using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessService : IBusinessService
    {
        private readonly Repository _repository;
        public BusinessService(Repository repository)
        {
            _repository = repository;
        }

        public List<Person> GetPersonList()
        {
            return _repository.GetNameList().Select(i => new Person { FullName = i }).ToList();
        }
    }
}
