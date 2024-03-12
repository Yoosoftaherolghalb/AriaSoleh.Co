using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.CompanyProjectAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class CompanyProjectMapping : IEntityTypeConfiguration<CompanyProject>
    {
        public void Configure(EntityTypeBuilder<CompanyProject> builder)
        {
            builder.ToTable("CompanyProjects");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Keywords).HasMaxLength(80).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(155).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();


        }
    }
}
