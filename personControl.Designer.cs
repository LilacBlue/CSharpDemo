namespace DemoApp
{
    partial class personControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSearchPerson = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.panelDataForm = new System.Windows.Forms.Panel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.textRole = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textFName = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelEnterData = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelLogContent = new System.Windows.Forms.Label();
            this.panelDataForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchPerson
            // 
            this.buttonSearchPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearchPerson.FlatAppearance.BorderSize = 0;
            this.buttonSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPerson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchPerson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearchPerson.Location = new System.Drawing.Point(729, 123);
            this.buttonSearchPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchPerson.Name = "buttonSearchPerson";
            this.buttonSearchPerson.Size = new System.Drawing.Size(163, 80);
            this.buttonSearchPerson.TabIndex = 1;
            this.buttonSearchPerson.Text = "Search for a person";
            this.buttonSearchPerson.UseVisualStyleBackColor = false;
            this.buttonSearchPerson.Click += new System.EventHandler(this.ButtonSearchPerson_Click);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddPerson.FlatAppearance.BorderSize = 0;
            this.buttonAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPerson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddPerson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddPerson.Location = new System.Drawing.Point(729, 35);
            this.buttonAddPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(163, 80);
            this.buttonAddPerson.TabIndex = 0;
            this.buttonAddPerson.Text = "Add New Person";
            this.buttonAddPerson.UseVisualStyleBackColor = false;
            this.buttonAddPerson.Click += new System.EventHandler(this.ButtonAddPerson_Click);
            // 
            // panelDataForm
            // 
            this.panelDataForm.Controls.Add(this.buttonShowAll);
            this.panelDataForm.Controls.Add(this.textInfo);
            this.panelDataForm.Controls.Add(this.buttonSearchPerson);
            this.panelDataForm.Controls.Add(this.textRole);
            this.panelDataForm.Controls.Add(this.buttonAddPerson);
            this.panelDataForm.Controls.Add(this.textEmail);
            this.panelDataForm.Controls.Add(this.textLName);
            this.panelDataForm.Controls.Add(this.textFName);
            this.panelDataForm.Controls.Add(this.labelInfo);
            this.panelDataForm.Controls.Add(this.labelRole);
            this.panelDataForm.Controls.Add(this.labelEmail);
            this.panelDataForm.Controls.Add(this.labelLName);
            this.panelDataForm.Controls.Add(this.labelFName);
            this.panelDataForm.Location = new System.Drawing.Point(13, 46);
            this.panelDataForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDataForm.Name = "panelDataForm";
            this.panelDataForm.Size = new System.Drawing.Size(937, 342);
            this.panelDataForm.TabIndex = 6;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonShowAll.FlatAppearance.BorderSize = 0;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowAll.Location = new System.Drawing.Point(729, 211);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(163, 80);
            this.buttonShowAll.TabIndex = 2;
            this.buttonShowAll.Text = "Show everyone";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.ButtonShowAll_Click);
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(197, 209);
            this.textInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(492, 122);
            this.textInfo.TabIndex = 14;
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(197, 162);
            this.textRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(492, 22);
            this.textRole.TabIndex = 13;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(197, 121);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(492, 22);
            this.textEmail.TabIndex = 12;
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(197, 78);
            this.textLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(492, 22);
            this.textLName.TabIndex = 11;
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(197, 36);
            this.textFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(492, 22);
            this.textFName.TabIndex = 10;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(27, 206);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(155, 23);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Additional info:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRole.Location = new System.Drawing.Point(27, 164);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 23);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Role:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(27, 122);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 23);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "E-mail: ";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLName.Location = new System.Drawing.Point(27, 80);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(120, 23);
            this.labelLName.TabIndex = 6;
            this.labelLName.Text = "Last Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFName.Location = new System.Drawing.Point(27, 38);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(116, 23);
            this.labelFName.TabIndex = 5;
            this.labelFName.Text = "First Name:";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(45, 405);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(860, 146);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            // 
            // labelEnterData
            // 
            this.labelEnterData.AutoSize = true;
            this.labelEnterData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnterData.Location = new System.Drawing.Point(168, 18);
            this.labelEnterData.Name = "labelEnterData";
            this.labelEnterData.Size = new System.Drawing.Size(584, 22);
            this.labelEnterData.TabIndex = 15;
            this.labelEnterData.Text = "Enter data in order to add a new person or search for a person";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.Location = new System.Drawing.Point(660, 565);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(245, 56);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete the record";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLog.ForeColor = System.Drawing.Color.DimGray;
            this.labelLog.Location = new System.Drawing.Point(18, 588);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(42, 20);
            this.labelLog.TabIndex = 9;
            this.labelLog.Text = "Info:";
            // 
            // labelLogContent
            // 
            this.labelLogContent.AutoSize = true;
            this.labelLogContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogContent.ForeColor = System.Drawing.Color.DimGray;
            this.labelLogContent.Location = new System.Drawing.Point(69, 588);
            this.labelLogContent.Name = "labelLogContent";
            this.labelLogContent.Size = new System.Drawing.Size(0, 20);
            this.labelLogContent.TabIndex = 9;
            // 
            // personControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelEnterData);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelDataForm);
            this.Controls.Add(this.labelLogContent);
            this.Controls.Add(this.labelLog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "personControl";
            this.Size = new System.Drawing.Size(972, 640);
            this.panelDataForm.ResumeLayout(false);
            this.panelDataForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchPerson;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Panel panelDataForm;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelEnterData;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelLogContent;
    }
}
