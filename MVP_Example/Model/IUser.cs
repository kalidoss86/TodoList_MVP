using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Example.Model
{
    public interface IUserModel
    {
        String FirstName { get; set; }

        String LastName { get; set; }

        int Age { get; set; }

        bool IsMarried { get; set; }

        String GaurdianName { get; set; }

        int Children { get; set; }

        bool CreateUser();

    }
}
