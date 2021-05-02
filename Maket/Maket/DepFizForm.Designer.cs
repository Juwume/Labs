namespace Maket
{
    partial class DepFizForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PatTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smallBankDataSet = new Maket.SmallBankDataSet();
            this.smallBankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладыTableAdapter = new Maket.SmallBankDataSetTableAdapters.ВкладыTableAdapter();
            this.iDВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОткрытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТарифаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.физическиеЛицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.физические_лицаTableAdapter = new Maket.SmallBankDataSetTableAdapters.Физические_лицаTableAdapter();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическиеЛицаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(451, 116);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 42);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SurTextBox
            // 
            this.SurTextBox.Location = new System.Drawing.Point(86, 126);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.Size = new System.Drawing.Size(169, 22);
            this.SurTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(86, 180);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(169, 22);
            this.NameTextBox.TabIndex = 5;
            // 
            // PatTextBox
            // 
            this.PatTextBox.Location = new System.Drawing.Point(86, 236);
            this.PatTextBox.Name = "PatTextBox";
            this.PatTextBox.Size = new System.Drawing.Size(169, 22);
            this.PatTextBox.TabIndex = 6;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(587, 116);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(139, 42);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Закрыть форму";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВкладаDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.датаОткрытияDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn,
            this.iDТарифаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.вкладыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smallBankDataSetBindingSource
            // 
            this.smallBankDataSetBindingSource.DataSource = this.smallBankDataSet;
            this.smallBankDataSetBindingSource.Position = 0;
            // 
            // вкладыBindingSource
            // 
            this.вкладыBindingSource.DataMember = "Вклады";
            this.вкладыBindingSource.DataSource = this.smallBankDataSetBindingSource;
            // 
            // вкладыTableAdapter
            // 
            this.вкладыTableAdapter.ClearBeforeFill = true;
            // 
            // iDВкладаDataGridViewTextBoxColumn
            // 
            this.iDВкладаDataGridViewTextBoxColumn.DataPropertyName = "ID вклада";
            this.iDВкладаDataGridViewTextBoxColumn.HeaderText = "ID вклада";
            this.iDВкладаDataGridViewTextBoxColumn.Name = "iDВкладаDataGridViewTextBoxColumn";
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // датаОткрытияDataGridViewTextBoxColumn
            // 
            this.датаОткрытияDataGridViewTextBoxColumn.DataPropertyName = "Дата открытия";
            this.датаОткрытияDataGridViewTextBoxColumn.HeaderText = "Дата открытия";
            this.датаОткрытияDataGridViewTextBoxColumn.Name = "датаОткрытияDataGridViewTextBoxColumn";
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            // 
            // iDТарифаDataGridViewTextBoxColumn
            // 
            this.iDТарифаDataGridViewTextBoxColumn.DataPropertyName = "ID тарифа";
            this.iDТарифаDataGridViewTextBoxColumn.HeaderText = "ID тарифа";
            this.iDТарифаDataGridViewTextBoxColumn.Name = "iDТарифаDataGridViewTextBoxColumn";
            // 
            // физическиеЛицаBindingSource
            // 
            this.физическиеЛицаBindingSource.DataMember = "Физические лица";
            this.физическиеЛицаBindingSource.DataSource = this.smallBankDataSetBindingSource;
            // 
            // физические_лицаTableAdapter
            // 
            this.физические_лицаTableAdapter.ClearBeforeFill = true;
            // 
            // IdComboBox
            // 
            this.IdComboBox.DataSource = this.физическиеЛицаBindingSource;
            this.IdComboBox.DisplayMember = "ID клиента";
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(86, 52);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(121, 24);
            this.IdComboBox.TabIndex = 10;
            this.IdComboBox.TextChanged += new System.EventHandler(this.IdComboBox_TextChanged);
            // 
            // DepFizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 531);
            this.Controls.Add(this.IdComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PatTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepFizForm";
            this.Text = "DCFizFace";
            this.Load += new System.EventHandler(this.DepFizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическиеЛицаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SurTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource smallBankDataSetBindingSource;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource вкладыBindingSource;
        private SmallBankDataSetTableAdapters.ВкладыTableAdapter вкладыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОткрытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТарифаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource физическиеЛицаBindingSource;
        private SmallBankDataSetTableAdapters.Физические_лицаTableAdapter физические_лицаTableAdapter;
        private System.Windows.Forms.ComboBox IdComboBox;
    }
}