namespace Nurse_IQ.Models
{
    public class Medicine
    {
            public int Id { get; set; }

            public string arabicName { get; set; }
            public string englishName { get; set; }
            public string latinName { get; set; }
            public string category { get; set; }
            public string form { get; set; }
            public string description { get; set; }
            public string indications { get; set; }//uses الاستخدامات
            public string sideEffects { get; set; }
            public string dosage { get; set; }


             public int UserId { get; set; }
            public User User { get; set; }
             public int AdminId { get; set; }
            public Admin AddedBy { get; set; }

        }
    }

}
}
