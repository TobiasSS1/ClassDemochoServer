using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemochoClient
{
	public class Client
	{
		public void start()
		{
			Console.WriteLine("Skriv en besked");
			while (true)
			{

			string SendStr = Console.ReadLine();

			using (TcpClient client = new TcpClient("Localhost", 7))
			using (NetworkStream ns = client.GetStream())
			using (StreamReader sr = new StreamReader(ns))
			using (StreamWriter sw = new StreamWriter(ns))
			{
				sw.WriteLine(SendStr);
				sw.Flush();

				String incomingStr = sr.ReadLine();
				Console.WriteLine(incomingStr);
				}
			}
		}
	}
}
