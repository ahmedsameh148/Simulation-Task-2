using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace NewspaperSellerModels
{
    public class ManageSystem
    {
        public SimulationSystem system;
        public Random random;
        public ManageSystem()
        {
            system = new SimulationSystem();
            random = new Random();
        }
        public void readData(string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Equals("NumOfNewspapers"))
                {
                    i++;
                    system.NumOfNewspapers = int.Parse(lines[i]);
                }
                else if (lines[i].Equals("NumOfRecords"))
                {
                    i++;
                    system.NumOfRecords = int.Parse(lines[i]);
                }
                else if (lines[i].Equals("PurchasePrice"))
                {
                    i++;
                    system.PurchasePrice = decimal.Parse(lines[i]);
                }
                else if (lines[i].Equals("ScrapPrice"))
                {
                    i++;
                    system.ScrapPrice = decimal.Parse(lines[i]);
                }
                else if (lines[i].Equals("SellingPrice"))
                {
                    i++;
                    system.SellingPrice = decimal.Parse(lines[i]);
                }
                else if (lines[i].Equals("DayTypeDistributions"))
                {
                    i++;
                    string[] l = lines[i].Split(',');

                    DayTypeDistribution dayDistribution = new DayTypeDistribution();
                    dayDistribution.DayType = Enums.DayType.Good;
                    dayDistribution.MinRange = 1;
                    dayDistribution.Probability = decimal.Parse(l[0]);
                    //Console.WriteLine((dayDistribution.Probability * (decimal)100.0).ToString());
                    dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0).ToString());
                    system.DayTypeDistributions.Add(dayDistribution);

                    dayDistribution = new DayTypeDistribution();
                    dayDistribution.DayType = Enums.DayType.Fair;
                    dayDistribution.MinRange = system.DayTypeDistributions.Last().MaxRange + 1;
                    dayDistribution.Probability = decimal.Parse(l[1]);
                    dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0 + dayDistribution.MinRange - 1).ToString());
                    system.DayTypeDistributions.Add(dayDistribution);

                    dayDistribution = new DayTypeDistribution();
                    dayDistribution.DayType = Enums.DayType.Poor;
                    dayDistribution.MinRange = system.DayTypeDistributions.Last().MaxRange + 1;
                    dayDistribution.Probability = decimal.Parse(l[2]);
                    dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0 + dayDistribution.MinRange - 1).ToString());
                    system.DayTypeDistributions.Add(dayDistribution);
                }
                else if (lines[i].Equals("DemandDistributions"))
                {
                    i++;
                    DemandDistribution demdistribution = new DemandDistribution();
                    string[] l = lines[i].Split(',');
                    demdistribution.Demand = int.Parse(l[0]);

                    DayTypeDistribution dayDistribution = new DayTypeDistribution();
                    dayDistribution.DayType = Enums.DayType.Good;
                    dayDistribution.MinRange = 1;
                    dayDistribution.Probability = decimal.Parse(l[1]);
                    dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0).ToString());
                    demdistribution.DayTypeDistributions.Add(dayDistribution);

                    dayDistribution = new DayTypeDistribution();
                    dayDistribution.DayType = Enums.DayType.Fair;
                    dayDistribution.MinRange = 1;
                    dayDistribution.Probability = decimal.Parse(l[2]);
                    dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0).ToString());
                    demdistribution.DayTypeDistributions.Add(dayDistribution);

                    dayDistribution = new DayTypeDistribution();
                    dayDistribution.DayType = Enums.DayType.Poor;
                    dayDistribution.MinRange = 1;
                    dayDistribution.Probability = decimal.Parse(l[3]);
                    dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0).ToString());
                    demdistribution.DayTypeDistributions.Add(dayDistribution);

                    system.DemandDistributions.Add(demdistribution);
                    i++;
                    while (i < lines.Length)
                    {
                        demdistribution = new DemandDistribution();
                        l = lines[i].Split(',');
                        demdistribution.Demand = int.Parse(l[0]);

                        dayDistribution = new DayTypeDistribution();
                        dayDistribution.DayType = Enums.DayType.Good;
                        dayDistribution.MinRange = system.DemandDistributions.Last().DayTypeDistributions[0].MaxRange + 1;
                        dayDistribution.Probability = decimal.Parse(l[1]);
                        dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0 + dayDistribution.MinRange - 1).ToString());
                        demdistribution.DayTypeDistributions.Add(dayDistribution);

                        dayDistribution = new DayTypeDistribution();
                        dayDistribution.DayType = Enums.DayType.Fair;
                        dayDistribution.MinRange = system.DemandDistributions.Last().DayTypeDistributions[1].MaxRange + 1;
                        dayDistribution.Probability = decimal.Parse(l[2]);
                        dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0 + dayDistribution.MinRange - 1).ToString());
                        demdistribution.DayTypeDistributions.Add(dayDistribution);

                        dayDistribution = new DayTypeDistribution();
                        dayDistribution.DayType = Enums.DayType.Poor;
                        dayDistribution.MinRange = system.DemandDistributions.Last().DayTypeDistributions[2].MaxRange + 1;
                        dayDistribution.Probability = decimal.Parse(l[3]);
                        dayDistribution.MaxRange = (int)double.Parse((dayDistribution.Probability * (decimal)100.0 + dayDistribution.MinRange - 1).ToString());
                        demdistribution.DayTypeDistributions.Add(dayDistribution);

                        system.DemandDistributions.Add(demdistribution); i++;
                    }
                }

            }
            
        }
        public KeyValuePair<Enums.DayType, int> generateRandomDayType()
        {
            int num = random.Next(1, 101);
            foreach (DayTypeDistribution i in system.DayTypeDistributions)
            {
                if (i.MinRange <= num && i.MaxRange >= num)
                    return new KeyValuePair<Enums.DayType, int>(i.DayType, num);
            }
            return new KeyValuePair<Enums.DayType, int>();
        }
        public KeyValuePair<int, int> generateRandomDemond(int dayType)
        {
            int num = random.Next(1, 101);
            foreach (DemandDistribution i in system.DemandDistributions)
            {
                if (i.DayTypeDistributions[dayType].MinRange <= num && i.DayTypeDistributions[dayType].MaxRange >= num)
                    return new KeyValuePair<int, int>(i.Demand, num);
            }
            return new KeyValuePair<int, int>();
        }
        public void startSimulation()
        {
            for (int i = 1; i <= system.NumOfRecords; i++)
            {
                //{ key, value}
                KeyValuePair<Enums.DayType, int> randomDayType = generateRandomDayType();
                //{dayetype, random }
                KeyValuePair<int, int> randomDemond = generateRandomDemond((int)randomDayType.Key);
                //{ customers, random}
                SimulationCase simcase= new SimulationCase();

                simcase.DayNo = i;
                simcase.RandomNewsDayType = randomDayType.Value;
                simcase.NewsDayType = randomDayType.Key;

                simcase.RandomDemand = randomDemond.Value;
                simcase.Demand = randomDemond.Key;

                simcase.SalesProfit = (decimal)Math.Min(simcase.Demand, system.NumOfNewspapers) * system.SellingPrice;
                simcase.LostProfit = (decimal)Math.Max(0, simcase.Demand - system.NumOfNewspapers) * (system.SellingPrice - system.PurchasePrice);

                simcase.ScrapProfit = (decimal)Math.Max(0, system.NumOfNewspapers - simcase.Demand) * system.ScrapPrice;
                simcase.DailyCost = (decimal)system.PurchasePrice * (decimal)system.NumOfNewspapers;

                simcase.DailyNetProfit = simcase.SalesProfit - simcase.DailyCost - simcase.LostProfit + simcase.ScrapProfit;
                system.SimulationTable.Add(simcase);

                if (simcase.ScrapProfit > 0)
                    system.PerformanceMeasures.DaysWithUnsoldPapers++;
                if (simcase.LostProfit > 0)
                    system.PerformanceMeasures.DaysWithMoreDemand++;

                system.PerformanceMeasures.TotalLostProfit += simcase.LostProfit;

                system.PerformanceMeasures.TotalScrapProfit += simcase.ScrapProfit;
                system.PerformanceMeasures.TotalSalesProfit += simcase.SalesProfit;

                system.PerformanceMeasures.TotalCost += (decimal)system.NumOfNewspapers * system.PurchasePrice;
                system.PerformanceMeasures.TotalNetProfit += simcase.DailyNetProfit;
            }

        }
    }
}
