using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;

namespace Pierres.Controllers
{

  public class OrdersController
  {
    [httpGet("/orders")]
    public ActionResult Index()
    {
      List<Orders> allOrders = Order.GetAll();
      return View(allOrders);
    }
    [HttpGet("/Orders/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create(string details);
    {
      Order myOrder = new Order(details);
    return RedirectToAction("Index");
  }
  [HttpGet("/Orders/{id}")]
  public ActionResultnShow(int id)
  {
    Order foundOrder = Order.Find(id);
    return View(foundOrder);
  }
}
}