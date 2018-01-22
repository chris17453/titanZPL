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
    public class zpl_cmd_c_JM : zpl_command{   //Set Dots per Millimeter
        public string set_dots_per_millimeter                                      = String.Empty;
                                        
        public zpl_cmd_c_JM(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JM";                   
            description="Set Dots per Millimeter";                   
            data_format="n ";                   
            example    ="^XA"+
			            "^JMA^FS"+
			            "^FO100,100"+
			            "^B2N,50,Y,N,N"+
			            "^FD1234567890^FS"+
			            "^XZ";                   
            set_dots_per_millimeter                                     =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
n =set_dots_per_millimeter //
A = 24 dots/mm, 12 dots/mm, 8 dots/mm or 6 dots/mm B = 12 dots/mm, 6 dots/mm, 4 dots/mm or 3 dots/mm  //

                                       
  **************************************************/ 
            manual=""+ 
			"^JM – Set Dots per Millimeter "+ 
			"The ^JM command lowers the density of the print—24 dots/mm becomes 12, 12 dots/mm becomes "+ 
			"6, 8 dots/mm becomes 4, and 6 dots/mm becomes 3. ^JM also affects the field origin (^FO) "+ 
			"placement on the label (see example below). "+ 
			"When sent to the printer, the "+ 
			"^JM command doubles the format size of the label. Depending on the "+ 
			"printhead, normal dot-per-millimeter capabilities for a Zebra printer are 12 dots/mm (304 dots/inch), "+ 
			"8 dots/mm (203 dots/inch) or 6 dots/mm (153 dots/inch). "+ 
			"This command must be entered before the first "+ 
			"^FS command in a format. The effects of ^JM are "+ 
			"persistent. "+ 
			"Format: ^JMn "+ 
			"Comments If ^JMB is used, the UPS MaxiCode bar code becomes out of specification. "+ 
			"Parameters Details "+ 
			"n = set dots per "+ 
			"millimeter "+ 
			"Values: "+ 
			"A = 24 dots/mm, 12 dots/mm, 8 dots/mm or 6 dots/mm "+ 
			"B = 12 dots/mm, 6 dots/mm, 4 dots/mm or 3 dots/mm "+ 
			"Default: "+ 
			"A "+ 
			"Example: This example of the affects of alternating the dots per millimeter: "+ 
			"^XA "+ 
			"^JMA^FS "+ 
			"^FO100,100 "+ 
			"^B2N,50,Y,N,N "+ 
			"^FD1234567890^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^JMB^FS "+ 
			"^FO100,100 "+ 
			"^B2N,50,Y,N,N "+ 
			"^FD1234567890^FS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JN "+ 
			"238 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
