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
    public class zpl_cmd_c_JS : zpl_command{   //Sensor Select
        public string sensor_selection                                             = String.Empty;
                                        
        public zpl_cmd_c_JS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JS";                   
            description="Sensor Select";                   
            data_format="a ";                   
            example    ="";                   
            sensor_selection                                            =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =sensor_selection //
A = auto select R = reflective sensor T = transmissive sensor  //
Z series
	s
=A // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^JS – Sensor Select "+ 
			"Format: ^JSa "+ 
			"Note • This command is ignored on Zebra ZM400/ZM600 and RZ400/RZ600 printers. This "+ 
			"command is only for use with the S4M and Z Series printers (with the exception of the "+ 
			"ZM400/ZM600/RZ400/RZ600). "+ 
			"Parameters Details "+ 
			"a = sensor selection "+ 
			"Values: "+ 
			"A = auto select "+ 
			"R = reflective sensor "+ 
			"T = transmissive sensor "+ 
			"Default: "+ 
			"Z series "+ 
			"= A "+ 
			"S4M "+ 
			"= R "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JS "+ 
			"244 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
