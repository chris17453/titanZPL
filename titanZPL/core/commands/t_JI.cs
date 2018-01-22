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
    public class zpl_cmd_t_JI : zpl_command{   //Start ZBI (Zebra BASIC Interpreter)
                                        
        public zpl_cmd_t_JI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JI";                   
            description="Start ZBI (Zebra BASIC Interpreter)";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~JI – Start ZBI (Zebra BASIC Interpreter) "+ 
			"~JI works much like the ^JI command. Both commands are sent to the printer to initialize the "+ 
			"Zebra BASIC Interpreter. "+ 
			"In interactive mode, "+ 
			"~JI can be sent through one of the communication ports (serial, parallel, or "+ 
			"Ethernet) to initialize the printer to receive ZBI commands. This command can be sent from one of "+ 
			"the Zebra software utilities, such as ZTools, or from a standard PC program, such as Hyper terminal. "+ 
			"When the command is received, the printer responds by sending a ZBI header back to the console, "+ 
			"along with the program version number. This indicates that the interpreter is active. "+ 
			"Format: ~JI "+ 
			"Comments While receiving commands, the printer echoes the received characters back to the "+ 
			"source. This can be toggled on and off with the ZBI ECHO command. "+ 
			"When the printer is turned on, it can receive ZPL II commands and label formats. However, for the "+ 
			"printer to recognize ZBI commands and formats, it must be initialized using "+ 
			"^JI or ~JI. "+ 
			"Only one ZBI interpreter can be active in the printer at a time. If a second "+ 
			"~JI or ^JI command is "+ 
			"received while the interpreter is running, the command is ignored. "+ 
			"The interpreter is deactivated by entering one of these commands: "+ 
			"ZPL at the ZBI prompt "+ 
			"~JQ at an active ZPL port "+ 
			"Identifies features that are available in printers with firmware version V60.16.2Z, V53.16.2Z, "+ 
			"or later. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^JJ "+ 
			"234 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
