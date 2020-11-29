using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public ManageSystem system;
        public Form1()
        {
            InitializeComponent();
            system = new ManageSystem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            system = new ManageSystem();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            system.readData("E:\\Collage\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase3.txt");
            //testDataReaderFromFile();
            system.startSimulation();
            fillDataGridViews();
            string test = TestingManager.Test(system.system, Constants.FileNames.TestCase3);
            MessageBox.Show(test);
        }
        public void testDataReaderFromFile()
        {
            MessageBox.Show(system.system.NumOfNewspapers.ToString());
            MessageBox.Show(system.system.NumOfRecords.ToString());
            MessageBox.Show(system.system.PurchasePrice.ToString());
            MessageBox.Show(system.system.SellingPrice.ToString());
            MessageBox.Show(system.system.ScrapPrice.ToString());
            foreach (DayTypeDistribution i in system.system.DayTypeDistributions)
            {
                MessageBox.Show(i.DayType + " = " + i.MinRange.ToString() + " " + i.MaxRange.ToString());
            }
            foreach (DemandDistribution i in system.system.DemandDistributions)
            {
                MessageBox.Show(i.Demand.ToString());
                foreach (DayTypeDistribution t in i.DayTypeDistributions)
                {
                    MessageBox.Show(t.DayType + " = " + t.MinRange.ToString() + " " + t.MaxRange.ToString());
                }

            }
        }
        public void fillDataGridViews()
        {
            foreach (SimulationCase i in system.system.SimulationTable)
            {
                dataGridView1.Rows.Add(i.DayNo, i.RandomNewsDayType, i.NewsDayType, i.RandomDemand, i.Demand, i.SalesProfit, i.LostProfit, i.ScrapProfit, i.DailyNetProfit);
            }
            dataGridView2.Rows.Add(system.system.PerformanceMeasures.TotalSalesProfit,
                system.system.PerformanceMeasures.TotalCost,
                system.system.PerformanceMeasures.TotalLostProfit,
                system.system.PerformanceMeasures.TotalScrapProfit,
                system.system.PerformanceMeasures.TotalNetProfit,
                system.system.PerformanceMeasures.DaysWithUnsoldPapers,
                system.system.PerformanceMeasures.DaysWithMoreDemand
                );
        }
        
    }
}
