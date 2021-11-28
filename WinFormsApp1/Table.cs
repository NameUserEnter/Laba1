using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    enum Mode { Expression, Value }
    class Table
    {
        private int columnCount = 5;
        private int rowCount = 5;
        private DataGridView dataGridView;


        public static List<List<Cell>> cells = new List<List<Cell>>();

        public Table(DataGridView _dataGridView)
        {
            dataGridView = _dataGridView;
            cells.Clear();
            for (int i = 0; i < rowCount; i++)
            {
                cells.Add(new List<Cell>());
                for (int j = 0; j < columnCount; j++)
                {
                    cells[i].Add(new Cell() { RowNumber = i + 1, ColumnLetter = Convert.ToChar('A' + j) });
                }
            }
        }

        public void AddRow()
        {
            cells.Add(new List<Cell>());
            for (int j = 0; j < columnCount; j++)
            {
                cells[cells.Count - 1].Add(new Cell() { RowNumber = rowCount + 1, ColumnLetter = Convert.ToChar('A' + j) });
            }
            dataGridView.Rows.Add(1);
            dataGridView.Rows[dataGridView.Rows.Count - 1].HeaderCell.Value = (dataGridView.Rows.Count).ToString();
            rowCount++;
        }

        public void AddColumn()
        {
            if (columnCount > 25)
            {
                columnCount++;
                DataGridViewColumn column = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                column.CellTemplate = cell;
                column.Name = Class26BaseSys.ToSys(columnCount - 1);
                dataGridView.Columns.Add(column);
                dataGridView.Refresh();
            }
            else
            {
                for (int i = 0; i < rowCount; i++)
                {
                    cells[i].Add(new Cell() { RowNumber = i + 1, ColumnLetter = Convert.ToChar('A' + columnCount) });
                }
                dataGridView.Columns.Add(((char)('A' + columnCount)).ToString(), ((char)('A' + columnCount)).ToString());
                columnCount++;
            }
        }
        public void FillTable(Mode mode)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (char i = 'A'; i < 'A' + columnCount; i++)
                dataGridView.Columns.Add(i.ToString(), i.ToString());
            dataGridView.Rows.Add(rowCount);

            for (int i = 0; i < rowCount; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();

                for (int j = 0; j < columnCount; j++)
                {
                    if (cells[i][j].Expression != null)
                    {
                        if (cells[i][j].Error != null)
                            dataGridView.Rows[i].Cells[j].Value = cells[i][j].Error.ToString();
                        else
                            dataGridView.Rows[i].Cells[j].Value = mode == Mode.Expression ? cells[i][j].Expression.ToString() : cells[i][j].Value.ToString();
                    }
                }
            }
        }
        public static List<string> list = new List<string>();
        public void ChangeData(string expression, int row, int col)
        {

                cells[row][col].Expression = expression;
                cells[row][col].Value = Calculator.Evaluate(expression);
                cells[row][col].Error = null;
                if ((list.Count != 0)&&(list!=null) && (char.IsLetter(list[0][0])))
                   ChangeReference(expression, row, col);
                LabCalculatorVisitor.tableIdentifier[Class26BaseSys.ToSys(col) + (row + 1).ToString()] = cells[row][col].Value;
                RecalcReferenceCell(cells[row][col]);
            
        }
        public void ChangeReference(string expression, int row, int col)
        {
            foreach (var c in list)
            {
                var row1 = Int32.Parse(c[1].ToString()) - 1;
                var col1 = Class26BaseSys.FromSys(c[0].ToString());
                cells[row][col].References.Add(cells[row1][col1]);
            }
            list.Clear();
        }


        public void SaveToFile(string path)
        {
            StreamWriter stream = new StreamWriter(path);
            stream.WriteLine(rowCount);
            stream.WriteLine(columnCount);
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    if (cells[i][j].Expression != null)
                    {
                        stream.WriteLine(i); stream.WriteLine(j);
                        stream.WriteLine(cells[i][j].Expression);
                        stream.WriteLine(cells[i][j].Value);
                        if (cells[i][j].Error == null)
                            stream.WriteLine();
                        else
                            stream.WriteLine(cells[i][j].Error);
                    }
                }
            stream.Close();
        }
        public void OpenFile(string path)
        {
            Table table = new Table(dataGridView);
            table.FillTable(Mode.Value);
            StreamReader stream = new StreamReader(path);
            DataGridView fileDataGridview = new DataGridView(); 
            rowCount = Convert.ToInt32(stream.ReadLine()); 
            columnCount = Convert.ToInt32(stream.ReadLine()); 
            fileDataGridview.ColumnCount = columnCount; 
            fileDataGridview.RowCount = rowCount; string line;
            while ((line = stream.ReadLine()) != null)
            {
                int i = Convert.ToInt32(line);
                int j = Convert.ToInt32(stream.ReadLine());
                cells[i][j].Expression = stream.ReadLine();
                string v = stream.ReadLine();
                var r = Int32.Parse(v);
                cells[i][j].Value = r;
                string error = stream.ReadLine();
                if (!string.IsNullOrEmpty(error))
                {
                    cells[i][j].Error = error;
                }
                line = "";   
            }
            stream.Close();
        }
        public void RemoveRow()
        {
            dataGridView.Rows.RemoveAt(rowCount - 1);
            cells.RemoveAt(rowCount - 1);
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    foreach (var c in cells[i][j].References)
                        if (c.RowNumber == rowCount)
                        {
                            LabCalculatorVisitor.tableIdentifier.Remove(Class26BaseSys.ToSys(i) + (j + 1).ToString());
                            cells[i][j].Error = "error";
                            cells[i][j].Expression = null;
                            dataGridView.Rows[i].Cells[j].Value = "Error";
                        }
                }
            }
            rowCount--;
        }

        public void RemoveColumn()
        {
            dataGridView.Columns.RemoveAt(columnCount - 1);
            for (int i = 0; i < rowCount; i++)
            {
                cells[i].RemoveAt(columnCount - 1);
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount - 1; j++)
                {
                    foreach (var c in cells[i][j].References)
                    {
                        var col = Class26BaseSys.FromSys(c.ColumnLetter.ToString());
                        col = col + 1;
                        if (col == columnCount)
                        {
                            LabCalculatorVisitor.tableIdentifier.Remove(Class26BaseSys.ToSys(i) + (j + 1).ToString());
                            cells[i][j].Error = "error";
                            cells[i][j].Expression = null;
                            dataGridView.Rows[i].Cells[j].Value = "Error";
                        } 
                    }
                }
            }
            columnCount--;
        }

        void RecalcReferenceCell(Cell cell)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (cells[i][j].Expression != null)
                    {
                        for (int k = 0; k < cells[i][j].References.Count; k++)
                        {
                            if (cells[i][j].References[k].RowNumber == cell.RowNumber && cells[i][j].References[k].ColumnLetter == cell.ColumnLetter)
                            {
                                cells[i][j].Value = Calculator.Evaluate(cells[i][j].Expression);
                                cells[i][j].Error = null;
                                dataGridView.Rows[i].Cells[j].Value = cells[i][j].Value.ToString();
                                RecalcReferenceCell(cells[i][j]);
                            }
                        }
                    }
                }
            }
        }


    }
}
