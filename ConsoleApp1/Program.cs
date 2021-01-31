using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Cep Telefonları");

        Product Product1 = new Product();
        Product1.Marka = "Apple";
        Product1.Model = "IPhone X";
        Product1.Hafıza = "128 GB";
        Product1.Fiyat = 5499;

        Product Product2 = new Product();
        Product2.Marka = "Samsung";
        Product2.Model = "Note 10";
        Product2.Hafıza = "128 GB";
        Product2.Fiyat = 6500;

        Product Product3 = new Product();
        Product3.Marka = "Huawei";
        Product3.Model = "P Smart";
        Product3.Hafıza = "32 GB";
        Product3.Fiyat = 2399;

        Product Product4 = new Product();
        Product4.Marka = "Xiomi";
        Product4.Model = "T10";
        Product4.Hafıza = "256 GB";
        Product4.Fiyat = 4444;

        Product[] products = new Product[] { Product1, Product2, Product3, Product4 };


        Console.WriteLine("--------If------For------------");

        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].Fiyat<4500)
            {
           
            Console.WriteLine(products[i].Marka);
            Console.WriteLine(products[i].Hafıza);

            }
        }
        Console.WriteLine("--------------ForEach------------");

        foreach (var Product in products)
            {
                Console.WriteLine(Product.Marka + " " + Product.Model);
            }
        Console.WriteLine("--------------While------------");

        int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].Fiyat);
                a++;
            }

        


    }
    class Product
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Hafıza { get; set; }
        public int Fiyat { get; set; }

    }
}
