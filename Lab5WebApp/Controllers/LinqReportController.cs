using Interfaces.Services;
using Lab5WebApp.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using System.Web.Mvc;

namespace Lab5WebApp.Controllers
{
    public class LinqReportController : Controller
    {
        IIngredientService ingredientService;
        IReportService reportService;
        LinqReportModel lrm;
        public LinqReportController(IIngredientService ingredientService, IReportService reportService)
        {
            this.ingredientService = ingredientService;
            this.reportService = reportService;
            //lrm = new LinqReportModel()
            //{
            //    ReportData = new List<Interfaces.DTO.ReportData>(),
            //    SelectedIngredientId = 7,
            //    IngredientList = ingredientService.GetIngredients(null)
            //};
        }
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        public ActionResult LinqReport()
        {
            lrm = new LinqReportModel()
            {
                ReportData = new List<Interfaces.DTO.ReportData>(),
                SelectedIngredientId = 7,
                IngredientList = ingredientService.GetIngredients(null)
            };
            //ViewBag.list = lrm.IngredientList;

            //SelectList ingrs = new SelectList(lrm.IngredientList, "Id", "Name");
            return View(lrm);

        }
        [HttpPost]
        public ActionResult LinqReport(int ingrId)
        {
            //model.ReportData = reportService.ReportPhonesOfMunufacturer(model.SelectedManufId);
            //model.ManufList = phoneService.GetManufacturers();
            //if (ModelState.IsValid)
            //{
            //    //lrm = new LinqReportModel()
            //    //{
            //    //    ReportData = new List<Interfaces.DTO.ReportData>(),
            //    //    SelectedIngredientId = 7,
            //    //    IngredientList = ingredientService.GetIngredients(null)
            //    //};
            //    lrm.ReportData = reportService.ReportPizzas(lrm.SelectedIngredientId);
            //    lrm.IngredientList = ingredientService.GetIngredients(null);
            //    lrm.SelectedIngredientId = model.SelectedIngredientId;
            //    //return RedirectToAction("Index");
            //    //return View(lrm);
            //    return RedirectToAction("Index");
            //}
            //return View(model);
            lrm = new LinqReportModel()
            {
                ReportData = new List<Interfaces.DTO.ReportData>(),
                SelectedIngredientId = 7,
                IngredientList = ingredientService.GetIngredients(null)
            };
            lrm.ReportData = reportService.ReportPizzas(ingrId);
            return View(lrm); 
        }
    }
}
