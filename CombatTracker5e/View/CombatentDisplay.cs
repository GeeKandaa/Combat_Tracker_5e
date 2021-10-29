using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker5e.View
{
    public partial class CombatentDisplay : DataGridView
    {
        public CombatentDisplay()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            AutoGenerateColumns = false;
            AutoSize = false;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Status";
            column.Name = "Status";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Character Name";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Hp";
            column.Name = "    HP    ";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Stunned";
            column.Name = "Stunned";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Concentrating";
            column.Name = "Concentrating";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Initiative";
            column.Name = "Initiative";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Columns.Add(column);

            for (int i = 0; i < Columns.Count; i++)
            {
                Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
