using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            demo newDemo = new demo(10, "A");
            Console.WriteLine(newDemo.Name);
            Console.ReadLine();
            //Opgave tilføj en Console.writeline med noget tekst og commit + push
            //se herefter på dit GitHub Classroom repo om ændringen er kommet op 
        }
    }
}
