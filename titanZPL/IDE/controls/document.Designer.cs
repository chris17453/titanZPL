namespace titanZPL.IDE{
    partial class document {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(document));
            this.split_container = new System.Windows.Forms.SplitContainer();
            this.label_image = new System.Windows.Forms.PictureBox();
            this.image_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zpl_code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.x_pos = new System.Windows.Forms.Label();
            this.y_pos = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.ComboBox();
            this.lavel_type_l = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.use_titan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).BeginInit();
            this.split_container.Panel1.SuspendLayout();
            this.split_container.Panel2.SuspendLayout();
            this.split_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label_image)).BeginInit();
            this.image_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zpl_code)).BeginInit();
            this.SuspendLayout();
            // 
            // split_container
            // 
            this.split_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.split_container.Location = new System.Drawing.Point(0, 0);
            this.split_container.Name = "split_container";
            // 
            // split_container.Panel1
            // 
            this.split_container.Panel1.AutoScroll = true;
            this.split_container.Panel1.Controls.Add(this.label_image);
            // 
            // split_container.Panel2
            // 
            this.split_container.Panel2.Controls.Add(this.zpl_code);
            this.split_container.Size = new System.Drawing.Size(1136, 585);
            this.split_container.SplitterDistance = 479;
            this.split_container.TabIndex = 5;
            // 
            // label_image
            // 
            this.label_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.label_image.ContextMenuStrip = this.image_menu;
            this.label_image.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_image.Location = new System.Drawing.Point(0, 0);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(479, 585);
            this.label_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.label_image.TabIndex = 0;
            this.label_image.TabStop = false;
            this.label_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_image_MouseDown);
            this.label_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_image_MouseMove);
            this.label_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_image_MouseUp);
            // 
            // image_menu
            // 
            this.image_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.image_menu.Name = "contextMenuStrip1";
            this.image_menu.Size = new System.Drawing.Size(128, 26);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // zpl_code
            // 
            this.zpl_code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.zpl_code.AutoScrollMinSize = new System.Drawing.Size(31, 14);
            this.zpl_code.BackBrush = null;
            this.zpl_code.CaretColor = System.Drawing.Color.White;
            this.zpl_code.CharHeight = 14;
            this.zpl_code.CharWidth = 10;
            this.zpl_code.CurrentLineColor = System.Drawing.Color.White;
            this.zpl_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.zpl_code.DescriptionFile = "C:\\repos\\Main\\titanZPL\\titanZPL\\IDE\\SyntaxtHighlighting.,xml";
            this.zpl_code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.zpl_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zpl_code.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold);
            this.zpl_code.IsReplaceMode = false;
            this.zpl_code.Location = new System.Drawing.Point(0, 0);
            this.zpl_code.Name = "zpl_code";
            this.zpl_code.Paddings = new System.Windows.Forms.Padding(0);
            this.zpl_code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.zpl_code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("zpl_code.ServiceColors")));
            this.zpl_code.Size = new System.Drawing.Size(653, 585);
            this.zpl_code.TabIndex = 1;
            this.zpl_code.Zoom = 100;
            this.zpl_code.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChanged);
            this.zpl_code.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);
            this.zpl_code.SelectionChangedDelayed += new System.EventHandler(this.zpl_code_SelectionChangedDelayed);
            // 
            // x_pos
            // 
            this.x_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.x_pos.AutoSize = true;
            this.x_pos.Location = new System.Drawing.Point(3, 601);
            this.x_pos.Name = "x_pos";
            this.x_pos.Size = new System.Drawing.Size(17, 13);
            this.x_pos.TabIndex = 6;
            this.x_pos.Text = "X:";
            // 
            // y_pos
            // 
            this.y_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.y_pos.AutoSize = true;
            this.y_pos.Location = new System.Drawing.Point(4, 618);
            this.y_pos.Name = "y_pos";
            this.y_pos.Size = new System.Drawing.Size(17, 13);
            this.y_pos.TabIndex = 7;
            this.y_pos.Text = "Y:";
            // 
            // label_type
            // 
            this.label_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_type.FormattingEnabled = true;
            this.label_type.Location = new System.Drawing.Point(128, 615);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(121, 21);
            this.label_type.TabIndex = 8;
            this.label_type.SelectedIndexChanged += new System.EventHandler(this.label_type_SelectedIndexChanged);
            // 
            // lavel_type_l
            // 
            this.lavel_type_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lavel_type_l.AutoSize = true;
            this.lavel_type_l.Location = new System.Drawing.Point(62, 618);
            this.lavel_type_l.Name = "lavel_type_l";
            this.lavel_type_l.Size = new System.Drawing.Size(60, 13);
            this.lavel_type_l.TabIndex = 9;
            this.lavel_type_l.Text = "Label Type";
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.info.Location = new System.Drawing.Point(1058, 618);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 10;
            this.info.Text = "Sys Info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // use_titan
            // 
            this.use_titan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.use_titan.AutoSize = true;
            this.use_titan.Location = new System.Drawing.Point(128, 592);
            this.use_titan.Name = "use_titan";
            this.use_titan.Size = new System.Drawing.Size(86, 17);
            this.use_titan.TabIndex = 11;
            this.use_titan.Text = "use titanZPL";
            this.use_titan.UseVisualStyleBackColor = true;
            this.use_titan.CheckedChanged += new System.EventHandler(this.use_titan_CheckedChanged);
            // 
            // document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.use_titan);
            this.Controls.Add(this.info);
            this.Controls.Add(this.lavel_type_l);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.y_pos);
            this.Controls.Add(this.x_pos);
            this.Controls.Add(this.split_container);
            this.Name = "document";
            this.Size = new System.Drawing.Size(1136, 645);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.document_Paint);
            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.label_image)).EndInit();
            this.image_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zpl_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_container;
        private System.Windows.Forms.PictureBox label_image;
        private FastColoredTextBoxNS.FastColoredTextBox zpl_code;
        private System.Windows.Forms.Label x_pos;
        private System.Windows.Forms.Label y_pos;
        private System.Windows.Forms.ComboBox label_type;
        private System.Windows.Forms.Label lavel_type_l;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.ContextMenuStrip image_menu;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.CheckBox use_titan;
    }
}
