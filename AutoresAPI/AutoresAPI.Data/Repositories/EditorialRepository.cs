using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Data.Repositories
{
    public class EditorialRepository : Repository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(DataContext context)
            : base(context)
        { }
    }
}
