using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TBCJ6C_IRF_beadando.Entities
{
    public partial class Login : Form
    {
        List<Users> allusers = new List<Users>();

        public Login()
        {
            InitializeComponent();

            string csvpath = "userData.csv";
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                var line = sr.ReadLine().Split(';');

                allusers.Add(new Users()
                {
                userName = line[0],
                Password = line[1],
                Permission = bool.Parse(line[2])
                }
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public Users userData(string userName, string password)
        {
            var permission = (from x in allusers where x.userName == userName && x.Password == password select x.Permission).FirstOrDefault();

            var user = new Users()
            {
                userName = userTxt.Text,
                Password = pwTxt.Text,
                Permission = true
            };

            return user;
        }
    }
}
