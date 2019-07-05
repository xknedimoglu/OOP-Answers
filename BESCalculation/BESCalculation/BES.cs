using System;
using System.Collections.Generic;
using System.Text;

namespace BESCalculation
{
    class BES
    {
        //2 tanesi 3.yü hesaplayacak ve bu hesaplandığı anda, başka 2 attribute ın hesaplanmasına sebep olacak
        private string isim;
        private string soyisim;
        private string tcKimlikNo;
        private string doğumYeri;
        private string bankaİsmi;
        private double toplamKazanç;
        private double primeEsasKazançYüzdesi;
        private double aylıkBesÖdemeMiktarı;
        private int sistemeGirişYılı;
        private int sistemdenÇıkışYılı;
        private double devletDestekMiktarı;
        private int sistemdeKaldığıSüre;

        

        public string getİsim() {
            return isim;
        }
        public void setİsim(string isim) {
            this.isim = isim;
        }
        public string getSoyisim() {
            return soyisim;
        }
        public void setSoyisim(string soyisim) {
            this.soyisim = soyisim;
        }
        public string getTcKimlikNo() {
            return tcKimlikNo;
        }
        public void setTcKimlikNo(string tcKimlikNo) {
            this.tcKimlikNo = tcKimlikNo;
        }
        public string getDoğumYeri(){
            return doğumYeri;
        }
        public void setDoğumYeri(string doğumYeri) {
            this.doğumYeri = doğumYeri;
        }
        public string getBankaİsmi() {
            return bankaİsmi;
        }
        public void setBankaİsmi(string bankaİsmi) {
            this.bankaİsmi = bankaİsmi;
        }
        public double getToplamKazanç() {
            return toplamKazanç;
        }
        public void setToplamKazanç(double toplamKazanç) {
            this.toplamKazanç = toplamKazanç;
        }
        public double getPrimeEsasKazançYüzdesi() {
            return primeEsasKazançYüzdesi;
        }
        public void setPrimeEsasKazançYüzdesi(double primeEsasKazançYüzdesi) {
            this.primeEsasKazançYüzdesi = primeEsasKazançYüzdesi;
        }
        public double getAylıkBesÖdemeMiktarı() {
            return aylıkBesÖdemeMiktarı;
        }
        public void setAylıkBesÖdemeMiktarı(double aylıkBesÖdemeMiktarı) {
            this.aylıkBesÖdemeMiktarı = aylıkBesÖdemeMiktarı;
        }
        public int getSistemeGirişYılı(){
            return sistemeGirişYılı;
        }
        public void setSistemeGirişYılı(int sistemeGirişYılı) {
            this.sistemeGirişYılı = sistemeGirişYılı;
        }
        public int getSistemdenÇıkışYılı()
        {
            return sistemdenÇıkışYılı;
        }
        public void setSistemdenÇıkışYılı(int sistemendenÇıkışYılı)
        {
            this.sistemdenÇıkışYılı = sistemendenÇıkışYılı;
        }
        public double getDevletDestekMiktarı() {
            return devletDestekMiktarı;
        }
        public void setDevletDestekMiktari(double devletDestekMiktarı) {
            this.devletDestekMiktarı = devletDestekMiktarı;
        }

        public int getSistemdeKaldığıSüre() {
            return sistemdeKaldığıSüre;
        }
        public void setSistemdeKaldığıSüre(int sistemdeKaldığıSüre){
            this.sistemdeKaldığıSüre = sistemdeKaldığıSüre;
        }

    }
}
