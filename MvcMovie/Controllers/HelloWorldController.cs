using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller

{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "Привет всем, я Конор и я проверю как это работает на самом деле!";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "Пока мир";
    }
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome1(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello Conor {name}, ID: {ID}");
    }

}