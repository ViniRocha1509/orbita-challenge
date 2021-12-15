using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orbita.Challenge.Core.Entities;

namespace Orbita.Challenge.Infra.Mapping
{
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(Student));
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Cpf).IsRequired();
        }
    }
}