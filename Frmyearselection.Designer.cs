
namespace IMS
{
    partial class Frmyearselection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmboyear = new System.Windows.Forms.ComboBox();
            this.cmboname = new System.Windows.Forms.ComboBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmboyear);
            this.panel1.Controls.Add(this.cmboname);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(182, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 261);
            this.panel1.TabIndex = 1;
            // 
            // cmboyear
            // 
            this.cmboyear.AutoCompleteCustomSource.AddRange(new string[] {
            "hi",
            "hey",
            "bye",
            "20009",
            "3001",
            "550",
            "2014",
            "2022",
            "2023",
            "2024"});
            this.cmboyear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboyear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmboyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboyear.FormatString = "N0";
            this.cmboyear.FormattingEnabled = true;
            this.cmboyear.Location = new System.Drawing.Point(213, 142);
            this.cmboyear.Name = "cmboyear";
            this.cmboyear.Size = new System.Drawing.Size(155, 23);
            this.cmboyear.TabIndex = 12;
            // 
            // cmboname
            // 
            this.cmboname.AutoCompleteCustomSource.AddRange(new string[] {
            "hi",
            "hey",
            "bye"});
            this.cmboname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmboname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboname.FormattingEnabled = true;
            this.cmboname.Location = new System.Drawing.Point(213, 90);
            this.cmboname.Name = "cmboname";
            this.cmboname.Size = new System.Drawing.Size(155, 23);
            this.cmboname.TabIndex = 11;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(385, 47);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(21, 23);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Silver;
            this.btnsubmit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(174, 203);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(204, 32);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "FINANCIAL YEAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "COMPANY NAME ";
            // 
            // Frmyearselection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frmyearselection";
            this.Text = "Frmyearselection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmboyear;
        private System.Windows.Forms.ComboBox cmboname;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}