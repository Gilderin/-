namespace АРМ_Менеджера_гостиницы
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.clientsRefreshGridButton = new System.Windows.Forms.Button();
            this.clientsUpdateDbButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.paymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.RoomsUpdateBdButton = new System.Windows.Forms.Button();
            this.RoomsRefreshGridButton = new System.Windows.Forms.Button();
            this.EmployeesUpdateBdButton = new System.Windows.Forms.Button();
            this.EmployeesRefreshGridButton = new System.Windows.Forms.Button();
            this.PaymentsUpdateBdButton = new System.Windows.Forms.Button();
            this.PaymentsRefreshGridButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 572);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer2.Size = new System.Drawing.Size(781, 540);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToOrderColumns = true;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.Size = new System.Drawing.Size(517, 172);
            this.roomsDataGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(781, 540);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.clientsDataGridView);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.clientsRefreshGridButton);
            this.splitContainer5.Panel2.Controls.Add(this.clientsUpdateDbButton);
            this.splitContainer5.Size = new System.Drawing.Size(517, 540);
            this.splitContainer5.SplitterDistance = 401;
            this.splitContainer5.TabIndex = 0;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToOrderColumns = true;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(517, 401);
            this.clientsDataGridView.TabIndex = 0;
            // 
            // clientsRefreshGridButton
            // 
            this.clientsRefreshGridButton.Location = new System.Drawing.Point(361, 50);
            this.clientsRefreshGridButton.Name = "clientsRefreshGridButton";
            this.clientsRefreshGridButton.Size = new System.Drawing.Size(124, 40);
            this.clientsRefreshGridButton.TabIndex = 1;
            this.clientsRefreshGridButton.Text = "Обновить таблицу";
            this.clientsRefreshGridButton.UseVisualStyleBackColor = true;
            this.clientsRefreshGridButton.Click += new System.EventHandler(this.clientsRefreshGridButton_Click);
            // 
            // clientsUpdateDbButton
            // 
            this.clientsUpdateDbButton.Location = new System.Drawing.Point(53, 50);
            this.clientsUpdateDbButton.Name = "clientsUpdateDbButton";
            this.clientsUpdateDbButton.Size = new System.Drawing.Size(118, 40);
            this.clientsUpdateDbButton.TabIndex = 0;
            this.clientsUpdateDbButton.Text = "Обновить базу";
            this.clientsUpdateDbButton.UseVisualStyleBackColor = true;
            this.clientsUpdateDbButton.Click += new System.EventHandler(this.clientsUpdateDbButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(787, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employees";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer3.Size = new System.Drawing.Size(787, 546);
            this.splitContainer3.SplitterDistance = 262;
            this.splitContainer3.TabIndex = 0;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToOrderColumns = true;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(521, 378);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(787, 546);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Payment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer4.Size = new System.Drawing.Size(787, 546);
            this.splitContainer4.SplitterDistance = 262;
            this.splitContainer4.TabIndex = 0;
            // 
            // paymentsDataGridView
            // 
            this.paymentsDataGridView.AllowUserToOrderColumns = true;
            this.paymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.paymentsDataGridView.Name = "paymentsDataGridView";
            this.paymentsDataGridView.Size = new System.Drawing.Size(521, 173);
            this.paymentsDataGridView.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.roomsDataGridView);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.RoomsRefreshGridButton);
            this.splitContainer6.Panel2.Controls.Add(this.RoomsUpdateBdButton);
            this.splitContainer6.Size = new System.Drawing.Size(517, 540);
            this.splitContainer6.SplitterDistance = 172;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.employeesDataGridView);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.EmployeesRefreshGridButton);
            this.splitContainer7.Panel2.Controls.Add(this.EmployeesUpdateBdButton);
            this.splitContainer7.Size = new System.Drawing.Size(521, 546);
            this.splitContainer7.SplitterDistance = 378;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.paymentsDataGridView);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.PaymentsRefreshGridButton);
            this.splitContainer8.Panel2.Controls.Add(this.PaymentsUpdateBdButton);
            this.splitContainer8.Size = new System.Drawing.Size(521, 546);
            this.splitContainer8.SplitterDistance = 173;
            this.splitContainer8.TabIndex = 0;
            // 
            // RoomsUpdateBdButton
            // 
            this.RoomsUpdateBdButton.Location = new System.Drawing.Point(38, 18);
            this.RoomsUpdateBdButton.Name = "RoomsUpdateBdButton";
            this.RoomsUpdateBdButton.Size = new System.Drawing.Size(118, 40);
            this.RoomsUpdateBdButton.TabIndex = 1;
            this.RoomsUpdateBdButton.Text = "Обновить базу";
            this.RoomsUpdateBdButton.UseVisualStyleBackColor = true;
            this.RoomsUpdateBdButton.Click += new System.EventHandler(this.RoomsUpdateBdButton_Click);
            // 
            // RoomsRefreshGridButton
            // 
            this.RoomsRefreshGridButton.Location = new System.Drawing.Point(278, 18);
            this.RoomsRefreshGridButton.Name = "RoomsRefreshGridButton";
            this.RoomsRefreshGridButton.Size = new System.Drawing.Size(118, 40);
            this.RoomsRefreshGridButton.TabIndex = 2;
            this.RoomsRefreshGridButton.Text = "Обновить таблицу";
            this.RoomsRefreshGridButton.UseVisualStyleBackColor = true;
            this.RoomsRefreshGridButton.Click += new System.EventHandler(this.RoomsRefreshGridButton_Click);
            // 
            // EmployeesUpdateBdButton
            // 
            this.EmployeesUpdateBdButton.Location = new System.Drawing.Point(25, 65);
            this.EmployeesUpdateBdButton.Name = "EmployeesUpdateBdButton";
            this.EmployeesUpdateBdButton.Size = new System.Drawing.Size(118, 40);
            this.EmployeesUpdateBdButton.TabIndex = 2;
            this.EmployeesUpdateBdButton.Text = "Обновить базу";
            this.EmployeesUpdateBdButton.UseVisualStyleBackColor = true;
            this.EmployeesUpdateBdButton.Click += new System.EventHandler(this.EmployeesUpdateBdButton_Click);
            // 
            // EmployeesRefreshGridButton
            // 
            this.EmployeesRefreshGridButton.Location = new System.Drawing.Point(321, 65);
            this.EmployeesRefreshGridButton.Name = "EmployeesRefreshGridButton";
            this.EmployeesRefreshGridButton.Size = new System.Drawing.Size(118, 40);
            this.EmployeesRefreshGridButton.TabIndex = 3;
            this.EmployeesRefreshGridButton.Text = "Обновить таблицу";
            this.EmployeesRefreshGridButton.UseVisualStyleBackColor = true;
            this.EmployeesRefreshGridButton.Click += new System.EventHandler(this.EmployeesRefreshGridButton_Click);
            // 
            // PaymentsUpdateBdButton
            // 
            this.PaymentsUpdateBdButton.Location = new System.Drawing.Point(51, 41);
            this.PaymentsUpdateBdButton.Name = "PaymentsUpdateBdButton";
            this.PaymentsUpdateBdButton.Size = new System.Drawing.Size(118, 40);
            this.PaymentsUpdateBdButton.TabIndex = 3;
            this.PaymentsUpdateBdButton.Text = "Обновить базу";
            this.PaymentsUpdateBdButton.UseVisualStyleBackColor = true;
            // 
            // PaymentsRefreshGridButton
            // 
            this.PaymentsRefreshGridButton.Location = new System.Drawing.Point(327, 41);
            this.PaymentsRefreshGridButton.Name = "PaymentsRefreshGridButton";
            this.PaymentsRefreshGridButton.Size = new System.Drawing.Size(118, 40);
            this.PaymentsRefreshGridButton.TabIndex = 4;
            this.PaymentsRefreshGridButton.Text = "Обновить таблицу";
            this.PaymentsRefreshGridButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button clientsRefreshGridButton;
        private System.Windows.Forms.Button clientsUpdateDbButton;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button RoomsRefreshGridButton;
        private System.Windows.Forms.Button RoomsUpdateBdButton;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button EmployeesRefreshGridButton;
        private System.Windows.Forms.Button EmployeesUpdateBdButton;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button PaymentsRefreshGridButton;
        private System.Windows.Forms.Button PaymentsUpdateBdButton;
    }
}