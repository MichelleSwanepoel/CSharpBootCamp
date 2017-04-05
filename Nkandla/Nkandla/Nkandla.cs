using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Nkandla:HomeStead
    {
        public Nkandla(string _name, string _district, string _province, string _country)
            : base(_name, _district, _province, _country)
        {
            pool = new SwimmingPool();
            chickenRun = new ChickenRun();
            amphi = new Amphitheatre();
        }

        private SwimmingPool pool;
        private ChickenRun chickenRun;
        private Amphitheatre amphi;
    }
}
