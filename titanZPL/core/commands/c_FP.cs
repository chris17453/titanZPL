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
    public class zpl_cmd_c_FP : zpl_command{   //Field Parameter
        public string direction                                                    = String.Empty;
        public string additional_inter                                             = String.Empty;
                                        
        public zpl_cmd_c_FP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FP";                   
            description="Field Parameter";                   
            data_format="d,g ";                   
            example    ="";                   
            direction                                                   =(string)argument(0,data,"s","                   ",""," ");
            additional_inter                                            =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =direction //
H = horizontal printing (left to right) V = vertical printing (top to bottom) R = reverse printing (right to left)  //H 
	
g =additional_inter //0 to 9999  //0 if no value is entere
                                       
  **************************************************/ 
            manual=""+ 
			"^FP – Field Parameter "+ 
			"The ^FP command allows vertical and reverse formatting of the font field, commonly used for "+ 
			"printing Asian fonts. "+ 
			"Format: ^FPd,g "+ 
			". "+ 
			"Parameters Details "+ 
			"d = direction "+ 
			"Values: "+ 
			"H = horizontal printing (left to right) "+ 
			"V = vertical printing (top to bottom) "+ 
			"R = reverse printing (right to left) "+ 
			"Default: H "+ 
			"g = additional "+ 
			"inter-character "+ 
			"gap (in dots) "+ 
			"Values: 0 to 9999 "+ 
			"Default: 0 if no value is entered "+ 
			"Example: This is an example of how to implement reverse and vertical print: "+ 
			"For vertical and reverse printing directions, combining semantic clusters are used to place "+ 
			"characters. "+ 
			"This command interacts with the justification parameters of ^FO and ^FT and with the rotation "+ 
			"parameter of "+ 
			"^A. For output and examples, see Field Interactions on page 1319. "+ 
			" "+ 
			"175 "+ 
			"ZPL Commands "+ 
			"^FR "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
