using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using titanZPL.IDE.controls;

namespace titanZPL.IDE{
    public partial class document : UserControl {
        public titanZPL label=new titanZPL();

        public string   calc_name   {get { if(edited) return "*"+name; else return name; } set { } }
        public string   type        {get; set; }   ="file";
        public string   name        {get; set; }   ="";
        public string   path        {get; set; }   ="";
        public string   ZPL         {get; set; }   ="";
        public bool     edited      {get; set; }   =false;
        public string   edited_ZPL  {get; set; }   ="";
        public bool     current_file{get; set; }   =true;

        private bool    populating=false;        
        label_types     lt;

        public document() {
            InitializeComponent();
            zpl_code.TabStop = true;
            zpl_code.ReadOnly = false;
            zpl_code.BackColor  = Color.Black;
            zpl_code.ForeColor  = Color.DarkGray;
            zpl_code.Cursor     = Cursors.IBeam;
            //label.set_label_type(4,8,203);
            this.label_type.SelectedIndexChanged -= new System.EventHandler(this.label_type_SelectedIndexChanged);
            
            lt=new label_types();
            label_type.DataSource=lt.items;
            label_type.DisplayMember="name";
            foreach(label_types.label_type t in lt.items) {
                if(t.width==4 && t.height==8 && t.dpi==203) {
                    label_type.SelectedItem=t;
                    break;
                }
            }
            this.label_type.SelectedIndexChanged += new System.EventHandler(this.label_type_SelectedIndexChanged);
           
        }

         public void ConvertCoordinates(PictureBox pic,out int X0, out int Y0, int x, int y){
            X0 = x;
            Y0 = y;
            if (null==pic || null==pic.Image) {
                return;//no null controls in here..
            }
            
            int pic_hgt = pic.ClientSize.Height;
            int pic_wid = pic.ClientSize.Width;
            int img_hgt = pic.Image.Height;
            int img_wid = pic.Image.Width;
            
            
            switch (pic.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    // These are okay. Leave them alone.
                    break;
                case PictureBoxSizeMode.CenterImage:
                    X0 = x - (pic_wid - img_wid) / 2;
                    Y0 = y - (pic_hgt - img_hgt) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    X0 = (int)(img_wid * x / (float)pic_wid);
                    Y0 = (int)(img_hgt * y / (float)pic_hgt);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = pic_wid / (float)pic_hgt;
                    float img_aspect = img_wid / (float)img_hgt;
                    if (pic_aspect > img_aspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        Y0 = (int)(img_hgt * y / (float)pic_hgt);

                        // The image fills the height of the PictureBox.
                        // Get its width.
                        float scaled_width = img_wid * pic_hgt / img_hgt;
                        float dx = (pic_wid - scaled_width) / 2;
                        X0 = (int)((x - dx) * img_hgt / (float)pic_hgt);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        X0 = (int)(img_wid * x / (float)pic_wid);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaled_height = img_hgt * pic_wid / img_wid;
                        float dy = (pic_hgt - scaled_height) / 2;
                        Y0 = (int)((y - dy) * img_wid / pic_wid);
                    }
                    break;
            }
        }
        private void label_image_MouseMove(Object sender, MouseEventArgs e) {
            int x=e.X,y=e.Y,x0=0,y0=0;
            ConvertCoordinates(label_image,out x0,out  y0,x,y);

            x_pos.Text=String.Format("X: {0}",x0);
            y_pos.Text=String.Format("Y: {0}",y0);
                
            if(label.ide_mode=="hover") {
                label.highlight_top_element_at_position(x0,y0);
            }
            if(label.ide_mode=="drag") {
                label.drag_element(x0,y0);
            }
            label.redraw=true;
            this.Refresh();
           // label.draw();
           // label_image.Image=label.label;
        }
        private void label_image_MouseDown(Object sender, MouseEventArgs e) {
            label.ide_mode="drag";
            int x=e.X,y=e.Y,x0=0,y0=0;
            ConvertCoordinates(label_image,out x0,out  y0,x,y);
            label.drag_start(x0,y0);            
            //label.draw();
            //label_image.Image=label.label;
            label.redraw=true;
            this.Refresh();
            
        }
        private void label_image_MouseUp(Object sender, MouseEventArgs e) {
            int x=e.X,y=e.Y,x0=0,y0=0;
            ConvertCoordinates(label_image,out x0,out  y0,x,y);
            label.ide_mode="hover";
            label.drag_end();       
            label.redraw=true;
            this.Refresh();
            //label.draw();
            int v=zpl_code.VerticalScroll.Value;
            int h=zpl_code.HorizontalScroll.Value;
            FastColoredTextBoxNS.Range range=zpl_code.VisibleRange;
            label.curent_zpl_command=null;
            this.zpl_code.TextChangedDelayed -= new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);
            zpl_code.Text=label.pretify_zpl();
            zpl_code.DoRangeVisible(range);
            this.zpl_code.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);

        }
        private void zpl_code_TextChangedDelayed(Object sender, FastColoredTextBoxNS.TextChangedEventArgs e) {
            label.load(zpl_code.Text);
            label_image.Image=label.label;
            edited=true;
        }

        public void load(string filename) {
            string ZPL= System.IO.File.ReadAllText(filename);           //not open? lets load it and add it to the list
            path  =filename;
            name  =Path.GetFileName(filename);
            label.load(ZPL);
            SizeF dim=label.calcuate_label_dimentions();

            label_type.SelectedItem=lt.auto_select_dimention(dim);
            
            
            this.zpl_code.TextChangedDelayed -= new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);
            zpl_code.Text=label.pretify_zpl();
            this.zpl_code.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);
            
            label_image.Image=label.label;
            path=filename;
            name=Path.GetFileName(filename);
        }
        
        public void save() {
            System.IO.File.WriteAllText(path,get_text());
        }
        public void save_as(string filename) {
            System.IO.File.WriteAllText(filename,get_text());
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        }
        public string get_text() {
            //if(edited) return zpl_code.Text;
            //else return label.zpl;
            return label.pretify_zpl();
        }

        public void new_text(string text) {
            label.load(text);
            label_image.Image=label.label;
            this.zpl_code.TextChangedDelayed -= new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);
            zpl_code.Text=label.pretify_zpl();
            this.zpl_code.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.zpl_code_TextChangedDelayed);

        }

        public void toggle_scale() {
            if(label_image.SizeMode==PictureBoxSizeMode.Zoom) {
                label_image.Dock=DockStyle.None;
                label_image.Top=0;
                label_image.Left=0;
                label_image.Width=label_image.Image.Width;
                label_image.Height=label_image.Image.Height;
                label_image.SizeMode=PictureBoxSizeMode.Normal;
            }
            else {
                label_image.SizeMode=PictureBoxSizeMode.Zoom;
                label_image.Dock=DockStyle.Fill;
            }
        }
        public void print_to_zpl() {
            label.print_zpl(zpl_code.Text);
        }
        public void print_to_os() {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();       

        }
        private void PrintPage(object o, PrintPageEventArgs e){
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(label_image.Image, loc);     
        }

        public void save_image() {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();  
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG|*.png";  
            saveFileDialog1.Title = "Save an Image File";  
            saveFileDialog1.FilterIndex=4;
            saveFileDialog1.RestoreDirectory = true ;
            saveFileDialog1.ShowDialog();  

            if(saveFileDialog1.FileName != "") {  
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();  
                switch(saveFileDialog1.FilterIndex) {  
                    case 1 :   this.label_image.Image.Save(fs,   System.Drawing.Imaging.ImageFormat.Jpeg);  break;  
                    case 2 :   this.label_image.Image.Save(fs,   System.Drawing.Imaging.ImageFormat.Bmp);   break;  
                    case 3 :   this.label_image.Image.Save(fs,   System.Drawing.Imaging.ImageFormat.Gif);   break;  
                    case 4 :   this.label_image.Image.Save(fs,   System.Drawing.Imaging.ImageFormat.Png);   break;  
                }  
                fs.Close();  
            }  
        }
        private void zpl_code_TextChanged(Object sender, FastColoredTextBoxNS.TextChangedEventArgs e) {
            edited=true;
        }

        private void label_type_SelectedIndexChanged(Object sender, EventArgs e) {
            if(label_type.SelectedItem!=null) {
                label_types.label_type selected=(label_types.label_type )label_type.SelectedItem;
                label.set_label_type(selected.width,selected.height,selected.dpi);
               // label.build();
                label.draw();
                label_image.Image=label.label;
            }
        }

        private void info_Click(Object sender, EventArgs e) {
            StringBuilder o=new StringBuilder();
            foreach(commands.zpl_command cmd in label.zpl_commands) {
                o.Append(string.Format("{0}-{1}\r\n",cmd.cmd,cmd.data_format));
            }
            info i =new info(o.ToString());
            i.Show();
        }

        private void propertiesToolStripMenuItem_Click(Object sender, EventArgs e) {

        }

        private void zpl_code_SelectionChangedDelayed(Object sender, EventArgs e) {

        }

        private void use_titan_CheckedChanged(Object sender, EventArgs e) {
            label.use_titan_engine=use_titan.Checked;
        }

        
        protected override void OnPaint(PaintEventArgs e) {
        
           // If there is an image and it has a location, 
           // paint it when the Form is repainted.
           
           if(label.redraw) {
                label.draw();
                if(label.curent_zpl_command==null) label_image.Cursor=Cursors.Cross;
                else {
                    if(label.ide_mode=="hover") label_image.Cursor=Cursors.Arrow;
                    if(label.ide_mode=="drag")  label_image.Cursor=Cursors.Hand;
                }
          //      label_image.Image=label.label;
                label.redraw=false;
            }
           base.OnPaint(e);
            
           
           
        }


        private void document_Paint(Object sender, PaintEventArgs e) {
           
        }
    }
}
