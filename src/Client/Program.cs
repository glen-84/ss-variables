using Client.GraphQL;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection
    .AddGraphQlClient()
    .ConfigureHttpClient(client => client.BaseAddress = new Uri("http://localhost:5095/graphql"));

IServiceProvider services = serviceCollection.BuildServiceProvider();

IGraphQlClient client = services.GetRequiredService<IGraphQlClient>();

var result = await client.GetBook.ExecuteAsync("example");

Console.WriteLine($"Book title: {result.Data?.Book.Title}");