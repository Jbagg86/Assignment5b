namespace Assignment5b
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            personDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource1 = new BindingSource(components);
            saveButton = new Button();
            personBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)personDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // personDataGridView
            // 
            personDataGridView.AllowUserToOrderColumns = true;
            personDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            personDataGridView.AutoGenerateColumns = false;
            personDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            personDataGridView.DataSource = personBindingSource;
            personDataGridView.Location = new Point(82, 48);
            personDataGridView.Name = "personDataGridView";
            personDataGridView.Size = new Size(406, 318);
            personDataGridView.TabIndex = 0;
            personDataGridView.CellContentClick += personDataGridView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // personBindingSource1
            // 
            personBindingSource1.DataSource = typeof(Person);
            // 
            // saveButton
            // 
            saveButton.Location = new Point(260, 394);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 448);
            Controls.Add(saveButton);
            Controls.Add(personDataGridView);
            Name = "MainForm";
            Text = "Assignment5b";
            Load += MainForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)personDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personDataGridView;
        private Button saveButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private BindingSource personBindingSource1;
        private BindingSource personBindingSource;
    }
}
