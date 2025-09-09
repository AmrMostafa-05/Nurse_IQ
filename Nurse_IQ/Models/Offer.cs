namespace Nurse_IQ.Models
{
    public class Offer
    {
        /// <summary>
        /// handle the config
        /// </summary>
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string category { get; set; }
        public string Description{ get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }//savings
        public decimal LastPrice { get; set; }// note //the admin would put only 2 values OriginalPrice and discountPercentage
                                             //and the other two would be computed colums but still you can make fileterations on them  
        public int discountPercentage { get; set; }//20%

        public string imageUrl { get; set; }
        public DateTime expiredAt { get; set; }
        public List<string> features { get; set; }

        public bool isValid ()
        {
            if(DateTime.Now > expiredAt) 
                return false;
            return true;
        }

        public int CreatedByAdminId { get; set; }
        public Admin CreatedBy { get; set; }









    }
}
