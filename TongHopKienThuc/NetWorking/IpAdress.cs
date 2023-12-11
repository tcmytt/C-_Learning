public static void IPAddressExample(string ips) {
    IPAddress ipaddress;
    if (IPAddress.TryParse(ips, out ipaddress)) {
        Console.WriteLine($"Broadcast     {IPAddress.Broadcast}");
        Console.WriteLine($"Loopback      {IPAddress.Loopback}");
        Console.WriteLine($"AddressFamily {ipaddress.AddressFamily}");
        Console.WriteLine($"IP4           {ipaddress.MapToIPv4().ToString()}");
        Console.WriteLine($"IP6           {ipaddress.MapToIPv6().ToString()}");
        /*
            Broadcast     255.255.255.255
            Loopback      127.0.0.1
            AddressFamily InterNetwork
            IP4           192.168.0.66
            IP6           ::ffff:192.168.0.66
        */
    }
}