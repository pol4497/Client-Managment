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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_Label = new System.Windows.Forms.Label();
            this.surename_Label = new System.Windows.Forms.Label();
            this.location_Label = new System.Windows.Forms.Label();
            this.company_Label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.surename_textBox = new System.Windows.Forms.TextBox();
            this.location_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.location_comboBox = new System.Windows.Forms.ComboBox();
            this.ClientList_DataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.search_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList_DataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Διαχείρηση Πελατών";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Πελάτης";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 77);
            this.panel1.TabIndex = 2;
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Label.Location = new System.Drawing.Point(36, 123);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(58, 18);
            this.name_Label.TabIndex = 3;
            this.name_Label.Text = "Όνομα:";
            // 
            // surename_Label
            // 
            this.surename_Label.AutoSize = true;
            this.surename_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surename_Label.Location = new System.Drawing.Point(27, 149);
            this.surename_Label.Name = "surename_Label";
            this.surename_Label.Size = new System.Drawing.Size(67, 18);
            this.surename_Label.TabIndex = 4;
            this.surename_Label.Text = "Επίθετο:";
            // 
            // location_Label
            // 
            this.location_Label.AutoSize = true;
            this.location_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_Label.Location = new System.Drawing.Point(8, 175);
            this.location_Label.Name = "location_Label";
            this.location_Label.Size = new System.Drawing.Size(86, 18);
            this.location_Label.TabIndex = 5;
            this.location_Label.Text = "Τοποθεσία:";
            // 
            // company_Label
            // 
            this.company_Label.AutoSize = true;
            this.company_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_Label.Location = new System.Drawing.Point(5, 201);
            this.company_Label.Name = "company_Label";
            this.company_Label.Size = new System.Drawing.Size(90, 18);
            this.company_Label.TabIndex = 6;
            this.company_Label.Text = "Επιχείρηση:";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(100, 124);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(193, 20);
            this.name_textBox.TabIndex = 7;
            // 
            // surename_textBox
            // 
            this.surename_textBox.Location = new System.Drawing.Point(100, 150);
            this.surename_textBox.Name = "surename_textBox";
            this.surename_textBox.Size = new System.Drawing.Size(193, 20);
            this.surename_textBox.TabIndex = 8;
            // 
            // location_textBox
            // 
            this.location_textBox.Location = new System.Drawing.Point(100, 176);
            this.location_textBox.Name = "location_textBox";
            this.location_textBox.Size = new System.Drawing.Size(193, 20);
            this.location_textBox.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clear_Button);
            this.panel2.Controls.Add(this.add_Button);
            this.panel2.Controls.Add(this.location_comboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.company_Label);
            this.panel2.Controls.Add(this.location_textBox);
            this.panel2.Controls.Add(this.location_Label);
            this.panel2.Controls.Add(this.name_Label);
            this.panel2.Controls.Add(this.surename_Label);
            this.panel2.Controls.Add(this.surename_textBox);
            this.panel2.Controls.Add(this.name_textBox);
            this.panel2.Location = new System.Drawing.Point(1, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 362);
            this.panel2.TabIndex = 10;
            // 
            // location_comboBox
            // 
            this.location_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_comboBox.FormattingEnabled = true;
            this.location_comboBox.Items.AddRange(new object[] {
            "",
            "Σούπερ Μάρκετ",
            "Μίνι Μάρκετ",
            "Περίπτερο"});
            this.location_comboBox.Location = new System.Drawing.Point(99, 202);
            this.location_comboBox.Name = "location_comboBox";
            this.location_comboBox.Size = new System.Drawing.Size(194, 21);
            this.location_comboBox.TabIndex = 10;
            this.location_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClientList_DataGridView
            // 
            this.ClientList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientList_DataGridView.Location = new System.Drawing.Point(3, 41);
            this.ClientList_DataGridView.Name = "ClientList_DataGridView";
            this.ClientList_DataGridView.Size = new System.Drawing.Size(444, 404);
            this.ClientList_DataGridView.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.update_Button);
            this.panel3.Controls.Add(this.exit_Button);
            this.panel3.Controls.Add(this.delete_Button);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.search_Label);
            this.panel3.Controls.Add(this.ClientList_DataGridView);
            this.panel3.Location = new System.Drawing.Point(340, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 496);
            this.panel3.TabIndex = 12;
            // 
            // search_Label
            // 
            this.search_Label.AutoSize = true;
            this.search_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Label.Location = new System.Drawing.Point(3, 15);
            this.search_Label.Name = "search_Label";
            this.search_Label.Size = new System.Drawing.Size(85, 18);
            this.search_Label.TabIndex = 12;
            this.search_Label.Text = "Αναζήτηση:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 20);
            this.textBox1.TabIndex = 13;
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(3, 451);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(144, 42);
            this.delete_Button.TabIndex = 14;
            this.delete_Button.Text = "Διαγραφή";
            this.delete_Button.UseVisualStyleBackColor = true;
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(303, 451);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(144, 42);
            this.exit_Button.TabIndex = 15;
            this.exit_Button.Text = "Έξοδος";
            this.exit_Button.UseVisualStyleBackColor = true;
            // 
            // add_Button
            // 
            this.add_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Button.Location = new System.Drawing.Point(186, 317);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(144, 42);
            this.add_Button.TabIndex = 11;
            this.add_Button.Text = "Προσθήκη";
            this.add_Button.UseVisualStyleBackColor = true;
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(4, 317);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(144, 42);
            this.clear_Button.TabIndex = 12;
            this.clear_Button.Text = "Εκκαθάρηση Στοιχείων";
            this.clear_Button.UseVisualStyleBackColor = true;
            // 
            // update_Button
            // 
            this.update_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Button.Location = new System.Drawing.Point(153, 451);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(144, 42);
            this.update_Button.TabIndex = 16;
            this.update_Button.Text = "Ανανέωση";
            this.update_Button.UseVisualStyleBackColor = true;
            // 
            // ClientManagment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientManagment_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList_DataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label surename_Label;
        private System.Windows.Forms.Label location_Label;
        private System.Windows.Forms.Label company_Label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox surename_textBox;
        private System.Windows.Forms.TextBox location_textBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox location_comboBox;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.DataGridView ClientList_DataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label search_Label;
    }
}

