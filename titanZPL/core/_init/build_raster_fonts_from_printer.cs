using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL{
    public static class build_raster_fonts_from_printer {

        //This sends the ZPL, and returns an image
        public static Image build(string zpl){
            string  return_data     =printer_render.post(zpl,false);
            int     img_uri_index   =return_data.IndexOf("png?prev=Y&dev=R&oname=");
            int     img_uri_end     =return_data.IndexOf("\"",img_uri_index);
            string  uri             =printer_render.printer_uri+return_data.Substring(img_uri_index,img_uri_end-img_uri_index);
        
            WebClient    wc      = new WebClient();
            byte[]       bytes   = wc.DownloadData(uri);
            MemoryStream ms      = new MemoryStream(bytes);
            Image        img     = Image.FromStream(ms);
            return img;
        }

        public static FontFamily LoadFontFamily(string fileName,string name){
            string  file_path=String.Format(@"C:\repos\Main\titanZPL\titanZPL\bin\Debug\fonts\ttf\{0}.ttf",fileName);   //IN MEMORY _myFonts 
            /*
            for(int i=0;i<_myFonts.Families.Length;i++) {
                    if(_myFonts.Families[i].Name==name) return _myFonts.Families[i];
            }
            _myFonts.AddFontFile(file_path);                                                                            //we add the full path of the ttf file
            for(int i=0;i<_myFonts.Families.Length;i++) {
                    if(_myFonts.Families[i].Name==name) return _myFonts.Families[i];
            }(*/

            return null;
        }

        public class font_structure{
            public string       font                    ="";
            public int          char_width              =0;
            public int          char_height             =0;
            public int          baseline                =0;
            public int          gap                     =0;
            public string       type                    ="";
            public int          offset_x                =10;                            //this is the HOME X OFFSET
            public int          offset_y                =10;                            //this is the HOME Y OFFSET
            public int          padding_x               =0;
            public int          padding_y               =0;
            public int          page_width              =800;                           //this is the label width
            public int          page_height             =1000;                          //this is the label height
            public int          characters_per_line     =0;                             //this is how many chars per line can exist
            public int          characters_per_page     =0;                             //this is how many chars are possible per page
            public int          lines_per_page          =0;                             //this is how many lines can fit on a single page
            public int          characters_left         =0;                             //this is how many chars are left to generate
            public int          character_index         =0;                             //this is the char we start on on the new page
            public int          characters_on_page      =0;                             //this is how many chars are on THIS page
            public int          character_start_index   =0x20;
            public int          character_end_index     =0xFF;
            public int          page                    =0;
            public int          character_pixel_width   =0;
            public int          character_pixel_height  =0; 
            public int          total_characters        =0;
            public SolidBrush   brush                   =new SolidBrush(Color.Black);   //background color for ttf rendering
            public Pen          pen                     =Pens.Black;                    //foreground color for ttf rendering
            public string       ttf_file_name;                                          //font file to load for ttf rendering
            public string       ttf_name;                                               //font name to match against
            public Font         ttf_font;                                               //the resultant ttf fonr for rendering
            public float        font_size               =0;
            public string       dir                     ="";
            Image               character_map;
            public font_structure(string font) {
                this.font=font;
                switch (font.ToUpper()) {
                    //a-d are monospaced tiny fonts
                    case "A" :  ttf_file_name="px10";                   ttf_name="snoot.orf pixel10";      char_width=5;  char_height=9;  gap=1; baseline=7;               type="RASTER"; break;   //this is just dilly tiny
                    case "B" :  ttf_file_name="LiberationMono-Regular"; ttf_name="Liberation Mono";        char_width=17; char_height=11; gap=2; baseline=11;              type="RASTER"; break;
                    case "C" :  ttf_file_name="LiberationMono-Regular"; ttf_name="Liberation Mono";        char_width=10; char_height=18; gap=2; baseline=14;              type="RASTER"; break;
                    case "D" :  ttf_file_name="LiberationMono-BOLD";    ttf_name="Liberation Mono";        char_width=10; char_height=18; gap=2; baseline=14;              type="RASTER"; break;
                    //e-h are OOCR fontsCR fonts                   
                    case "E" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=15; char_height=28; gap=5; baseline=23;              type="RASTER"; break;
                    case "F" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=13; char_height=26; gap=3; baseline=21;              type="RASTER"; break;
                    case "G" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=40; char_height=60; gap=8; baseline=48;              type="RASTER"; break;
                    case "H" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=13; char_height=21; gap=6; baseline=21;              type="RASTER"; break;
                    //gs is symmbols                          
                    case "GS":  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=24; char_height=24; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    //p-v+0 aree all the same font all the same font
                    case "P" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=18; char_height=20; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "Q" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=24; char_height=28; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "R" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=31; char_height=35; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "S" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=35; char_height=40; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "T" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=42; char_height=48; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "U" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=53; char_height=59; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "V" :  ttf_file_name="UPS-SANS-regular";       ttf_name="UPS SANS";               char_width=71; char_height=80; gap=0; baseline=3*char_height/4; type="TTF"; break;
                    case "0" :                                                                                
                    default:    ttf_file_name="Langdon";                ttf_name="Langdon";                        char_width=12; char_height=15; gap=0; baseline=(3*char_height)/4; type="TTF"; break;
                }
                padding_x               = char_width *2;
                padding_y               = char_height*2;
                characters_per_line     =(page_width -offset_x*2)/(char_width +gap+padding_x);
                lines_per_page          =(page_height-offset_y*2)/(char_height+gap+padding_y)-1;
                characters_per_page     = characters_per_line*lines_per_page;
                characters_left         = character_end_index-character_start_index;                                                 //characters under 0x20 are non printable characters (commands)
                character_index         = character_start_index;                                                                     //you can do unicode, but I've not come that far.
                total_characters        = characters_left;
                character_pixel_width   =(char_width +gap+padding_x);
                character_pixel_height  =(char_height+gap+padding_y);
                //font_size               = char_width*2 +gap;      
                dir="ttf";      
   
            }//end init font structure

            public Rectangle get_master_character_position(int character) {
                Rectangle position=new Rectangle();

                position.X      =0;
                position.Y      =(character_pixel_height+1)*(character-character_start_index);
                position.Width  =char_width;
                position.Height =char_height;
                return position;
            }
            
            public Point get_character_position(int character) {
                Point position=new Point();
                character-=character_start_index;
                int x=character%characters_per_line;
                int y=(character/characters_per_line)%lines_per_page;
                position.X=x*(character_pixel_width )+offset_x;
                position.Y=y*(character_pixel_height)+offset_y;
                return position;
            }

            public void load_ttf_font() {
                //FontFamily font_family=build_raster_fonts_from_printer.LoadFontFamily(ttf_file_name,ttf_name);
                               //impliment point scaling
                float pt=.01f;
                Bitmap   temp_img  =new Bitmap(char_width*2,char_height*2);
                Graphics temp_img_g=Graphics.FromImage(temp_img);
                temp_img_g.TextRenderingHint=TextRenderingHint.AntiAlias;
                Rectangle temp_img_rect=new Rectangle(0,0,temp_img.Width,temp_img.Height);
                Rectangle char_bounds=new Rectangle();
                for (float cur_pt=.01f;cur_pt<400;cur_pt+=.01f) {
                    using(Font test_font=new Font(ttf_name,cur_pt)){
                        temp_img_g.FillRectangle(Brushes.White,temp_img_rect);
                        temp_img_g.DrawString("X",test_font,Brushes.Black,0,0);
                        char_bounds=find_character_bounds(temp_img,temp_img_rect);
                        if(char_bounds.Width<char_width &&
                           char_bounds.Height<char_height) pt=cur_pt;
                        else
                            break;
                    }
                }
                font_size=pt;
                ttf_font=new Font(ttf_name,font_size);
                dir="ttf";
            }
            public void load() {
                string file_path=string.Format("./fonts/raster/{1}/font-{0}.png",font,dir);
                if(File.Exists(file_path)) {
                    character_map=Image.FromFile(file_path);            //save the master iamge file.    
                }  else {
                    //throw load error;
                }

            }
            public void draw_string(Image image,int x,int y,int new_character_width,int new_character_height,string text) {
                if(character_map==null) load();                                                                     //load map if not loaded
                if(character_map==null) return;                                                                     //load map if not loaded
                
                int position_x=0;
                Graphics dest_g=Graphics.FromImage(image);
                if(new_character_width <char_width ) new_character_width =char_width;
                if(new_character_height<char_height) new_character_height=char_height;
                foreach (char c in text) {
                    int pos_x=position_x*(new_character_width+gap);
                    Rectangle src=get_master_character_position((int)c);
                    Rectangle dest=new Rectangle(pos_x,0,new_character_width,new_character_height);
                    dest_g.DrawImage(character_map,dest,src,GraphicsUnit.Pixel);//,scale_w,scale_h
                    position_x++;
                }
            }

            public Rectangle find_character_bounds(Bitmap test_image,Rectangle src_bounds) {
                Rectangle bounds=new Rectangle();
                int x_min =src_bounds.Width;
                int x_max =0;
                int y_min =src_bounds.Height;
                int y_max =0;
                bool blank=true;
                for(int y=0;y<(src_bounds.Height);y++) {                //we scan the character and set the min/max bounds for the image where data exists
                for(int x=0;x<(src_bounds.Width );x++) {
                    Color c=test_image.GetPixel(x+src_bounds.X,y+src_bounds.Y);
                    if(c.R!=255 || c.G!=255 || c.B!=255) {       //we got a pixel
                            if(x_min>x) x_min=x;
                            if(y_min>y) y_min=y;

                            if (x_max<x) x_max=x;
                            if(y_max<y) y_max=y;
                            blank=false;
                    }
                }//end x
                }//end y
                if(blank) {
                    x_min=0;
                    y_min=0;
                    x_max=src_bounds.Width ;
                    y_max=src_bounds.Height;    
                }

                bounds.X     =x_min;
                bounds.Y     =y_min;
                bounds.Width =x_max-x_min+1;
                bounds.Height=y_max-y_min+1;
                return bounds;
            }
        }//end font structure class

        public static void generate_font(string font,bool use_ttf) {
            StringBuilder  sb=new StringBuilder();
            font_structure fs=new font_structure(font);
            if (use_ttf) {                                                                                                      //load font if needed
                fs.load_ttf_font();
            }
             
            while( fs.characters_left>0) {
                if(fs.characters_left>=fs.characters_per_page) fs.characters_on_page=fs.characters_per_page;                    //set max chars per page
                if(fs.characters_left<=fs.characters_per_page) fs.characters_on_page=fs.characters_left;                        //set max chars per page
                sb.Append("^XA\r\n");                                                                                           //start the label
                Bitmap      ttf_image  =new Bitmap(fs.page_width,fs.page_height);                                               //only valid for ttf font creation (NO ZPL PRINTER)
                Graphics    ttf_image_g=Graphics.FromImage(ttf_image);
                ttf_image_g.FillRectangle(Brushes.White,new Rectangle(0,0,ttf_image.Width,ttf_image.Height));
                ttf_image_g.TextRenderingHint = TextRenderingHint.AntiAlias;

                 for (int i=0;i<fs.characters_on_page;i++) {
                    Point character_position=fs.get_character_position(fs.character_index);
                    if(!use_ttf) {
                        sb.Append(string.Format("^FO{1},{2}^A{3}N,{4},{5}^FH_^FD_{0:X2}^FS\r\n"  ,(fs.character_index)
                                                                                                ,character_position.X
                                                                                                ,character_position.Y
                                                                                                ,fs.font
                                                                                                ,fs.char_width 
                                                                                                ,fs.char_height));
                    }
                    if (use_ttf) {
                        ttf_image_g.DrawString(((char)fs.character_index).ToString(),fs.ttf_font,fs.brush,character_position);
                    }
                    fs.character_index++;
                    fs.characters_left--;
                }
                sb.Append("^XZ");                                             //end the label
                if (use_ttf) {                                                   //no zpl printer available. lets build the images from TTF fonts...
                    ttf_image.Save(string.Format("./fonts/raster/master-pages/{3}/FONT-{0}-Page-{1}-Scale-{2}.png",font.ToUpper(),fs.page,fs.font_size,fs.dir));
                } else {
                    Image img1=build(sb.ToString());                            //get the image
                    img1.Save(string.Format("./fonts/raster/master-pages/{3}/FONT-{0}-Page-{1}-Scale-{2}.png",font.ToUpper(),fs.page,fs.font_size,fs.dir));
                }
                ttf_image_g.Dispose();
                ttf_image.Dispose();
                sb.Clear();                                                     //empty the ZPL
                fs.page++;
            }//end page loop
            create_font_file_from_zpl_images(fs);                               //Now we have images of every characer, lets create 1 image with all the fonts arranged how we like.
        }//end build function

        public static void create_font_file_from_zpl_images(font_structure fs) {
            fs.characters_left      =fs.character_end_index-fs.character_start_index;                                           //characters under 0x20 are non printable characters (commands)
            fs.character_index      =fs.character_start_index;                                                                  //you can do unicode, but I've not come that far.
            Bitmap  master_image    =new Bitmap(fs.character_pixel_width,(fs.character_pixel_height+1)*(fs.total_characters));  //1 font character wide, x number long.
            Graphics master_image_g =Graphics.FromImage(master_image);
            for (int page_index=0;page_index<fs.page;page_index++) {                                                            //loop through all image files and put them into 1 file.
                Image page2=Image.FromFile(string.Format("./fonts/raster/master-pages/{3}/FONT-{0}-Page-{1}-Scale-{2}.png",fs.font.ToUpper(),page_index,fs.font_size,fs.dir));

                Image page=(Image)new Bitmap(page2.Width,page2.Height);         //this swap is because the image is a indexed format not 32 when from the ZPL printer.
                Graphics page_g=Graphics.FromImage(page);
                page_g.DrawImage(page2,0,0);
                while (fs.characters_left>0) {
                    if(fs.characters_left>=fs.characters_per_page) fs.characters_on_page=fs.characters_per_page;                //set max chars per page
                    if(fs.characters_left<=fs.characters_per_page) fs.characters_on_page=fs.characters_left;                    //set max chars per page
                    for (int i=0;i<fs.characters_on_page;i++) {
                        Point character_position=fs.get_character_position(fs.character_index);
                        int dest_x=0;
                        int dest_y=(fs.character_index-fs.character_start_index)*(fs.character_pixel_height+1);
                        Rectangle src_rect =new Rectangle(character_position.X,character_position.Y,fs.character_pixel_width,fs.character_pixel_height);
                        Rectangle char_bounds=fs.find_character_bounds((Bitmap)page,src_rect);
                        Rectangle dest_rect=new Rectangle(dest_x-char_bounds.X,dest_y,fs.character_pixel_width,fs.character_pixel_height);

                        //copy image to master file
                        master_image_g.DrawImage(page,dest_rect,src_rect,GraphicsUnit.Pixel);

                        //draw seperator line
                        int seperator_y=(fs.character_index-fs.character_start_index+1)*(fs.character_pixel_height+1)-1;
                        master_image_g.DrawLine(fs.pen,5,seperator_y,master_image.Width,seperator_y);
                        
                        //encode bounds in image before spperator line (high / low)
                        Color color2=Color.FromArgb(255,char_bounds.X       >>0xFF      ,char_bounds.X%0xFF,255);
                        Color color3=Color.FromArgb(255,char_bounds.Right   >>0xFF      ,char_bounds.Right%0xFF,255);
                        Color color4=Color.FromArgb(255,char_bounds.Y       >>0xFF,255  ,char_bounds.Y%0xFF);
                        Color color5=Color.FromArgb(255,char_bounds.Bottom  >>0xFF,255  ,char_bounds.Bottom%0xFF);
                        master_image.SetPixel(0,seperator_y,color2);
                        master_image.SetPixel(1,seperator_y,color3);
                        master_image.SetPixel(2,seperator_y,color4);
                        master_image.SetPixel(3,seperator_y,color5);
                        fs.character_index++;
                        fs.characters_left--;
                    }//end loop i
                }//end fs characters while
            }//end page loop
            master_image.Save(string.Format("./fonts/raster/{1}/font-{0}.png",fs.font,fs.dir));         //save the master iamge file.
        }//end function

        public static void generate_raster_fonts() {
            bool use_ttf=true;
            generate_font("A",use_ttf);
            generate_font("B",use_ttf);
            generate_font("C",use_ttf);
            generate_font("D",use_ttf);
            generate_font("E",use_ttf);
            generate_font("F",use_ttf);
            generate_font("G",use_ttf);
            generate_font("GS",use_ttf);
            generate_font("H",use_ttf);
            generate_font("P",use_ttf);
            generate_font("Q",use_ttf);
            generate_font("R",use_ttf);
            generate_font("S",use_ttf);
            generate_font("T",use_ttf);
            generate_font("U",use_ttf);
            generate_font("V",use_ttf);
            generate_font("0",use_ttf);
        }


        public static void draw_string(string font, Image image,int x,int y,int width,int height,string text) {
            font_structure fs=new font_structure(font);
            fs.dir="TTF";
            fs.draw_string(image,x,y,width,height,text);            
        }
    }//end class
}//end namespace
