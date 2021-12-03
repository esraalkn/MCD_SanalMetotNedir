using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sanal Metot Nedir?
             * Sanal metot dediğimiz BaseClass içerisinde bulunan bir metotun istenirse türeyen sınıf içerisinde nasıl yeniden şekillenebileceğini inceleyeceğiz.             
             * Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı metotların object nesnesinde bize geldiğini söylemiştik.
             * Sanal metot anllatımına object içerisinde bize standart olarak gelen toString metotunu inceleyerek başlayacağız.
             * Sanal metotları,X-men filminde bulunan mistik karakterine benzetebiliriz.
             * Ortama göre kendi şeklini değiştirebilen bir karakter olması buna bir örnek olabilir. 
             * 
             * object => ToString();
             * Musteri M1 = new Musteri();
             * object  => musteri
             *            
             */

            Musteri M1 = new Musteri();
            M1.isim = " Esra";
            M1.soyisim = "Alkan";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);
            Console.ReadKey();
            //Console.WriteLine(M1.ToString() + " " + M1.GetHashCode() + " " + M1.Equals(M1));
        }
    }
}
