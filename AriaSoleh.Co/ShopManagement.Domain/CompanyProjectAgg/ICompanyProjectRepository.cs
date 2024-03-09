using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.CompanyProjectAgg
{
    public interface ICompanyProjectRepository
    {
        void Create(CompanyProject entity);

        CompanyProject Get(Guid id);

        List<CompanyProject> GetAll();
    }
}
