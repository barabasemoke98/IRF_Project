using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBCJ6C_IRF_beadando.Entities;

namespace TBCJ6C_IRF_beadando
{
    public partial class CovidCasesForm : Form
    {
        List<covidCases> allCovidCases = new List<covidCases>();
        string csvpath;

        public CovidCasesForm()
        {
            InitializeComponent();   
        }

        private void LoadCsv()
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();

                choofdlog.Multiselect = false;
                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    csvpath = choofdlog.FileName.ToString();

                    using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                    {

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
                                continent = (Continent)Enum.Parse(typeof(Continent), line[6])
                            });

                        }
                    }

                    var distcontinents = (from x in allCovidCases
                                          select x.continent).Distinct();
                    foreach (var item in distcontinents)
                    {
                        ContinetnCombo.Items.Add(item);
                    }

                    var distcountries = (from y in allCovidCases 
                                         select y.country).Distinct();

                    foreach (var item in distcountries)
                    {
                        country1.Items.Add(item);
                        country2.Items.Add(item);
                    }
                    ContinetnCombo.Enabled = true;
                    CountryCombo.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    ContinetnCombo.SelectedIndex = 0;

                    CountryCombo.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            //choofdlog.Filter = "CSV files (.csv)|.csv";
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog()==DialogResult.OK)
            {
                csvpath = choofdlog.FileName.ToString();

                using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                {

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
                
                dataGridView1.DataSource = allCovidCases.ToList();
            }
            
        }*/
    }
}
