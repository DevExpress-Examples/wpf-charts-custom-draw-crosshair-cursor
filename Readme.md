<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569577/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4385)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomDraw/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDraw/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomDraw/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomDraw/MainWindow.xaml.vb))
<!-- default file list end -->
# How to custom draw a crosshair cursor


<p>This example shows how to provide custom appearance of the crosshair cursor using the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsChartControl_CustomDrawCrosshairtopic"><u>ChartControl.CustomDrawCrosshair</u></a> <strong> </strong>event. This event is invoked when you click the <strong>Custom Draw Crosshair Cursor</strong> button on the form. </p><p>If you wish to display crosshair axis  lines and labels on a chart before custom drawing the crosshair cursor, set the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowArgumentLabelstopic"><u>CrosshairOptions.ShowArgumentLabels</u></a>, <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowArgumentLinetopic"><u>CrosshairOptions.ShowArgumentLine</u></a>, <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowValueLabelstopic"><u>CrosshairOptions.ShowValueLabels</u></a> and <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowValueLinetopic"><u>CrosshairOptions.ShowValueLine</u></a> properties to <strong>true</strong>. </p><p>Note that the customization of the crosshair cursor is provided for the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_SnapModetopic"><u>CrosshairOptions.SnapMode</u></a> property set to <strong>NearestArgument</strong>.</p><br />


<br/>


