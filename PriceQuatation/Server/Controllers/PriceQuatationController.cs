using PriceQuatation.Shared;

namespace PriceQuatation.Server.Controllers
{
    public interface IPriceQuatation
    {
        Task<PriceQuatationModel> Calculate(PriceQuatationModel PQ);
    }

    public class PriceQuatationController : IPriceQuatation
    {
        public async Task<PriceQuatationModel> Calculate(PriceQuatationModel PQ)
        {
            PriceQuatationModel PQDATA = new();
            try
            {
                PQDATA.Subtotal = PQ.Subtotal;
                PQDATA.DiscountPercent = PQ.DiscountPercent;
                PQDATA.DiscountAmount = (PQ.Subtotal * PQ.DiscountPercent) / 100;
                PQDATA.TotalAmount = PQ.Subtotal - PQ.DiscountAmount;
            }
            catch (Exception)
            {
                PQDATA = new PriceQuatationModel();
            }
            return PQDATA;
        }
    }
}
