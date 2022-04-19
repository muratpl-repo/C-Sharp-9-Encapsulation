using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49DersEncapsulation //Kapsülleme nesne yönelimli programlamada herhangi bir nesnenin 
//metotlarını, verilerini ve değiskenlerini diğer nesnelerden saklayarak ve bunlara erişimini sınırlandırarak 
//yanlış kullanımlardan koruyan bir konsepttir.
{
    class Program
    {


        class Futbolcu
        {
            int bonservisBedeli; //private olarak belirtmesek bile default hali zaten private'tir.
            public int getbonservisBedeli()
            {
                return bonservisBedeli;
            }
            public void setbonservisBedeli(int fiyat)
            {
                this.bonservisBedeli = fiyat;

            }
        }
        static void Main(string[] args)
        {
            Futbolcu f1 = new Futbolcu();
            f1.setbonservisBedeli(1500000);
            Console.WriteLine(f1.getbonservisBedeli());
            Console.ReadLine();
        }
    }
}
