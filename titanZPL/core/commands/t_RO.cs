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
    public class zpl_cmd_t_RO : zpl_command{   //Reset Advanced Counters
        public string counter_number                                               = String.Empty;
                                        
        public zpl_cmd_t_RO(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~RO";                   
            description="Reset Advanced Counters";                   
            data_format="c ";                   
            example    ="";                   
            counter_number                                              =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
c =counter_number //
1 = reset counter 1 2 = reset counter 2 3 = reset valid RFID label counter 4 = reset voided RFID label counter C=reset head cleaned counter x R=reset head replaced counter and head cleaned counter x  //a value must be specified or the command is ignored x. These values are supported only on Xi4, RXi4, ZM400/ZM600, RZ400/RZ600, S4M, and G-Series printers
                                       
  **************************************************/ 
            manual=""+ 
			"~RO – Reset Advanced Counters "+ 
			"The ~RO command resets the advanced counters used by the printer to monitor label generation in "+ 
			"inches, centimeters, and number of labels. "+ 
			"Format: ~ROc "+ 
			"Parameters Details "+ 
			"c = counter number "+ 
			"Values: "+ 
			"1 = reset counter 1 "+ 
			"2 = reset counter 2 "+ 
			"3 = reset valid RFID label counter "+ 
			"4 = reset voided RFID label counter "+ 
			"C=reset head cleaned counter "+ 
			"x "+ 
			"R=reset head replaced counter and head cleaned counter "+ 
			"x "+ 
			"Default: a value must be specified or the command is ignored "+ 
			"x. These values are supported only on Xi4, RXi4, ZM400/ZM600, RZ400/RZ600, S4M, and G-Series printers. "+ 
			"Example 1: This example shows how the counter portion of the printer configuration labels "+ 
			"looks when counter 1 is reset by sending "+ 
			"~RO1. "+ 
			"Before "+ 
			"After "+ 
			" "+ 
			"303 "+ 
			"ZPL Commands "+ 
			"^SC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
