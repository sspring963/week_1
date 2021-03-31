

using sc = System.Console;

namespace Revature.Week_1.HelloWorld //namespaces scope
{
    //only class, struc, interface, enum in a namespace
    class ProgramOne // class scope
    {
        private static void Main() // method scope
        {
            //stnin to get name
            sc.WriteLine("Enter your name:");
            //var in = Console.ReadLine(); //datatype inference
            var input = sc.ReadLine();
            //object fred = Console.ReadLine();// anonymous datatype
            //stnout to print name

            sc.Write($"Hello {input}!"); // string interpolation, template string
        }

        private void UiPath()
        {
            { // block scope

            }

            {

            }
        }
    }
}
