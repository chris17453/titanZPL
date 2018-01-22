namespace titanZPL.IDE.controls {
    partial class info {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.info_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // info_box
            // 
            this.info_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_box.Location = new System.Drawing.Point(0, 0);
            this.info_box.Multiline = true;
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(743, 625);
            this.info_box.TabIndex = 0;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 625);
            this.Controls.Add(this.info_box);
            this.Name = "info";
            this.Text = "System Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox info_box;
    }
}