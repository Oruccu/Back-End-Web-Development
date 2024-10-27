Console.WriteLine("Lütfen oluşturmak istediğiniz ürün kodunu giriniz. Telefon için 1'e basınız. Bilgisayar için 2'ye basınız.");
string productCreate = Console.ReadLine();
int productCreateInput = Convert.ToInt32(productCreate);
while (true)
{
    if (productCreateInput == 1)
    {
        Telephone telephone = new Telephone(new DateTime(2022, 4, 17), 1234, "Apple 15", "Yeni nesil akıllı telefon", "İOS", true);
        telephone.ProductNameGet();
        telephone.PrintInfo();

        Console.WriteLine(" ");
        Console.WriteLine("-------------------");
        Console.WriteLine(" ");

        /*Telephone telephone1 = new Telephone(new DateTime(2022, 4, 17), 1234, "Apple 15", "Yeni nesil akıllı telefon", "İOS", false);
        telephone1.ProductNameGet();
        telephone1.PrintInfo();*/
    }
    else if (productCreateInput == 2)
    {
        Computer computer = new Computer(new DateTime(2023, 11, 04), 1999, "MacBook Pro", "Eşsiz bir deneyime ne dersin", "İOS", 2, false);
        computer.ProductNameGet();
        computer.PrintInfo();

        Console.WriteLine(" ");
        Console.WriteLine("-------------------");
        Console.WriteLine(" ");

        /*Computer computer1 = new Computer(new DateTime(2023, 11, 04), 1999, "MacBook Pro", "Eşsiz bir deneyime ne dersin", "İOS", 5, false);
        computer1.ProductNameGet();
        computer1.PrintInfo();*/
    }
    Console.WriteLine("Ürün başarıyla oluşturuldu. Başka bir cihaz girişi yapmak ister misiniz? Telefon için 1'e, Bilgisayar için 2'ye, çıkmak için 0'a basınız.");
    productCreate = Console.ReadLine();
    productCreateInput = Convert.ToInt32(productCreate);

    if (productCreateInput == 0)
    {
        break;
    }
}
