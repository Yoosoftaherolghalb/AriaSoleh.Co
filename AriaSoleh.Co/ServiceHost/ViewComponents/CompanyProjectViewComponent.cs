using _01_Query.Contracts.CompanyProject;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class CompanyProjectViewComponent : ViewComponent
    {
        private readonly ICompanyProjectQuery _projectQuery;

        public CompanyProjectViewComponent(ICompanyProjectQuery projectQuery)
        {
            _projectQuery = projectQuery;
        }

        public IViewComponentResult Invoke()
        {
            var projects = _projectQuery.GetProjects();
            return View(projects);
        }
    }
}
