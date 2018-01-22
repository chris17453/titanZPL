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
    public class zpl_cmd_c_JZ : zpl_command{   //Reprint After Error
        public string reprint_after_error                                          = String.Empty;
                                        
        public zpl_cmd_c_JZ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JZ";                   
            description="Reprint After Error";                   
            data_format="a ";                   
            example    ="";                   
            reprint_after_error                                         =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =reprint_after_error // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^JZ – Reprint After Error "+ 
			"The ^JZ command reprints a partially printed label caused by a Ribbon Out, Media Out, or "+ 
			"Head Open error condition. The label is reprinted as soon as the error condition is corrected. "+ 
			"This command remains active until another "+ 
			"^JZ command is sent to the printer or the printer is "+ 
			"turned off. "+ 
			"Format: ^JZa "+ 
			"Comments ^JZ sets the error mode for the printer. If ^JZ changes, only labels printed after "+ 
			"the change are affected. "+ 
			"If the parameter is missing or incorrect, the command is ignored. "+ 
			"Parameters Details "+ 
			"a = reprint after "+ 
			"error "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Initial Value at Power Up: Y "+ 
			" "+ 
			"ZPL Commands "+ 
			"~KB "+ 
			"250 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
