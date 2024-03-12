using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.Application.Contracts.CompanyProject;
using ShopManagement.Domain.CompanyProjectAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CompanyProjectRepository : ICompanyProjectRepository
    {
        private readonly Context _context;

        public CompanyProjectRepository(Context context)
        {
            _context = context;
        }

        public void Create(CompanyProject entity)
        {
            _context.CompanyProjects.Add(entity); 
        }

        public CompanyProject? Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CompanyProject> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<CompanyProject, bool>> ex)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public EditCompanyProject GetDetails(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search)
        {
            throw new NotImplementedException();
        }
    }
}
