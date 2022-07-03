// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Print out current date and time
Console.WriteLine(DateTime.Now);
//Call a new method to print out current date and time
PrintDateTime();

//Create a new method called PrintDateTime
void PrintDateTime()
{
    Console.WriteLine(DateTime.Now);
}