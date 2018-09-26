using Microsoft.AspNetCore.Mvc.Rendering;
using RazorBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasics.Services {
    public interface IFormDataService {
        List<SelectListItem> GetLocations();
        List<SelectListItem> GetClientTypes();
        List<SelectListItem> GetOrderStages();
        List<OrderProductVM> GetProducts();
    }
}
