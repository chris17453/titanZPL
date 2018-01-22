using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL {
    public class zpl_RLE {
        public string data=String.Empty;

        public zpl_RLE(string data,int total_bytes,int bytes_per_row) {
            int index=0;
            int qty=0;
            bytes_per_row*=2;
            
            StringBuilder o=new StringBuilder();
            int c_index=0;
            foreach (char c in data) {
                switch(c) {
                    case 'G': qty+=1; break;
                    case 'H': qty+=2; break;
                    case 'I': qty+=3; break;
                    case 'J': qty+=4; break;
                    case 'K': qty+=5; break;
                    case 'L': qty+=6; break;
                    case 'M': qty+=7; break;
                    case 'N': qty+=8; break;
                    case 'O': qty+=9; break;
                    case 'P': qty+=10; break;
                    case 'Q': qty+=11; break;
                    case 'R': qty+=12; break;
                    case 'S': qty+=13; break;
                    case 'T': qty+=14; break;
                    case 'U': qty+=15; break;
                    case 'V': qty+=16; break;
                    case 'W': qty+=17; break;
                    case 'X': qty+=18; break;
                    case 'Y': qty+=19; break;
                    case 'g': qty+=20; break;
                    case 'h': qty+=40; break;
                    case 'i': qty+=60; break;
                    case 'j': qty+=80; break;
                    case 'k': qty+=100; break;
                    case 'l': qty+=120; break;
                    case 'm': qty+=140; break;
                    case 'n': qty+=160; break;
                    case 'o': qty+=180; break;
                    case 'p': qty+=200; break;
                    case 'q': qty+=220; break;
                    case 'r': qty+=240; break;
                    case 's': qty+=260; break;
                    case 't': qty+=280; break;
                    case 'u': qty+=300; break;
                    case 'v': qty+=320; break;
                    case 'w': qty+=340; break;
                    case 'x': qty+=360; break;
                    case 'y': qty+=380; break;
                    case 'z': qty+=400; break;
                    case ':': string temp="";
                                if(o.Length>=bytes_per_row) {
                                    temp =o.ToString().Substring(o.Length-bytes_per_row);
                                    o.Append(temp);
                                } else {
                                    for(int x3=0;x3<bytes_per_row;x3++) o.Append("0");
                                }
                                
                                qty =0;
                              break;
                    case ',':   int start=index%bytes_per_row;
                                for(int x2=start;x2<bytes_per_row;x2++) o.Append("0");
                                //index+=bytes_per_row-start;
                                qty =0;
                                break;
                    case '!':   int start2=index%bytes_per_row;
                                for(int x2=start2;x2<bytes_per_row;x2++) o.Append("F");
                                qty =0;
                                break;
                    default:    if(qty==0)
                                    qty =1;
                                if((c>='A' && c<='F') || (c>='0' && c<='9')) {
                                    for (int i=0;i<qty;i++) o.Append(c.ToString());
                                    qty =0;
                                }
                                break;
                }
                index=o.Length;
                c_index++;
              
            }
            this.data=o.ToString();
        }//end init
    }//end class
}
