using System.Collections.Generic;

namespace RepositoryLayer
{
    public class Repository : IRepository
    {
        public List<string> GetNameList()
        {
            return new List<string> { "Abhram Lincon", "William Clinton", "Barak Obama", "Teddy Rosevelt" };
        }
    }
}
