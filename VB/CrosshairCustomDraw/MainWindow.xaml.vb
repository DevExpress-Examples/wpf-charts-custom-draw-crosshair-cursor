Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports System.Windows.Media


Namespace CrosshairCustomDraw
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Private handleCustomDraw As Boolean
        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            handleCustomDraw = True
            AddHandler chartControl1.CustomDrawCrosshair, AddressOf chartControl1_CustomDrawCrosshair
        End Sub

        Private Sub chartControl1_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)

            If Not handleCustomDraw Then
                Return
            End If

            ' Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Brush = Brushes.Aqua
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyles.DashDot
            e.CrosshairLineElement.LineStyle.Thickness = 3

            ' Specify  the back color for crosshair argument label. 
            For Each axisLabelElement As CrosshairAxisLabelElement In e.CrosshairAxisLabelElements
                axisLabelElement.Background = Brushes.Blue
            Next axisLabelElement

            For Each group As CrosshairElementGroup In e.CrosshairElementGroups
                Dim element As CrosshairElement = group.CrosshairElements(0)

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
            Next group

            For Each group As CrosshairElementGroup In e.CrosshairElementGroups
                Dim groupHeaderElement As CrosshairGroupHeaderElement = group.HeaderElement

                ' Specify the text, text color and font for the crosshair group header element. 
                groupHeaderElement.Text = "Custom draw"
                groupHeaderElement.Foreground = Brushes.Red
                groupHeaderElement.FontSize = 15
            Next group
        End Sub
    End Class
End Namespace
