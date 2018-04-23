using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace Q148401 {
    public partial class ChangeCaptionDialog : Form {
        private GridColumn column;

        public ChangeCaptionDialog() {
            InitializeComponent();
        }

        public ChangeCaptionDialog(GridColumn column, Point position) : this() {
            this.column = column;
            textBox1.Text = column.Caption;
            Location = position;
        }

        private void OnApplyClick(object sender, EventArgs e) {
            column.Caption = textBox1.Text;
            Close();
        }

        private void OnCancelClick(object sender, EventArgs e) {
            Close();
        }
    }
}