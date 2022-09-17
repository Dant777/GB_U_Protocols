using ClinicService.Proto;
using Grpc.Net.Client;

AppContext.SetSwitch(
    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
var channel = GrpcChannel.ForAddress("http://localhost:5001");


ClinicClientService.ClinicClientServiceClient client = new ClinicClientService.ClinicClientServiceClient(channel);

var createClientResponse = client.CreateClient(new CreateClientRequest
{
    Document = "PASS123",
    FirstName = "cтаниcлав",
    Surname = "Байраковcкий",
    Patronymic = "Антонович"
});

Console.WriteLine($"Client ({createClientResponse.ClientId}) created successfully.");

var getClientsResponse = client.GetClients(new GetClientsRequest());

Console.WriteLine("Clients:");
Console.WriteLine("========\n");
foreach (var clientObj in getClientsResponse.Clients)
{
    Console.WriteLine($"{clientObj.Document} >> {clientObj.Surname} {clientObj.FirstName}");
}

Console.ReadKey();