using hm12_finalizing_disposing;

var play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1600);
play.DisplayInfo();
play.Dispose();

Console.WriteLine();

using (var store = new Store("Supermarket", "Baker Street", "Grocery"))
{
    store.DisplayInfo();
}