using System.Windows;
using DevExpress.Xpf.Charts;
using System.Windows.Media;


namespace CrosshairCustomDraw {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        bool handleCustomDraw;
        public MainWindow() {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            handleCustomDraw = true;
            chartControl1.CustomDrawCrosshair += chartControl1_CustomDrawCrosshair;
        }

        private void chartControl1_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {

            if (!handleCustomDraw) return;

            // Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Brush = Brushes.Aqua;
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyles.DashDot;
            e.CrosshairLineElement.LineStyle.Thickness = 3;

            // Specify  the background  and font size for the crosshair argument label. 
            foreach (CrosshairAxisLabelElement axisLabelElement in e.CrosshairAxisLabelElements) {
                axisLabelElement.Background = Brushes.Blue;
                axisLabelElement.FontSize = 14;
            }

            foreach (CrosshairElement element in e.CrosshairElements) {

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
            foreach (CrosshairGroupHeaderElement groupHeaderElement in e.CrosshairGroupHeaderElements) {

                // Specify the font style, foreground and font size for the crosshair group header element.  
                groupHeaderElement.FontStyle = FontStyles.Oblique;
                groupHeaderElement.Foreground = Brushes.Red;
                groupHeaderElement.FontSize = 15;

            }
        }
    }
}
