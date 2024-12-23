using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Text.Json;
using HikeService;
using HikeService.Data;
using HikeService.GraphQL;
using HikeService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => {
    options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer()));
}).AddJsonOptions(options => {
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower; // Use snake_case
    options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower; // Optional for dictionary keys
});


builder.Services.AddScoped<IHikeRepository, HikeRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddApolloFederation()
    .AddType<User>()
    .AddType<Trail>()
    .AddType<Hike>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.MapGraphQL();

app.Run();
