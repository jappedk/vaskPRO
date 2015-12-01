using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaskeProjekt
{
    class Service
    {
        private static VaskeProjektEntities1 DB = Dao.getdB();

        public static Bruger CreateBruger(String navn)
        {
            Bruger b = new Bruger();
            b.Navn = navn;
            b.Konto = 0;
            return Dao.CreateBruger(b);
        }
        public static void Tilknyt(Bruger b, Vaskeri v)
        {
                v.Brugers.Add(b);
                DB.SaveChanges();
        }

        public static List<Vaskeri> getVaskerier()
        {
            return Dao.getVaskerier();
        }
        public static List<Bruger> getBrugereUdenVaskeri()
        {
           return Dao.getBrugereUdenVaskeri();
        }
    }
}
