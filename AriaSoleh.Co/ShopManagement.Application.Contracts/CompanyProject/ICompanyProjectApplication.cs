
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.CompanyProject
{
    public interface ICompanyProjectApplication
    {
        OperationResult Create(CreateCompanyProject command);

        OperationResult Edit(EditCompanyProject command);
        
        EditCompanyProject GetDetails(Guid id);

        List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search);
    }
}
