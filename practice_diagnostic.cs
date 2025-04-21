
using System;
using System.Net;
using System.Net.Sockets;
using Wireshark;

namespace NetworkTrafficAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the capture device
            using (Capturer capturer = new Capturer(@"C:\Program Files\Wireshark\tshark.exe"))
            {
                // Start capturing packets
                capturer.StartCapture();

                Console.WriteLine("Capturing network traffic. Press any key to stop...");

                // Wait for user input to stop capturing
                Console.ReadKey();

                // Stop capturing packets
                capturer.StopCapture();

                // Analyze captured packets
                foreach (var packet in capturer.GetPackets())
                {
                    // Display packet information
                    Console.WriteLine(packet.Timestamp + " " + packet.SrcAddr + " -> " + packet.DstAddr + " " + packet.Protocol);
                }
            }
        }
    }
}
