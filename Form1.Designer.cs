namespace addname
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddItem = new Button();
            Remove = new Button();
            Change = new Button();
            Clear = new Button();
            textBox = new TextBox();
            ListBox1 = new ListBox();
            SuspendLayout();
            // 
            // AddItem
            // 
            AddItem.BackColor = Color.PaleGreen;
            AddItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddItem.Location = new Point(38, 64);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(94, 29);
            AddItem.TabIndex = 0;
            AddItem.Text = "Add";
            AddItem.UseVisualStyleBackColor = false;
            AddItem.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.BackColor = Color.PaleGreen;
            Remove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Remove.Location = new Point(38, 133);
            Remove.Name = "Remove";
            Remove.Size = new Size(94, 29);
            Remove.TabIndex = 1;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // Change
            // 
            Change.BackColor = Color.PaleGreen;
            Change.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Change.Location = new Point(38, 202);
            Change.Name = "Change";
            Change.Size = new Size(94, 29);
            Change.TabIndex = 2;
            Change.Text = "Change";
            Change.UseVisualStyleBackColor = false;
            Change.Click += Change_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.PaleGreen;
            Clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(38, 279);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.PaleGreen;
            textBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(296, 53);
            textBox.Name = "textBox";
            textBox.Size = new Size(269, 27);
            textBox.TabIndex = 4;
            // 
            // ListBox1
            // 
            ListBox1.BackColor = SystemColors.Control;
            ListBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 20;
            ListBox1.Location = new Point(298, 147);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(267, 164);
            ListBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(642, 450);
            Controls.Add(ListBox1);
            Controls.Add(textBox);
            Controls.Add(Clear);
            Controls.Add(Change);
            Controls.Add(Remove);
            Controls.Add(AddItem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddItem;
        private Button Remove;
        private Button Change;
        private Button Clear;
        private TextBox textBox;
        private ListBox ListBox1;
    }
}