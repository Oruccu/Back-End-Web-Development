int NumberControl; // Variable to hold the number entered by the user

while (true) //Loop
{
    Console.WriteLine("Bir sayi giriniz: ");
    string number = Console.ReadLine();

    // Check if the input is a valid integer
    if (int.TryParse(number, out NumberControl))
    {
        // If the number is greater than 10, print a message
        if (NumberControl > 10)
        {
            Console.WriteLine("Girilen sayi 10'dan büyüktür.");
        }
        // If the number is even, print a message
        if (NumberControl % 2 == 0)
        {
            Console.WriteLine("Girilen sayi çifttir.");

        }
        break; //Loop break 
    }

    else
    {
         // Print an error message for invalid input
        Console.WriteLine("Lütfen bir sayi giriniz: ");
    }
}

