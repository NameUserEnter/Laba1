using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        Table table;
        public Form1()
        {
            InitializeComponent();
            table = new Table(dataGridView1);
            this.Text = "MyExcel";
        }
        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Value.ToString()))
            {
                table.ChangeData(e.Value.ToString(), e.RowIndex, e.ColumnIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.FillTable(Mode.Value);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                textBox1.Text = Table.cells[selectedCell.RowIndex][selectedCell.ColumnIndex].Expression;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Table.cells[e.RowIndex][e.ColumnIndex].Expression != null)
                if (!String.IsNullOrEmpty(Table.cells[e.RowIndex][e.ColumnIndex].Error))
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Table.cells[e.RowIndex][e.ColumnIndex].Error;
                else
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Table.cells[e.RowIndex][e.ColumnIndex].Value.ToString();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Table.cells[e.RowIndex][e.ColumnIndex].Expression;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                var sectedCell = dataGridView1.SelectedCells[0];
                if (textBox1.Text == String.Empty)
                {
                    Table.cells[sectedCell.RowIndex][sectedCell.ColumnIndex].Expression = null;
                    Table.cells[sectedCell.RowIndex][sectedCell.ColumnIndex].Value = 0;
                    dataGridView1.Rows[sectedCell.RowIndex].Cells[sectedCell.ColumnIndex].Value = "";
                }
                else
                {
                    table.ChangeData(textBox1.Text, sectedCell.RowIndex, sectedCell.ColumnIndex);
                    if (!String.IsNullOrEmpty(Table.cells[sectedCell.RowIndex][sectedCell.ColumnIndex].Error))
                        dataGridView1.Rows[sectedCell.RowIndex].Cells[sectedCell.ColumnIndex].Value = "";
                    else
                        dataGridView1.Rows[sectedCell.RowIndex].Cells[sectedCell.ColumnIndex].Value = Table.cells[sectedCell.RowIndex][sectedCell.ColumnIndex].Value.ToString();

                }
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            table.AddRow();
        }

        private void AddCol_Click(object sender, EventArgs e)
        {
            table.AddColumn();
        }

        private void DelRow_Click(object sender, EventArgs e)
        {
            table.RemoveRow();
        }

        private void DelCol_Click(object sender, EventArgs e)
        {
            table.RemoveColumn();
        }

        private void проToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpMsg = "Це спеціальна версія програми Excel." +
                 " Програма дозволяє додавати/видаляти стовпці та рядки." +
                 " Виділіть комірку, введіть вираз і натисніть кнопку Обрахувати, результат з'явиться відразу." +
                 " Користуватися досить просто, тому я впевнений, що ви впораєтеся з цією програмою. Удачі!»; ";

            MessageBox.Show(helpMsg, "Про", MessageBoxButtons.OK);
        }
        private void довідкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string helpMsg = " Підтримуються арифметичні операції:" +
                " ^, --, ++," +
                "MIN(x,y), MAX(x,y), " +
                "MMIN(x1,...xN), MMAX(x1,...xN).";
            MessageBox.Show(helpMsg, "Довідка", MessageBoxButtons.OK);
        }
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                table.SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                table.OpenFile(openFileDialog1.FileName);
                table.FillTable(Mode.Value);
            }
        }

    }
}
     