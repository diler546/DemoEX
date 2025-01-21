namespace Shuler_MasterPol.AppForms
{
    partial class CreateUpdatePartnerForm
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
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label addressLabel;
            this.partnerNameLabel = new System.Windows.Forms.Label();
            this.partnerTypeIdLabel = new System.Windows.Forms.Label();
            this.ceoLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.partnerNameTextBox = new System.Windows.Forms.TextBox();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shuler_MasterPolDataSet = new Shuler_MasterPol.Shuler_MasterPolDataSet();
            this.partnerTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.partnerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ceoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.saveAttentionBackground = new System.Windows.Forms.Button();
            this.partnerTableAdapter = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.PartnerTableAdapter();
            this.tableAdapterManager = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.TableAdapterManager();
            this.partnerTypeTableAdapter1 = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.PartnerTypeTableAdapter();
            this.partnerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter = new Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.ProductTypeTableAdapter();
            this.partnerTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ratingLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuler_MasterPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // partnerNameLabel
            // 
            this.partnerNameLabel.AutoSize = true;
            this.partnerNameLabel.Location = new System.Drawing.Point(85, 34);
            this.partnerNameLabel.Name = "partnerNameLabel";
            this.partnerNameLabel.Size = new System.Drawing.Size(75, 13);
            this.partnerNameLabel.TabIndex = 14;
            this.partnerNameLabel.Text = "Partner Name:";
            // 
            // partnerTypeIdLabel
            // 
            this.partnerTypeIdLabel.AutoSize = true;
            this.partnerTypeIdLabel.Location = new System.Drawing.Point(85, 60);
            this.partnerTypeIdLabel.Name = "partnerTypeIdLabel";
            this.partnerTypeIdLabel.Size = new System.Drawing.Size(83, 13);
            this.partnerTypeIdLabel.TabIndex = 16;
            this.partnerTypeIdLabel.Text = "Partner Type Id:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(85, 87);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 18;
            ratingLabel.Text = "Rating:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(85, 113);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 20;
            addressLabel.Text = "Address:";
            // 
            // ceoLabel
            // 
            this.ceoLabel.AutoSize = true;
            this.ceoLabel.Location = new System.Drawing.Point(85, 139);
            this.ceoLabel.Name = "ceoLabel";
            this.ceoLabel.Size = new System.Drawing.Size(29, 13);
            this.ceoLabel.TabIndex = 22;
            this.ceoLabel.Text = "Ceo:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(85, 165);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 24;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(85, 191);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 26;
            this.emailLabel.Text = "Email:";
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
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(85, 20);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(102, 13);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "НОВЫЙ ПАРТНЕР";
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
            this.splitContainer.Panel2.Controls.Add(this.PhoneMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(this.partnerNameLabel);
            this.splitContainer.Panel2.Controls.Add(this.partnerNameTextBox);
            this.splitContainer.Panel2.Controls.Add(this.partnerTypeIdLabel);
            this.splitContainer.Panel2.Controls.Add(this.partnerTypeIdComboBox);
            this.splitContainer.Panel2.Controls.Add(ratingLabel);
            this.splitContainer.Panel2.Controls.Add(this.ratingTextBox);
            this.splitContainer.Panel2.Controls.Add(addressLabel);
            this.splitContainer.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer.Panel2.Controls.Add(this.ceoLabel);
            this.splitContainer.Panel2.Controls.Add(this.ceoTextBox);
            this.splitContainer.Panel2.Controls.Add(this.phoneLabel);
            this.splitContainer.Panel2.Controls.Add(this.emailLabel);
            this.splitContainer.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer.Panel2.Controls.Add(this.saveAttentionBackground);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainer.Size = new System.Drawing.Size(384, 389);
            this.splitContainer.SplitterDistance = 77;
            this.splitContainer.TabIndex = 2;
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Phone", true));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(174, 163);
            this.PhoneMaskedTextBox.Mask = "+0 000 000 00 00";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.PhoneMaskedTextBox.TabIndex = 28;
            // 
            // partnerNameTextBox
            // 
            this.partnerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "PartnerName", true));
            this.partnerNameTextBox.Location = new System.Drawing.Point(174, 31);
            this.partnerNameTextBox.Name = "partnerNameTextBox";
            this.partnerNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.partnerNameTextBox.TabIndex = 15;
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "Partner";
            this.partnerBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // shuler_MasterPolDataSet
            // 
            this.shuler_MasterPolDataSet.DataSetName = "Shuler_MasterPolDataSet";
            this.shuler_MasterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerTypeIdComboBox
            // 
            this.partnerTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partnerBindingSource, "PartnerTypeId", true));
            this.partnerTypeIdComboBox.DataSource = this.partnerTypeBindingSource1;
            this.partnerTypeIdComboBox.DisplayMember = "PartnerTypeName";
            this.partnerTypeIdComboBox.FormattingEnabled = true;
            this.partnerTypeIdComboBox.Location = new System.Drawing.Point(174, 57);
            this.partnerTypeIdComboBox.Name = "partnerTypeIdComboBox";
            this.partnerTypeIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.partnerTypeIdComboBox.TabIndex = 17;
            this.partnerTypeIdComboBox.ValueMember = "IdPartnerType";
            // 
            // partnerBindingSource1
            // 
            this.partnerBindingSource1.DataMember = "Partner";
            this.partnerBindingSource1.DataSource = this.shuler_MasterPolDataSet;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(174, 84);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(121, 20);
            this.ratingTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(174, 110);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 21;
            // 
            // ceoTextBox
            // 
            this.ceoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Ceo", true));
            this.ceoTextBox.Location = new System.Drawing.Point(174, 136);
            this.ceoTextBox.Name = "ceoTextBox";
            this.ceoTextBox.Size = new System.Drawing.Size(121, 20);
            this.ceoTextBox.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(174, 188);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 27;
            // 
            // saveAttentionBackground
            // 
            this.saveAttentionBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveAttentionBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.saveAttentionBackground.Location = new System.Drawing.Point(21, 236);
            this.saveAttentionBackground.Name = "saveAttentionBackground";
            this.saveAttentionBackground.Size = new System.Drawing.Size(345, 47);
            this.saveAttentionBackground.TabIndex = 14;
            this.saveAttentionBackground.Text = "Сохранить";
            this.saveAttentionBackground.UseVisualStyleBackColor = false;
            this.saveAttentionBackground.Click += new System.EventHandler(this.SaveAttentionBackground_Click);
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Material_typeTableAdapter = null;
            this.tableAdapterManager.PartnerProductTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = this.partnerTableAdapter;
            this.tableAdapterManager.PartnerTypeTableAdapter = this.partnerTypeTableAdapter1;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partnerTypeTableAdapter1
            // 
            this.partnerTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // partnerTypeBindingSource
            // 
            this.partnerTypeBindingSource.DataMember = "PartnerType";
            this.partnerTypeBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.shuler_MasterPolDataSet;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // partnerTypeBindingSource1
            // 
            this.partnerTypeBindingSource1.DataMember = "PartnerType";
            this.partnerTypeBindingSource1.DataSource = this.shuler_MasterPolDataSet;
            // 
            // CreateUpdatePartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 389);
            this.Controls.Add(this.splitContainer);
            this.Name = "CreateUpdatePartnerForm";
            this.Text = "CreateUpdatePartnerForm";
            this.Load += new System.EventHandler(this.CreateUpdatePartnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuler_MasterPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button saveAttentionBackground;
        private Shuler_MasterPolDataSet shuler_MasterPolDataSet;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private Shuler_MasterPolDataSetTableAdapters.PartnerTableAdapter partnerTableAdapter;
        private Shuler_MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox partnerNameTextBox;
        private System.Windows.Forms.ComboBox partnerTypeIdComboBox;
        private System.Windows.Forms.BindingSource partnerBindingSource1;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ceoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private Shuler_MasterPolDataSetTableAdapters.PartnerTypeTableAdapter partnerTypeTableAdapter1;
        private System.Windows.Forms.Label partnerNameLabel;
        private System.Windows.Forms.Label partnerTypeIdLabel;
        private System.Windows.Forms.Label ceoLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.BindingSource partnerTypeBindingSource;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private Shuler_MasterPolDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.BindingSource partnerTypeBindingSource1;
    }
}