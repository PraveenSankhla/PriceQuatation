using System.ComponentModel.DataAnnotations;

namespace PriceQuatation.Shared
{
    public class PriceQuatationModel
    {
        [Required(ErrorMessage = "Please Enter a sale price")]
        [Range(2, Int32.MaxValue, ErrorMessage = "Sale price must be greater than 1")]
        public Int32 Subtotal { get; set; }
        
        [Required(ErrorMessage = "Please enter a discount amount")]
        [Range(10, 30, ErrorMessage = "Min. discount is 10% and max. is 30%")]
        public Int32 DiscountPercent { get; set; }
        public Double DiscountAmount { get; set; } = 0.00;
        public Double TotalAmount { get; set; } = 0.00;
    }
}
