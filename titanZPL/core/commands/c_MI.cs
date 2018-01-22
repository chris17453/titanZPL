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
    public class zpl_cmd_c_MI : zpl_command{   //Set Maintenance Information Message
        public string type                                                         = String.Empty;
        public string message                                                      = String.Empty;
                                        
        public zpl_cmd_c_MI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MI";                   
            description="Set Maintenance Information Message";                   
            data_format="type,message ";                   
            example    ="^XA^MIR,PRINT HEAD NEEDS REPLACEMENT - CALL EXT 1000^XZ";                   
            type                                                        =(string)argument(0,data,"s","                   ",""," ");
            message                                                     =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	pe =identifies_the_type_of_alert //
R = head replacement C = head cleaning  //R messag
	ge =message // //
HEAD CLEANIN
	NG =please_clean_printhead // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^MI – Set Maintenance Information Message "+ 
			"The ^MI command controls the content of maintenance alert messages, which are reminders "+ 
			"printed by the printer to instruct the operator to clean or replace the printhead. "+ 
			"Supported Devices "+ 
			"• Xi4, RXi4 "+ 
			"• ZM400/ZM600m RZ400/RZ600 "+ 
			"• S4M with v53.15.5Z or later "+ 
			"•G-Series "+ 
			"Format: ^MItype,message "+ 
			"This command is available only for printers with firmware version V60.15.x, V50.15.x, or "+ 
			"later. "+ 
			"Parameters Details "+ 
			"type = identifies "+ 
			"the type of "+ 
			"alert "+ 
			"Values: "+ 
			"R = head replacement "+ 
			"C = head cleaning "+ 
			"Default: R "+ 
			"message = message "+ 
			"that prints "+ 
			"on the label "+ 
			"when a "+ 
			"maintenance "+ 
			"alert occurs "+ 
			"The maximum length of each message is 63 characters. All characters following the "+ 
			"comma and preceding the next tilde (~) or carat (^) define the message string. "+ 
			"Commas (,) are not allowed in the message. "+ 
			"Default: "+ 
			"HEAD CLEANING = please clean printhead "+ 
			"HEAD REPLACEMENT = please replace printhead "+ 
			"Example: This example sets the printhead (head) replacement warning message. Printing of this "+ 
			"message is controlled by the ^MA command. "+ 
			"1. To customize the text of this label, type something like this: "+ 
			"^XA^MIR,PRINT HEAD NEEDS REPLACEMENT - CALL EXT 1000^XZ "+ 
			"The label prints whatever you program it to say. "+ 
			"2. For this example, the message on the label looks like this: "+ 
			" "+ 
			"271 "+ 
			"ZPL Commands "+ 
			"^ML "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
