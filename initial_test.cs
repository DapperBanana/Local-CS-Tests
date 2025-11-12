
using System;
using SharpPcap;
using PacketDotNet;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        var devices = CaptureDeviceList.Instance;

        // If no devices were found, print an error message
        if (devices.Count < 1)
        {
            Console.WriteLine("No capture devices found on this machine.");
            return;
        }

        // Print out the available devices
        Console.WriteLine("Available capture devices:");
        for (int i = 0; i < devices.Count; i++)
        {
            Console.WriteLine($"{i+1}. {devices[i]}");
        }

        // Prompt the user to select a device
        Console.Write("Enter the number of the device to capture traffic from: ");
        int selectedDeviceIndex = int.Parse(Console.ReadLine()) - 1;

        // Open the selected device for capturing
        var device = devices[selectedDeviceIndex];
        device.Open(DeviceMode.Promiscuous);

        // Register a handler for the packet arrival event
        device.OnPacketArrival += (sender, eventArgs) =>
        {
            var packet = Packet.ParsePacket(eventArgs.Packet.LinkLayerType, eventArgs.Packet.Data);
            var tcpPacket = packet.Extract<TcpPacket>();
            var udpPacket = packet.Extract<UdpPacket>();

            Console.WriteLine($"Source IP: {packet.SourceAddress}");
            Console.WriteLine($"Destination IP: {packet.DestinationAddress}");

            if (tcpPacket != null)
            {
                Console.WriteLine($"Protocol: TCP");
                Console.WriteLine($"Source Port: {tcpPacket.SourcePort}");
                Console.WriteLine($"Destination Port: {tcpPacket.DestinationPort}");
            }

            if (udpPacket != null)
            {
                Console.WriteLine($"Protocol: UDP");
                Console.WriteLine($"Source Port: {udpPacket.SourcePort}");
                Console.WriteLine($"Destination Port: {udpPacket.DestinationPort}");
            }

            Console.WriteLine();
        };

        // Start capturing packets
        device.StartCapture();

        Console.WriteLine("Press Enter to stop capturing...");
        Console.ReadLine();

        // Stop capturing packets and close the device
        device.StopCapture();
        device.Close();
    }
}
