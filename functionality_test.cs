
using SharpPcap;
using PacketDotNet;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve the device list
        CaptureDeviceList devices = CaptureDeviceList.Instance;

        if (devices.Count < 1)
        {
            Console.WriteLine("No devices found.");
            return;
        }

        // Select the first device for capturing
        ICaptureDevice device = devices[0];

        // Open the device for capturing
        device.Open(DeviceMode.Promiscuous);

        Console.WriteLine("Listening on " + device.Description);

        // Subscribe to the packet arrival event
        device.OnPacketArrival += new PacketArrivalEventHandler(PacketArrival);

        // Start capturing packets
        device.StartCapture();

        // Wait for user input to stop capturing
        Console.WriteLine("Press Enter to stop capturing...");
        Console.ReadLine();

        // Stop capturing packets
        device.StopCapture();

        // Close the device
        device.Close();
    }

    static void PacketArrival(object sender, CaptureEventArgs e)
    {
        // Parse the packet
        Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

        if (packet is EthernetPacket)
        {
            // Retrieve the Ethernet packet
            EthernetPacket ethernetPacket = (EthernetPacket)packet;

            Console.WriteLine("Source MAC: " + ethernetPacket.SourceHardwareAddress);
            Console.WriteLine("Destination MAC: " + ethernetPacket.DestinationHardwareAddress);
        }
    }
}
