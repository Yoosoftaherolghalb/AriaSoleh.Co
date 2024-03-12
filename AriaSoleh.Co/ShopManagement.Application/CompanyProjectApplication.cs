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
        if (_companyProjectRepository.Exists(x => x.Name == command.Name))
            return new OperationResult().Failed("قبلا ثبت شده.");

        var slug = command.Slug.Slugify();
        var model = new CompanyProject(command.Name, command.Description,
            command.Picture, command.PictureAlt, command.PictureTitle, command.Keywords,
            command.MetaDescription, slug);

        _companyProjectRepository.Create(model);

        _companyProjectRepository.SaveChanges();

        return new OperationResult().Succedded();
    }

    public OperationResult Edit(EditCompanyProject command)
    {
        var model = _companyProjectRepository.Get(command.Id);
        if (model == null)
            return new OperationResult().Failed("رکورد مورد نظر یافت نشد.");

        if (_companyProjectRepository.Exists(x => x.Name == command.Name
                                                  && x.Id != command.Id))
            return new OperationResult().Failed("قبلا ثبت شده.");

        var slug = command.Slug.Slugify();

        model.Edit(command.Name, command.Description, command.Picture, command.PictureAlt, command.PictureTitle,
            command.Keywords, command.MetaDescription, slug);

        _companyProjectRepository.SaveChanges();

        return new OperationResult().Succedded(); 

    }

    public EditCompanyProject GetDetails(Guid id)
    {
        return _companyProjectRepository.GetDetails(id);
    }

    public List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search)
    {
        return _companyProjectRepository.Search(search);
    }
}