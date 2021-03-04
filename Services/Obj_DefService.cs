using BetlApp.Data;
using BetlApp.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetlApp.Services
{
    public class Obj_DefService : IObj_DefService
    {
        private readonly ApplicationDbContext _dbContext;
        public Obj_DefService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public void DeleteObj_Def(int id)
        {
            var obj_def = _dbContext.obj_defs.FirstOrDefault(x => x.Id == id);
            if (obj_def != null)
            {
                _dbContext.obj_defs.Remove(obj_def);
                _dbContext.SaveChanges();
            }
        }
        public Obj_def GetObj_DefById(int id)
        {
            var obj_def = _dbContext.obj_defs.SingleOrDefault(x => x.Id == id);
            return obj_def;
        }

        public List<Obj_def> GetObj_Defs()
        {
            return _dbContext.obj_defs.ToList();
        }
        public void SaveObj_Def(Obj_def obj_def)
        {
            if (obj_def.Id == 0) _dbContext.obj_defs.Add(obj_def);
            else _dbContext.obj_defs.Update(obj_def);
            _dbContext.SaveChanges();
        }
    }
}
