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
    public class zpl_cmd_c_DF : zpl_command{   //Download Format
        public string device_to_store_image                                        = String.Empty;
        public string image_name                                                   = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_DF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^DF";                   
            description="Download Format";                   
            data_format="d,o,x ";                   
            example    ="^XA"+
			            "^DFR:STOREFMT.ZPL^FS"+
			            "^FO25,25"+
			            "^AD,36,20^FN1^FS"+
			            "^FO165,25"+
			            "^AD,36,20^FN2^FS"+
			            "^FO25,75"+
			            "^AB,22,14^FDBUILT BY^FS"+
			            "^FO25,125"+
			            "^AE,28,15^FN1"+
			            "^XZ";                   
            device_to_store_image                                       =(string)argument(0,data,"s","                   ",""," ");
            image_name                                                  =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =device_to_store_image //R:, E:, B:, and A:  //R: 
	
o =image_name //1 to 16 alphanumeric characters with a file type of 1 to 3 alphanumeric characters separated by a '.'  //if a name is not specified, UNKNOWN is used. 
	
x =extension // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^DF – Download Format "+ 
			"The ^DF command saves ZPL II format commands as text strings to be later merged using ^XF with "+ 
			"variable data. The format to be stored might contain field number (^FN) commands to be referenced "+ 
			"when recalled. "+ 
			"While use of stored formats reduces transmission time, no formatting time is saved—this command "+ 
			"saves ZPL II as text strings formatted at print time. "+ 
			"Enter the "+ 
			"^DF stored format command immediately after the ^XA command, then enter the format "+ 
			"commands to be saved. "+ 
			"Format: ^DFd:o.x "+ 
			"For a complete example of the "+ 
			"^DF and ^XF command, see ^DF and ^XF — Download format and "+ 
			"recall format on page 35. "+ 
			"Parameters Details "+ 
			"d = device to store "+ 
			"image "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = image name "+ 
			"Values: 1 to 16 alphanumeric characters with a file type of 1 to 3 alphanumeric "+ 
			"characters separated by a '.' "+ 
			"Default: if a name is not specified, UNKNOWN is used. "+ 
			"x = extension "+ 
			"Format: .ZPL "+ 
			"Example: This example is generated using the ^XF command to recall this format: "+ 
			"^XA "+ 
			"^DFR:STOREFMT.ZPL^FS "+ 
			"^FO25,25 "+ 
			"^AD,36,20^FN1^FS "+ 
			"^FO165,25 "+ 
			"^AD,36,20^FN2^FS "+ 
			"^FO25,75 "+ 
			"^AB,22,14^FDBUILT BY^FS "+ 
			"^FO25,125 "+ 
			"^AE,28,15^FN1 "+ 
			"^XZ "+ 
			"^XA "+ 
			"^XFR:STOREFMT.ZPL^FS "+ 
			"^FN1^FDZEBRA^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"149 "+ 
			"ZPL Commands "+ 
			"~DG "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
