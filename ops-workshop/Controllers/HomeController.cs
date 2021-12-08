using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ops_workshop.Models;

namespace ops_workshop.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration Configuration;

    public HomeController(IConfiguration configuration, ILogger<HomeController> logger)
    {
      _logger = logger;
      Configuration = configuration;
    }

    public IActionResult Index()
    {
      string sqlConnectionstring = Configuration.GetConnectionString("WorkshopDatabase");
      string sqlcommand = @"SELECT OrderQty,Name,ListPrice
                    FROM SalesLT.SalesOrderHeader JOIN SalesLT.SalesOrderDetail
                            ON SalesLT.SalesOrderDetail.SalesOrderID = SalesLT.SalesOrderHeader.SalesOrderID
                                            JOIN SalesLT.Product
                            ON SalesLT.SalesOrderDetail.ProductID=SalesLT.Product.ProductID
                    WHERE CustomerID=30113";
      var salesResult = CreateCommand(sqlcommand, sqlConnectionstring);
      return View(salesResult);
    }

    private static List<SalesResult> CreateCommand(string queryString,
        string connectionString)
    {
      List<SalesResult> salesResults = new List<SalesResult>();

      using (SqlConnection connection = new SqlConnection(
                 connectionString))
      {
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          salesResults.Add(new SalesResult((short)reader[0], (string)reader[1], (decimal)reader[2]));
        }
      }
      return salesResults;
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
