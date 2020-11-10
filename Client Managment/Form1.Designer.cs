namespace Client_Managment
{
    partial class ClientManagment_Form
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
            this.label_ClientManagmet = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surename = new System.Windows.Forms.Label();
            this.label_Location = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surename = new System.Windows.Forms.TextBox();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.DataGridView_ClientList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ClientList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ClientManagmet
            // 
            this.label_ClientManagmet.AutoSize = true;
            this.label_ClientManagmet.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientManagmet.Location = new System.Drawing.Point(14, 16);
            this.label_ClientManagmet.Name = "label_ClientManagmet";
            this.label_ClientManagmet.Size = new System.Drawing.Size(438, 60);
            this.label_ClientManagmet.TabIndex = 0;
            this.label_ClientManagmet.Text = "Διαχείρηση Πελατών";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client.Location = new System.Drawing.Point(3, 41);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(81, 25);
            this.label_Client.TabIndex = 1;
            this.label_Client.Text = "Πελάτης";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label_ClientManagmet);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 104);
            this.panel1.TabIndex = 2;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(39, 105);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(58, 18);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Όνομα:";
            // 
            // label_Surename
            // 
            this.label_Surename.AutoSize = true;
            this.label_Surename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Surename.Location = new System.Drawing.Point(28, 137);
            this.label_Surename.Name = "label_Surename";
            this.label_Surename.Size = new System.Drawing.Size(67, 18);
            this.label_Surename.TabIndex = 4;
            this.label_Surename.Text = "Επίθετο:";
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Location.Location = new System.Drawing.Point(11, 169);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(86, 18);
            this.label_Location.TabIndex = 5;
            this.label_Location.Text = "Τοποθεσία:";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Company.Location = new System.Drawing.Point(5, 201);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(90, 18);
            this.label_Company.TabIndex = 6;
            this.label_Company.Text = "Επιχείρηση:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(100, 102);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(193, 26);
            this.textBox_Name.TabIndex = 7;
            // 
            // textBox_Surename
            // 
            this.textBox_Surename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Surename.Location = new System.Drawing.Point(99, 134);
            this.textBox_Surename.Name = "textBox_Surename";
            this.textBox_Surename.Size = new System.Drawing.Size(193, 26);
            this.textBox_Surename.TabIndex = 8;
            // 
            // textBox_Location
            // 
            this.textBox_Location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Location.Location = new System.Drawing.Point(99, 166);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.Size = new System.Drawing.Size(193, 26);
            this.textBox_Location.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Update);
            this.panel2.Controls.Add(this.button_Add);
            this.panel2.Controls.Add(this.comboBox_Company);
            this.panel2.Controls.Add(this.label_Client);
            this.panel2.Controls.Add(this.label_Company);
            this.panel2.Controls.Add(this.textBox_Location);
            this.panel2.Controls.Add(this.label_Location);
            this.panel2.Controls.Add(this.label_Name);
            this.panel2.Controls.Add(this.label_Surename);
            this.panel2.Controls.Add(this.textBox_Surename);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 377);
            this.panel2.TabIndex = 10;
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(3, 287);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(158, 42);
            this.button_Update.TabIndex = 16;
            this.button_Update.Text = "Ανανέωση";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(172, 287);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(158, 42);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "Προσθήκη";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Company.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Items.AddRange(new object[] {
            "Σούπερ Μάρκετ",
            "Μίνι Μάρκετ",
            "Περίπτερο"});
            this.comboBox_Company.Location = new System.Drawing.Point(98, 198);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(194, 26);
            this.comboBox_Company.TabIndex = 10;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(6, 438);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(327, 42);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Εκκαθάρηση Στοιχείων";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // DataGridView_ClientList
            // 
            this.DataGridView_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataGridView_ClientList.Location = new System.Drawing.Point(2, 44);
            this.DataGridView_ClientList.Name = "DataGridView_ClientList";
            this.DataGridView_ClientList.Size = new System.Drawing.Size(445, 404);
            this.DataGridView_ClientList.TabIndex = 11;
            this.DataGridView_ClientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClientList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Όνομα";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Επίθετο";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Τοποθεσία";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Επιχείρηση";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_Search);
            this.panel3.Controls.Add(this.button_Exit);
            this.panel3.Controls.Add(this.button_Delete);
            this.panel3.Controls.Add(this.textBox_Search);
            this.panel3.Controls.Add(this.DataGridView_ClientList);
            this.panel3.Location = new System.Drawing.Point(340, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 496);
            this.panel3.TabIndex = 12;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(302, 451);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(144, 42);
            this.button_Exit.TabIndex = 15;
            this.button_Exit.Text = "Έξοδος";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(3, 451);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(144, 42);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Διαγραφή";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(90, 12);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(357, 26);
            this.textBox_Search.TabIndex = 13;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(3, 15);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(85, 18);
            this.label_Search.TabIndex = 16;
            this.label_Search.Text = "Αναζήτηση:";
            // 
            // ClientManagment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 619);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientManagment_Form";
            this.Load += new System.EventHandler(this.ClientManagment_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ClientList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ClientManagmet;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surename;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surename;
        private System.Windows.Forms.TextBox textBox_Location;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView DataGridView_ClientList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label_Search;
    }
}

