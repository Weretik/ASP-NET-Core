Console.OutputEncoding = System.Text.Encoding.Unicode;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Use( async (context, next) =>
{

    Console.WriteLine("Початок компонента");
    await next(context);
    Console.WriteLine("Кінець компонента");
});

int x = 0;
app.Run(async context =>
{
    await context.Response.WriteAsync($"My numbr {x++}");
});

app.Run();
