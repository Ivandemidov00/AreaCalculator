using AreaCalculator;
using AreaCalculator.Example.Parallelogram;
using AreaCalculator.Interfaces;
using AreaCalculator.Shapes.Circle;
using Microsoft.AspNetCore.Mvc;
using Rectangle = AreaCalculator.Shapes.Rectangle.Rectangle;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddShape<Circle, CircleCalculator>();
builder.Services.AddShape<Parallelogram, ParallelogramCalculator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.EnableAnnotations();
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); 

app.MapPost("/calc/circle", (IAreaCalculator calculator, [FromBody] Circle circle) => calculator.Calculate(circle));
app.MapPost("/calc/parallelogram", (IAreaCalculator calculator, [FromBody] Parallelogram parallelogram) => calculator.Calculate(parallelogram));
app.MapPost("/calc/rectangle", (IAreaCalculator calculator, [FromBody] Rectangle rectangle) => calculator.Calculate(rectangle));

app.Run();


