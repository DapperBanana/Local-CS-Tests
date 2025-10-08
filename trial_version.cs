
using System;
using System.Net;

class MainClass {
    public static void Main (string[] args) {
        string input = "192.168.1.1";
        
        bool isValidIPv4 = IsValidIPv4(input);
        
        if(isValidIPv4) {
            Console.WriteLine(input + " is a valid IPv4 address.");
        } else {
            Console.WriteLine(input + " is not a valid IPv4 address.");
        }
    }
    
    public static bool IsValidIPv4(string ipAddress) {
        IPAddress address;
        return IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
    }
}
