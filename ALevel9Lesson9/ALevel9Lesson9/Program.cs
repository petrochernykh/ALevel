using ALevel9Lesson9;
using ALevel9Lesson9.Repositories;
using ALevel9Lesson9.Repositories.Abstractions;
using ALevel9Lesson9.Services;
using ALevel9Lesson9.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

void ConfigureService(ServiceCollection serviceCollection, IConfiguration configuration)
{
    //serviceCollection.AddOptions<>

    serviceCollection
        .AddTransient<IShoeService, ShoeService>()
        .AddScoped<IShoeRepository, ShoeRepository>()
        .AddScoped<IUserRepository, UserRepository>()
        .AddTransient<App>();
}

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("C:\\Users\\petrc\\source\\repos\\ALevel9Lesson9\\ALevel9Lesson9\\config.json")
    .Build();

var serviceCollection = new ServiceCollection();
ConfigureService(serviceCollection, configuration);
var provider = serviceCollection.BuildServiceProvider();

var app = provider.GetService<App>();
app!.Run();
