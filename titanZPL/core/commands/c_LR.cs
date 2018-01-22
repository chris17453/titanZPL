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
    public class zpl_cmd_c_LR : zpl_command{   //Label Reverse Print
        public string reverse_print_fields                                         = String.Empty;
                                        
        public zpl_cmd_c_LR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^LR";                   
            description="Label Reverse Print";                   
            data_format="a ";                   
            example    ="^XA^LRY"+
			            "^FO100,50"+
			            "^GB195,203,195^FS"+
			            "^FO180,110^CFG"+
			            "^FDLABEL^FS"+
			            "^FO130,170"+
			            "^FDREVERSE^FS"+
			            "^XZ";                   
            reverse_print_fields                                        =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =reverse_print_all_fields // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^LR – Label Reverse Print "+ 
			"The ^LR command reverses the printing of all fields in the label format. It allows a field to appear as "+ 
			"white over black or black over white. "+ 
			"Using the "+ 
			"^LR is identical to placing an ^FR command in all current and subsequent fields. "+ 
			"Format: ^LRa "+ 
			"Comments The ^LR setting remains active unless turned off by ^LRN or the printer is "+ 
			"turned off. "+ 
			"Only fields following this command are affected. "+ 
			"Parameters Details "+ 
			"a = reverse print all "+ 
			"fields "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Initial Value at Power Up: N or last permanently saved value "+ 
			"Example: This is an example that shows printing white over black and black over white. The ^GB "+ 
			"command is used to create the black background. "+ 
			"Note • ^GB needs to be used together with ^LR. "+ 
			"^XA^LRY "+ 
			"^FO100,50 "+ 
			"^GB195,203,195^FS "+ 
			"^FO180,110^CFG "+ 
			"^FDLABEL^FS "+ 
			"^FO130,170 "+ 
			"^FDREVERSE^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"263 "+ 
			"ZPL Commands "+ 
			"^LS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
