using MVP_TodoList.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_TodoList.Presenter;
using MVP_TodoList.Model;

namespace MVP_TodoList
{
    public partial class Form1 : Form, IView
    {
        private string todoTask = "";

        private bool _TypedInto;

        public Form1()
        {

            InitializeComponent();

            InitializeControls();

            btnAdd.Click += (sender, args) => InvokeAdd(Add);

            this.Load += (sender, args) => InvokeLoadView(FormLoad);

            txtTask.Text = "Enter your task here";

            //txtTask.GotFocus += AddPaceHolderText;
            //txtTask.LostFocus += RemovePlaceHolderText;
            txtTask.KeyDown += TxtTask_KeyDown;

            txtTask.KeyPress += TxtTask_KeyPress;
            txtTask.TextChanged += TxtTask_TextChanged;
            txtTask.Click += TxtTask_Click;
            txtTask.Leave += TxtTask_Leave;
        }

        private void InvokeLoadView(Action formLoad)
        {
            formLoad?.Invoke();
        }

        private void TxtTask_Leave(object sender, EventArgs e)
        {
            if (!_TypedInto)
            {
                txtTask.Text = "Enter you task here";
                txtTask.ForeColor = Color.LightGray;
            }
        }

        private void TxtTask_Click(object sender, EventArgs e)
        {
            if(!_TypedInto) { txtTask.Text = ""; }
        }

        private void TxtTask_TextChanged(object sender, EventArgs e)
        {
            _TypedInto = !String.IsNullOrEmpty(txtTask.Text);
            if(_TypedInto) { txtTask.ForeColor = Color.Black; }
        }



        private void TxtTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            _TypedInto = true;
        }

        private void TxtTask_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnAdd.PerformClick();
                    break;
                case Keys.Escape:
                    txtTask.Text = "";
                    break;
                default:
                    break;
            }
        }



        public void InitializeControls()
        {
            lstTaskList.View = System.Windows.Forms.View.Details;
            var totalWidth = lstTaskList.Width;
            lstTaskList.Columns.Add("Task", totalWidth * 89/100 );
            lstTaskList.Columns.Add("Status", totalWidth * 9 / 100);
        }

        public IPresenter Presenter { get; set; }
        public TodoItem todo { get; set; }

        public event Action Add;
        public event Action FormLoad;

        public void LoadView(List<TodoItem> list)
        {
            txtTask.Text = "";
            lstTaskList.Items.Clear();
            foreach (var item in list)
            {
                var lstItem = new ListViewItem(new[] { item.Title, item.IsCompleted.ToString() });
                lstTaskList.Items.Add(lstItem);
            }
            txtTask.Focus();
        }

        public void ShowError(string errorMessage)
        {
            errorProvider1.SetError(txtTask, errorMessage);
        }

        private void InvokeAdd(Action action)
        {
            todo = new TodoItem();
            todo.Title = txtTask.Text;
            todo.IsCompleted = false;
            action?.Invoke();
        }


    }
}
