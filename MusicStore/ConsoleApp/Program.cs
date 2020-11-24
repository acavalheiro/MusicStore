using Artist;
using Grpc.Net.Client;
using System;
using System.Net.Http;

Console.WriteLine("Hello World!");



var httpHandler = new HttpClientHandler();
// Return `true` to allow certificates that are untrusted/invalid
httpHandler.ServerCertificateCustomValidationCallback = 
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

var channel = GrpcChannel.ForAddress("https://localhost:5001",
    new GrpcChannelOptions { HttpHandler = httpHandler });
var client = new ArtistService.ArtistServiceClient(channel);

var response = await client.ArtistListPaginateAsync(new ArtistListPaginatedRequest { PageIndex = 0, PageSize = 1000});

Console.WriteLine(response.Items);