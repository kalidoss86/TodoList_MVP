using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Example.Model
{
    public class UserModel : IUserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public string GaurdianName { get; set; }
        public int Children { get; set; }

        public bool CreateUser()
        {
            return true;
        }
    }
}
