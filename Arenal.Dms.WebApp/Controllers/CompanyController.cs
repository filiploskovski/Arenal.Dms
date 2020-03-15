using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arenal.Dms.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Arenal.Dms.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly DataContext _db;

        public CompanyController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<int> Losko(int id)
        {
             await _db.DocumentType.AddAsync(new DocumentType()
            {
                DocumentTypeName = $"asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasda" +
                                   $"sdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasd" +
                                   $"asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasda" +
                                   $"sdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdas" +
                                   $"dasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdas" +
                                   $"dasdasdasdasdasdasdasdasdasdasd"
            });
             await _db.SaveChangesAsync();
            return 1;
        }
    }
}