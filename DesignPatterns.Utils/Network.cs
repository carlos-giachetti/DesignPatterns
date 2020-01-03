using System.Net;

namespace DesignPatterns.Utils
{
    public static class Network
    {
        private static string GetHostName()
        {
            return Dns.GetHostName();
        }


        public static string GetIPAddress() => Dns.GetHostEntry(GetHostName()).AddressList[1].ToString();
    }
}
