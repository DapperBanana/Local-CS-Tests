
using System;
using SharpPcap;
using PacketDotNet;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        var devices = CaptureDeviceList.Instance;

        if (devices.Count < 1)
        {
            Console.WriteLine("No network devices found.");
            return;
        }

        // Select the first device
        var device = devices[0];

        // Open the device for capturing
        device.Open();
        device.OnPacketArrival += new PacketArrivalEventHandler(device_OnPacketArrival);
        device.StartCapture();

        Console.WriteLine("Capturing network traffic... Press any key to stop.");
        Console.ReadKey();

        device.StopCapture();
        device.Close();
    }

    private static void device_OnPacketArrival(object sender, CaptureEventArgs e)
    {
        var packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

        if (packet is EthernetPacket)
        {
            var ethPacket = (EthernetPacket)packet;
            Console.WriteLine("Source MAC: {0}, Destination MAC: {1}", ethPacket.SourceHardwareAddress, ethPacket.DestinationHardwareAddress);
        }
    }
}
