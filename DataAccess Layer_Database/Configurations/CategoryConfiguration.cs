﻿using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.HasKey(c => c.Id);
            //builder.Property(c => c.Name).HasMaxLength(100).IsRequired();

            //builder.HasMany(c => c.Courses)
            //       .WithMany(c => c.categories);
        }
    }

}