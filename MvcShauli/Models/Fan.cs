using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcShauli.Models
{
        public class Fan
        {
            public int ID { get; set; }
            [DisplayName("First name")]
            public string FirstName { get; set; }
            [DisplayName("Last name")]
            public string LastName { get; set; }
            public Gender Gender { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Birthday { get; set; }

            public int Seniority { get; set; }

            public Fan()
            {
                Birthday = DateTime.Now;
            }
        }

        public class FanDBContext : DbContext
        {
            public DbSet<Fan> fan;
            public System.Data.Entity.DbSet<MvcShauli.Models.Fan> Fans { get; set; }
        }

        public enum Gender
        {
            Male,
            Female
        }
    
}