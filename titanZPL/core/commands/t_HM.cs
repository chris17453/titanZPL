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
    public class zpl_cmd_t_HM : zpl_command{   //Host RAM Status
                                        
        public zpl_cmd_t_HM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~HM";                   
            description="Host RAM Status";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~HM – Host RAM Status "+ 
			"Sending ~HM to the printer immediately returns a memory status message to the host. Use this "+ 
			"command whenever you need to know the printer’s RAM status. "+ 
			"When "+ 
			"~HM is sent to the Zebra printer, a line of data containing information on the total amount, "+ 
			"maximum amount, and available amount of memory is sent back to the host. "+ 
			"Format: ~HM "+ 
			"Comments Memory taken up by bitmaps is included in the currently available memory "+ 
			"value (due to "+ 
			"^MCN). "+ 
			"Downloading a graphic image, fonts, or saving a bitmap affects only the amount of RAM. The total "+ 
			"amount of RAM and maximum amount of RAM does not change after the printer is turned on. "+ 
			"Example: This example shows when the ~HM is sent to the printer, a line of data containing three "+ 
			"numbers are sent back to the host. Each set of numbers is identified and explained in the table that "+ 
			"follows: "+ 
			"1024,0780,0780 "+ 
			"2 "+ 
			"1 "+ 
			"3 "+ 
			"1 "+ 
			"The total amount of RAM (in kilobytes) installed in the printer. In this "+ 
			"example, the printer has 1024K RAM installed. "+ 
			"2 "+ 
			"The maximum amount of RAM (in kilobytes) available to the user. In "+ 
			"this example, the printer has a maximum of 780K RAM available. "+ 
			"3 "+ 
			"The amount of RAM (in kilobytes) currently available to the user. In "+ 
			"this example, there is 780K of RAM in the printer currently available "+ 
			"to the user. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HQ "+ 
			"198 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
