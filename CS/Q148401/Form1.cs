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

        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;

            table.Columns.Add("Prod_NO", typeof(string));
            table.Columns.Add("Prod_Name", typeof(string));
            table.Columns.Add("Order_Date", typeof(string));
            table.Columns.Add("Quantity", typeof(string));

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "101";
            dataRow["Prod_Name"] = "Product1";
            dataRow["Order_Date"] = "12/06/2012";
            dataRow["Quantity"] = "50";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "103";
            dataRow["Prod_Name"] = "Product3";
            dataRow["Order_Date"] = "18/06/2012";
            dataRow["Quantity"] = "30";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "104";
            dataRow["Prod_Name"] = "Product4";
            dataRow["Order_Date"] = "25/06/2012";
            dataRow["Quantity"] = "20";
            table.Rows.Add(dataRow);

            return table;
        }

        private void Form1_Load(object sender, EventArgs e) {
            gridControl1.DataSource = CreateTable();
        }

        private void OnGridViewShowGridMenu(object sender, PopupMenuShowingEventArgs e) {
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