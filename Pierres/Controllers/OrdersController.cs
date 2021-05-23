using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;

namespace Pierres.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    // [HttpPost("/orders/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Order.ClearAll();
    //   return View();
    // }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    //   [HttpGet("/orders")]
    //   public ActionResult Index()
    //   {
    //     List<Order> allOrders = Order.GetAll();
    //     return View(allOrders);
    //   }

    //   [HttpGet("/orders/new")]
    //   public ActionResult New()
    //   {
    //     return View();
    //   }

    //   [HttpPost("/orders")]
    //   public ActionResult Create(string description)
    //   {
    //     Order myOrder = new Order(description);
    //     return RedirectToAction("Index");
    //   }

    //   [HttpPost("/orders/delete")]
    //   public ActionResult DeleteAll()
    //   {
    //     Order.ClearAll();
    //     return View();
    //   }

    //   [HttpGet("/orders/{id}")]
    //   public ActionResult Show(int id)
    //   {
    //     Order foundOrder = Order.Find(id);
    //     return View(foundOrder);
    //   }
  }
}