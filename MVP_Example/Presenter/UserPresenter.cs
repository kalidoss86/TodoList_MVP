using MVP_Example.Model;
using MVP_Example.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Example.Presenter
{
    class UserPresenter : IUserPresenter
    {

        public IUserModel userModel = null;
        IUserView userView = null;

        public UserPresenter(IUserModel user, IUserView view )
        {
            this.userModel = user;
            this.userView = view;

            this.userView.userPresenter = this;

            WireUpEvents();
        }

        private void WireUpEvents()
        {
            this.userView.Save += _view_Save;
        }

        private void _view_Save(object sender, EventArgs e)
        {
            var isCreated = this.userModel.CreateUser();

            this.userView.UpdateRegistrationResult(isCreated);
        }


    }
}
