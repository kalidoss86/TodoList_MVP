using MVP_Example.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Example.View
{
    public interface IUserView
    {
        IUserPresenter userPresenter { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        string GaurdianName { get; set; }

        bool IsMarried { get; set; }

        int Children { get; set; }

        void UpdateRegistrationResult(bool result);

        event EventHandler Save;
    }
}
