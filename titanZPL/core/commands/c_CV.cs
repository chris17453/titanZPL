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
    public class zpl_cmd_c_CV : zpl_command{   //Code Validation
        public string code_validation                                              = String.Empty;
                                        
        public zpl_cmd_c_CV(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^CV";                   
            description="Code Validation";                   
            data_format="a ";                   
            example    ="^XA"+
			            "^CVY"+
			            "^FO50,50"+
			            "^BEN,100,Y,N"+
			            "^FD97823456 890^FS"+
			            "^XZ";                   
            code_validation                                             =(string)argument(0,data,"s","Y,N","","N");
                                    
  /*************************************************  
	
a =code_validation //
N = no Y = yes  //N  141 ZPL Commands ^CV 11/21/16 Zebra Programming Guide P1012728-011 Comments If more than one error exists, the first error detected is the one displayed. The ^CV command tests the integrity of the data encoded into the bar code. It is not used for (or to be confused with) testing the scan-integrity of an image or bar code
                                       
  **************************************************/ 
            manual=""+ 
			"^CV – Code Validation "+ 
			"The ^CV command acts as a switch to turn the code validation function on and off. When this "+ 
			"command is turned on, all bar code data is checked for these error conditions: "+ 
			"• character not in character set "+ 
			"• check-digit incorrect "+ 
			"• data field too long (too many characters) "+ 
			"• data field too short (too few characters) "+ 
			"• parameter string contains incorrect data or missing parameter "+ 
			"When invalid data is detected, an error message and code is printed in reverse image in place of the "+ 
			"bar code. The message reads "+ 
			"INVALID - X where X is one of these error codes: "+ 
			"C = character not in character set "+ 
			"E = check-digit incorrect "+ 
			"L = data field too long "+ 
			"S = data field too short "+ 
			"P = parameter string contains incorrect data "+ 
			"(occurs only on select bar codes) "+ 
			"Once turned on, the ^CV command remains active from format to format until turned off by another "+ 
			"^CV command or the printer is turned off. The command is not permanently saved. "+ 
			"Format: ^CVa "+ 
			"Parameters Details "+ 
			"a = code validation "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			" "+ 
			"141 "+ 
			"ZPL Commands "+ 
			"^CV "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments If more than one error exists, the first error detected is the one displayed. "+ 
			"The ^CV command tests the integrity of the data encoded into the bar code. It is not used for (or to "+ 
			"be confused with) testing the scan-integrity of an image or bar code. "+ 
			"Example: The examples below show the error labels "+ 
			"^CVY generates when incorrect field data is "+ 
			"entered. Compare the letter following INVALID – to the listing on the previous page. "+ 
			"^XA "+ 
			"^CVY "+ 
			"^FO50,50 "+ 
			"^BEN,100,Y,N "+ 
			"^FD97823456 890^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^CVY "+ 
			"^FO50,50 "+ 
			"^BEN,100,Y,N "+ 
			"^FD9782345678907^FS "+ 
			"^XZ "+ 
			"^XA "+ 
			"^CVY "+ 
			"^FO50,50 "+ 
			"^BEN,100,Y,N "+ 
			"^FD97823456789081^FS "+ 
			"^XZ "+ 
			"^XA "+ 
			"^CVY "+ 
			"^FO50,50 "+ 
			"^BEN,100,Y,N "+ 
			"^FD97823456789^FS "+ 
			"^XZ "+ 
			"^XA "+ 
			"^CVY "+ 
			"^FO50,50 "+ 
			"^BQN2,3 "+ 
			"^FDHM,BQRCODE-22^FS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^CW "+ 
			"142 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
