namespace WindowsFormsApp1
{
    partial class todoList
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
            this.addButton = new System.Windows.Forms.Button();
            this.taskHolder = new System.Windows.Forms.DataGridView();
            this.Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskCompletedHolder = new System.Windows.Forms.DataGridView();
            this.completedTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearLabel = new System.Windows.Forms.Label();
            this.completeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.taskHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskCompletedHolder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(172, 111);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 39);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // taskHolder
            // 
            this.taskHolder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taskHolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tasks});
            this.taskHolder.Location = new System.Drawing.Point(35, 190);
            this.taskHolder.Name = "taskHolder";
            this.taskHolder.Size = new System.Drawing.Size(240, 403);
            this.taskHolder.TabIndex = 1;
            this.taskHolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskHolder_CellContentClick);
            // 
            // Tasks
            // 
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.Name = "Tasks";
            this.Tasks.Width = 240;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(30, 82);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(213, 26);
            this.taskLabel.TabIndex = 2;
            this.taskLabel.Text = "Enter your task here.";
            // 
            // taskBox
            // 
            this.taskBox.Location = new System.Drawing.Point(35, 121);
            this.taskBox.Name = "taskBox";
            this.taskBox.Size = new System.Drawing.Size(131, 20);
            this.taskBox.TabIndex = 3;
            this.taskBox.TextChanged += new System.EventHandler(this.taskBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "To-Do List";
            // 
            // taskCompletedHolder
            // 
            this.taskCompletedHolder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskCompletedHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskCompletedHolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.completedTasks});
            this.taskCompletedHolder.Location = new System.Drawing.Point(470, 190);
            this.taskCompletedHolder.Name = "taskCompletedHolder";
            this.taskCompletedHolder.Size = new System.Drawing.Size(240, 403);
            this.taskCompletedHolder.TabIndex = 5;
            this.taskCompletedHolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskCompletedHolder_CellContentClick);
            // 
            // completedTasks
            // 
            this.completedTasks.HeaderText = "Completed Tasks";
            this.completedTasks.Name = "completedTasks";
            this.completedTasks.Width = 240;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(607, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 39);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLabel.Location = new System.Drawing.Point(454, 82);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(283, 26);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "Clear completed tasks here.";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(307, 290);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(129, 58);
            this.completeButton.TabIndex = 8;
            this.completeButton.Text = "Mark Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // todoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 605);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.taskCompletedHolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.taskHolder);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "todoList";
            this.Text = "To-Do List";
            ((System.ComponentModel.ISupportInitialize)(this.taskHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskCompletedHolder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView taskHolder;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.TextBox taskBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView taskCompletedHolder;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedTasks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

