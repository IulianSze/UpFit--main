using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpFit__main.Models
{
    public class AlimentsModel
    {
    [Key]
     public int AlimentID { get; set; }
    public string AlimentName { get; set; }
    public double Kcal { get; set; }
    public double Carbohidrates { get; set; }
    public double Proteins { get; set; }

    public double Fibers { get; set; }

    public double VitA { get; set; }

    public double VitB { get; set; }

    public double  VitC { get; set; }

    public double Magnezium { get; set; }
    public double Sodium { get; set;  }
}
}