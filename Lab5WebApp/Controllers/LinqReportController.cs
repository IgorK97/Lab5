using Interfaces.Services;
using Lab5WebApp.Models;
using Microsoft.AspNetCore.Mvc;

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
            lrm = new LinqReportModel()
            {
                ReportData = new List<Interfaces.DTO.ReportData>(),
                SelectedIngredientId = 7,
                IngredientList = ingredientService.GetIngredients(null)
            };
        }
        public IActionResult LinqReport()
        {
            
            return View(lrm);

        }
        [HttpPost]
        public ActionResult LinqReport(LinqReportModel model)
        {
            //model.ReportData = reportService.ReportPhonesOfMunufacturer(model.SelectedManufId);
            //model.ManufList = phoneService.GetManufacturers();
            lrm = new LinqReportModel()
            {
                ReportData = new List<Interfaces.DTO.ReportData>(),
                SelectedIngredientId = 7,
                IngredientList = ingredientService.GetIngredients(null)
            };
            lrm.ReportData = reportService.ReportPizzas(lrm.SelectedIngredientId);
            lrm.IngredientList = ingredientService.GetIngredients(null);
            lrm.SelectedIngredientId = model.SelectedIngredientId;
            //return RedirectToAction("Index");
            return View(lrm);
        }
    }
}
