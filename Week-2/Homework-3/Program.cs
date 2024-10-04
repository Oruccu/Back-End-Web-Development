int counter = 0;
int counter2 = 0;
string limit = Console.ReadLine();
int InputLimit = Convert.ToInt32(limit);

#region 1.Method
while(true){
    counter++;
    if(counter<=InputLimit){
        Console.WriteLine(" Ben bir Patika'lıyım ");
    }
    else
        break;
}
#endregion
Console.WriteLine("------------------------");
#region 2.Method
do
{
    counter2++;
    if(counter2<=InputLimit){
        Console.WriteLine(" Ben bir Patika'lıyım ");
    }
    else
        break;
} while (true);

#endregion

//Comparison While - Do While
//The while loop may not run at all if the condition is not met. The do-while loop runs at least once.