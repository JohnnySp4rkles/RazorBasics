using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RazorBasics.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RazorBasics.Services {

    public class JsonFormDataService : IFormDataService {
        private DropDownData _srcJson;

        public JsonFormDataService() {
            _srcJson = JsonConvert.DeserializeObject<DropDownData>(File.ReadAllText("FormData.json"));
        }

        public List<SelectListItem> GetClientTypes() {
            return _srcJson.ClientTypes.Select(x => new SelectListItem() { Text = x }).ToList();
        }

        public List<SelectListItem> GetLocations() {
            return _srcJson.Locations.Select(x => new SelectListItem() { Text = x }).ToList();
        }

        public List<SelectListItem> GetOrderStages() {
            throw new System.NotImplementedException();
        }

        public List<OrderProductVM> GetProducts() {
            throw new System.NotImplementedException();
        }
    }

    public class DropDownData {
        public List<string> Locations { get; set; }
        public List<string> ClientTypes { get; set; }
    }
}