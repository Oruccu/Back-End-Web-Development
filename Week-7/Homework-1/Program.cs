List<int> numberList = new List<int>() { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 19, 20, 13, 18, 17, 15 };


Console.WriteLine("------Çift Sayılar---------");
var evenNumber = from number in numberList
                 where number % 2 == 0
                 select number;

foreach (var number in evenNumber)
{
    Console.WriteLine(number);
}
Console.WriteLine("");

Console.WriteLine("------Tek Sayılar---------");
var oddNumber = from number in numberList
                where number % 2 != 0
                select number;
foreach (var number in oddNumber)
{
    Console.WriteLine(number);
}
Console.WriteLine("");
Console.WriteLine("------Negatif Sayılar---------");
var NegativeNumbers = from number in numberList
                      where number < 0
                      select number;

foreach (var number in NegativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("");
Console.WriteLine("------Pozitif Sayılar---------");
var PositiveNumbers = from number in numberList
                      where number > 0
                      select number;

foreach (var number in PositiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("");
Console.WriteLine("------15'ten büyük ve 22'den küçük sayılar---------");

var SelectedNumber = from number in numberList
                     where number > 15 && number < 22
                     orderby number
                     select number;

foreach (var number in SelectedNumber)
{
    Console.WriteLine(number);
}

Console.WriteLine("");
Console.WriteLine("------Sayıların karesi---------");

var SquareNumbers = from number in numberList
                    select number * number into square
                    orderby square
                    select square;

            
foreach(var number in SquareNumbers){
    Console.WriteLine(number);
}