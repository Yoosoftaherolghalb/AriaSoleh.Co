using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.CompanyProject;
using ShopManagement.Domain.CompanyProjectAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CompanyProjectRepository : RepositoryBase<Guid, CompanyProject>, ICompanyProjectRepository
    {
        private readonly Context _context;

        public CompanyProjectRepository(Context context) : base(context)
        {
            _context = context;
        }

        public EditCompanyProject GetDetails(Guid id)
        {
            return _context.CompanyProjects.Select(x => new EditCompanyProject()
            {
                Id = x.Id,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Name = x.Name,
                Slug = x.Slug,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CompanyProjectViewModel> Search(CompanyProjectSearchModel search)
        {
            var query = _context.CompanyProjects.Select(x => new CompanyProjectViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Name = x.Name,
                CreationDate = x.CreationDate.ToString(),
            });

            if (!string.IsNullOrWhiteSpace(search.Name))
                query = query.Where(x => x.Name.Contains(search.Name));

            return query.OrderByDescending(x => x.CreationDate).ToList();
        }
    }
}
