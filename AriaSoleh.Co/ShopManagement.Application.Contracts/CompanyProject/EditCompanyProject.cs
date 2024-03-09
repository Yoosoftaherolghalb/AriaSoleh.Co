using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.CompanyProject
{
    public class EditCompanyProject : CreateCompanyProject
    {
        public Guid Id { get; set; }
    }
}
