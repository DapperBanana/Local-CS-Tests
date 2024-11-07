
using System;
using PacketDotNet;
using SharpPcap;

class NetworkTrafficAnalyzer
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        CaptureDeviceList devices = CaptureDeviceList.Instance;

        if (devices.Count < 1)
        {
            Console.WriteLine("No network devices found.");
            return;
        }

        // Select the first device for capturing
        ICaptureDevice device = devices[0];

        // Open the device for capturing
        device.Open();

        // Print out the device information
        Console.WriteLine("Analyzing traffic on device: " + device.Description);

        // Start capturing packets
        device.OnPacketArrival += new PacketArrivalEventHandler((sender, e) =>
        {
            Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            if (packet is EthernetPacket)
            {
                EthernetPacket ethPacket = (EthernetPacket)packet;
                Console.WriteLine("Source MAC: {0}, Destination MAC: {1}", ethPacket.SourceHwAddress, ethPacket.DestinationHwAddress);
            }
        });

        device.StartCapture();
    }
}
