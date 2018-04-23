using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Q148401 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

        }

        private void OnGridViewShowGridMenu(object sender, GridMenuEventArgs e) {
            if (e.MenuType == GridMenuType.Column) {
                DXMenuItem item = new DXMenuItem("Change caption", new EventHandler(OnDXMenuItemClick));
                item.Tag = e.HitInfo.Column;
                e.Menu.Items.Add(item);
            }
        }

        private void OnDXMenuItemClick(object sender, EventArgs e) {
            GridColumn gColumn = (GridColumn)((DXMenuItem)sender).Tag;
            GridView gView = (GridView)gColumn.View;
            Rectangle columnBounds = ((GridViewInfo)gView.GetViewInfo()).ColumnsInfo[gColumn].Bounds;
            Point formLocation = new Point(columnBounds.Left, columnBounds.Bottom);
            formLocation = gView.GridControl.PointToScreen(formLocation);
            new ChangeCaptionDialog(gColumn, formLocation).ShowDialog(this);
        }
    }
}