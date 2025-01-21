namespace Shuler_MasterPol.AppForms
{
    partial class HistoryForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.partner_productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shuler_MasterPolDataSet = new Shuler_MasterPol.Shuler_MasterPolDataSet();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partner_productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner_productsTableAdapter = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.PartnerProductTableAdapter();
            this.tableAdapterManager = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.ProductTableAdapter();
            this.shulerMasterPolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuler_MasterPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shulerMasterPolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.titleLabelAttentionFont);
            this.splitContainer.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.partner_productsDataGridView);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 90;
            this.splitContainer.TabIndex = 1;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(85, 20);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(113, 13);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "ИСТОРИЯ ПРОДАЖ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shuler_MasterPol.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // partner_productsDataGridView
            // 
            this.partner_productsDataGridView.AllowUserToAddRows = false;
            this.partner_productsDataGridView.AllowUserToDeleteRows = false;
            this.partner_productsDataGridView.AutoGenerateColumns = false;
            this.partner_productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partner_productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partner_productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.partner_productsDataGridView.DataSource = this.partnerProductBindingSource;
            this.partner_productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partner_productsDataGridView.Location = new System.Drawing.Point(20, 0);
            this.partner_productsDataGridView.Name = "partner_productsDataGridView";
            this.partner_productsDataGridView.ReadOnly = true;
            this.partner_productsDataGridView.Size = new System.Drawing.Size(760, 336);
            this.partner_productsDataGridView.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productIdDataGridViewTextBoxColumn.DisplayMember = "ProductName";
            this.productIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Продукция";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIdDataGridViewTextBoxColumn.ValueMember = "IdProduct";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // shuler_MasterPolDataSet
            // 
            this.shuler_MasterPolDataSet.DataSetName = "Shuler_MasterPolDataSet";
            this.shuler_MasterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partner_productsBindingSource
            // 
            this.partner_productsBindingSource.DataMember = "PartnerProduct";
            this.partner_productsBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Product";
            this.productsBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // partner_productsTableAdapter
            // 
            this.partner_productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Material_typeTableAdapter = null;
            this.tableAdapterManager.PartnerProductTableAdapter = this.partner_productsTableAdapter;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.PartnerTypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // shulerMasterPolDataSetBindingSource
            // 
            this.shulerMasterPolDataSetBindingSource.DataSource = this.shuler_MasterPolDataSet;
            this.shulerMasterPolDataSetBindingSource.Position = 0;
            // 
            // partnerProductBindingSource
            // 
            this.partnerProductBindingSource.DataMember = "PartnerProduct";
            this.partnerProductBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuler_MasterPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shulerMasterPolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Shuler_MasterPolDataSet shuler_MasterPolDataSet;
        private System.Windows.Forms.BindingSource partner_productsBindingSource;
        private Shuler_MasterPolDataSetTableAdapters.PartnerProductTableAdapter partner_productsTableAdapter;
        private Shuler_MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Shuler_MasterPolDataSetTableAdapters.ProductTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource shulerMasterPolDataSetBindingSource;
        private System.Windows.Forms.DataGridView partner_productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerProductBindingSource;
    }
}