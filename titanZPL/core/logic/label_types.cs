using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL{
    public class label_types {
        public class label_type {
            public float width      { get; set; }
            public float height     { get; set; }
            public int dpi          { get; set; }
            public String name      { get; set; }
            public label_type()     {
            }
            public label_type(string name,float w,float h,int d) {
                width=w;
                height=h;
                dpi=d;
                this.name=name;
            }
        }
        public BindingList<label_type> items=new BindingList<label_type>();
        public label_types() {
            float[] w= {4};                             //known width
            float[] h= {4,6,6.75f,8,9 };                //known heights
            int  [] d= {72,96,152,203,300,600 };        //known dpi's
            
            foreach(int   _d in d) {
            foreach(float _w in w) {
            foreach(float _h in h) {
                items.Add(new label_type(string.Format("{0}x{1}   x{2}",_w,_h,_d),_w,_h,_d));
            }
            }
            }
        }
        public label_type auto_select_dimention(SizeF dimention){
            foreach(label_type item in items) {
                if(item.width *item.dpi>dimention.Width && 
                   item.height*item.dpi>dimention.Height) return item;
            }
            return null;
        }

    }
}
