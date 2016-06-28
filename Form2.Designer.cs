namespace Code_Snippet_Manager
{
    partial class Form2
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
            this.snippet_title_lbl = new System.Windows.Forms.Label();
            this.snippet_title_txt = new System.Windows.Forms.TextBox();
            this.save_b = new System.Windows.Forms.Button();
            this.code_richtxt = new System.Windows.Forms.RichTextBox();
            this.home_b = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snippet_title_lbl
            // 
            this.snippet_title_lbl.AutoSize = true;
            this.snippet_title_lbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snippet_title_lbl.Location = new System.Drawing.Point(13, 59);
            this.snippet_title_lbl.Name = "snippet_title_lbl";
            this.snippet_title_lbl.Size = new System.Drawing.Size(138, 33);
            this.snippet_title_lbl.TabIndex = 0;
            this.snippet_title_lbl.Text = "Snippet Title";
            // 
            // snippet_title_txt
            // 
            this.snippet_title_txt.Location = new System.Drawing.Point(169, 69);
            this.snippet_title_txt.Name = "snippet_title_txt";
            this.snippet_title_txt.Size = new System.Drawing.Size(152, 20);
            this.snippet_title_txt.TabIndex = 1;
            // 
            // save_b
            // 
            this.save_b.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_b.Location = new System.Drawing.Point(360, 51);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(75, 41);
            this.save_b.TabIndex = 2;
            this.save_b.Text = "Save";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.button1_Click);
            // 
            // code_richtxt
            // 
            this.code_richtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code_richtxt.Location = new System.Drawing.Point(12, 98);
            this.code_richtxt.Name = "code_richtxt";
            this.code_richtxt.Size = new System.Drawing.Size(535, 368);
            this.code_richtxt.TabIndex = 3;
            this.code_richtxt.Text = "";
            // 
            // home_b
            // 
            this.home_b.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_b.Location = new System.Drawing.Point(12, 12);
            this.home_b.Name = "home_b";
            this.home_b.Size = new System.Drawing.Size(75, 38);
            this.home_b.TabIndex = 4;
            this.home_b.Text = "Home";
            this.home_b.UseVisualStyleBackColor = true;
            this.home_b.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(465, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.home_b);
            this.Controls.Add(this.code_richtxt);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.snippet_title_txt);
            this.Controls.Add(this.snippet_title_lbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label snippet_title_lbl;
        private System.Windows.Forms.TextBox snippet_title_txt;
        private System.Windows.Forms.Button save_b;
        private System.Windows.Forms.RichTextBox code_richtxt;
        private System.Windows.Forms.Button home_b;
        private System.Windows.Forms.Button button1;
    }
}