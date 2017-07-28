using MVP_Example.Model;
using MVP_Example.Presenter;
using MVP_Example.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Example
{
    public partial class Form1 : Form, IUserView
    {


        public Form1()
        {
            InitializeComponent();
        }

        public Form1(IUserPresenter _userPresenter, IUserModel _userModel)
        {
            this.userPresenter = _userPresenter;
            this.userPresenter = new UserPresenter(_userModel, this);
        }

        public string FirstName
        {
            get => txtFirstName.Text;
            set => txtFirstName.Text = value;
        }
        public string LastName
        {
            get => txtLastName.Text;
            set => txtLastName.Text = value;
        }
        public int Age
        {
            get => trkAge.Value;
            set => trkAge.Value = value;
        }
        public string GaurdianName
        {
            get => txtGaurdName.Text;
            set => txtGaurdName.Text = value;
        }
        public bool IsMarried
        {
            get => rdbMarried.Checked;
            set => rdbMarried.Checked = value;
        }
        public int Children
        {
            get => Convert.ToInt32(cmbChildren.SelectedValue);
            set => cmbChildren.SelectedValue = value;
        }
        public IUserPresenter userPresenter
        {
            get;
            set;
        }

        public event EventHandler Save;

        private void label5_Click(object sender, EventArgs e)
        {

        }


        void IUserView.UpdateRegistrationResult(bool result)
        {
            if (result)
            {
                MessageBox.Show("User Registered Successfully.");
            }
            else
            {
                MessageBox.Show("Failed to Register the user.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Save != null)
            {
                this.Save(sender, e);
            }
        }
    }
}
