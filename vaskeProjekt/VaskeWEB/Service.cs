using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaskeWEB
{
    public class Service
    {
        private static VaskeProjektEntities1 DB = Dao.getdB();

        public static Bruger findBruger(String navn)
        {
            return Dao.FindBruger(navn);
        }
    }
}