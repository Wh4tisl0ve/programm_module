
namespace Nauch
{
    partial class Sposob2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коэффициентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаОчередиАвтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьКмчDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уравнениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sposob2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new Nauch.Database2DataSet();
            this.sposob2TableAdapter = new Nauch.Database2DataSetTableAdapters.Sposob2TableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sposob2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с БД";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(341, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код для удаления";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(226, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(118, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(7, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 57);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(840, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "↩";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 308);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "2 способ организации движения";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-1, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 361);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.n1DataGridViewTextBoxColumn,
            this.n2DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.t2DataGridViewTextBoxColumn,
            this.коэффициентDataGridViewTextBoxColumn,
            this.длинаОчередиАвтDataGridViewTextBoxColumn,
            this.скоростьКмчDataGridViewTextBoxColumn,
            this.уравнениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sposob2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 50;
            // 
            // n1DataGridViewTextBoxColumn
            // 
            this.n1DataGridViewTextBoxColumn.DataPropertyName = "N1";
            this.n1DataGridViewTextBoxColumn.HeaderText = "N1";
            this.n1DataGridViewTextBoxColumn.Name = "n1DataGridViewTextBoxColumn";
            this.n1DataGridViewTextBoxColumn.Width = 80;
            // 
            // n2DataGridViewTextBoxColumn
            // 
            this.n2DataGridViewTextBoxColumn.DataPropertyName = "N2";
            this.n2DataGridViewTextBoxColumn.HeaderText = "N2";
            this.n2DataGridViewTextBoxColumn.Name = "n2DataGridViewTextBoxColumn";
            this.n2DataGridViewTextBoxColumn.Width = 80;
            // 
            // t1DataGridViewTextBoxColumn
            // 
            this.t1DataGridViewTextBoxColumn.DataPropertyName = "t1";
            this.t1DataGridViewTextBoxColumn.HeaderText = "t1";
            this.t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            this.t1DataGridViewTextBoxColumn.Width = 80;
            // 
            // t2DataGridViewTextBoxColumn
            // 
            this.t2DataGridViewTextBoxColumn.DataPropertyName = "t2";
            this.t2DataGridViewTextBoxColumn.HeaderText = "t2";
            this.t2DataGridViewTextBoxColumn.Name = "t2DataGridViewTextBoxColumn";
            this.t2DataGridViewTextBoxColumn.Width = 80;
            // 
            // коэффициентDataGridViewTextBoxColumn
            // 
            this.коэффициентDataGridViewTextBoxColumn.DataPropertyName = "Коэффициент";
            this.коэффициентDataGridViewTextBoxColumn.HeaderText = "Коэффициент";
            this.коэффициентDataGridViewTextBoxColumn.Name = "коэффициентDataGridViewTextBoxColumn";
            this.коэффициентDataGridViewTextBoxColumn.Width = 80;
            // 
            // длинаОчередиАвтDataGridViewTextBoxColumn
            // 
            this.длинаОчередиАвтDataGridViewTextBoxColumn.DataPropertyName = "Длина очереди, авт";
            this.длинаОчередиАвтDataGridViewTextBoxColumn.HeaderText = "Длина очереди, авт";
            this.длинаОчередиАвтDataGridViewTextBoxColumn.Name = "длинаОчередиАвтDataGridViewTextBoxColumn";
            this.длинаОчередиАвтDataGridViewTextBoxColumn.Width = 80;
            // 
            // скоростьКмчDataGridViewTextBoxColumn
            // 
            this.скоростьКмчDataGridViewTextBoxColumn.DataPropertyName = "Скорость, км/ч";
            this.скоростьКмчDataGridViewTextBoxColumn.HeaderText = "Скорость, км/ч";
            this.скоростьКмчDataGridViewTextBoxColumn.Name = "скоростьКмчDataGridViewTextBoxColumn";
            this.скоростьКмчDataGridViewTextBoxColumn.Width = 80;
            // 
            // уравнениеDataGridViewTextBoxColumn
            // 
            this.уравнениеDataGridViewTextBoxColumn.DataPropertyName = "Уравнение";
            this.уравнениеDataGridViewTextBoxColumn.HeaderText = "Уравнение";
            this.уравнениеDataGridViewTextBoxColumn.Name = "уравнениеDataGridViewTextBoxColumn";
            this.уравнениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // sposob2BindingSource
            // 
            this.sposob2BindingSource.DataMember = "Sposob2";
            this.sposob2BindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sposob2TableAdapter
            // 
            this.sposob2TableAdapter.ClearBeforeFill = true;
            // 
            // Sposob2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sposob2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sposob2";
            this.Load += new System.EventHandler(this.Sposob2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sposob2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource sposob2BindingSource;
        private Database2DataSetTableAdapters.Sposob2TableAdapter sposob2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коэффициентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаОчередиАвтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьКмчDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уравнениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}