namespace titanZPL {
    partial class ide {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ide));
            this.tool_strip = new System.Windows.Forms.ToolStrip();
            this.new_label = new System.Windows.Forms.ToolStripButton();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.save_zpl = new System.Windows.Forms.ToolStripButton();
            this.close_zpl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.save_image = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.load_default_zpl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toggle_scale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.print_ZPL = new System.Windows.Forms.ToolStripButton();
            this.print_system = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.label_tab = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.loadDefaultZPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barCodePrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleLabelZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tool_strip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_strip
            // 
            this.tool_strip.Dock = System.Windows.Forms.DockStyle.None;
            this.tool_strip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tool_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_label,
            this.open,
            this.save_zpl,
            this.close_zpl,
            this.toolStripSeparator5,
            this.save_image,
            this.toolStripSeparator2,
            this.load_default_zpl,
            this.toolStripSeparator3,
            this.toggle_scale,
            this.toolStripSeparator1,
            this.print_ZPL,
            this.print_system,
            this.toolStripSeparator4,
            this.Paste,
            this.Copy});
            this.tool_strip.Location = new System.Drawing.Point(3, 0);
            this.tool_strip.Name = "tool_strip";
            this.tool_strip.Size = new System.Drawing.Size(978, 39);
            this.tool_strip.TabIndex = 5;
            this.tool_strip.Text = "toolStrip1";
            // 
            // new_label
            // 
            this.new_label.Image = ((System.Drawing.Image)(resources.GetObject("new_label.Image")));
            this.new_label.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_label.Name = "new_label";
            this.new_label.Size = new System.Drawing.Size(67, 36);
            this.new_label.Text = "New";
            this.new_label.Click += new System.EventHandler(this.new_label_Click);
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(72, 36);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save_zpl
            // 
            this.save_zpl.Image = ((System.Drawing.Image)(resources.GetObject("save_zpl.Image")));
            this.save_zpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_zpl.Name = "save_zpl";
            this.save_zpl.Size = new System.Drawing.Size(67, 36);
            this.save_zpl.Text = "Save";
            this.save_zpl.Click += new System.EventHandler(this.save_zpl_Click);
            // 
            // close_zpl
            // 
            this.close_zpl.Image = ((System.Drawing.Image)(resources.GetObject("close_zpl.Image")));
            this.close_zpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close_zpl.Name = "close_zpl";
            this.close_zpl.Size = new System.Drawing.Size(72, 36);
            this.close_zpl.Text = "Close";
            this.close_zpl.Click += new System.EventHandler(this.close_zpl_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // save_image
            // 
            this.save_image.Image = ((System.Drawing.Image)(resources.GetObject("save_image.Image")));
            this.save_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_image.Name = "save_image";
            this.save_image.Size = new System.Drawing.Size(103, 36);
            this.save_image.Text = "Save Image";
            this.save_image.Click += new System.EventHandler(this.save_image_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // load_default_zpl
            // 
            this.load_default_zpl.Image = ((System.Drawing.Image)(resources.GetObject("load_default_zpl.Image")));
            this.load_default_zpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.load_default_zpl.Name = "load_default_zpl";
            this.load_default_zpl.Size = new System.Drawing.Size(133, 36);
            this.load_default_zpl.Text = "Load Default ZPL";
            this.load_default_zpl.Click += new System.EventHandler(this.load_default_zpl_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toggle_scale
            // 
            this.toggle_scale.Image = ((System.Drawing.Image)(resources.GetObject("toggle_scale.Image")));
            this.toggle_scale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggle_scale.Name = "toggle_scale";
            this.toggle_scale.Size = new System.Drawing.Size(109, 36);
            this.toggle_scale.Text = "Toggle Scale";
            this.toggle_scale.Click += new System.EventHandler(this.toggle_scale_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // print_ZPL
            // 
            this.print_ZPL.Image = ((System.Drawing.Image)(resources.GetObject("print_ZPL.Image")));
            this.print_ZPL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_ZPL.Name = "print_ZPL";
            this.print_ZPL.Size = new System.Drawing.Size(88, 36);
            this.print_ZPL.Text = "PrintZPL";
            this.print_ZPL.Click += new System.EventHandler(this.print_ZPL_Click);
            // 
            // print_system
            // 
            this.print_system.Image = ((System.Drawing.Image)(resources.GetObject("print_system.Image")));
            this.print_system.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_system.Name = "print_system";
            this.print_system.Size = new System.Drawing.Size(83, 36);
            this.print_system.Text = "PrintOS";
            this.print_system.Click += new System.EventHandler(this.print_system_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // Paste
            // 
            this.Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(71, 36);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(71, 36);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // label_tab
            // 
            this.label_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tab.Location = new System.Drawing.Point(0, 0);
            this.label_tab.Name = "label_tab";
            this.label_tab.SelectedIndex = 0;
            this.label_tab.Size = new System.Drawing.Size(1399, 718);
            this.label_tab.TabIndex = 10;
            this.label_tab.SelectedIndexChanged += new System.EventHandler(this.label_tab_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1431, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator6,
            this.saveImageToolStripMenuItem,
            this.toolStripSeparator7,
            this.loadDefaultZPLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // loadDefaultZPLToolStripMenuItem
            // 
            this.loadDefaultZPLToolStripMenuItem.Name = "loadDefaultZPLToolStripMenuItem";
            this.loadDefaultZPLToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadDefaultZPLToolStripMenuItem.Text = "Load Default ZPL";
            this.loadDefaultZPLToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultZPLToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barCodePrinterToolStripMenuItem,
            this.systemPrinterToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // barCodePrinterToolStripMenuItem
            // 
            this.barCodePrinterToolStripMenuItem.Name = "barCodePrinterToolStripMenuItem";
            this.barCodePrinterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.barCodePrinterToolStripMenuItem.Text = "Bar Code Printer";
            this.barCodePrinterToolStripMenuItem.Click += new System.EventHandler(this.barCodePrinterToolStripMenuItem_Click);
            // 
            // systemPrinterToolStripMenuItem
            // 
            this.systemPrinterToolStripMenuItem.Name = "systemPrinterToolStripMenuItem";
            this.systemPrinterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.systemPrinterToolStripMenuItem.Text = "System Printer";
            this.systemPrinterToolStripMenuItem.Click += new System.EventHandler(this.systemPrinterToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toggleLabelZoomToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toggleLabelZoomToolStripMenuItem
            // 
            this.toggleLabelZoomToolStripMenuItem.Name = "toggleLabelZoomToolStripMenuItem";
            this.toggleLabelZoomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.toggleLabelZoomToolStripMenuItem.Text = "Toggle Label Zoom";
            this.toggleLabelZoomToolStripMenuItem.Click += new System.EventHandler(this.toggleLabelZoomToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label_tab);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1399, 718);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1431, 757);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tool_strip);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(32, 53);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1431, 781);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ide";
            this.Text = "titanZPL Rendering Engine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tool_strip.ResumeLayout(false);
            this.tool_strip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tool_strip;
        private System.Windows.Forms.ToolStripButton save_image;
        private System.Windows.Forms.ToolStripButton load_default_zpl;
        private System.Windows.Forms.ToolStripButton toggle_scale;
        private System.Windows.Forms.ToolStripButton print_ZPL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton print_system;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Paste;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripButton new_label;
        private System.Windows.Forms.ToolStripButton save_zpl;
        private System.Windows.Forms.ToolStripButton close_zpl;
        private System.Windows.Forms.TabControl label_tab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultZPLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barCodePrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleLabelZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

