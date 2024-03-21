using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.CompanyProject
{
    public class CreateCompanyProject
    {
        [Required(ErrorMessage = "این مقدار نمیتواند خالی باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این مقدار نمیتواند خالی باشد")]
        public string Description { get; set; }

        [Required(ErrorMessage = "این مقدار نمیتواند خالی باشد")]
        public string Picture { get; set; }

        public string PictureAlt { get; set; }

        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "این مقدار نمیتواند خالی باشد")]
        public string Keywords { get; set; }

        [Required(ErrorMessage = "این مقدار نمیتواند خالی باشد")]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = "این مقدار نمیتواند خالی باشد")]
        public string Slug { get; set; }

    }


}
