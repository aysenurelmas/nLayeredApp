﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("CustomerID").IsRequired();
        builder.Property(b => b.CompanyName).HasColumnName("CompanyName").IsRequired();
        builder.Property(b => b.ContactName).HasColumnName("ContactName");
        builder.Property(b => b.City).HasColumnName("City");
        builder.Property(b => b.Country).HasColumnName("Country");

        builder.HasIndex(indexExpression: b => b.CompanyName, name: "UK_Customer_CompanyName").IsUnique();

      
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
