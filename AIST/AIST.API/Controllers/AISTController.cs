﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AIST.DataAccess.AISTDatabaseContext;
using AIST.DataAccess.Repository;
using AIST.DataAccess.AISTModel;

namespace AIST.API.Controllers
{
    [Route("api/[controller]")]
    public class AISTController : Controller
    {
        private DbContextOptionsBuilder<DataAccessDbContext> optionsBuilder;
        private readonly AISTRepository _aistRepository;
        private string connectionString = "Server=??;Database=AISTDB;User Id=??; Password=??;Trusted_Connection=True;MultipleActiveResultSets=true";

        public AISTController()
        {
            optionsBuilder = new DbContextOptionsBuilder<DataAccessDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _aistRepository = new AISTRepository(new DataAccessDbContext(optionsBuilder.Options));
        }
        
        //http://localhost:62057/api/aist/getrecords
        [HttpGet]
        public List<PagesData> Get()
        {
            return (List<PagesData>)_aistRepository.Get();
        }

        //http://localhost:62057/api/aist/addrecord
        //{"Id":10, "Url":"TEST", "HtmlString":"HTML", "PageType": "TEST1"}
        [HttpPut]
        public void Put(PagesData page)
        {
            _aistRepository.Add(page);
        }
    }
}
