string[] petarray = { "Peter", "is", "de", "broer", "van", "Hans" };
foreach (string p in petarray)
{
    Console.Write(p);
    Console.Write(" ");
}


string[] hansarray = { "Peter", "is", "de", "broer", "van", "Hans" };

var Peter = hansarray[0];
var Hans = hansarray[5];

hansarray[0] = Hans;
hansarray[5] = Peter;

Console.WriteLine();
foreach (string h in hansarray)
{
    Console.Write(h);
    Console.Write(" ");
}