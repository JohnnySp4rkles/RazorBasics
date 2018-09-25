using RazorBasics.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasics.Services {
    public class SurveyService:ISurveyService {
        private List<SurveyProduct> _products;
        public SurveyService() {
            _products = new List<SurveyProduct>() {
                new SurveyProduct() { Id = 1, Name = "Hoodies", VoteCount = 8 },
                new SurveyProduct() { Id = 2, Name = "Banners", VoteCount = 1 },
                new SurveyProduct() { Id = 3, Name = "Posters", VoteCount = 4 },
                new SurveyProduct() { Id = 4, Name = "T-Shirts", VoteCount = 2 }
            };
        }

        public List<SurveyProduct> GetSurveyProducts() {
            return _products;
        }
        public void IncreaseVoteCount(int productID) {
            _products.FirstOrDefault(x => x.Id == productID).VoteCount++;
        }
    }
}
