using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// List of units used to measure distance
    /// </summary>
    public enum DistanceUnits
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Feet,
        Metres,
        Kilometres,
        Miles
    }
}
namespace ConsoleAppProject.App02
{
    public enum BMIUnits
    {
        [Display(Name = "No BMI")]
        Feet,
        Stone,
        Height,
        Weight,
    }

}


