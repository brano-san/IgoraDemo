namespace IgoraDemo.Forms
{
    partial class ManagerAddClientForm
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
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label pasportLabel;
            System.Windows.Forms.Label born_dateLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label ratingLabel;
            this.statuses_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.statuses_TableAdapter();
            this.entertypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igoraDataSet = new IgoraDemo.Models.IgoraDataSet();
            this.clients_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.clients_TableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enter_type_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.enter_type_TableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pasportTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.born_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.orders_TableAdapter = new IgoraDemo.Models.IgoraDataSetTableAdapters.orders_TableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new IgoraDemo.Models.IgoraDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            fioLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            pasportLabel = new System.Windows.Forms.Label();
            born_dateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entertypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Location = new System.Drawing.Point(81, 33);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(36, 18);
            fioLabel.TabIndex = 2;
            fioLabel.Text = "ФИО";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(85, 65);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(32, 18);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Код";
            // 
            // pasportLabel
            // 
            pasportLabel.AutoSize = true;
            pasportLabel.Location = new System.Drawing.Point(57, 97);
            pasportLabel.Name = "pasportLabel";
            pasportLabel.Size = new System.Drawing.Size(63, 18);
            pasportLabel.TabIndex = 6;
            pasportLabel.Text = "Паспорт";
            // 
            // born_dateLabel
            // 
            born_dateLabel.AutoSize = true;
            born_dateLabel.Location = new System.Drawing.Point(17, 132);
            born_dateLabel.Name = "born_dateLabel";
            born_dateLabel.Size = new System.Drawing.Size(103, 18);
            born_dateLabel.TabIndex = 8;
            born_dateLabel.Text = "Дата рождения";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(71, 161);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(46, 18);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Адрес";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(68, 193);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 18);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Почта";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(60, 225);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 18);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Пароль";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(60, 257);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(57, 18);
            ratingLabel.TabIndex = 16;
            ratingLabel.Text = "Рейтинг";
            // 
            // statuses_TableAdapter
            // 
            this.statuses_TableAdapter.ClearBeforeFill = true;
            // 
            // entertypeBindingSource
            // 
            this.entertypeBindingSource.DataMember = "enter_type$";
            this.entertypeBindingSource.DataSource = this.igoraDataSet;
            // 
            // igoraDataSet
            // 
            this.igoraDataSet.DataSetName = "IgoraDataSet";
            this.igoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clients_TableAdapter
            // 
            this.clients_TableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients$";
            this.clientsBindingSource.DataSource = this.igoraDataSet;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients$";
            this.clientsBindingSource1.DataSource = this.igoraDataSet;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "statuses$";
            this.statusesBindingSource.DataSource = this.igoraDataSet;
            // 
            // enter_type_TableAdapter
            // 
            this.enter_type_TableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.BackBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(224, 69);
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
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление клиента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IgoraDemo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.BackBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pasportTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.AddBtn);
            this.splitContainer1.Panel2.Controls.Add(fioLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fioTextBox);
            this.splitContainer1.Panel2.Controls.Add(codeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.codeTextBox);
            this.splitContainer1.Panel2.Controls.Add(pasportLabel);
            this.splitContainer1.Panel2.Controls.Add(born_dateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.born_dateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(addressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer1.Panel2.Controls.Add(emailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel2.Controls.Add(passwordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passwordTextBox);
            this.splitContainer1.Panel2.Controls.Add(ratingLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ratingTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(377, 466);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 5;
            // 
            // pasportTextBox
            // 
            this.pasportTextBox.Location = new System.Drawing.Point(137, 94);
            this.pasportTextBox.Mask = "Серия 0000 Номер 000000";
            this.pasportTextBox.Name = "pasportTextBox";
            this.pasportTextBox.Size = new System.Drawing.Size(200, 26);
            this.pasportTextBox.TabIndex = 18;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.AddBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(118, 292);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(140, 32);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(137, 30);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(200, 26);
            this.fioTextBox.TabIndex = 3;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(137, 62);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(200, 26);
            this.codeTextBox.TabIndex = 5;
            // 
            // born_dateDateTimePicker
            // 
            this.born_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "born_date", true));
            this.born_dateDateTimePicker.Location = new System.Drawing.Point(137, 126);
            this.born_dateDateTimePicker.Name = "born_dateDateTimePicker";
            this.born_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.born_dateDateTimePicker.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(137, 158);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 26);
            this.addressTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(137, 190);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 26);
            this.emailTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(137, 222);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 26);
            this.passwordTextBox.TabIndex = 15;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(137, 254);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 26);
            this.ratingTextBox.TabIndex = 17;
            // 
            // orders_TableAdapter
            // 
            this.orders_TableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders$";
            this.ordersBindingSource.DataSource = this.igoraDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clients_TableAdapter = this.clients_TableAdapter;
            this.tableAdapterManager.enter_type_TableAdapter = this.enter_type_TableAdapter;
            this.tableAdapterManager.orders_TableAdapter = this.orders_TableAdapter;
            this.tableAdapterManager.posts_TableAdapter = null;
            this.tableAdapterManager.services_TableAdapter = null;
            this.tableAdapterManager.statuses_TableAdapter = this.statuses_TableAdapter;
            this.tableAdapterManager.UpdateOrder = IgoraDemo.Models.IgoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.worker_TableAdapter = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "1";
            this.label2.Visible = false;
            // 
            // ManagerAddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 466);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(393, 505);
            this.Name = "ManagerAddClientForm";
            this.Text = "Добавление клиента";
            ((System.ComponentModel.ISupportInitialize)(this.entertypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Models.IgoraDataSetTableAdapters.statuses_TableAdapter statuses_TableAdapter;
        private System.Windows.Forms.BindingSource entertypeBindingSource;
        private Models.IgoraDataSet igoraDataSet;
        private Models.IgoraDataSetTableAdapters.clients_TableAdapter clients_TableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private Models.IgoraDataSetTableAdapters.enter_type_TableAdapter enter_type_TableAdapter;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.DateTimePicker born_dateDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private Models.IgoraDataSetTableAdapters.orders_TableAdapter orders_TableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Models.IgoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox pasportTextBox;
        private System.Windows.Forms.Label label2;
    }
}