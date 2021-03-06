﻿namespace Code_Snippet_Manager
{
    partial class Form3
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
            this.home_b = new System.Windows.Forms.Button();
            this.search_b = new System.Windows.Forms.Button();
            this.snippet_name_lbl = new System.Windows.Forms.Label();
            this.search_result_lbl = new System.Windows.Forms.Label();
            this.search_result_listbox = new System.Windows.Forms.ListBox();
            this.snippetname_txt = new System.Windows.Forms.TextBox();
            this.copy_clipboard_b = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // home_b
            // 
            this.home_b.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_b.Location = new System.Drawing.Point(12, 12);
            this.home_b.Name = "home_b";
            this.home_b.Size = new System.Drawing.Size(75, 32);
            this.home_b.TabIndex = 0;
            this.home_b.Text = "HOME";
            this.home_b.UseVisualStyleBackColor = true;
            this.home_b.Click += new System.EventHandler(this.home_b_Click);
            // 
            // search_b
            // 
            this.search_b.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_b.Location = new System.Drawing.Point(269, 52);
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(75, 37);
            this.search_b.TabIndex = 1;
            this.search_b.Text = "Search";
            this.search_b.UseVisualStyleBackColor = true;
            this.search_b.Click += new System.EventHandler(this.button2_Click);
            // 
            // snippet_name_lbl
            // 
            this.snippet_name_lbl.AutoSize = true;
            this.snippet_name_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snippet_name_lbl.Location = new System.Drawing.Point(7, 56);
            this.snippet_name_lbl.Name = "snippet_name_lbl";
            this.snippet_name_lbl.Size = new System.Drawing.Size(125, 28);
            this.snippet_name_lbl.TabIndex = 2;
            this.snippet_name_lbl.Text = "Snippet Name";
            // 
            // search_result_lbl
            // 
            this.search_result_lbl.AutoSize = true;
            this.search_result_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_result_lbl.Location = new System.Drawing.Point(5, 117);
            this.search_result_lbl.Name = "search_result_lbl";
            this.search_result_lbl.Size = new System.Drawing.Size(127, 28);
            this.search_result_lbl.TabIndex = 3;
            this.search_result_lbl.Text = "Search Results";
            // 
            // search_result_listbox
            // 
            this.search_result_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_result_listbox.FormattingEnabled = true;
            this.search_result_listbox.ItemHeight = 16;
            this.search_result_listbox.Location = new System.Drawing.Point(10, 157);
            this.search_result_listbox.Name = "search_result_listbox";
            this.search_result_listbox.Size = new System.Drawing.Size(110, 292);
            this.search_result_listbox.TabIndex = 4;
            this.search_result_listbox.Click += new System.EventHandler(this.search_result_listbox_Click);
            // 
            // snippetname_txt
            // 
            this.snippetname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snippetname_txt.Location = new System.Drawing.Point(138, 60);
            this.snippetname_txt.Name = "snippetname_txt";
            this.snippetname_txt.Size = new System.Drawing.Size(100, 22);
            this.snippetname_txt.TabIndex = 5;
            // 
            // copy_clipboard_b
            // 
            this.copy_clipboard_b.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.copy_clipboard_b.Location = new System.Drawing.Point(138, 107);
            this.copy_clipboard_b.Name = "copy_clipboard_b";
            this.copy_clipboard_b.Size = new System.Drawing.Size(151, 49);
            this.copy_clipboard_b.TabIndex = 6;
            this.copy_clipboard_b.Text = "Copy Snippet";
            this.copy_clipboard_b.UseVisualStyleBackColor = true;
            this.copy_clipboard_b.Click += new System.EventHandler(this.copy_clipboard_b_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(134, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 298);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Font Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.copy_clipboard_b);
            this.Controls.Add(this.snippetname_txt);
            this.Controls.Add(this.search_result_listbox);
            this.Controls.Add(this.search_result_lbl);
            this.Controls.Add(this.snippet_name_lbl);
            this.Controls.Add(this.search_b);
            this.Controls.Add(this.home_b);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_b;
        private System.Windows.Forms.Button search_b;
        private System.Windows.Forms.Label snippet_name_lbl;
        private System.Windows.Forms.Label search_result_lbl;
        private System.Windows.Forms.ListBox search_result_listbox;
        private System.Windows.Forms.TextBox snippetname_txt;
        private System.Windows.Forms.Button copy_clipboard_b;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}