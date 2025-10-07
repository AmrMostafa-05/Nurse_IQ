namespace Nurse_IQ.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string category { get; set; }
        public string Description { get; set; }

        public decimal OriginalPrice { get; set; } // السعر الأصلي

        public int DiscountPercentage { get; set; } // نسبة الخصم 

        // قيمة الخصم (المبلغ اللي اتخصم)
        public decimal DiscountPrice { get; private set; }

        // السعر بعد الخصم
        public decimal LastPrice { get; private set; } /*=> OriginalPrice - DiscountPrice;
*/
        public string imageUrl { get; set; }
        public DateTime expiredAt { get; set; }
        public List<string> features { get; set; }

        public bool IsValid()
        {
            return DateTime.Now <= expiredAt;
        }

        public int CreatedByAdminId { get; set; }
        public applicationUser CreatedBy { get; set; }
    }
}
