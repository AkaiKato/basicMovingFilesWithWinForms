namespace lab3HM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.backFromButton = new System.Windows.Forms.Button();
            this.backToButton = new System.Windows.Forms.Button();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Location = new System.Drawing.Point(12, 46);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fromListBox.Size = new System.Drawing.Size(1006, 225);
            this.fromListBox.TabIndex = 0;
            this.fromListBox.DoubleClick += new System.EventHandler(this.fromListBox_DoubleClick);
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Location = new System.Drawing.Point(12, 355);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(1006, 225);
            this.toListBox.TabIndex = 1;
            this.toListBox.DoubleClick += new System.EventHandler(this.toListBox_DoubleClick);
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.moveButton.Location = new System.Drawing.Point(12, 277);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(1006, 38);
            this.moveButton.TabIndex = 2;
            this.moveButton.Text = "↓";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // backFromButton
            // 
            this.backFromButton.Image = ((System.Drawing.Image)(resources.GetObject("backFromButton.Image")));
            this.backFromButton.Location = new System.Drawing.Point(12, 12);
            this.backFromButton.Name = "backFromButton";
            this.backFromButton.Size = new System.Drawing.Size(29, 28);
            this.backFromButton.TabIndex = 3;
            this.backFromButton.UseVisualStyleBackColor = true;
            this.backFromButton.Click += new System.EventHandler(this.backFromButton_Click);
            // 
            // backToButton
            // 
            this.backToButton.Image = ((System.Drawing.Image)(resources.GetObject("backToButton.Image")));
            this.backToButton.Location = new System.Drawing.Point(12, 321);
            this.backToButton.Name = "backToButton";
            this.backToButton.Size = new System.Drawing.Size(29, 28);
            this.backToButton.TabIndex = 4;
            this.backToButton.UseVisualStyleBackColor = true;
            this.backToButton.Click += new System.EventHandler(this.backToButton_Click);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fromTextBox.Location = new System.Drawing.Point(47, 13);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(971, 27);
            this.fromTextBox.TabIndex = 5;
            this.fromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromTextBox_KeyPress);
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.toTextBox.Location = new System.Drawing.Point(47, 322);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(971, 27);
            this.toTextBox.TabIndex = 6;
            this.toTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 595);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.backToButton);
            this.Controls.Add(this.backFromButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.toListBox);
            this.Controls.Add(this.fromListBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "lab3hm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button backFromButton;
        private System.Windows.Forms.Button backToButton;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
    }
}

