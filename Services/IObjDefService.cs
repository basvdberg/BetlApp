using BetlApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetlApp.Services
{
    public interface IObjDefService
    {
        List<ObjDef> GetObjDefs();
        ObjDef GetObjDefById(int id);
        void SaveObjDef(ObjDef objDef);
        void DeleteObjDef(int id);
    }
}
