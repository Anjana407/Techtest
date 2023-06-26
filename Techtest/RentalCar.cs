using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techtest.Helper;


namespace Techtest
{
    internal class RentalCar
    {
        private Dictionary<int, Dictionary<string,int>> monthlyRentalRates = new Dictionary<int, Dictionary<string, int>>();

        public RentalCar()
        {
            monthlyRentalRates[(int)Months.January] = new Dictionary<string, int>
            {
                {"1-3" ,50 },
                {"4-8" ,49 },
                {"9-15" ,48 },
                {"16" ,45 }
            };
            monthlyRentalRates[(int)Months.February] = new Dictionary<string, int>
            {
                {"1-3" ,50 },
                {"4-8" ,49},
                {"9-15" ,48 },
                {"16" ,45 }
            };
            monthlyRentalRates[(int)Months.March] = new Dictionary<string, int>
            {
                {"1-3" ,50 },
                {"4-8" ,49 },
                {"9-15" ,48 },
                {"16" ,45 }
            };
            monthlyRentalRates[(int)Months.April] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50},
                {"16" ,50 }
            };
            monthlyRentalRates[(int)Months.May] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50 },
                {"16" ,50 }
            };
            monthlyRentalRates[(int)Months.June] = new Dictionary<string, int>
            {
                {"1-3" ,54},
                {"4-8" ,54 },
                {"9-15" ,54 },
                {"16" ,54 }
            };
            monthlyRentalRates[(int)Months.July] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50 },
                {"16" ,50 }
            };
            monthlyRentalRates[(int)Months.August] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50 },
                {"16" ,50 }
            };
            monthlyRentalRates[(int)Months.September] = new Dictionary<string, int>
            {
                {"1-3" ,50 },
                {"4-8" ,49 },
                {"9-15" ,48 },
                {"16" ,45 }
            };
            monthlyRentalRates[(int)Months.October] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50 },
                {"16" ,50 }
            };
            monthlyRentalRates[(int)Months.November] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50 },
                {"16" ,50 }
            };
            monthlyRentalRates[(int)Months.December] = new Dictionary<string, int>
            {
                {"1-3" ,52 },
                {"4-8" ,51 },
                {"9-15" ,50 },
                {"16" ,50 }
            };
        }
        public double TotalPrice(DateTime dateTime,int NumberofDays)
        {
            double totalPrice = 0;
            double rate = 0;
            int startDay = 0;
            int endDay = 0;
            int month = dateTime.Month;
            var monthData= monthlyRentalRates[month];
            foreach(var item in monthData)
            {
              if(item.Key.Split("-").Length >1)
              {
                 startDay = Convert.ToInt32(item.Key.Split("-")[0]);
                 endDay = Convert.ToInt32(item.Key.Split("-")[1]);
              }
              else
              {
                  rate=item.Value;
              }
              if(startDay>0 && NumberofDays >=startDay && NumberofDays<=endDay)
              {
                 rate = item.Value;
                 totalPrice = rate * NumberofDays;
                 break;
              }
            }
            return totalPrice;
        }
    }
}
