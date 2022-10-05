
Console.WriteLine("Enter number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if (result != 0)
{
    Console.WriteLine("You number is odd.");
} else
{
    Console.WriteLine("You number is even.");
}