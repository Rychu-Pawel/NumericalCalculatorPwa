using NumericalCalculatorPwa.ViewModels;

namespace NumericalCalculatorPwa.Pages.FunctionEstimation.ViewModels
{
    public class FunctionEstimationViewModel
    {
        public ValueErrorModel X { get; set; } = new ValueErrorModel();
        public ValueErrorModel Y { get; set; } = new ValueErrorModel();
    }
}