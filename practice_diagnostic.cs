
using System;
using System.Collections.Generic;
using SharpPcap;
using PacketDotNet;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        CaptureDeviceList devices = CaptureDeviceList.Instance;

        // Check if any devices are available
        if (devices.Count < 1)
        {
            Console.WriteLine("No devices found");
            return;
        }

        // Print the available devices
        Console.WriteLine("Available devices:");
        for (int i = 0; i < devices.Count; i++)
        {
            Console.WriteLine($"{i}. {devices[i].Description}");
        }

        // Prompt the user to select a device
        Console.Write("Select a device to capture traffic: ");
        int deviceIndex = Convert.ToInt32(Console.ReadLine());
        ICaptureDevice device = devices[deviceIndex];

        // Open the device for capturing
        device.OnPacketArrival += new PacketArrivalEventHandler(PacketHandler);
        device.Open(DeviceMode.Promiscuous);

        // Start capturing packets indefinitely
        device.Capture();
    }

    private static void PacketHandler(object sender, CaptureEventArgs e)
    {
        // Parse the packet
        Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

        // Display the packet information
        Console.WriteLine($"Packet incoming: {packet.ToString()}");
    }
}
