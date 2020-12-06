using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBCJ6C_IRF_beadando.Entities;
using System.IO;

namespace TBCJ6C_IRF_beadando
{
    public partial class Form1 : Form
    {
        List<covidCases> allCovidCases = new List<covidCases>(); 
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"\covid.csv", Encoding.Default);
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine().Split(';');
                allCovidCases.Add(new covidCases()
                {
                    day = int.Parse(line[0]),
                    month = int.Parse(line[1]),
                    year = int.Parse(line[2]),
                    cases = int.Parse(line[3]),
                    death = int.Parse(line[4]),
                    country = line[5],
                    continent = line[6]
                });
            }
        }
    }
}
