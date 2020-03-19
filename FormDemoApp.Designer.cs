namespace DemoApp
{
    partial class FormDemoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemoApp));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.todolistimg = new System.Windows.Forms.PictureBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonTasks = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.personControl1 = new DemoApp.personControl();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todolistimg)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPanel.Controls.Add(this.panelOrange);
            this.leftPanel.Controls.Add(this.todolistimg);
            this.leftPanel.Controls.Add(this.buttonView);
            this.leftPanel.Controls.Add(this.buttonTasks);
            this.leftPanel.Controls.Add(this.buttonUsers);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(195, 640);
            this.leftPanel.TabIndex = 0;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(0, 126);
            this.panelOrange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(15, 58);
            this.panelOrange.TabIndex = 1;
            // 
            // todolistimg
            // 
            this.todolistimg.Image = ((System.Drawing.Image)(resources.GetObject("todolistimg.Image")));
            this.todolistimg.Location = new System.Drawing.Point(0, 22);
            this.todolistimg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todolistimg.Name = "todolistimg";
            this.todolistimg.Size = new System.Drawing.Size(195, 94);
            this.todolistimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.todolistimg.TabIndex = 1;
            this.todolistimg.TabStop = false;
            // 
            // buttonView
            // 
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonView.Location = new System.Drawing.Point(0, 242);
            this.buttonView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(191, 58);
            this.buttonView.TabIndex = 0;
            this.buttonView.Text = "Board view";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // buttonTasks
            // 
            this.buttonTasks.FlatAppearance.BorderSize = 0;
            this.buttonTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTasks.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonTasks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTasks.Location = new System.Drawing.Point(0, 185);
            this.buttonTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(191, 58);
            this.buttonTasks.TabIndex = 0;
            this.buttonTasks.Text = "Tasks";
            this.buttonTasks.UseVisualStyleBackColor = true;
            this.buttonTasks.Click += new System.EventHandler(this.ButtonTasks_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUsers.Location = new System.Drawing.Point(0, 126);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(191, 58);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // personControl1
            // 
            this.personControl1.BackColor = System.Drawing.Color.SandyBrown;
            this.personControl1.Location = new System.Drawing.Point(198, 3);
            this.personControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personControl1.Name = "personControl1";
            this.personControl1.Size = new System.Drawing.Size(972, 640);
            this.personControl1.TabIndex = 1;
            // 
            // FormDemoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1167, 640);
            this.Controls.Add(this.personControl1);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDemoApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo App";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todolistimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.PictureBox todolistimg;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonTasks;
        private System.Windows.Forms.Panel panelOrange;
        private personControl personControl1;
    }
}

