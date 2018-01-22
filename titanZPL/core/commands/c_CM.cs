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
    public class zpl_cmd_c_CM : zpl_command{   //Change Memory Letter Designation
        public string memory_alias_for_b                                           = String.Empty;
        public string memory_alias_for_e                                           = String.Empty;
        public string memory_alias_for_r                                           = String.Empty;
        public string memory_alias_for_a                                           = String.Empty;
                                        
        public zpl_cmd_c_CM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^CM";                   
            description="Change Memory Letter Designation";                   
            data_format="a,b,c,d ";                   
            example    ="";                   
            memory_alias_for_b                                          =(string)argument(0,data,"s","                   ",""," ");
            memory_alias_for_e                                          =(string)argument(1,data,"s","                   ",""," ");
            memory_alias_for_r                                          =(string)argument(2,data,"s","                   ",""," ");
            memory_alias_for_a                                          =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =memory_alias_for_B //B:, E:,R:, A:, and NONE  //B: 
	
b =memory_alias_for_E //B:, E:,R:, A:, and NONE  //E: 
	
c =memory_alias_for_R //B:, E:,R:, A:, and NONE  //R: 
	
d =memory_alias_for_A //B:, E:,R:, A:, and NONE  //A: 
	
e =multiple_alias //M, or no value  //no value • This parameter is supported on Xi4 and ZM400/ZM600 printers using firmware V53.17.7Z or later. • This parameter is supported on G-Series printers using firmware versions v56.17.7Z and v61.17.7Z or later. • This parameter is supported on printers using firmware V60.17.7Z or later
                                       
  **************************************************/ 
            manual=""+ 
			"^CM – Change Memory Letter Designation "+ 
			"The ^CM command allows you to reassign a letter designation to the printer’s memory devices. If a "+ 
			"format already exists, you can reassign the memory device to the corresponding letter without "+ 
			"forcing, altering, or recreating the format itself. "+ 
			"Using this command affects every subsequent command that refers to specific memory locations. "+ 
			"Format: ^CMa,b,c,d "+ 
			"Comments Unless the e (multiple alias) parameter is used, when two or more parameters "+ 
			"specify the same letter designator, all letter designators are set to their default values. "+ 
			"It is recommended that after entering the ^CM command, ^JUS is entered to save changes to "+ 
			"EEPROM. Any duplicate parameters entered will reset the letter designations back to the default. "+ 
			"If any of the parameters are out of specification, the command is ignored. "+ 
			"Parameters Details "+ 
			"a = memory alias for "+ 
			"B: "+ 
			"Values: B:, E:,R:, A:, and NONE "+ 
			"Default: B: "+ 
			"b = memory alias for "+ 
			"E: "+ 
			"Values: B:, E:,R:, A:, and NONE "+ 
			"Default: E: "+ 
			"c = memory alias for "+ 
			"R: "+ 
			"Values: B:, E:,R:, A:, and NONE "+ 
			"Default: R: "+ 
			"d = memory alias for "+ 
			"A: "+ 
			"Values: B:, E:,R:, A:, and NONE "+ 
			"Default: A: "+ 
			"e = multiple alias "+ 
			"Values: M, or no value "+ 
			"Default: no value "+ 
			"• This parameter is supported on Xi4 and ZM400/ZM600 printers using firmware "+ 
			"V53.17.7Z or later. "+ 
			"• This parameter is supported on G-Series printers using firmware versions "+ 
			"v56.17.7Z and v61.17.7Z or later. "+ 
			"• This parameter is supported on printers using firmware V60.17.7Z or later. "+ 
			"Example 1: This example designates letter E: to point to the B: memory device, and the letter "+ 
			"B: to point to the E:memory device. "+ 
			"^XA "+ 
			"^CME,B,R,A "+ 
			"^JUS "+ 
			"^XZ "+ 
			"Example 2: This example designates that content sent to, or read from the B: or E: memory "+ 
			"locations will be sent to or read from the E: memory location. "+ 
			"^XA "+ 
			"^CME,E,R,A,M "+ 
			"^JUS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^CM "+ 
			"134 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example 3: This example designates that content sent to, or read from the A: or E: memory "+ 
			"locations will be sent to or read from the E: memory location. "+ 
			"^XA "+ 
			"^CMB,E,R,E,M "+ 
			"^JUS "+ 
			"^XZ "+ 
			"Example 4: This example designates that content sent to, or read from the A:, B: or E: "+ 
			"memory locations will be sent to or read from the E: memory location. "+ 
			"^XA "+ 
			"^CME,E,R,E,M "+ 
			"^JUS "+ 
			"^XZ "+ 
			"Note • "+ 
			"Examples 2, 3 and 4 are the only valid uses of the multiple alias parameter. "+ 
			" "+ 
			"135 "+ 
			"ZPL Commands "+ 
			"^CN "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
