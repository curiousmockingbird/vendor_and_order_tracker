using Microsoft.AspNetCore.Mvc;
using Business.Models;
using System.Collections.Generic;

namespace Business.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.FindId(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindId(orderId);
      Vendor vendor = Vendor.FindId(vendorId);

      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("item", order);
      model.Add("category", vendor);

      return View(model);
    }
  }
}