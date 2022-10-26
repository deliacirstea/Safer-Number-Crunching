
/*I cannot take credit for this one because my teacher has fixed it in class
 * as an example for - Methods
 * but here comes the solution*/



Console.Title = "Safer number crunching";

int number;
do
{
    Console.WriteLine("Write a number: ");
}
while (!int.TryParse(Console.ReadLine(), out number));
Console.WriteLine(number);

//double
double number1;
do
{
    Console.Write("Write a number: \n");
} while (!double.TryParse(Console.ReadLine(), out number1));
Console.WriteLine(number1);


//bool
bool truth;
do
{
   Console.Write("Enter true / false: \n");
} while (!bool.TryParse(Console.ReadLine(), out truth));
Console.WriteLine(truth);

Console.Beep();
Console.ReadLine();
