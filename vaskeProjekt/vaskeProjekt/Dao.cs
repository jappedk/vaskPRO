using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaskeProjekt
{
    class Dao
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
        public static Bruger CreateBruger(Bruger b)
        {
            DB.Brugers.Add(b);
            try
            {
                DB.SaveChanges();
            }
            catch
            {

            }
            return b;
        }
        public static void CreateVaskeri(Vaskeri v)
        {
            DB.Vaskeris.Add(v);
            DB.SaveChanges();  
        }
        public static List<Vaskeri> getVaskerier()
        {
            List<Vaskeri> list = new List<Vaskeri>();
            foreach (var vaskeri in from v in DB.Vaskeris select v)
            {
                list.Add(vaskeri);
            }
            return list;
        }
        public static List<Bruger> getBrugereUdenVaskeri()
        {
            List<Bruger> list = new List<Bruger>();
            foreach (var Bruger in from b in DB.Brugers select b)
            {
                list.Add(Bruger);
            }
            return list;
        }

    }
}
