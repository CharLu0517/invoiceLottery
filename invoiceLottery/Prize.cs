using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceLottery
{
    public class Prize
    {
        private string invoYm;
        private string superPrizeNo;
        private string[] spcPrizeNo;
        private string[] firstPrizeNo;
        private string[] sixthPrizeNo;
        private string[] prizeName;
        private int[] prizeAmt;

        public Prize(string invoYm, string superPrizeNo, string[] spcPrizeNo, string[] firstPrizeNo, string[] sixthPrizeNo, int[] prizeAmt)
        {
            this.invoYm = invoYm;
            this.superPrizeNo = superPrizeNo;
            this.spcPrizeNo = spcPrizeNo;
            this.firstPrizeNo = firstPrizeNo;
            this.sixthPrizeNo = sixthPrizeNo;
            this.prizeAmt = prizeAmt;
            prizeName = new string[] { "特別", "特獎", "頭獎", "二獎", "三獎", "四獎", "五獎", "六獎" };
        }
        public string InvoYm { get { return invoYm; } }
        public string SuperPrizeNo { get { return superPrizeNo; } }

        public string[] SpcPrizeNo { get { return spcPrizeNo; } }
        public string[] FirstPrizeNo { get { return firstPrizeNo; } }

        public string[] SixthPrizeNo { get { return sixthPrizeNo; } }

        public int[] PrizeAmt { get { return prizeAmt; } }

        public Invoice prizeCheck(Invoice invoice)
        {
            //確認有無中獎
            string num = invoice.Number;
            //特別
            if (num == superPrizeNo)
            {
                invoice.Prize = prizeName[0];
                invoice.PrizeAmt = prizeAmt[0];
                return invoice;
            }
            //特獎
            foreach (string s in spcPrizeNo)
            {
                if (num == s)
                {
                    invoice.Prize = prizeName[1];
                    invoice.PrizeAmt = prizeAmt[1];
                    return invoice;
                }
            }
            //二獎~六獎
            foreach (string s in firstPrizeNo)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (num.Substring(i, 8 - i) == s.Substring(i, 8 - i))
                    {
                        invoice.Prize = prizeName[i+2];
                        invoice.PrizeAmt = prizeAmt[i+2];
                         return invoice;
                    }
                }
            }
            //加開六獎
            foreach (string s in sixthPrizeNo)
            {
                if(num.Substring(5,3) == s)
                {
                    invoice.Prize = prizeName[7];
                    invoice.PrizeAmt = prizeAmt[7];
                    return invoice;
                }
            }
            return invoice;
        }

    }

}
