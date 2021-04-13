using SfDataGrid_Demo;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;

            this.sfDataGrid1.QueryCellStyle += OnSfDataGrid1_QueryCellStyle;
        }

        private void OnSfDataGrid1_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "Quantity")
            {
                if ((e.DataRow.RowData as OrderInfo).Quantity < 40)
                    e.Style.Borders.All = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Color.Red, Syncfusion.WinForms.DataGrid.Styles.GridBorderWeight.Thick);
            }
        }

        #endregion
    }
}
