using System.ComponentModel.DataAnnotations;

namespace PriceQuatation.Shared
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please Enter Cost of Meal")]
        [RegularExpression(@"\d{0,9}", ErrorMessage = "Meal Cost greater then 0")]
        public Int32 Costofmeal { get; set; }

        public Double DiscountPercent_15 { get; set; }
        public Double DiscountPercent_20 { get; set; } = 0.00;
        public Double DiscountPercent_25 { get; set; } = 0.00;
    }
}
