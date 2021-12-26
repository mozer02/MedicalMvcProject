using DataAccessLayer.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public  class CurrentManager
    {
        Repository<Currents> rcurrent = new Repository<Currents>();
        Repository<EmployeeDetail> remployee = new Repository<EmployeeDetail>();

        public List<Currents> GetHospital()
        {
            return rcurrent.List(x=>x.CurrentGroups.Id==1);
        }
        public List<Currents> GetDoctor()
        {
            return rcurrent.List(x=>x.CurrentGroups.Id==2 && x.isActive == true);
        }
        public List<Currents> GetCompany()
        {
            return rcurrent.List(x=>x.CurrentGroups.Id==3 && x.isActive == true);
        }
        public List<EmployeeDetail> GetPersonel()
        {
            return remployee.List(x=>x.Currents.isActive==true && x.Currents.CurrentGroups.Id==4);
        }
        public List<Currents> GetTest()
        {
            return rcurrent.List();
        }
        
    }
}
