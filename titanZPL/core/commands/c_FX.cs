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
    public class zpl_cmd_c_FX : zpl_command{   //Comment
        public string non_printing                                                 = String.Empty;
                                        
        public zpl_cmd_c_FX(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FX";                   
            description="Comment";                   
            data_format="c ";                   
            example    ="^XA"+
			            "^LH100,100^FS"+
			            "^FXSHIPPING LABEL^FS"+
			            "^FO10,10^GB470,280,4^FS"+
			            "^FO10,190^GB470,4,4^FS"+
			            "^FO10,80^GB240,2,2^FS"+
			            "^FO250,10^GB2,100,2^FS"+
			            "^FO250,110^GB226,2,2^FS"+
			            "^FO250,60^GB226,2,2^FS"+
			            "^FO156,190^GB2,95,2^FS"+
			            "^FO312,190^GB2,95,2^FS"+
			            "^XZ";                   
            non_printing                                                =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
c =non_printing // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^FX – Comment "+ 
			"The ^FX command is useful when you want to add non-printing informational comments or "+ 
			"statements within a label format. Any data after the ^FX command up to the next caret (^) or tilde (~) "+ 
			"command does not have any effect on the label format. Therefore, you should avoid using the caret "+ 
			"(^) or tilde (~) commands within the "+ 
			"^FX statement. "+ 
			"Format: ^FXc "+ 
			"Comments Correct usage of the ^FX command includes following it with the ^FS "+ 
			"command. "+ 
			"Parameters Details "+ 
			"c = non printing "+ 
			"comment "+ 
			"Creates a non-printable comment. "+ 
			"Example: This is an example of how to use the ^FX command effectively: "+ 
			"^XA "+ 
			"^LH100,100^FS "+ 
			"^FXSHIPPING LABEL^FS "+ 
			"^FO10,10^GB470,280,4^FS "+ 
			"^FO10,190^GB470,4,4^FS "+ 
			"^FO10,80^GB240,2,2^FS "+ 
			"^FO250,10^GB2,100,2^FS "+ 
			"^FO250,110^GB226,2,2^FS "+ 
			"^FO250,60^GB226,2,2^FS "+ 
			"^FO156,190^GB2,95,2^FS "+ 
			"^FO312,190^GB2,95,2^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"183 "+ 
			"ZPL Commands "+ 
			"^GB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
