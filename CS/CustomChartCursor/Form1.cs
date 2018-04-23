#region #usings
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...
#endregion #usings

namespace CustomChartCursor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
private void chartControl1_QueryCursor(object sender, QueryCursorEventArgs e) {
    if (e.CursorType == CursorType.Hand || e.CursorType == CursorType.Grab) {
        e.Cursor = Cursors.Default;
    }
}
#endregion #code

    }
}
