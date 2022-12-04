using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User1");
            builder.HasKey(p => p.id);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(128);  
            builder.Property( p => p.Email).HasMaxLength(128);

        }
    }
}
