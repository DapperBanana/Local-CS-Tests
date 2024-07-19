
using System;
using SharpPcap;
using PacketDotNet;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        var devices = CaptureDeviceList.Instance;

        // Print out the available devices
        Console.WriteLine("Available devices:");
        for (int i = 0; i < devices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {devices[i].Description}");
        }

        // Choose a device to capture traffic from
        Console.Write("Enter the number of the device to capture from: ");
        int deviceIndex = int.Parse(Console.ReadLine()) - 1;
        var device = devices[deviceIndex];

        // Open the device for capturing
        device.Open(DeviceMode.Promiscuous);

        // Set a filter to capture only TCP packets
        device.Filter = "tcp";

        // Register a callback for packet arrival events
        device.OnPacketArrival += (sender, e) =>
        {
            var packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            // Print out the source and destination IP addresses
            if (packet is IpPacket ipPacket)
            {
                Console.WriteLine($"Source IP: {ipPacket.SourceAddress}");
                Console.WriteLine($"Destination IP: {ipPacket.DestinationAddress}");
            }
        };

        // Start capturing packets
        device.StartCapture();

        Console.WriteLine("Capturing network traffic. Press any key to stop...");
        Console.ReadKey();

        // Stop capturing packets
        device.StopCapture();

        // Close the device
        device.Close();
    }
}
