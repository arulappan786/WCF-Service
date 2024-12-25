namespace QTMWcfDealServiceTestApp
{
    partial class frmServiceTest
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
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.btnUnwind = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(136, 12);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(118, 37);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            // 
            // btnCustomize
            // 
            this.btnCustomize.Location = new System.Drawing.Point(260, 12);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(118, 37);
            this.btnCustomize.TabIndex = 1;
            this.btnCustomize.Text = "Customize";
            this.btnCustomize.UseVisualStyleBackColor = true;
            // 
            // btnUnwind
            // 
            this.btnUnwind.Location = new System.Drawing.Point(384, 12);
            this.btnUnwind.Name = "btnUnwind";
            this.btnUnwind.Size = new System.Drawing.Size(118, 37);
            this.btnUnwind.TabIndex = 2;
            this.btnUnwind.Text = "Unwind";
            this.btnUnwind.UseVisualStyleBackColor = true;
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(12, 12);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(118, 37);
            this.btnAuthenticate.TabIndex = 3;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // frmServiceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 63);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.btnUnwind);
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.btnInitialize);
            this.Name = "frmServiceTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.Button btnUnwind;
        private System.Windows.Forms.Button btnAuthenticate;
    }
}

