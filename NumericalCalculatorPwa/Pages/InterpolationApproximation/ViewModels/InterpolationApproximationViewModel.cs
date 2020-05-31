using NumericalCalculatorPwa.ViewModels;

namespace NumericalCalculatorPwa.Pages.InterpolationApproximation.ViewModels
{
    public class InterpolationApproximationViewModel
    {
        public ValueErrorModel X { get; set; } = new ValueErrorModel();
        public ValueErrorModel Y { get; set; } = new ValueErrorModel();
    }
}