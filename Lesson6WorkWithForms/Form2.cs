using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6WorkWithForms
{
    public partial class Form2 : Form
    {
        public string MyText { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string username, string password)
        {
            InitializeComponent();

            usernameLbl.Text = $"your username is {username} and password is {password}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = MyText;
        }

        public DialogResult ShowDialog(User user)
        {
            usernameLbl.Text = $"USERNAME : {user.Username}  PASSWORD : {user.Password}";
            return ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MyText = textBox1.Text;
        }

    }
}
