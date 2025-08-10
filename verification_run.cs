
using System;
using System.Net;
using System.Net.Sockets;
using PacketDotNet;
using SharpPcap;
using Packets;

namespace NetworkTrafficAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieve the list of network devices
            CaptureDeviceList devices = CaptureDeviceList.Instance;

            // If no devices were found, print an error message
            if (devices.Count < 1)
            {
                Console.WriteLine("No network devices found.");
                return;
            }

            // Print out the available network devices
            Console.WriteLine("Available network devices:");
            for (int i = 0; i < devices.Count; i++)
            {
                Console.WriteLine($"{i}: {devices[i].Description}");
            }

            // Prompt the user to select a network device
            Console.Write("Enter the index of the device you want to use: ");
            int deviceIndex = int.Parse(Console.ReadLine());

            // Open the selected network device for capturing
            ICaptureDevice device = devices[deviceIndex];
            device.OnPacketArrival += new PacketArrivalEventHandler(HandlePacketArrival);
            device.Open(DeviceMode.Promiscuous);

            // Start capturing packets
            device.StartCapture();

            Console.WriteLine("Press any key to stop capturing...");
            Console.ReadKey();

            // Stop capturing packets
            device.StopCapture();
            device.Close();
        }

        static void HandlePacketArrival(object sender, CaptureEventArgs e)
        {
            try
            {
                // Parse the packet using PacketDotNet
                Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

                // Check if the packet is an IP packet
                if (packet is IpPacket)
                {
                    // Get the IP packet
                    IpPacket ipPacket = (IpPacket)packet;

                    // Display the source and destination IP addresses
                    Console.WriteLine($"Source IP: {ipPacket.SourceAddress}");
                    Console.WriteLine($"Destination IP: {ipPacket.DestinationAddress}");

                    // Display the protocol
                    Console.WriteLine($"Protocol: {ipPacket.Protocol}");

                    // Display the packet payload
                    Console.WriteLine($"Payload: {BitConverter.ToString(ipPacket.PayloadData)}");

                    // Add additional analysis code here
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
