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
using System.Reflection;

namespace TBCJ6C_IRF_beadando.Entities
{
    public partial class Login : Form
    {
        List<Users> allusers = new List<Users>();
        public bool isAllowed { get { return userData(userTxt.Text, pwTxt.Text).Permission; } set { isAllowed = value; } }

        public Login()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            string csvpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"userData.csv");
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');

                    allusers.Add(new Users()
                    {
                        userName = line[0],
                        Password = line[1],
                        Permission = perm(line[2])
                    });
                }
            }
        }

        public bool perm(string p)
        {
            if (p == "true")
            {
                return true;
            }
            else { return false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
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
