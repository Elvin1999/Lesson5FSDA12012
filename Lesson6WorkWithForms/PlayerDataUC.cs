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
    public partial class PlayerDataUC : UserControl
    {
        public string Username { get; set; }
        public PlayerDataUC(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            label1.Text = Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Username);
        }
    }
}
