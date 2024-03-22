using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Query.Contracts.CompanyProject;
using ShopManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class CompanyProjectQuery : ICompanyProjectQuery
    {
        private readonly Context _context;

        public CompanyProjectQuery(Context context)
        {
            _context = context;
        }

        public List<CompanyProjectQueryModel> GetProjects()
        {
            return _context.CompanyProjects.Select(x => new CompanyProjectQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Slug = x.Slug
            }).ToList();
        }
    }
}
