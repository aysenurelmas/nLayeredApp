﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DataAccess.EntityConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products").HasKey(b => b.Id);
        builder.Property(b => b.Id ).HasColumnName("ProductId").IsRequired(); 
        builder.Property(b => b.CategoryId).HasColumnName("CategoryId");
        builder.Property(b => b.FileUploadId).HasColumnName("FileUploadId");
        builder.Property(b => b.ProductName).HasColumnName("ProductName").IsRequired(); 
        builder.Property(b => b.UnitPrice).HasColumnName("UnitPrice"); 
        builder.Property(b => b.UnitsInStock).HasColumnName("UnitsInStock");
        builder.Property(b => b.QuantityPerUnit).HasColumnName("QuantityPerUnit");

        builder.HasIndex(indexExpression: b => b.ProductName, name: "UK_Products_ProductName").IsUnique();
        builder.HasOne(b => b.Category);
        builder.HasOne(b => b.FileUpload);
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
