using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceLottery
{
    public class Invoice
    {
        private string year, mounth, number;
        public Invoice(string year, string mounth, string number)
        {
            this.year = year;
            this.number = number;
            switch (mounth)
            {
                case "01":
                case "02":
                    this.mounth = "01~02";
                    break;
                case "03":
                case "04":
                    this.mounth = "03~04";
                    break;
                case "05":
                case "06":
                    this.mounth = "05~06";
                    break;
                case "07":
                case "08":
                    this.mounth = "07~08";
                    break;
                case "09":
                case "10":
                    this.mounth = "09~10";
                    break;
                case "11":
                case "12":
                    this.mounth = "11~12";
                    break;
                default:
                    this.mounth = "";
                    break;
            }
        }
        public string Year { get { return year; } }
        public string Mounth { get { return mounth; } }
        public string Number { get { return number; } }
    }
}
