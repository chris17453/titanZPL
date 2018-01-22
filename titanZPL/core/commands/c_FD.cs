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
    public class zpl_cmd_c_FD : zpl_command{   //Field Data
        public string field_data                                                 = String.Empty;
        public zpl_cmd_c_A  a;                                                   //requires an A to draw strings.
        public zpl_cmd_c_FB fb;                                                   //fb for bounds
                                        
        public zpl_cmd_c_FD(string data,List<zpl_command> commands):base(commands){                    
            a =(zpl_cmd_c_A )find_in_field("^A");
            fb=(zpl_cmd_c_FB)find_in_field("^FB");
                   cmd        ="^FD";                   
            description="Field Data";                   
            data_format="a ";                   
            example    ="";                   
            _internal.argument_max=1;
            field_data                                                           =(string)argument(0,data,"s","*","","");
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^FD – Field Data "+ 
			"The ^FD command defines the data string for a field. The field data can be any printable character "+ 
			"except those used as command prefixes (^ and ~). "+ 
			"In RFID printers, it can also be used to specify passwords to write to tags. "+ 
			"Format: ^FDa "+ 
			"Comments The ^ and ~ characters can be printed by changing the prefix characters—see "+ 
			"^CD ~CD on page 127 and ^CT ~CT on page 139. The new prefix characters cannot be printed. "+ 
			"Characters with codes above 127, or the ^ and ~ characters, can be printed using the ^FH and ^FD "+ 
			"commands. "+ 
			"• ^CI13 must be selected to print a backslash (\\). "+ 
			"For information on using soft hyphens, see Comments on the ^FB command on page 161. "+ 
			"Parameters Details "+ 
			"a = "+ 
			"• data to be printed (all "+ 
			"printers), or "+ 
			"• a password to be written "+ 
			"to a RFID tag (rfid "+ 
			"printers) "+ 
			"Values: any data string up to 3072 bytes "+ 
			"Default: none—a string of characters must be entered "+ 
			" "+ 
			"165 "+ 
			"ZPL Commands "+ 
			"^FH "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
        public override void draw() {
    
            bool reverse=false;
            if(null!=a.fr) reverse=true;
            else reverse =false;
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
