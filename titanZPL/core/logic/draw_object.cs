using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titanZPL.commands;

namespace titanZPL{
    public partial class titanZPL {
        //this is the final resting place of all drawing commands.....

        Font ide_property_font=new Font("Courier New",12,FontStyle.Regular);
               
        public void draw_object(zpl_command cmd) {
            if(null==cmd._internal.image) return;       //lots of commands dont have representation. its cool dont cry..
                                                        //future handel orentation here...
            int x=0;
            int y=0;

            x=cmd._internal.x;
            y=cmd._internal.y;

            if (cmd._internal.highlight) {
                int bound_width  =6;
                int bound_width_2=3;
                Rectangle rect=cmd.get_bounds();
                rect.X=x-bound_width_2;
                rect.Y=y-bound_width_2;
                rect.Width +=bound_width;
                rect.Height+=bound_width;
                graphics.DrawRectangle(new Pen(Brushes.Red,bound_width),rect);
                string coords=String.Format("{2}:{0},{1} REAL: {0},{3}",x,y,cmd._internal.cooridinate_mode,y+cmd._internal.baseline);
                SizeF       coords_dim  =graphics.MeasureString(coords,ide_property_font);
                coords_dim.Width+=20;


                
                Rectangle   coord_box   =new Rectangle((int)x-bound_width   ,(int)(y-bound_width-coords_dim.Height-20),(int)(coords_dim.Width)+20,(int)(coords_dim.Height)+20);
                Rectangle   coord_text  =new Rectangle((int)x-bound_width+10,(int)(y-bound_width-coords_dim.Height-10),(int)(coords_dim.Width)   ,(int)(coords_dim.Height));

                if(coord_box.Y<0) {
                    coord_box.Y +=rect.Height+20;
                    coord_text.Y+=rect.Height+20;
                }
                if (coord_box.X<0) {
                    coord_box.X =0;
                    coord_text.X=0;
                }
                
                
                graphics.FillRectangle(Brushes.Black,coord_box);
                graphics.DrawString(coords,ide_property_font,Brushes.White,coord_text);
            }
            graphics.DrawImage(cmd._internal.image,x,y);           // <-- work horse
         
        }

    }//end class
}//end namespace
