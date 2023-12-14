﻿using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Dynamic;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICategoryService
{
   Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest);
   // Task<GetListProductResponse> GetAsync(int id);
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
    Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest);
    Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest);
}
