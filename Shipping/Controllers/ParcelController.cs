using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;


namespace Shipping.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
  

  [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int height, int length, int depth, int weight)
    {
      Parcel myItem = new Parcel(height, length, depth, weight);
      return RedirectToAction("Index");
    }
}
}