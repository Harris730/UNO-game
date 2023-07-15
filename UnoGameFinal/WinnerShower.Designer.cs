namespace UnoGameFinal
{
    partial class WinnerShower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerShower));
            this.DGW1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universDataSet = new UnoGameFinal.universDataSet();
            this.b_ExitThisForm = new System.Windows.Forms.Button();
            this.winnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uno_WinnersDataSet1 = new UnoGameFinal.Uno_WinnersDataSet1();
            this.uno_WinnersDataSet = new UnoGameFinal.Uno_WinnersDataSet();
            this.unoWinnersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unoWinnersDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.winnersTableAdapter = new UnoGameFinal.Uno_WinnersDataSet1TableAdapters.WinnersTableAdapter();
            this.winnersTableAdapter1 = new UnoGameFinal.universDataSetTableAdapters.WinnersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uno_WinnersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uno_WinnersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoWinnersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoWinnersDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW1
            // 
            this.DGW1.AllowUserToAddRows = false;
            this.DGW1.AllowUserToDeleteRows = false;
            this.DGW1.AllowUserToOrderColumns = true;
            this.DGW1.AutoGenerateColumns = false;
            this.DGW1.BackgroundColor = System.Drawing.Color.Tomato;
            this.DGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.DGW1.DataSource = this.winnersBindingSource1;
            this.DGW1.GridColor = System.Drawing.Color.IndianRed;
            this.DGW1.Location = new System.Drawing.Point(580, 180);
            this.DGW1.Margin = new System.Windows.Forms.Padding(4);
            this.DGW1.Name = "DGW1";
            this.DGW1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGW1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGW1.Size = new System.Drawing.Size(500, 229);
            this.DGW1.TabIndex = 0;
            this.DGW1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // winnersBindingSource1
            // 
            this.winnersBindingSource1.DataMember = "Winners";
            this.winnersBindingSource1.DataSource = this.universDataSet;
            // 
            // universDataSet
            // 
            this.universDataSet.DataSetName = "universDataSet";
            this.universDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_ExitThisForm
            // 
            this.b_ExitThisForm.BackColor = System.Drawing.Color.Transparent;
            this.b_ExitThisForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_ExitThisForm.FlatAppearance.BorderSize = 0;
            this.b_ExitThisForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_ExitThisForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_ExitThisForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ExitThisForm.Image = global::UnoGameFinal.Properties.Resources.Door1;
            this.b_ExitThisForm.Location = new System.Drawing.Point(1127, 441);
            this.b_ExitThisForm.Margin = new System.Windows.Forms.Padding(4);
            this.b_ExitThisForm.Name = "b_ExitThisForm";
            this.b_ExitThisForm.Size = new System.Drawing.Size(128, 63);
            this.b_ExitThisForm.TabIndex = 1;
            this.b_ExitThisForm.UseVisualStyleBackColor = false;
            this.b_ExitThisForm.Click += new System.EventHandler(this.b_ExitThisForm_Click);
            this.b_ExitThisForm.MouseLeave += new System.EventHandler(this.b_ExitThisForm_MouseLeave);
            this.b_ExitThisForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_ExitThisForm_MouseMove);
            // 
            // winnersBindingSource
            // 
            this.winnersBindingSource.DataMember = "Winners";
            this.winnersBindingSource.DataSource = this.uno_WinnersDataSet1;
            // 
            // uno_WinnersDataSet1
            // 
            this.uno_WinnersDataSet1.DataSetName = "Uno_WinnersDataSet1";
            this.uno_WinnersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uno_WinnersDataSet
            // 
            this.uno_WinnersDataSet.DataSetName = "Uno_WinnersDataSet";
            this.uno_WinnersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unoWinnersDataSetBindingSource
            // 
            this.unoWinnersDataSetBindingSource.DataSource = this.uno_WinnersDataSet;
            this.unoWinnersDataSetBindingSource.Position = 0;
            // 
            // unoWinnersDataSetBindingSource1
            // 
            this.unoWinnersDataSetBindingSource1.DataSource = this.uno_WinnersDataSet;
            this.unoWinnersDataSetBindingSource1.Position = 0;
            // 
            // winnersTableAdapter
            // 
            this.winnersTableAdapter.ClearBeforeFill = true;
            // 
            // winnersTableAdapter1
            // 
            this.winnersTableAdapter1.ClearBeforeFill = true;
            // 
            // WinnerShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnoGameFinal.Properties.Resources.Darkened_Uno_no_items_bg_high_resol3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 671);
            this.ControlBox = false;
            this.Controls.Add(this.b_ExitThisForm);
            this.Controls.Add(this.DGW1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WinnerShower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerShower";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinnerShower_FormClosed);
            this.Load += new System.EventHandler(this.WinnerShower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uno_WinnersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uno_WinnersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoWinnersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoWinnersDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW1;
        private System.Windows.Forms.BindingSource unoWinnersDataSetBindingSource1;
        private Uno_WinnersDataSet uno_WinnersDataSet;
        private System.Windows.Forms.BindingSource unoWinnersDataSetBindingSource;
        private Uno_WinnersDataSet1 uno_WinnersDataSet1;
        private System.Windows.Forms.BindingSource winnersBindingSource;
        private Uno_WinnersDataSet1TableAdapters.WinnersTableAdapter winnersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button b_ExitThisForm;
        private universDataSet universDataSet;
        private System.Windows.Forms.BindingSource winnersBindingSource1;
        private universDataSetTableAdapters.WinnersTableAdapter winnersTableAdapter1;
    }
}