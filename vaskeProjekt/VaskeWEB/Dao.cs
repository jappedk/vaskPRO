using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaskeWEB
{
    public class Dao
    {
        static VaskeProjektEntities1 DB = null;

        private Dao()
        {

        }

        public static VaskeProjektEntities1 getdB()
        {
            if (DB == null)
            {
                DB = new VaskeProjektEntities1();
            }
            return DB;
        }
        public static Bruger FindBruger(String navn)
        {
           return DB.Brugers.Find(navn);
        }
    }
}