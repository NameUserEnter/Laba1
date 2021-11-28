
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddRow = new System.Windows.Forms.Button();
            this.AddCol = new System.Windows.Forms.Button();
            this.DelRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DelCol = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(296, 22);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(106, 23);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Обрахувати";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(698, 283);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // AddRow
            // 
            this.AddRow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddRow.Location = new System.Drawing.Point(467, 27);
            this.AddRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(26, 26);
            this.AddRow.TabIndex = 4;
            this.AddRow.Text = "+";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // AddCol
            // 
            this.AddCol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCol.Location = new System.Drawing.Point(588, 27);
            this.AddCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCol.Name = "AddCol";
            this.AddCol.Size = new System.Drawing.Size(26, 26);
            this.AddCol.TabIndex = 5;
            this.AddCol.Text = "+";
            this.AddCol.UseVisualStyleBackColor = true;
            this.AddCol.Click += new System.EventHandler(this.AddCol_Click);
            // 
            // DelRow
            // 
            this.DelRow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelRow.Location = new System.Drawing.Point(499, 27);
            this.DelRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelRow.Name = "DelRow";
            this.DelRow.Size = new System.Drawing.Size(26, 26);
            this.DelRow.TabIndex = 6;
            this.DelRow.Text = "-";
            this.DelRow.UseVisualStyleBackColor = true;
            this.DelRow.Click += new System.EventHandler(this.DelRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(467, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Рядок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(588, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Стовпчик";
            // 
            // DelCol
            // 
            this.DelCol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelCol.Location = new System.Drawing.Point(641, 27);
            this.DelCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelCol.Name = "DelCol";
            this.DelCol.Size = new System.Drawing.Size(26, 26);
            this.DelCol.TabIndex = 9;
            this.DelCol.Text = "-";
            this.DelCol.UseVisualStyleBackColor = true;
            this.DelCol.Click += new System.EventHandler(this.DelCol_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.проToolStripMenuItem,
            this.довідкаToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проToolStripMenuItem.Text = "Про";
            this.проToolStripMenuItem.Click += new System.EventHandler(this.проToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem1
            // 
            this.довідкаToolStripMenuItem1.Name = "довідкаToolStripMenuItem1";
            this.довідкаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.довідкаToolStripMenuItem1.Text = "Довідка";
            this.довідкаToolStripMenuItem1.Click += new System.EventHandler(this.довідкаToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.DelCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelRow);
            this.Controls.Add(this.AddCol);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Button AddCol;
        private System.Windows.Forms.Button DelRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelCol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem1;
    }
}

