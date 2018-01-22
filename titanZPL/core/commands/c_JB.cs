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
    public class zpl_cmd_c_JB : zpl_command{   //Initialize Flash Memory
        public string device_to_initialize                                         = String.Empty;
                                        
        public zpl_cmd_c_JB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JB";                   
            description="Initialize Flash Memory";                   
            data_format="a ";                   
            example    ="";                   
            device_to_initialize                                        =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =device_to_initialize //
A = Option Flash memory B = Flash card (PCMCIA) E = internal Flash memory  //a device must be specifie
                                       
  **************************************************/ 
            manual=""+ 
			"^JB – Initialize Flash Memory "+ 
			"The ^JB command is used to initialize various types of Flash memory available in the Zebra "+ 
			"printers. "+ 
			"Format: ^JBa "+ 
			"Parameters Details "+ 
			"a = device to "+ 
			"initialize "+ 
			"Values: "+ 
			"A = Option Flash memory "+ 
			"B = Flash card (PCMCIA) "+ 
			"E = internal Flash memory "+ 
			"Default: a device must be specified "+ 
			"Example: This is an example of initializing the different types of flash memory: "+ 
			"^JBA – initializes initial Compact Flash memory when installed in the printer. "+ 
			"^JBB – initializes the optional Flash card when installed in the printer. "+ 
			"^JBE – initializes the optional Flash memory when installed in the printer. "+ 
			"Note • "+ 
			"Initializing memory can take several minutes. Be sure to allow sufficient time for the "+ 
			"initialization to complete before power cycling the printer. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JB "+ 
			"222 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
