using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Route_EF_01.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01.Context
{
    internal class DeparmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(D => D.DeptId);

            builder
                //.Property(D => D.DeptId)
                .Property(nameof(Department.DeptId))
                .UseIdentityColumn(10, 10);

            builder.Property(D => D.Name)
                .IsRequired(true)
                .HasMaxLength(50)
            .HasColumnType("varchar");

            builder.Property(D => D.DataOfCreation)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
