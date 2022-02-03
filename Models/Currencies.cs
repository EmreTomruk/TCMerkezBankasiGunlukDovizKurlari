using System.Collections.Generic;

namespace TCMBCurrencies.Models
{
    public class Currencies
    {
        public Developer Developer { get; set; }
        public List<TCMBAnlikKurBilgileri> TCMB_AnlikKurBilgileri { get; set; }
    }
    public class Developer
    {
        public string name { get; set; }
        public string website { get; set; }
        public string email { get; set; }
    }

    public class TCMBAnlikKurBilgileri
    {
        public string Isim { get; set; }
        public string CurrencyName { get; set; }
        public double ForexBuying { get; set; }
        public object ForexSelling { get; set; }
        public object BanknoteBuying { get; set; }
        public object BanknoteSelling { get; set; }
        public object CrossRateUSD { get; set; }
        public object CrossRateOther { get; set; }
    }
}

