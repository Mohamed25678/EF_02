using Microsoft.Extensions.Options;

namespace EF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
             using var context = new EventHubDBContext();
        }
    }
}
