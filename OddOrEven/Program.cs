Console.WriteLine("Enter a number: ");
int userNum = Convert.ToInt32(Console.ReadLine());  
//paaris or paaritu
int result = userNum % 2;

if (result != 0)
{
    Console.WriteLine("Number is odd");
}
else if (result == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Invalid input");
}
