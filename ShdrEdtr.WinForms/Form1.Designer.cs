namespace ShdrEdtr.WinForms
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
            this.rndrForm1 = new ShdrEdtr.Engine.Controls.RndrForm();
            this.SuspendLayout();
            // 
            // rndrForm1
            // 
            this.rndrForm1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rndrForm1.Location = new System.Drawing.Point(12, 12);
            this.rndrForm1.Name = "rndrForm1";
            this.rndrForm1.Size = new System.Drawing.Size(310, 238);
            this.rndrForm1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 626);
            this.Controls.Add(this.rndrForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ShdrEdtr.Engine.Controls.RndrForm rndrForm1;

    }
}

