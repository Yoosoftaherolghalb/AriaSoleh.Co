using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.Application.Contracts.CompanyProject;

namespace ShopManagement.Domain.CompanyProjectAgg
{
    public interface ICompanyProjectRepository
    {
        void Create(CompanyProject entity);

        CompanyProject? Get(Guid id);

        List<CompanyProject> GetAll();

        bool Exists(Expression<Func<CompanyProject, bool>> ex);

        void SaveChanges();

        EditCompanyProject GetDetails(Guid id);

        List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search);

    }
}
