using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.DataModel
{
    public class RegisterDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterList
    {
        public List<RegisterDataModel> register;
        public List<RegisterDataModel> RegisterDataModels { get =>register; set=>register = value; }
    }
}
