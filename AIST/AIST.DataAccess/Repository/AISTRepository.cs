using System.Collections.Generic;
using System.Linq;
using AIST.DataAccess.AISTDatabaseContext;
using AIST.DataAccess.AISTModel;
using AIST.DataAccess.Implementation;

namespace AIST.DataAccess.Repository
{
    public class AISTRepository : IRepository<PagesData>
    {
        private readonly DataAccessDbContext _context;

        public AISTRepository(DataAccessDbContext context)
        {
            this._context = context;
        }

        public void Add(PagesData entity)
        {
            _context.PagesData.Add(entity);
            _context.SaveChanges();
        }

        public void AddIfDoeNotExist(PagesData entity)
        {
            var exist = _context.PagesData.Where(a => a.HtmlString == entity.HtmlString).FirstOrDefault();
            if(exist == null)
            {
                _context.PagesData.Add(entity);
                _context.SaveChanges();
            }            
        }

        public void AddRange(IEnumerable<PagesData> entity)
        {
            _context.PagesData.AddRange(entity);
            _context.SaveChanges();
        }

        public PagesData FindById(int id)
        {
            return _context.PagesData.Find(id);
        }

        public void Update(PagesData entity)
        {
            _context.SaveChanges();
        }

        public void Delete(PagesData entity)
        {
            _context.PagesData.Remove(entity);
            _context.SaveChanges();
        }

        public void DeleteRange(IEnumerable<PagesData> entity)
        {
            _context.PagesData.RemoveRange(entity);
            _context.SaveChanges();
        }

        public IEnumerable<PagesData> Get()
        {
            return _context.PagesData.AsEnumerable().ToList();
        }
    }
}
