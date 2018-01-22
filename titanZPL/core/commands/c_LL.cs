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
    public class zpl_cmd_c_LL : zpl_command{   //Label Length
        public    int y                                                            = 0;
                                        
        public zpl_cmd_c_LL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^LL";                   
            description="Label Length";                   
            data_format="y ";                   
            example    ="";                   
            y                                                           =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
y =y //1 to 32000, not to exceed the maximum label size. While the printer accepts any value for this parameter, the amount of memory installed determines the maximum length of the label.  //typically set through the LCD (if applicable), or to the maximum label length capability of the printer. For 6 dot/mm printheads... Label length in inches x 152.4 (dots/inch
	h) =y // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^LL – Label Length "+ 
			"The ^LL command defines the length of the label. This command is necessary when using "+ 
			"continuous media (media not divided into separate labels by gaps, spaces, notches, slots, or holes). "+ 
			"To affect the current label and be compatible with existing printers, "+ 
			"^LL must come before the first "+ 
			"^FS (Field Separator) command. Once you have issued ^LL, the setting is retained until you turn off "+ 
			"the printer or send a new "+ 
			"^LL command. "+ 
			"Format: ^LLy "+ 
			"Comments These formulas can be used to determine the value of y: "+ 
			"Values for y depend on the memory size. If the entered value for y exceeds the acceptable limits, "+ 
			"the bottom of the label is cut off. The label also shifts down from top to bottom. "+ 
			"If multiple "+ 
			"^LL commands are issued in the same label format, the last ^LL command affects the "+ 
			"next label unless it is prior to the first ^FS. "+ 
			"This command is ignored on the HC100™ printer. "+ 
			"Parameters Details "+ 
			"y = y-axis position "+ 
			"(in dots) "+ 
			"Values: 1 to 32000, not to exceed the maximum label size. "+ 
			"While the printer accepts any value for this parameter, the amount of memory "+ 
			"installed determines the maximum length of the label. "+ 
			"Default: typically set through the LCD (if applicable), or to the maximum label "+ 
			"length capability of the printer. "+ 
			"For 6 dot/mm printheads... "+ 
			"Label length in inches x 152.4 (dots/inch) = y "+ 
			"For 8 dot/mm printheads... "+ 
			"Label length in inches x 203.2 (dots/inch) = y "+ 
			"For 12 dot/mm printheads... "+ 
			"Label length in inches x 304.8 (dots/inch) = y "+ 
			"For 24 dot/mm printheads... "+ 
			"Label length in inches x 609.6 (dots/inch) = y "+ 
			" "+ 
			"ZPL Commands "+ 
			"^LR "+ 
			"262 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
