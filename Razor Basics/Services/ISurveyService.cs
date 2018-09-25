using RazorBasics.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasics.Services {
    public interface ISurveyService {
        List<SurveyProduct> GetSurveyProducts();
        void IncreaseVoteCount(int productId);
    }
}
