/*
 * Example code for a WebSocketClient
*/

using System.Net.WebSockets;
using System.Text;

while (true)
{
    try
    {
        Task t = Echo();
        t.Wait();
    }
    catch (Exception)
    { }

}
static async Task Echo()
{
    using (ClientWebSocket ws = new ClientWebSocket())
    {
        Uri serverUri = new Uri("ws://localhost:8008/");
        await ws.ConnectAsync(serverUri, CancellationToken.None);
        while (ws.State == WebSocketState.Open)
        {
            Console.Write("Input message ('exit' to exit): ");
            string msg = Console.ReadLine();

            if (msg == "close")
            {
                break;
            }

            ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg));

            await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);

            ArraySegment<byte> bytesReceived = new ArraySegment<byte>(new byte[1024]);

            // Response
            //WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, CancellationToken.None);
            //Console.WriteLine(Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count));
        }
    }
}