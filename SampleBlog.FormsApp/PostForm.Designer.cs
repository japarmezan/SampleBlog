namespace SampleBlog.FormsApp
{
    partial class PostForm
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
            this.richTextBoxPostText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post title";
            // 
            // richTextBoxPostText
            // 
            this.richTextBoxPostText.Location = new System.Drawing.Point(32, 61);
            this.richTextBoxPostText.Name = "richTextBoxPostText";
            this.richTextBoxPostText.Size = new System.Drawing.Size(512, 285);
            this.richTextBoxPostText.TabIndex = 1;
            this.richTextBoxPostText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(36, 408);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(508, 22);
            this.textBoxCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxPostText);
            this.Controls.Add(this.label1);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxPostText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label2;
    }
}