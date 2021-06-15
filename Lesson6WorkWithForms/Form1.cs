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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> users = new List<string>
            {
                "Murad",
                "Cavid",
                "Tural"
            };
            int x = 100;
            int y = 300;
            foreach (var item in users)
            {
                PlayerDataUC playerDataUC = new PlayerDataUC(item);
                playerDataUC.Location = new Point(x, y);
                y += 70;
                this.Controls.Add(playerDataUC);
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form2 form2 = new Form2();
            //var result=form2.ShowDialog();

            //if (result == DialogResult.Cancel)
            //{
            //    form2.Close();
            //    this.Show();
            //}


            //Form2 form2 = new Form2();
            //form2.MyText = textBox1.Text;
            //form2.ShowDialog();



            //From Child To Parent
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = form2.MyText;
            }

           
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //Send data by constructor 1 version
            //Form2 form2 = new Form2(usernameTxtb.Text,passwordTxtb.Text);
            //form2.ShowDialog();


            //Send data by Method 2 version



            //User user = new User
            //{
            //    Username = usernameTxtb.Text,
            //    Password = passwordTxtb.Text
            //};

            //Form2 form2 = new Form2();
            //form2.ShowDialog(user);



        }


    }
}
