using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.CompanyProject;

namespace ShopManagement.Domain.CompanyProjectAgg
{
    public interface ICompanyProjectRepository : IRepository<Guid, CompanyProject>
    {
        EditCompanyProject GetDetails(Guid id);

        List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search);

    }
}
