using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Web;

using HaxonAPI;
namespace testi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HaxonAPI.HaxonAPI API = new HaxonAPI.HaxonAPI();
            Console.Title = "ElKoax Magic";



            

            Console.WriteLine(API.IsInjected());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "attach")
                {
                    Console.WriteLine("[HXNAPI] Attaching to roblox...");
                    API.InjectDLL();
                    Thread.Sleep(200);
                    Console.WriteLine(API.IsInjected());
                }

                if (input.Length >= 7 && input.Substring(0, 7) == "execute")
                {
                    API.ExecuteLua(input.Substring(8));
                    Console.WriteLine("[HXNAPI] Executed!");
                }
                Console.WriteLine("LOL, nothing was inputted.");
                Thread.Sleep(100);

            }





        }
    }
}
