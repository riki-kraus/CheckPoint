
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
builder.Services.AddScoped<IManagerService, ManagerService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IResultService, ResultService>();
builder.Services.AddScoped<IExamService, ExamService>();
builder.Services.AddScoped<IAnswerService, AnswerService>();

builder.Services.AddScoped<IManagerRepository, ManagerRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddScoped<IExamRepository, ExamRepository>();
builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
builder.Services.AddSingleton<DataContext>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty; // ��� ��-Swagger UI ����� �-root URL
});
app.Run();