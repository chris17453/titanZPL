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
    public class zpl_cmd_c_XF : zpl_command{   //Recall Format
        public string source_device_of_stored_image                                = String.Empty;
        public string name_of_stored_image                                         = String.Empty;
        public string extension1                                                   = String.Empty;
                                        
        public zpl_cmd_c_XF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^XF";                   
            description="Recall Format";                   
            data_format="d,o,x ";                   
            example    ="";                   
            source_device_of_stored_image                               =(string)argument(0,data,"s","                   ",""," ");
            name_of_stored_image                                        =(string)argument(1,data,"s","                   ",""," ");
            extension1                                                  =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =source_device_of_stored_image //R:, E:, B:, and A:  //search priority (R:, E:, B:, and A:) 
	
o =name_of_stored_image //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_l // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^XF – Recall Format "+ 
			"The ^XF command recalls a stored format to be merged with variable data. There can be multiple "+ 
			"^XF commands in one format, and they can be located anywhere within the code. "+ 
			"When recalling a stored format and merging data using the "+ 
			"^FN (Field Number) function, the calling "+ 
			"format must contain the ^FN command to merge the data properly. "+ 
			"While using stored formats reduces transmission time, no formatting time is saved. The ZPL II "+ 
			"format being recalled is saved as text strings that need to be formatted at print time. "+ 
			"Format: ^XFd:o.x "+ 
			"For a complete example of the "+ 
			"^DF and ^XF command, see ^DF and ^XF — Download format and "+ 
			"recall format on page 35. "+ 
			"Parameters Details "+ 
			"d = source device of "+ 
			"stored image "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: search priority (R:, E:, B:, and A:) "+ 
			"o = name of stored "+ 
			"image "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension l "+ 
			"Fixed Value: .ZPL "+ 
			" "+ 
			"339 "+ 
			"ZPL Commands "+ 
			"^XG "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
