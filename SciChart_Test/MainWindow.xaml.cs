using SciChart.Charting.ChartModifiers;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Annotations;
using SciChart.Charting.Visuals.Axes;
using System.Windows;

namespace SciChart_Test
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create the chart surface
            var sciChartSurface = new SciChartSurface();

            // Create the X and Y Axis
            var xAxis = new NumericAxis() { AxisTitle = "Number of Samples (per series)" };
            var yAxis = new NumericAxis() { AxisTitle = "Value" };

            sciChartSurface.XAxis = xAxis;
            sciChartSurface.YAxis = yAxis;

            // Specify Interactivity Modifiers
            sciChartSurface.ChartModifier = new ModifierGroup(new RubberBandXyZoomModifier(), new ZoomExtentsModifier());
            // Add annotation hints to the user
            var textAnnotation = new TextAnnotation()
            {
                Text = "Hello World!",
                X1 = 5.0,
                Y1 = 5.0
            };
            sciChartSurface.Annotations.Add(textAnnotation);
        }
    }
}
