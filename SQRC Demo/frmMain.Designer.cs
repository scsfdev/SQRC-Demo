namespace SQRC_Demo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.txtPri = new System.Windows.Forms.TextBox();
            this.btnPub = new System.Windows.Forms.Button();
            this.btnPri = new System.Windows.Forms.Button();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.picSqrc = new System.Windows.Forms.PictureBox();
            this.sqrcOcx = new AxSQRCmakerLib.AxSQRCmaker();
            ((System.ComponentModel.ISupportInitialize)(this.picSqrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqrcOcx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Public data file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Private data file:";
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(204, 96);
            this.txtPub.Name = "txtPub";
            this.txtPub.ReadOnly = true;
            this.txtPub.Size = new System.Drawing.Size(432, 27);
            this.txtPub.TabIndex = 3;
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(204, 164);
            this.txtPri.Name = "txtPri";
            this.txtPri.ReadOnly = true;
            this.txtPri.Size = new System.Drawing.Size(432, 27);
            this.txtPri.TabIndex = 4;
            // 
            // btnPub
            // 
            this.btnPub.Location = new System.Drawing.Point(642, 95);
            this.btnPub.Name = "btnPub";
            this.btnPub.Size = new System.Drawing.Size(75, 29);
            this.btnPub.TabIndex = 5;
            this.btnPub.Text = "Browse";
            this.btnPub.UseVisualStyleBackColor = true;
            this.btnPub.Click += new System.EventHandler(this.btnPub_Click);
            // 
            // btnPri
            // 
            this.btnPri.Location = new System.Drawing.Point(642, 163);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(75, 29);
            this.btnPri.TabIndex = 6;
            this.btnPri.Text = "Browse";
            this.btnPri.UseVisualStyleBackColor = true;
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(204, 225);
            this.txtExport.Name = "txtExport";
            this.txtExport.ReadOnly = true;
            this.txtExport.Size = new System.Drawing.Size(432, 27);
            this.txtExport.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Export SQRC image to:";
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(642, 224);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(75, 29);
            this.btnExp.TabIndex = 9;
            this.btnExp.Text = "Browse";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(204, 278);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 49);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(339, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 49);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(474, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 49);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(784, 59);
            this.label4.TabIndex = 13;
            this.label4.Text = "SQRC DEMO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSqrc
            // 
            this.picSqrc.Location = new System.Drawing.Point(607, 287);
            this.picSqrc.Name = "picSqrc";
            this.picSqrc.Size = new System.Drawing.Size(100, 50);
            this.picSqrc.TabIndex = 14;
            this.picSqrc.TabStop = false;
            this.picSqrc.Visible = false;
            // 
            // sqrcOcx
            // 
            this.sqrcOcx.Enabled = true;
            this.sqrcOcx.Location = new System.Drawing.Point(24, 299);
            this.sqrcOcx.Margin = new System.Windows.Forms.Padding(4);
            this.sqrcOcx.Name = "sqrcOcx";
            this.sqrcOcx.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sqrcOcx.OcxState")));
            this.sqrcOcx.Size = new System.Drawing.Size(100, 50);
            this.sqrcOcx.TabIndex = 0;
            this.sqrcOcx.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 370);
            this.Controls.Add(this.picSqrc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPri);
            this.Controls.Add(this.btnPub);
            this.Controls.Add(this.txtPri);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqrcOcx);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQRC Demo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSqrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqrcOcx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSQRCmakerLib.AxSQRCmaker sqrcOcx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.Button btnPub;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picSqrc;
    }
}

