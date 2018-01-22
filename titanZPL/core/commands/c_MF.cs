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
    public class zpl_cmd_c_MF : zpl_command{   //Media Feed
        public string feed_action_at_power                                         = String.Empty;
        public string feed_action_after_closing_printhead                          = String.Empty;
                                        
        public zpl_cmd_c_MF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MF";                   
            description="Media Feed";                   
            data_format="p,h ";                   
            example    ="";                   
            feed_action_at_power                                        =(string)argument(0,data,"s","                   ",""," ");
            feed_action_after_closing_printhead                         =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
p =feed_action_at_power //
F = feed to the first web after sensor C = (see ~JC on page 223 definition) L = (see ~JL on page 236 definition) N = no media feed S = short calibration m  //C 
	
h =feed_action_after_closing_printhead //
F = feed to the first web after sensor C = (see ~JC on page 223 definition) L = (see ~JL on page 236 definition) N = no media feed S = short calibration m  //C m. These values are supported only on Xi4, RXi4, XiIIIPlus, PAX, ZM400/ZM600, RZ400/RZ600, and S4M printers.  ZPL Commands ^MI 270 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^MF – Media Feed "+ 
			"The ^MF command dictates what happens to the media at power-up and at head-close after the "+ 
			"error clears. "+ 
			"Format: ^MFp,h "+ 
			"Comments It is important to remember that if you choose the N setting, the printer "+ 
			"assumes that the media and its position relative to the printhead are the same as before "+ 
			"power was turned off or the printhead was opened. Use the "+ 
			"^JU command to save changes. "+ 
			"Parameters Details "+ 
			"p = feed action at "+ 
			"power-up "+ 
			"Values: "+ 
			"F = feed to the first web after sensor "+ 
			"C = (see ~JC on page 223 definition) "+ 
			"L = (see ~JL on page 236 definition) "+ 
			"N = no media feed "+ 
			"S = short calibration "+ 
			"m "+ 
			"Default: C "+ 
			"h = feed action after "+ 
			"closing "+ 
			"printhead "+ 
			"Values: "+ 
			"F = feed to the first web after sensor "+ 
			"C = (see ~JC on page 223 definition) "+ 
			"L = (see ~JL on page 236 definition) "+ 
			"N = no media feed "+ 
			"S = short calibration "+ 
			"m "+ 
			"Default: C "+ 
			"m. These values are supported only on Xi4, RXi4, XiIIIPlus, PAX, ZM400/ZM600, RZ400/RZ600, and S4M printers. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MI "+ 
			"270 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
