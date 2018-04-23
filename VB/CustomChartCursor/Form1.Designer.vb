Namespace CustomChartCursor
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(12R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(14R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(16R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(8R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (DirectCast(9R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (DirectCast(13R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (DirectCast(11R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (DirectCast(7R, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (DirectCast(15R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("J", New Object() { (DirectCast(6R, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("K", New Object() { (DirectCast(13R, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("L", New Object() { (DirectCast(7R, Object))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("M", New Object() { (DirectCast(16R, Object))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("N", New Object() { (DirectCast(8R, Object))})
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("O", New Object() { (DirectCast(15R, Object))})
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("P", New Object() { (DirectCast(11R, Object))})
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.VisualRange.Auto = False
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "J"
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "A"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(463, 283)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(463, 283)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

