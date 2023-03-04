using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManger : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        public RepositoryManger(RepositoryContext context)
        {
            _context = context; 
        }

        public IBookRepository Book => new BookRepository(_context);

        public void Save()=>_context.SaveChanges();
    }
}
