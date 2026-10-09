int pin;

do
{
    Console.Write("Please enter a pin (must be between 1000-9999): ");
    pin = int.Parse(Console.ReadLine());

    if (pin < 1000 || pin > 9999)
    {
        Console.WriteLine("Access denied!(pin must be between 1000-9999,try again!)");
    }
    else
    {
        Console.WriteLine("Access granted!");
    }

} while (pin < 1000 || pin > 9999);

