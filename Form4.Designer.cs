namespace Code_Snippet_Manager
{
    partial class Form4
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.search_b = new System.Windows.Forms.Button();
            this.home_b = new System.Windows.Forms.Button();
            this.search_result_listbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.preview_snippet_b = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.title_lbl.Location = new System.Drawing.Point(12, 57);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(99, 28);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Enter Title";
            // 
            // title_txt
            // 
            this.title_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_txt.Location = new System.Drawing.Point(116, 57);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(114, 20);
            this.title_txt.TabIndex = 1;
            // 
            // search_b
            // 
            this.search_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_b.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.search_b.Location = new System.Drawing.Point(151, 83);
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(79, 41);
            this.search_b.TabIndex = 2;
            this.search_b.Text = "Search";
            this.search_b.UseVisualStyleBackColor = true;
            this.search_b.Click += new System.EventHandler(this.search_b_Click);
            // 
            // home_b
            // 
            this.home_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_b.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold);
            this.home_b.Location = new System.Drawing.Point(12, 4);
            this.home_b.Name = "home_b";
            this.home_b.Size = new System.Drawing.Size(75, 40);
            this.home_b.TabIndex = 3;
            this.home_b.Text = "HOME";
            this.home_b.UseVisualStyleBackColor = true;
            this.home_b.Click += new System.EventHandler(this.home_b_Click);
            // 
            // search_result_listbox
            // 
            this.search_result_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_result_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_result_listbox.FormattingEnabled = true;
            this.search_result_listbox.ItemHeight = 16;
            this.search_result_listbox.Location = new System.Drawing.Point(258, 52);
            this.search_result_listbox.Name = "search_result_listbox";
            this.search_result_listbox.Size = new System.Drawing.Size(113, 148);
            this.search_result_listbox.TabIndex = 4;
            this.search_result_listbox.Click += new System.EventHandler(this.search_result_listbox_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(130, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Snippet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // preview_snippet_b
            // 
            this.preview_snippet_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview_snippet_b.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_snippet_b.Location = new System.Drawing.Point(12, 151);
            this.preview_snippet_b.Name = "preview_snippet_b";
            this.preview_snippet_b.Size = new System.Drawing.Size(112, 61);
            this.preview_snippet_b.TabIndex = 6;
            this.preview_snippet_b.Text = "Preview Full Screen";
            this.preview_snippet_b.UseVisualStyleBackColor = true;
            this.preview_snippet_b.Click += new System.EventHandler(this.preview_snippet_b_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 238);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(258, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "All Snippets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.preview_snippet_b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_result_listbox);
            this.Controls.Add(this.home_b);
            this.Controls.Add(this.search_b);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.title_lbl);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Button search_b;
        private System.Windows.Forms.Button home_b;
        private System.Windows.Forms.ListBox search_result_listbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button preview_snippet_b;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
    }
}