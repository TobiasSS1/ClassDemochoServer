using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemochoServer
{
	public class Server
	{
		public Server()
		{

		}

		public void start()
		{
			TcpListener Server = new TcpListener(IPAddress.Loopback, 7);
			Server.Start();

			while (true)
			{
				using (TcpClient Client = Server.AcceptTcpClient())
				using (NetworkStream ns = Client.GetStream())
				using (StreamReader sr = new StreamReader(ns))
				using (StreamWriter sw = new StreamWriter(ns))
				{
					string inlinje = sr.ReadLine();
					int inlinjeCount = inlinje.Split().Length;
					Console.WriteLine("Client: " + inlinje + " Antal ord: " + inlinjeCount);
					//sw.WriteLine(inlinje);
					sw.Flush();
				}
			}
		}
	}
}
