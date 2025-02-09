namespace IgoraDemo.Forms
{
    partial class ManagerClientsForm
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
            this.igoraDataSet = new IgoraDemo.Models.IgoraDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.orders_TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddClient = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enter_type_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.enter_type_TableAdapter();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clients_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.clients_TableAdapter();
            this.entertypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statuses_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.statuses_TableAdapter();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entertypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // igoraDataSet
            // 
            this.igoraDataSet.DataSetName = "IgoraDataSet";
            this.igoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders$";
            this.ordersBindingSource.DataSource = this.igoraDataSet;
            // 
            // orders_TableAdapter
            // 
            this.orders_TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.pasportDataGridViewTextBoxColumn,
            this.borndateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(866, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "statuses$";
            this.statusesBindingSource.DataSource = this.igoraDataSet;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.SearchTb);
            this.splitContainer1.Panel1.Controls.Add(this.AddClient);
            this.splitContainer1.Panel1.Controls.Add(this.BackBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(866, 590);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // AddClient
            // 
            this.AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.AddClient.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClient.Location = new System.Drawing.Point(523, 100);
            this.AddClient.Margin = new System.Windows.Forms.Padding(4);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(182, 32);
            this.AddClient.TabIndex = 7;
            this.AddClient.Text = "Добавить клиента";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.BackBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(713, 100);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(140, 32);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клиенты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IgoraDemo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // enter_type_TableAdapter
            // 
            this.enter_type_TableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients$";
            this.clientsBindingSource1.DataSource = this.igoraDataSet;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients$";
            this.clientsBindingSource.DataSource = this.igoraDataSet;
            // 
            // clients_TableAdapter
            // 
            this.clients_TableAdapter.ClearBeforeFill = true;
            // 
            // entertypeBindingSource
            // 
            this.entertypeBindingSource.DataMember = "enter_type$";
            this.entertypeBindingSource.DataSource = this.igoraDataSet;
            // 
            // statuses_TableAdapter
            // 
            this.statuses_TableAdapter.ClearBeforeFill = true;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Visible = false;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasportDataGridViewTextBoxColumn
            // 
            this.pasportDataGridViewTextBoxColumn.DataPropertyName = "pasport";
            this.pasportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.pasportDataGridViewTextBoxColumn.Name = "pasportDataGridViewTextBoxColumn";
            this.pasportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borndateDataGridViewTextBoxColumn
            // 
            this.borndateDataGridViewTextBoxColumn.DataPropertyName = "born_date";
            this.borndateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.borndateDataGridViewTextBoxColumn.Name = "borndateDataGridViewTextBoxColumn";
            this.borndateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(523, 54);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(331, 26);
            this.SearchTb.TabIndex = 8;
            this.SearchTb.TextChanged += new System.EventHandler(this.SearchTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Поиск";
            // 
            // ManagerClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 590);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ManagerClientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ManagerClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entertypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Models.IgoraDataSet igoraDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Models.IgoraDataSetTableAdapters.orders_TableAdapter orders_TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Models.IgoraDataSetTableAdapters.enter_type_TableAdapter enter_type_TableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Models.IgoraDataSetTableAdapters.clients_TableAdapter clients_TableAdapter;
        private System.Windows.Forms.BindingSource entertypeBindingSource;
        private Models.IgoraDataSetTableAdapters.statuses_TableAdapter statuses_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTb;
    }
}