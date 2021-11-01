namespace Oefening2
{
    partial class Gemiddelde
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
            this.btAddGetal = new System.Windows.Forms.Button();
            this.tbGemiddelde = new System.Windows.Forms.TextBox();
            this.lbLijst = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btAddGetal
            // 
            this.btAddGetal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAddGetal.ForeColor = System.Drawing.Color.White;
            this.btAddGetal.Location = new System.Drawing.Point(12, 12);
            this.btAddGetal.Name = "btAddGetal";
            this.btAddGetal.Size = new System.Drawing.Size(90, 27);
            this.btAddGetal.TabIndex = 0;
            this.btAddGetal.Text = "Nieuw Getal";
            this.btAddGetal.UseVisualStyleBackColor = false;
            this.btAddGetal.Click += new System.EventHandler(this.btAddGetal_Click);
            // 
            // tbGemiddelde
            // 
            this.tbGemiddelde.Enabled = false;
            this.tbGemiddelde.Location = new System.Drawing.Point(12, 45);
            this.tbGemiddelde.Name = "tbGemiddelde";
            this.tbGemiddelde.Size = new System.Drawing.Size(90, 20);
            this.tbGemiddelde.TabIndex = 1;
            // 
            // lbLijst
            // 
            this.lbLijst.AutoSize = true;
            this.lbLijst.Location = new System.Drawing.Point(12, 81);
            this.lbLijst.Name = "lbLijst";
            this.lbLijst.Size = new System.Drawing.Size(0, 13);
            this.lbLijst.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // Gemiddelde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 246);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbLijst);
            this.Controls.Add(this.tbGemiddelde);
            this.Controls.Add(this.btAddGetal);
            this.Name = "Gemiddelde";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddGetal;
        private System.Windows.Forms.TextBox tbGemiddelde;
        private System.Windows.Forms.Label lbLijst;
        private System.Windows.Forms.ListBox listBox1;
    }
}