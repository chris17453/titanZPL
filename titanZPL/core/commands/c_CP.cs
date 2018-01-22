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
    public class zpl_cmd_c_CP : zpl_command{   //Remove Label
        public string change_control_command_character                             = String.Empty;
                                        
        public zpl_cmd_c_CP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^CP";                   
            description="Remove Label";                   
            data_format="a ";                   
            example    ="^XA"+
			            "^CT+"+
			            "^XZ";                   
            change_control_command_character                            =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =kiosk_present_mode //
0 = Eject presented page 1 = Retracts presented page 2 = Takes the action defined by c parameter of ^KV command.  //none The command is ignored if parameters are missing or invalid.  139 ZPL Commands ^CT ~CT 11/21/16 Zebra Programming Guide P1012728-011 ^CT ~CT – Change Tilde The ^CT and ~CT commands are used to change the control command prefix. The default prefix is the tilde (~). Format: ^CTa or ~CTa Parameters Details 
	
a =change_control_command_character //any ASCII character  //a parameter is required. If a parameter is not entered, the next character received is the new control command character
                                       
  **************************************************/ 
            manual=""+ 
			"^CP – Remove Label "+ 
			"The ^CP command causes the printer to move a printed label out of the presenter area in one of "+ 
			"several ways. "+ 
			"Supported Devices "+ 
			"•KR403 "+ 
			"Format: ^CPa "+ 
			"Parameters Details "+ 
			"a = kiosk present "+ 
			"mode "+ 
			"Values: "+ 
			"0 = Eject presented page "+ 
			"1 = Retracts presented page "+ 
			"2 = Takes the action defined by c parameter of ^KV command. "+ 
			"Default: none "+ 
			"The command is ignored if parameters are missing or invalid. "+ 
			" "+ 
			"139 "+ 
			"ZPL Commands "+ 
			"^CT ~CT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"^CT ~CT – Change Tilde "+ 
			"The ^CT and ~CT commands are used to change the control command prefix. The default prefix is "+ 
			"the tilde (~). "+ 
			"Format: ^CTa or ~CTa "+ 
			"Parameters Details "+ 
			"a = change control "+ 
			"command "+ 
			"character "+ 
			"Values: any ASCII character "+ 
			"Default: a parameter is required. If a parameter is not entered, the next character "+ 
			"received is the new control command character. "+ 
			"Example: This is an example of how to change the control command prefix from a ^ to a +: "+ 
			"^XA "+ 
			"^CT+ "+ 
			"^XZ "+ 
			"+HS "+ 
			" "+ 
			"ZPL Commands "+ 
			"^CV "+ 
			"140 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
