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
    public class zpl_cmd_c_MP : zpl_command{   //Mode Protection
        public string mode_to_protect                                              = String.Empty;
                                        
        public zpl_cmd_c_MP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MP";                   
            description="Mode Protection";                   
            data_format="a ";                   
            example    ="^XA"+
			            "^MPD"+
			            "^MPC"+
			            "^XZ";                   
            mode_to_protect                                             =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =mode_to_protect //
D = disable Darkness Mode P = disable Position Mode C = disable Calibration Mode E = enable all modes S = disable all mode saves (modes can be adjusted but values are not saved) W = disable Pause F = disable Feed X = disable Cancel M = disable menu changes  //a value must be entered or the command is ignored  ZPL Commands ^MP 276 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^MP – Mode Protection "+ 
			"The ^MP command is used to disable the various mode functions on the control panel. Once "+ 
			"disabled, the settings for the particular mode function can no longer be changed and the LED "+ 
			"associated with the function does not light. "+ 
			"Because this command has only one parameter, each mode must be disabled with an individual "+ 
			"^MP "+ 
			"command. "+ 
			"Format: ^MPa "+ 
			"Parameters Details "+ 
			"a = mode to protect "+ 
			"Values: "+ 
			"D = disable Darkness Mode "+ 
			"P = disable Position Mode "+ 
			"C = disable Calibration Mode "+ 
			"E = enable all modes "+ 
			"S = disable all mode saves (modes can be adjusted but values are not "+ 
			"saved) "+ 
			"W = disable Pause "+ 
			"F = disable Feed "+ 
			"X = disable Cancel "+ 
			"M = disable menu changes "+ 
			"Default: a value must be entered or the command is ignored "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MP "+ 
			"276 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This example shows the ZPL code that disables modes D and C. It also shows the "+ 
			"effects on the configuration label before and after the ZPL code is sent: "+ 
			"^XA "+ 
			"^MPD "+ 
			"^MPC "+ 
			"^XZ "+ 
			"Before "+ 
			"After "+ 
			" "+ 
			"277 "+ 
			"ZPL Commands "+ 
			"^MT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
