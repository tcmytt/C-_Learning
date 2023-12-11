IPHostEntry hostInfo = Dns.GetHostEntry("google.com.vn");
Console.WriteLine(hostInfo.HostName);
foreach (var ip in hostInfo.AddressList)
{
   Console.WriteLine(ip);
}
/*
    google.com.vn
    216.58.221.227
    2404:6800:4005:800::2003
*/