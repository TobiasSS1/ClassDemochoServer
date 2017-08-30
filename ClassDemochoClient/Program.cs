using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemochoClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Client MinClient = new Client();
			MinClient.start();

			Console.ReadLine();
		}
	}
}
