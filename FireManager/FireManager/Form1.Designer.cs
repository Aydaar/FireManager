namespace FireManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.QueryBox = new System.Windows.Forms.RichTextBox();
            this.OpenQueryBtn = new System.Windows.Forms.Button();
            this.SaveQueryBtn = new System.Windows.Forms.Button();
            this.QueryGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.QueryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(-3, 135);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(819, 432);
            this.DataGrid.TabIndex = 0;
            // 
            // QueryBox
            // 
            this.QueryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryBox.Location = new System.Drawing.Point(97, 18);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(439, 97);
            this.QueryBox.TabIndex = 1;
            this.QueryBox.Text = "";
            // 
            // OpenQueryBtn
            // 
            this.OpenQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenQueryBtn.Location = new System.Drawing.Point(16, 18);
            this.OpenQueryBtn.Name = "OpenQueryBtn";
            this.OpenQueryBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenQueryBtn.TabIndex = 2;
            this.OpenQueryBtn.Text = "Open";
            this.OpenQueryBtn.UseVisualStyleBackColor = true;
            // 
            // SaveQueryBtn
            // 
            this.SaveQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveQueryBtn.Location = new System.Drawing.Point(16, 48);
            this.SaveQueryBtn.Name = "SaveQueryBtn";
            this.SaveQueryBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveQueryBtn.TabIndex = 3;
            this.SaveQueryBtn.Text = "Save";
            this.SaveQueryBtn.UseVisualStyleBackColor = true;
            // 
            // QueryGroupBox
            // 
            this.QueryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryGroupBox.Controls.Add(this.SaveQueryBtn);
            this.QueryGroupBox.Controls.Add(this.QueryBox);
            this.QueryGroupBox.Controls.Add(this.OpenQueryBtn);
            this.QueryGroupBox.Location = new System.Drawing.Point(266, 5);
            this.QueryGroupBox.Name = "QueryGroupBox";
            this.QueryGroupBox.Size = new System.Drawing.Size(550, 124);
            this.QueryGroupBox.TabIndex = 4;
            this.QueryGroupBox.TabStop = false;
            this.QueryGroupBox.Text = "Query";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 579);
            this.Controls.Add(this.QueryGroupBox);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.QueryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.RichTextBox QueryBox;
        private System.Windows.Forms.Button OpenQueryBtn;
        private System.Windows.Forms.Button SaveQueryBtn;
        private System.Windows.Forms.GroupBox QueryGroupBox;
    }
}

