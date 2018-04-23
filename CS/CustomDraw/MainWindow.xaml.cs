using System.Windows;
using System.Windows.Media;
using DevExpress.Xpf.Charts;

namespace CustomDraw
{

    public partial class MainWindow : Window
    {
        bool handleCustomDraw;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            handleCustomDraw = true;
            chartControl.CustomDrawCrosshair += chartControl_CustomDrawCrosshair;
        }
        private void chartControl_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e)
        {
            if (!handleCustomDraw) return;

            // Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Brush = Brushes.Aqua;
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyles.DashDot;
            e.CrosshairLineElement.LineStyle.Thickness = 3;

            // Specify  the background  and font size for the crosshair argument label. 
            foreach (CrosshairAxisLabelElement axisLabelElement in e.CrosshairAxisLabelElements)
            {
                axisLabelElement.Background = Brushes.Blue;
                axisLabelElement.FontSize = 14;
            }

            foreach (CrosshairElement element in e.CrosshairElements)
            {
                // Specify the color, dash style and thickness for the crosshair value lines.                 
                element.LineElement.Brush = Brushes.DarkViolet;
                element.LineElement.LineStyle.DashStyle = DashStyles.Dash;
                element.LineElement.LineStyle.Thickness = 2;

                // Specify the  font size and background for the crosshair value labels.
                element.AxisLabelElement.FontSize = 14;
                element.AxisLabelElement.Background = Brushes.Red;

                // Specify the foreground and  font size for the crosshair  cursor label that shows series. 
                element.LabelElement.Foreground = Brushes.Green;
                element.LabelElement.FontSize = 14;

            }
        }
    }
}
