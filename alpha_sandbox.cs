
using System;
using System.Net;

class MainClass {
  public static void Main (string[] args) {
    string ipAddress = "192.168.1.1";
    
    if (IsValidIpAddress(ipAddress)) {
      Console.WriteLine(ipAddress + " is a valid IPv4 address.");
    } else {
      Console.WriteLine(ipAddress + " is not a valid IPv4 address.");
    }
  }

  public static bool IsValidIpAddress(string ipAddress) {
    IPAddress address;
    return IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
  }
}
