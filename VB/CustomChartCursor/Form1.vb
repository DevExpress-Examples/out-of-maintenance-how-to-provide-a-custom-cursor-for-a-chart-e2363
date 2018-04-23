Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...
#End Region ' #usings

Namespace CustomChartCursor
    Partial Public Class Form1
        Inherits Form
            Public Sub New()
                InitializeComponent()
            End Sub

#Region "#code"
Private Sub chartControl1_QueryCursor(ByVal sender As Object, _ 
ByVal e As QueryCursorEventArgs) Handles chartControl1.QueryCursor
    If e.CursorType = CursorType.Hand OrElse e.CursorType = CursorType.Grab Then
        e.Cursor = Cursors.Default
    End If
End Sub
#End Region ' #code

    End Class
End Namespace
