using System.Net;
using System.Net.Sockets;
using System.Text;


var server = new UdpClient(45678);

var remoteEP = new IPEndPoint(IPAddress.Any, 0);

Console.WriteLine($"Server started......{server.Client.RemoteEndPoint}");

while (true)
{
    var bytes = server.Receive(ref remoteEP);
    var str = Encoding.Default.GetString(bytes);
    Console.WriteLine(str);
}