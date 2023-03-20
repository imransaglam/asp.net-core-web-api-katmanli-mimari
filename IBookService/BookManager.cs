using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManager : IBookService
    {
        public readonly IRepositoryManager _manager;
        public BookManager(IRepositoryManager manager)
        {
            _manager = manager; 
        }  
    }
}
