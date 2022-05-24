
namespace Travel_Project
{
    partial class FrmReport
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
            this.htmlLabel = new System.Windows.Forms.Label();
            this.xmlLabel = new System.Windows.Forms.Label();
            this.jsonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGöster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // htmlLabel
            // 
            this.htmlLabel.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.htmlLabel.ForeColor = System.Drawing.Color.White;
            this.htmlLabel.Location = new System.Drawing.Point(12, 46);
            this.htmlLabel.Name = "htmlLabel";
            this.htmlLabel.Size = new System.Drawing.Size(983, 146);
            this.htmlLabel.TabIndex = 0;
            this.htmlLabel.Text = "label1";
            // 
            // xmlLabel
            // 
            this.xmlLabel.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xmlLabel.ForeColor = System.Drawing.Color.White;
            this.xmlLabel.Location = new System.Drawing.Point(12, 227);
            this.xmlLabel.Name = "xmlLabel";
            this.xmlLabel.Size = new System.Drawing.Size(983, 163);
            this.xmlLabel.TabIndex = 1;
            this.xmlLabel.Text = "label1";
            // 
            // jsonLabel
            // 
            this.jsonLabel.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jsonLabel.ForeColor = System.Drawing.Color.White;
            this.jsonLabel.Location = new System.Drawing.Point(12, 425);
            this.jsonLabel.Name = "jsonLabel";
            this.jsonLabel.Size = new System.Drawing.Size(983, 132);
            this.jsonLabel.TabIndex = 2;
            this.jsonLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "HTML Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(433, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "XML Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "JSON Report";
            // 
            // btnGöster
            // 
            this.btnGöster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGöster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGöster.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGöster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.btnGöster.Location = new System.Drawing.Point(389, 562);
            this.btnGöster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(227, 48);
            this.btnGöster.TabIndex = 9;
            this.btnGöster.Text = "Cancel Travel";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1007, 631);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jsonLabel);
            this.Controls.Add(this.xmlLabel);
            this.Controls.Add(this.htmlLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label htmlLabel;
        private System.Windows.Forms.Label xmlLabel;
        private System.Windows.Forms.Label jsonLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGöster;
    }
}