using System.Diagnostics;
using static System.Console;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
          var j = new Journal();
          j.AddEntry("I cried today.");
          j.AddEntry("I ate a bug.");
          WriteLine(j);

          var p = new Persistence();
          var filename = @"journal.txt";
          p.SaveToFile(j, filename);
          Process.Start(filename);
        }
    }
}
