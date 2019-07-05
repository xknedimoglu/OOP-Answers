using System;

namespace BESCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            BES bes = new BES();

            bes.setİsim("KAAN");
            string isim= bes.getİsim();

            bes.setSoyisim("NEDİMOĞLU");
            string soyisim=bes.getSoyisim();

            bes.setTcKimlikNo("33466363846");
            string tcKimlikNo=bes.getTcKimlikNo();

            bes.setDoğumYeri("DİYARBAKIR");
            bes.getDoğumYeri();

            bes.setBankaİsmi("GARANTİ");
            bes.getBankaİsmi();

            bes.setSistemeGirişYılı(2019);
            int girişYılı=bes.getSistemeGirişYılı();

            bes.setSistemdenÇıkışYılı(2025);
            int çıkışYılı=bes.getSistemdenÇıkışYılı();

            bes.setToplamKazanç(4120);
            double besToplamKazanç = bes.getToplamKazanç();

            bes.setPrimeEsasKazançYüzdesi(3);
            double primeEsasKazançYüzdesi = bes.getPrimeEsasKazançYüzdesi();

            // çıkış yılı ve giriş yılı bilgisi ile sistemde kaldığı süre attribute değeri bulnurbulunur 
            int sistemdeKaldığıSüre = çıkışYılı - girişYılı;

            // hesaplanan sistemde kalma süresi değeri bulunmuş olur.
            bes.setSistemdeKaldığıSüre(sistemdeKaldığıSüre);
            bes.getSistemdeKaldığıSüre();
            
            if (sistemdeKaldığıSüre>3 && sistemdeKaldığıSüre<6)
            {
                // aylık bes ödeme Miktarı ve toplam kazanç da sistemde Kaldığı süreye istinaden hesaplanır.
                double aylıkBesÖdemeMiktarı = besToplamKazanç * primeEsasKazançYüzdesi / 100;
                bes.setAylıkBesÖdemeMiktarı(aylıkBesÖdemeMiktarı);

                double toplamKazanç = (aylıkBesÖdemeMiktarı * sistemdeKaldığıSüre) + (((aylıkBesÖdemeMiktarı * sistemdeKaldığıSüre) * 15) / 100);
                bes.setToplamKazanç(toplamKazanç);
                bes.getToplamKazanç();

                Console.WriteLine("Aylık BES ödeme miktarı " + aylıkBesÖdemeMiktarı + " olan " + isim + soyisim + " ve tc'si " + tcKimlikNo + " 'suna sahip ve  " + " sistemde kaldığı süre " + sistemdeKaldığıSüre + " yıl " + "olup " + "toplam kazancı :" + toplamKazanç + " tl dir");
            }
            else if (sistemdeKaldığıSüre>=6 && sistemdeKaldığıSüre<10)
            {
                // aylık bes ödeme Miktarı ve toplam kazanç da sistemde Kaldığı süreye istinaden hesaplanır.

                double aylıkBesÖdemeMiktarı = (besToplamKazanç * primeEsasKazançYüzdesi) / 100;
                bes.setAylıkBesÖdemeMiktarı(aylıkBesÖdemeMiktarı);

                double toplamKazanç = (aylıkBesÖdemeMiktarı * sistemdeKaldığıSüre) + (((aylıkBesÖdemeMiktarı * sistemdeKaldığıSüre) * 35) / 100);
                bes.setToplamKazanç(toplamKazanç);
                bes.getToplamKazanç();

                Console.WriteLine("Aylık BES ödeme miktarı " + aylıkBesÖdemeMiktarı + " olan " + isim + soyisim + " ve tc'si " + tcKimlikNo + " 'suna sahip ve  " + " sistemde kaldığı süre " + sistemdeKaldığıSüre + " yıl " + "olup " + "toplam kazancı :"+ toplamKazanç + " tl dir");
            }
            else if (sistemdeKaldığıSüre>=10)
            {
                // aylık bes ödeme Miktarı ve toplam kazanç da sistemde Kaldığı süreye istinaden hesaplanır.

                double aylıkBesÖdemeMiktarı = (besToplamKazanç * primeEsasKazançYüzdesi) / 100;
                bes.setAylıkBesÖdemeMiktarı(aylıkBesÖdemeMiktarı);

                double toplamKazanç = (aylıkBesÖdemeMiktarı * sistemdeKaldığıSüre) + (((aylıkBesÖdemeMiktarı * sistemdeKaldığıSüre) * 60) / 100);
                bes.setToplamKazanç(toplamKazanç);
                bes.getToplamKazanç();

                Console.WriteLine("Aylık BES ödeme miktarı " + aylıkBesÖdemeMiktarı + " olan " + isim + soyisim + " ve tc'si " + tcKimlikNo + " 'suna sahip ve  " + " sistemde kaldığı süre " + sistemdeKaldığıSüre + " yıl " + "olup " + "toplam kazancı :" + toplamKazanç + " tl dir");
            }
            else
            {
                Console.WriteLine("BES sisteminde kazancınız bulunmamaktadır.");
            }

            Console.ReadLine();


           




        }
    }
}
