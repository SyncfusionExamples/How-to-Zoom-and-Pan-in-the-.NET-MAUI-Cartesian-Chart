# How-to-Zoom-and-Pan-in-the-.NET-MAUI-Cartesian-Chart

This repository contains a sample project demonstrating how to implement zoom and pan functionality in the [.NET MAUI Cartesian Chart](https://help.syncfusion.com/maui/cartesian-charts/getting-started).

## Zoom and Pan
The .NET MAUI Cartesian Chart provides a powerful way to visualize data with enhanced interactivity through [zooming and panning](https://help.syncfusion.com/maui/cartesian-charts/zooming-and-panning) functionalities. This sample demonstrates how to enable zooming and panning in a Cartesian chart to allow users to interact with and closely examine the chart data.

[ZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomPanBehavior): Adds zoom and pan capabilities to the chart.

[EnableSelectionZooming](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_EnableSelectionZooming): Allows the user to zoom into a selected area of the chart.

[SelectionRectFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectFill): Sets the fill color of the selection rectangle used for zooming.

[SelectionRectStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectStroke): Sets the border color of the selection rectangle.

[SelectionRectStrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectStrokeWidth): Specifies the thickness of the selection rectangle's border.

By utilizing these properties, you can create a highly interactive chart that allows users to focus on specific data points and navigate through the chart with ease.

## Troubleshooting
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
