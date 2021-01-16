using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //nameing convention (isimlendirme kuralları)
        public void Add(Product product)
        {
            Console.WriteLine(product.Name+ " Sepete Eklendi!");
        }
        //Hatalı bir işlem yapalım.
        //Add2 adında yeni bir ekleme metodu oluşruralım.
        public void Add2(string Name, string Explanation, double Price)
        {
            Console.WriteLine(product.Name + " Sepete Eklendi!");
        }
    }
}
