﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Products;

public class CreatedProductResponse
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public  string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public  string QuantityPerUnit { get; set; }
    public Guid FileUploadId { get; set; }
}