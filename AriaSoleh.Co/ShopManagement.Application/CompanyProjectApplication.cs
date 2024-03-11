using _0_Framework.Application;
using ShopManagement.Application.Contracts.CompanyProject;
using ShopManagement.Domain.CompanyProjectAgg;

namespace ShopManagement.Application;

public class CompanyProjectApplication : ICompanyProjectApplication
{
    private readonly ICompanyProjectRepository _companyProjectRepository;

    public CompanyProjectApplication(ICompanyProjectRepository companyProjectRepository)
    {
        _companyProjectRepository = companyProjectRepository;
    }

    public OperationResult Create(CreateCompanyProject command)
    {
        if (_companyProjectRepository.Exists(command.Name))
            return new OperationResult().Failed("قبلا ثبت شده.");

        var model = new CompanyProject(command.Name, command.Description,
            command.Picture, command.PictureAlt, command.PictureTitle, command.Keywords,
            command.MetaDescription, command.Slug);
    }

    public OperationResult Edit(EditCompanyProject command)
    {
        throw new NotImplementedException();
    }

    public CompanyProject GetDetails(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search)
    {
        throw new NotImplementedException();
    }
}