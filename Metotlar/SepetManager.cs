using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Product product)
        {

            Console.WriteLine("Sepete eklenen =  " + product.Adi + product.Fiyat);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat , int stok)//kullanılması sakıncalı ** üstteki ekle daha iyi
        {
            Console.WriteLine("Sepete eklenen =  " + urunAdi +" "+ aciklama +" "+ fiyat);



        }

    }
}
