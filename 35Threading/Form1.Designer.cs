namespace _35Threading
{
    partial class Form
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
            this.Listbox1 = new System.Windows.Forms.ListBox();
            this.Listbox2 = new System.Windows.Forms.ListBox();
            this.btnstartT1 = new System.Windows.Forms.Button();
            this.btnstartT2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Listbox1
            // 
            this.Listbox1.FormattingEnabled = true;
            this.Listbox1.Location = new System.Drawing.Point(30, 32);
            this.Listbox1.Name = "Listbox1";
            this.Listbox1.Size = new System.Drawing.Size(120, 173);
            this.Listbox1.TabIndex = 0;
            // 
            // Listbox2
            // 
            this.Listbox2.FormattingEnabled = true;
            this.Listbox2.Location = new System.Drawing.Point(417, 42);
            this.Listbox2.Name = "Listbox2";
            this.Listbox2.Size = new System.Drawing.Size(120, 160);
            this.Listbox2.TabIndex = 1;
            // 
            // btnstartT1
            // 
            this.btnstartT1.Location = new System.Drawing.Point(181, 64);
            this.btnstartT1.Name = "btnstartT1";
            this.btnstartT1.Size = new System.Drawing.Size(75, 23);
            this.btnstartT1.TabIndex = 2;
            this.btnstartT1.Text = "startT1";
            this.btnstartT1.UseVisualStyleBackColor = true;
            this.btnstartT1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstartT2
            // 
            this.btnstartT2.Location = new System.Drawing.Point(285, 64);
            this.btnstartT2.Name = "btnstartT2";
            this.btnstartT2.Size = new System.Drawing.Size(75, 23);
            this.btnstartT2.TabIndex = 3;
            this.btnstartT2.Text = "startT2";
            this.btnstartT2.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(612, 261);
            this.Controls.Add(this.btnstartT2);
            this.Controls.Add(this.btnstartT1);
            this.Controls.Add(this.Listbox2);
            this.Controls.Add(this.Listbox1);
            this.Name = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox1;
        private System.Windows.Forms.ListBox Listbox2;
        private System.Windows.Forms.Button btnstartT1;
        private System.Windows.Forms.Button btnstartT2;
    }
}

