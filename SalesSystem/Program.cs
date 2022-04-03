// See https://aka.ms/new-console-template for more information


using SalesSystem;

Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2022, 12, 31));
    Console.WriteLine(new Date(2024, 02, 29));
    Console.WriteLine(new Date(2022, 01, 5));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}