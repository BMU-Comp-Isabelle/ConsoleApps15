using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// A listing of WHO weight classifications - Isabelle Thorpe
    /// </summary>
    public enum BMI_Status
    {
        None,
        [Display(Name = "Underweight")]
        UnderWeight,
        [Display(Name = "Normal weight")]
        NormalWeight,
        [Display(Name = "Overweight")]
        OverWeight,
        [Display(Name = "Obese Class I")]
        ObeseI,
        [Display(Name = "Obese Class II")]
        ObeseII,
        [Display(Name = "Obese Class III")]
        ObeseIII
    }
}
