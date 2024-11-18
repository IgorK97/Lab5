using BLL.Services;
using DTO;
using Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab5WebApp.Controllers
{
    public class BasketController : Controller
    {
        IOrderLineService orderLineService;
        IOrderService orderService;
        int currentOrderId;
        IEnumerable<OrderLineDto> orderlines;
        public BasketController(IOrderLineService orderLineService, IOrderService orderService)
        {
            this.orderLineService = orderLineService;
            this.orderService = orderService;
        }

        public IActionResult Index()
        {
            currentOrderId = orderService.GetCurrentOrder(3);
            orderlines = orderLineService.GetAllOrderLines(currentOrderId);
            return View(orderlines);
        }
    }
}
