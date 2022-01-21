Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Charts

Namespace CustomDraw

    Public Partial Class MainWindow
        Inherits Window

        Private handleCustomDraw As Boolean

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            handleCustomDraw = True
            AddHandler Me.chartControl.CustomDrawCrosshair, AddressOf Me.chartControl_CustomDrawCrosshair
        End Sub

        Private Sub chartControl_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            If Not handleCustomDraw Then Return
            ' Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Brush = Brushes.Aqua
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyles.DashDot
            e.CrosshairLineElement.LineStyle.Thickness = 3
            ' Specify  the background  and font size for the crosshair argument label. 
            For Each axisLabelElement As CrosshairAxisLabelElement In e.CrosshairAxisLabelElements
                axisLabelElement.Background = Brushes.Blue
                axisLabelElement.FontSize = 14
            Next

            For Each element As CrosshairElement In e.CrosshairElements
                ' Specify the color, dash style and thickness for the crosshair value lines.                 
                element.LineElement.Brush = Brushes.DarkViolet
                element.LineElement.LineStyle.DashStyle = DashStyles.Dash
                element.LineElement.LineStyle.Thickness = 2
                ' Specify the  font size and background for the crosshair value labels.
                element.AxisLabelElement.FontSize = 14
                element.AxisLabelElement.Background = Brushes.Red
                ' Specify the foreground and  font size for the crosshair  cursor label that shows series. 
                element.LabelElement.Foreground = Brushes.Green
                element.LabelElement.FontSize = 14
            Next
        End Sub
    End Class
End Namespace
