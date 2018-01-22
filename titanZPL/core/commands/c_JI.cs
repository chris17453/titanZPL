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
    public class zpl_cmd_c_JI : zpl_command{   //Start ZBI (Zebra BASIC Interpreter)
        public string location                                                     = String.Empty;
        public string name_of_program                                              = String.Empty;
        public string extension_of_program_to_run_after_initializatio_n_fixed_value = String.Empty;
        public string b                                                            = String.Empty;
        public string echoing_control                                              = String.Empty;
        public string memory_allocation_for_zbi                                    = String.Empty;
                                        
        public zpl_cmd_c_JI(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JI";                   
            description="Start ZBI (Zebra BASIC Interpreter)";                   
            data_format="d,o,x,b,c,d ";                   
            example    ="";                   
            location                                                    =(string)argument(0,data,"s","                   ",""," ");
            name_of_program                                             =(string)argument(1,data,"s","                   ",""," ");
            extension_of_program_to_run_after_initializatio_n_fixed_value=(string)argument(2,data,"s","                   ",""," ");
            b                                                           =(string)argument(3,data,"s","                   ",""," ");
            echoing_control                                             =(string)argument(4,data,"s","                   ",""," ");
            memory_allocation_for_zbi                                   =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_program_to_run_after_initializatio_n //R:, E:, B:, and A:  //location must be specified 
	
o =name_of_program_to_run_after_initializatio_n //any valid program name  //name must be specified 
	
x =extension_of_program_to_run_after_initializatio_n_Fixed_Value //
Y = console on N = console off  //Y 
	
c =echoing_control //
Y = echo on N = echo off  //Y 
	
d =memory_allocation_for_ZBI //20K to 1024K  //50K  ZPL Commands ^JI 232 P1012728-011 Zebra Programming Guide 11/21/16 Only one ZBI interpreter can be active in the printer at a time. If a second ^JI or ~JI command is received while the interpreter is running, the command is ignored. The interpreter is deactivated by entering one of two commands: ZPL at the ZBI prompt ~JQ at an active ZPL port  233 ZPL Commands ~JI 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^JI – Start ZBI (Zebra BASIC Interpreter) "+ 
			"^JI works much like the ~JI command. Both commands are sent to the printer to initialize the "+ 
			"Zebra BASIC Interpreter. "+ 
			"In interactive mode, "+ 
			"^JI can be sent through one of the communication ports (serial, parallel, or "+ 
			"Ethernet) to initialize the printer to receive ZBI commands. This command can be sent from one of "+ 
			"the Zebra software utilities, such as ZTools, or from a terminal emulation program. "+ 
			"When the command is received, the printer responds by sending a ZBI header back to the console, "+ 
			"along with the program version number. This indicates that the interpreter is active. "+ 
			"Format: ^JId:o.x,b,c,d "+ 
			"* This parameter is only available on printers with firmware V60.12.0.x or earlier. "+ 
			"Comments When the printer is turned on, it can receive ZPL II commands and label formats. "+ 
			"However, for the printer to recognize ZBI commands and programs, it must be initialized using "+ 
			"^JI "+ 
			"or "+ 
			"~JI. "+ 
			"Identifies features that are available in printers with firmware version V60.16.2Z, V53.16.2Z, "+ 
			"or later. "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"program to "+ 
			"run after "+ 
			"initializatio "+ 
			"n "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: location must be specified "+ 
			"o = name of "+ 
			"program to "+ 
			"run after "+ 
			"initializatio "+ 
			"n "+ 
			"Values: any valid program name "+ 
			"Default: name must be specified "+ 
			"x = extension of "+ 
			"program to "+ 
			"run after "+ 
			"initializatio "+ 
			"n "+ 
			"Fixed Value: .BAS, .BAE "+ 
			".BAE "+ 
			"is only supported in firmware version "+ 
			"V60.16.0Z or later "+ 
			"b = console "+ 
			"control "+ 
			"Values: "+ 
			"Y = console on "+ 
			"N = console off "+ 
			"Default: Y "+ 
			"c = echoing "+ 
			"control "+ 
			"Values: "+ 
			"Y = echo on "+ 
			"N = echo off "+ 
			"Default: Y "+ 
			"d = memory "+ 
			"allocation "+ 
			"for ZBI * "+ 
			"Values: 20K to 1024K "+ 
			"Default: 50K "+ 
			" "+ 
			"ZPL Commands "+ 
			"^JI "+ 
			"232 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Only one ZBI interpreter can be active in the printer at a time. If a second ^JI or ~JI command is "+ 
			"received while the interpreter is running, the command is ignored. "+ 
			"The interpreter is deactivated by entering one of two commands: "+ 
			"ZPL at the ZBI prompt "+ 
			"~JQ at an active ZPL port "+ 
			" "+ 
			"233 "+ 
			"ZPL Commands "+ 
			"~JI "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
