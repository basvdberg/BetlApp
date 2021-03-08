using BetlApp.Data;
using BetlApp.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetlApp.Services
{
    public class ObjDefService : IObjDefService
    {
        private readonly BetlContext _dbContext;
        public ObjDefService(BetlContext context)
        {
            _dbContext = context;
        }

        public void DeleteObjDef(int id)
        {
            var objDef = _dbContext.ObjDefs.FirstOrDefault(x => x.ObjDefId == id);
            if (objDef != null)
            {
                _dbContext.ObjDefs.Remove(objDef);
                _dbContext.SaveChanges();
            }
        }
        public ObjDef GetObjDefById(int id)
        {
            var objDef = _dbContext.ObjDefs.SingleOrDefault(x => x.ObjDefId == id);
            return objDef;
        }

        public List<ObjDef> GetObjDefs()
        {
            return _dbContext.ObjDefs.ToList();
        }
        public void SaveObjDef(ObjDef objDef)
        {
            if (objDef.ObjDefId == 0) _dbContext.ObjDefs.Add(objDef);
            else _dbContext.ObjDefs.Update(objDef);
            _dbContext.SaveChanges();
        }
    }
}
