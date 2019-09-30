using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseTest
{
    [Table("Droid")]
    public class Droid
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        //public Arme Arme { get; set; }
    }
}
