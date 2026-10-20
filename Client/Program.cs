using System.Net;
using System.Text;
using System.Net.Sockets;


var client = new UdpClient();

var endPoint = IPAddress.Parse("127.0.0.1");
var port = 45678;

var connectEP = new IPEndPoint(endPoint, port);

Console.WriteLine($"Client Started on Port : {client.Client.RemoteEndPoint}");

while (true)
{
    var str = Console.ReadLine() ?? string.Empty;
    var bytes = Encoding.Default.GetBytes(str);
    client.Send(bytes, bytes.Length, connectEP);
}