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
    public class zpl_cmd_c_MD : zpl_command{   //Media Darkness
        public string media_darkness_level                                         = String.Empty;
                                        
        public zpl_cmd_c_MD(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MD";                   
            description="Media Darkness";                   
            data_format="a ";                   
            example    ="";                   
            media_darkness_level                                        =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =media_darkness_level // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^MD – Media Darkness "+ 
			"The ^MD command adjusts the darkness relative to the current darkness setting. "+ 
			"Format: ^MDa "+ 
			"Comments The ~SD command value, if applicable, is added to the ^MD command. "+ 
			"Parameters Details "+ 
			"a = media darkness "+ 
			"level "+ 
			"Values: -30 to 30, depending on current value "+ 
			"Initial Value at Power Up: 0 "+ 
			"If no value is entered, this command is ignored. "+ 
			"Example 1: These examples show setting the printer to different darkness levels: "+ 
			"• If the current value (value on configuration label) is 16, entering the command ^MD-9 decreases "+ 
			"the value to 7. "+ 
			"• If the current value (value on configuration label) is 1, entering the command ^MD15 increases "+ 
			"the value to 16. "+ 
			"• If the current value (value on configuration label) is 25, entering the command ^MD10 increases "+ 
			"only the value to 30, which is the maximum value allowed. "+ 
			"Each "+ 
			"^MD command is treated separately in relation to the current value as printed on the "+ 
			"configuration label. "+ 
			"Note • On Zebra G-Series™ printers the value set with the ^MD command is persistent across "+ 
			"power cycles. "+ 
			"Important • The darkness setting range for the XiIIIPlus, Xi4, and RXi4 is 0 to 30 in "+ 
			"increments of 0.1. "+ 
			"The firmware is setup so that the "+ 
			"^MD and ~SD commands (ZPL darkness commands) "+ 
			"accepts that range of settings. "+ 
			"Example 2: These are examples of the XiIIIPlus, Xi4, and RXi4 Darkness Setting: "+ 
			"^MD8.3 "+ 
			"~SD8.3 "+ 
			"Example 3: For example, this is what would happen if two ^MD commands were received: "+ 
			"Assume the current value is 15. An ^MD-6 command is received that changes the current value to 9. "+ 
			"Another command, "+ 
			"^MD2, is received. The current value changes to 17. "+ 
			"The two "+ 
			"^MD commands are treated individually in relation to the current value of 15. "+ 
			" "+ 
			"269 "+ 
			"ZPL Commands "+ 
			"^MF "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
