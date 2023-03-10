using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguesaDavidTrujillo.Models
{
    [Table("burger")]
    public class BurgerDT
    {
        
        
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            [MaxLength(250), Unique]
            public string NameDT { get; set; }
            public string DescriptionDT { get; set; }
            public bool WithExtraCheeseDT { get; set; }

            public DateTime DateTimeDT { get; set; }


    }
}
