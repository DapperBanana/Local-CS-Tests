
using System;
using PcapDotNet.Core;
using PcapDotNet.Packets;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

        if (allDevices.Count == 0)
        {
            Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
            return;
        }

        // Choose the network device to capture packets
        PacketDevice selectedDevice = allDevices[0];

        // Open the device
        using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
        {
            // Check the MAC address of the network device
            MacAddress macAddress = selectedDevice.GetMacAddress();
            Console.WriteLine($"MAC Address: {macAddress}");

            // Start capturing packets
            communicator.ReceivePackets(0, PacketHandler);
        }
    }

    // Callback function to handle received packets
    private static void PacketHandler(Packet packet)
    {
        Console.WriteLine(packet.Timestamp.ToString("hh:mm:ss.fff") + " length:" + packet.Length);
    }
}
