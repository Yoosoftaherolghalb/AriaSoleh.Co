using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.CompanyProject;

namespace ServiceHost.Areas.Administration.Pages.Shop.CompanyProjects
{
    public class IndexModel : PageModel
    {
        public CompanyProjectSearchModel SearchModel;
        public List<CompanyProjectViewModel> CompanyProjects;
        private readonly ICompanyProjectApplication _companyProject;

        public IndexModel(ICompanyProjectApplication companyProject)
        {
            _companyProject = companyProject;
        }

        public void OnGet(CompanyProjectSearchModel searchModel)
        {
            CompanyProjects = _companyProject.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateCompanyProject());
        }
        public JsonResult OnPostCreate(CreateCompanyProject command)
        {
            var result = _companyProject.Create(command);
            return new JsonResult(result);
        }
    }
}
