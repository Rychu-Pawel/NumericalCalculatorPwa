using NumericalCalculatorPwa.ViewModels;

namespace NumericalCalculatorPwa.Pages.Mean.ViewModels
{
    public class MeanViewModel
    {
        public ValueErrorModel Value { get; set; } = new ValueErrorModel();
        public ValueErrorModel Weight { get; set; } = new ValueErrorModel();
    }
}