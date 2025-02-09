namespace IgoraDemo.Forms
{
    partial class AdminAddEditForm
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
            this.igoraDataSet = new IgoraDemo.Models.IgoraDataSet();
            this.services_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.services_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.services_TableAdapter();
            this.tableAdapterManager = new IgoraDemo.Models.IgoraDataSetTableAdapters.TableAdapterManager();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.code_serviceTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.services_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // igoraDataSet
            // 
            this.igoraDataSet.DataSetName = "IgoraDataSet";
            this.igoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // services_BindingSource
            // 
            this.services_BindingSource.DataMember = "services$";
            this.services_BindingSource.DataSource = this.igoraDataSet;
            // 
            // services_TableAdapter
            // 
            this.services_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clients_TableAdapter = null;
            this.tableAdapterManager.enter_type_TableAdapter = null;
            this.tableAdapterManager.orders_TableAdapter = null;
            this.tableAdapterManager.posts_TableAdapter = null;
            this.tableAdapterManager.services_TableAdapter = this.services_TableAdapter;
            this.tableAdapterManager.statuses_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IgoraDemo.Models.IgoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.worker_TableAdapter = null;
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_BindingSource, "service", true));
            this.serviceTextBox.Location = new System.Drawing.Point(89, 20);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(188, 20);
            this.serviceTextBox.TabIndex = 7;
            // 
            // code_serviceTextBox
            // 
            this.code_serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_BindingSource, "code_service", true));
            this.code_serviceTextBox.Location = new System.Drawing.Point(89, 64);
            this.code_serviceTextBox.Name = "code_serviceTextBox";
            this.code_serviceTextBox.Size = new System.Drawing.Size(188, 20);
            this.code_serviceTextBox.TabIndex = 9;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_BindingSource, "cost", true));
            this.costTextBox.Location = new System.Drawing.Point(89, 105);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(188, 20);
            this.costTextBox.TabIndex = 11;
            // 
            // addEditBtn
            // 
            this.addEditBtn.Location = new System.Drawing.Point(12, 147);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(119, 23);
            this.addEditBtn.TabIndex = 12;
            this.addEditBtn.Text = "Сохранить";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(this.code_serviceTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddEditForm";
            this.Text = "AdminAddEditForm";
            this.Load += new System.EventHandler(this.AdminAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.services_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Models.IgoraDataSet igoraDataSet;
        private System.Windows.Forms.BindingSource services_BindingSource;
        private Models.IgoraDataSetTableAdapters.services_TableAdapter services_TableAdapter;
        private Models.IgoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.TextBox code_serviceTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Button button1;
    }
}