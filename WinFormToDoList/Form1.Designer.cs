namespace WinFormToDoList
{
    partial class toDoMainform
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
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.todoLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.todoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 29;
            this.todoListBox.Location = new System.Drawing.Point(33, 62);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(506, 352);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.DoubleClick += new System.EventHandler(this.todoListBox_DoubleClick);
            this.todoListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todoListBox_KeyDown);
            this.todoListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.todoListBox_KeyPress);
            this.todoListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.todoListBox_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToDo List";
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Location = new System.Drawing.Point(700, 140);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(182, 29);
            this.todoLabel.TabIndex = 2;
            this.todoLabel.Text = "New ToDo Item";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(705, 238);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(255, 57);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add ToDo Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(575, 199);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 35);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(575, 238);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 35);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // todoText
            // 
            this.todoText.Location = new System.Drawing.Point(705, 186);
            this.todoText.Name = "todoText";
            this.todoText.Size = new System.Drawing.Size(255, 34);
            this.todoText.TabIndex = 6;
            // 
            // toDoMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 471);
            this.Controls.Add(this.todoText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todoListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "toDoMainform";
            this.Text = "ToDo List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox todoText;
    }
}

