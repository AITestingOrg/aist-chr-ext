using System.Collections.Generic;
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
        private readonly AISTRepository _aistRepository;
    
        public AISTController(DataAccessDbContext context)
        {
            _aistRepository = new AISTRepository(context);            
        }

        //http://localhost:63762/API/AIST
        [HttpGet]
        public List<PagesData> Get()
        {
            return (List<PagesData>)_aistRepository.Get();
        }

        //http://localhost:63762/API/AIST?Url=http://www.ultimatesoftware.com&HtmlString=html&PageType=login
        [HttpPut]
        [RequestSizeLimit(valueCountLimit: 2147483647)] // e.g. 2 GB request limit
        public void Put(PagesData page)
        {
            _aistRepository.AddIfDoeNotExist(page);
        }
    }
}
