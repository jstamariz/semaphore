// * For a detailed explanation please read the README.MD

using semaphore;

BEGINNING: Console.WriteLine("How many people are in the coffee line? ☕");
int MAXIMUM_AMOUNT = 5;
string? amountOfPeople = Console.ReadLine();
var semaphore = new Semaphore(initialCount: MAXIMUM_AMOUNT, maximumCount: MAXIMUM_AMOUNT);

if (int.TryParse(amountOfPeople, out int parsedAmountOfPeople))
{
    for (int clientNumber = 1; clientNumber <= parsedAmountOfPeople; clientNumber++)
    {
        var task = new Thread(new ParameterizedThreadStart(Buy));
        task.Start($"Client #{clientNumber}");
    }
}
else goto BEGINNING;


void Buy(object? clientName)
{
    semaphore.WaitOne();
    var randomNumber = new Random().Next(Cafe.Products.Length);
    var timeBuying = randomNumber * 1_000;
    Thread.Sleep(timeBuying);
    Console.WriteLine($"The client {clientName} brought {Cafe.Products[randomNumber]}");
    semaphore.Release();
}
