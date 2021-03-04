using BetlApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetlApp.Services
{
    public interface IObj_DefService
    {
        List<Obj_def> GetObj_Defs();
        Obj_def GetObj_DefById(int id);
        void SaveObj_Def(Obj_def Obj_def);
        void DeleteObj_Def(int id);
    }
}
