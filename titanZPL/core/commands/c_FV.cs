/*****************************************************************************
*       ████████╗██╗████████╗ █████╗ ███╗   ██╗███████╗██████╗ ██╗           *
*       ╚══██╔══╝██║╚══██╔══╝██╔══██╗████╗  ██║╚══███╔╝██╔══██╗██║           *
*          ██║   ██║   ██║   ███████║██╔██╗ ██║  ███╔╝ ██████╔╝██║           *
*          ██║   ██║   ██║   ██╔══██║██║╚██╗██║ ███╔╝  ██╔═══╝ ██║           *
*          ██║   ██║   ██║   ██║  ██║██║ ╚████║███████╗██║     ███████╗      *
*          ╚═╝   ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝╚═╝     ╚══════╝      *
******************************************************************************
*      Created By: Charles Watkins                                           *
*      Date      : 2017-10-12                                                *
*****************************************************************************/
using System;
using System.Collections.Generic;
namespace titanZPL.commands  {
    public class zpl_cmd_c_FV : zpl_command{   //Field Variable
        public string field_data  = String.Empty;
        public zpl_cmd_c_A a;                                                   //requires an A to draw strings.
        public zpl_cmd_c_FB fb;                                                   //requires an A to draw strings.
                                                
        public zpl_cmd_c_FV(string data,List<zpl_command> commands):base(commands){                    
            a =(zpl_cmd_c_A )find_in_field("^A");
            fb=(zpl_cmd_c_FB)find_in_field("^FB");
                        cmd        ="^FV";                   
            description="Field Variable";                   
            data_format="a ";                   
            example    ="^XA"+
			            "^FO40,40"+
			            "^GB300,203,8^FS"+
			            "^FO55,60^CF0,25"+
			            "^FVVARIABLE DATA #1^FS"+
			            "^FO80,150"+
			            "^FDFIXED DATA^FS"+
			            "^MCN"+
			            "^XZ";              
            _internal.argument_max=1;
            field_data  =(string)argument(0,data,"s","*",""," ");
                                    
  /*************************************************  
	
a =variable_field_data_to_be_printed //0 to 3072 byte string  //if no data is entered, the command is ignore
                                       
  **************************************************/ 
            manual=""+ 
			"^FV – Field Variable "+ 
			"^FV replaces the ^FD (field data) command in a label format when the field is variable. "+ 
			"Format: ^FVa "+ 
			"Comments ^FV fields are always cleared after the label is printed. ^FD fields are not "+ 
			"cleared. "+ 
			"Parameters Details "+ 
			"a = variable field "+ 
			"data to be "+ 
			"printed "+ 
			"Values: 0 to 3072 byte string "+ 
			"Default: if no data is entered, the command is ignored "+ 
			"Example: This is an example of how to use the ^MC and ^FV command: "+ 
			"^XA "+ 
			"^FO40,40 "+ 
			"^GB300,203,8^FS "+ 
			"^FO55,60^CF0,25 "+ 
			"^FVVARIABLE DATA #1^FS "+ 
			"^FO80,150 "+ 
			"^FDFIXED DATA^FS "+ 
			"^MCN "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO55,60 "+ 
			"^FVVARIABLE DATA #2^FS "+ 
			"^MCY "+ 
			"^XZ "+ 
			"^CF0,25 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FW "+ 
			"180 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function     
        public override void draw() {
            bool reverse=false;
            if(null!=a.fr) reverse=true;
            else           reverse=false;
            int lines=0;
            int width=0;
            if (fb!=null) {
                width=fb.width_of_text_block_line;
                lines=fb.maximum_number_of_lines;    
            }
            draw_string(a.font,a.font_width,a.font_height,field_data,reverse,width,lines) ;
          }                
    }//end class                                  
}//end namespace                                  
