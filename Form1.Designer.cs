namespace PDF_Creator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rchtxtbxUpload = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkLearnmore = new System.Windows.Forms.LinkLabel();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(286, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 34);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "&Select File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Location = new System.Drawing.Point(464, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(172, 34);
            this.btnGenerate.TabIndex = 33;
            this.btnGenerate.Text = "&Generate to PDF";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.Location = new System.Drawing.Point(171, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 74);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "RESUME GENERATOR";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.rchtxtbxUpload);
            this.panel8.Location = new System.Drawing.Point(43, 119);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(844, 109);
            this.panel8.TabIndex = 27;
            // 
            // rchtxtbxUpload
            // 
            this.rchtxtbxUpload.BackColor = System.Drawing.Color.Silver;
            this.rchtxtbxUpload.Location = new System.Drawing.Point(11, 10);
            this.rchtxtbxUpload.Name = "rchtxtbxUpload";
            this.rchtxtbxUpload.Size = new System.Drawing.Size(820, 88);
            this.rchtxtbxUpload.TabIndex = 0;
            this.rchtxtbxUpload.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(307, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Upload your JSON file here:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lnkLearnmore);
            this.panel2.Controls.Add(this.lblNote2);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(-8, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 368);
            this.panel2.TabIndex = 35;
            // 
            // lnkLearnmore
            // 
            this.lnkLearnmore.AutoEllipsis = true;
            this.lnkLearnmore.AutoSize = true;
            this.lnkLearnmore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLearnmore.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLearnmore.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lnkLearnmore.Location = new System.Drawing.Point(594, 16);
            this.lnkLearnmore.Name = "lnkLearnmore";
            this.lnkLearnmore.Size = new System.Drawing.Size(113, 19);
            this.lnkLearnmore.TabIndex = 36;
            this.lnkLearnmore.TabStop = true;
            this.lnkLearnmore.Text = "Learn More ...";
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.BackColor = System.Drawing.Color.Transparent;
            this.lblNote2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNote2.Location = new System.Drawing.Point(125, 16);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(570, 22);
            this.lblNote2.TabIndex = 35;
            this.lblNote2.Text = "You must provide your JSON file to generate your resume to PDF";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNote.Location = new System.Drawing.Point(61, 16);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(72, 23);
            this.lblNote.TabIndex = 34;
            this.lblNote.Text = "Note: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(913, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rchtxtbxUpload;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.LinkLabel lnkLearnmore;
        private System.Windows.Forms.Label lblNote2;
    }
}

