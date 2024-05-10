using System.Security.Cryptography.X509Certificates;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AtmManager atmManager = new AtmManager();
            atmManager.Run();
           
        }
    }
}
