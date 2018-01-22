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
    public class zpl_cmd_t_JP : zpl_command{   //Pause and Cancel Format
                                        
        public zpl_cmd_t_JP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JP";                   
            description="Pause and Cancel Format";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JP – Pause and Cancel Format "+ 
			"The ~JP command clears the format currently being processed and places the printer into Pause "+ 
			"Mode. "+ 
			"The command clears the next format that would print, or the oldest format from the buffer. Each "+ 
			"subsequent "+ 
			"~JP command clears the next buffered format until the buffer is empty. The DATA "+ 
			"indicator turns off when the buffer is empty and no data is being transmitted. "+ 
			"Issuing the "+ 
			"~JP command is identical to using CANCEL on the printer, but the printer does not have "+ 
			"to be in Pause Mode first. "+ 
			"Format: ~JP "+ 
			" "+ 
			"241 "+ 
			"ZPL Commands "+ 
			"~JQ "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
