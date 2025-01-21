namespace Shuler_MasterPol.CustomControls
{
    partial class PartnerUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeAndName = new System.Windows.Forms.Label();
            this.ceo = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.historyAttentionBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeAndName
            // 
            this.typeAndName.AutoSize = true;
            this.typeAndName.Location = new System.Drawing.Point(20, 20);
            this.typeAndName.Margin = new System.Windows.Forms.Padding(0);
            this.typeAndName.Name = "typeAndName";
            this.typeAndName.Size = new System.Drawing.Size(112, 13);
            this.typeAndName.TabIndex = 0;
            this.typeAndName.Text = "Тип и наименование";
            this.typeAndName.Click += new System.EventHandler(this.PartnerUserControl_Click);
            // 
            // ceo
            // 
            this.ceo.AutoSize = true;
            this.ceo.Location = new System.Drawing.Point(20, 47);
            this.ceo.Margin = new System.Windows.Forms.Padding(0);
            this.ceo.Name = "ceo";
            this.ceo.Size = new System.Drawing.Size(57, 13);
            this.ceo.TabIndex = 1;
            this.ceo.Text = "Директор";
            this.ceo.Click += new System.EventHandler(this.PartnerUserControl_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(20, 74);
            this.phone.Margin = new System.Windows.Forms.Padding(0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(52, 13);
            this.phone.TabIndex = 2;
            this.phone.Text = "Телефон";
            this.phone.Click += new System.EventHandler(this.PartnerUserControl_Click);
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(20, 99);
            this.rating.Margin = new System.Windows.Forms.Padding(0);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(48, 13);
            this.rating.TabIndex = 3;
            this.rating.Text = "Рейтинг";
            this.rating.Click += new System.EventHandler(this.PartnerUserControl_Click);
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(674, 20);
            this.discount.Margin = new System.Windows.Forms.Padding(0);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(112, 13);
            this.discount.TabIndex = 4;
            this.discount.Text = "Скидка";
            this.discount.Click += new System.EventHandler(this.PartnerUserControl_Click);
            // 
            // historyAttentionBackground
            // 
            this.historyAttentionBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.historyAttentionBackground.Location = new System.Drawing.Point(640, 84);
            this.historyAttentionBackground.Name = "historyAttentionBackground";
            this.historyAttentionBackground.Size = new System.Drawing.Size(75, 23);
            this.historyAttentionBackground.TabIndex = 5;
            this.historyAttentionBackground.Text = "История";
            this.historyAttentionBackground.UseVisualStyleBackColor = false;
            this.historyAttentionBackground.Click += new System.EventHandler(this.historyAttentionBackground_Click);
            // 
            // PartnerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.historyAttentionBackground);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.ceo);
            this.Controls.Add(this.typeAndName);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "PartnerUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(738, 130);
            this.Load += new System.EventHandler(this.PartnerUserControl_Load);
            this.Click += new System.EventHandler(this.PartnerUserControl_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PartnerUserControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeAndName;
        private System.Windows.Forms.Label ceo;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Button historyAttentionBackground;
    }
}
