﻿using BLOG.BLL.Services.Abstracts;
using BLOG.Repository.Abstracts;
using BLOG.Repository.UOW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.BLL.Services.Concretes
{
   public class CommentsService:ICommentsService
    {
        private readonly IUnitofWork _uow;
        public CommentsService(IUnitofWork uow)
        {
            _uow = uow;
        }
    }
}
