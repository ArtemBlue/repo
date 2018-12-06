using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation; 

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Computer Name: ");
			string name = Console.ReadLine();
			
			Console.WriteLine("The Computer is " + name);
			Console.WriteLine(PingName(name));
			
		}

		public static bool PingName(string nameOrAddress)
		{
		    bool pingable = false;
		    Ping pinger = null;

		    try
		    {
		        pinger = new Ping();
		        PingReply reply = pinger.Send(nameOrAddress);
		        pingable = reply.Status == IPStatus.Success;
		    }
		    catch (PingException)
		    {
		        // Discard PingExceptions and return false;
		    }
		    finally
		    {
		        if (pinger != null)
		        {
		            pinger.Dispose();
		        }
		    }
		
		    return pingable;
		}
	}
}



   