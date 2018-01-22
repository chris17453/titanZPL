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
    public class zpl_cmd_c_FW : zpl_command{   //Field Orientation
        public string rotate_field                                                 = String.Empty;
        public string z                                                            = String.Empty;
                                        
        public zpl_cmd_c_FW(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FW";                   
            description="Field Orientation";                   
            data_format="r,z ";                   
            example    ="^XA"+
			            "^FWR"+
			            "^FO150,90^A0N,25,20^FDZebra Technologies^FS"+
			            "^FO115,75^A0,25,20^FD0123456789^FS"+
			            "^FO150,115^A0N,25,20^FD333 Corporate Woods"+
			            "Parkway^FS"+
			            "^FO400,75^A0,25,20^FDXXXXXXXXX^FS"+
			            "^XZ";                   
            rotate_field                                                =(string)argument(0,data,"s","                   ",""," ");
            z                                                           =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
r =rotate_field //
N = normal R = rotated 90 degrees I = inverted 180 degrees B = bottom-up 270 degrees, read from bottom up Initial Value at Power Up: N z = justification The z parameter is available only with printers with firmware version V60.14.x, V50.14.x, or later. Values: 0 = left justification 1 = right justification 2 = auto justification (script dependent)  //auto for ^TB and left for all other command
                                       
  **************************************************/ 
            manual=""+ 
			"^FW – Field Orientation "+ 
			"The ^FW command sets the default orientation for all command fields that have an orientation "+ 
			"(rotation) parameter (and in x.14 sets the default justification for all commands with a justification "+ 
			"parameter). Fields can be rotated 0, 90, 180, or 270 degrees clockwise by using this command. In "+ 
			"x.14, justification can be left, right, or auto. "+ 
			"The ^FW command affects only fields that follow it. Once you have issued a ^FW command, the "+ 
			"setting is retained until you turn off the printer or send a new ^FW command to the printer. "+ 
			"Format: ^FWr,z "+ 
			"Comments ^FW affects only the orientation in commands where the rotation parameter "+ 
			"has not been specifically set. If a command has a specific rotation parameter, that value is "+ 
			"used. "+ 
			"Parameters Details "+ 
			"r = rotate field "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees "+ 
			"I = inverted 180 degrees "+ 
			"B = bottom-up 270 degrees, read from bottom up "+ 
			"Initial Value at Power Up: N "+ 
			"z = justification "+ 
			"The z parameter is available "+ 
			"only with printers with "+ 
			"firmware version V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			"Values: "+ 
			"0 = left justification "+ 
			"1 = right justification "+ 
			"2 = auto justification (script dependent) "+ 
			"Default: auto for ^TB and left for all other commands "+ 
			"Example: This example shows how ^FW rotation works in conjunction with ^FO. In this example, "+ 
			"note that: "+ 
			"• the fields using A0N print the field in normal rotation "+ 
			"• the fields with no rotation indicated (A0) follow the rotation used in the ^FW command "+ 
			"( "+ 
			"^FWR). "+ 
			"^XA "+ 
			"^FWR "+ 
			"^FO150,90^A0N,25,20^FDZebra Technologies^FS "+ 
			"^FO115,75^A0,25,20^FD0123456789^FS "+ 
			"^FO150,115^A0N,25,20^FD333 Corporate Woods "+ 
			"Parkway^FS "+ 
			"^FO400,75^A0,25,20^FDXXXXXXXXX^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"181 "+ 
			"ZPL Commands "+ 
			"^FW "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"^FW affects only the justification in commands where the parameter has not been set. If a "+ 
			"command has a specific justification parameter that value is used . "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FX "+ 
			"182 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
