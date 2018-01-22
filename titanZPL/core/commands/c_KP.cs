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
    public class zpl_cmd_c_KP : zpl_command{   //Define Password
        public string mandatory_four                                               = String.Empty;
        public string password_level                                               = String.Empty;
                                        
        public zpl_cmd_c_KP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^KP";                   
            description="Define Password";                   
            data_format="a,b ";                   
            example    ="";                   
            mandatory_four                                              =(string)argument(0,data,"s","                   ",""," ");
            password_level                                              =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =mandatory_four //any four-digit numeric sequence  //1234 
	
b =password_level //1, 2, 3, 4  //3 Note • The b parameter applies only to the S4M printers
                                       
  **************************************************/ 
            manual=""+ 
			"^KP – Define Password "+ 
			"The ^KP command is used to define the password that must be entered to access the control panel "+ 
			"switches and LCD Setup Mode. "+ 
			"Format: ^KPa,b "+ 
			"Comments If you forget your password, the printer can be returned to a default Setup "+ 
			"Mode and the default password 1234 is valid again. Caution should be used, however — this "+ 
			"also sets the printer configuration values back to their defaults. "+ 
			"To return the printer to the default factory settings using ZPL, send this: "+ 
			"^XA "+ 
			"^JUF "+ 
			"^XZ "+ 
			"To return the printer to the default factory settings using the control panel keys, see your printer’s "+ 
			"User Guide for the procedure. "+ 
			"Parameters Details "+ 
			"a = mandatory four- "+ 
			"digit password "+ 
			"Values: any four-digit numeric sequence "+ 
			"Default: 1234 "+ 
			"b = password level "+ 
			"Values: 1, 2, 3, 4 "+ 
			"Default: 3 "+ 
			"Note • The b parameter applies only to the S4M printers. "+ 
			"Example 1: This example shows how to set a new control panel password: "+ 
			"^XA "+ 
			"^KP5678 "+ 
			"^XZ "+ 
			"Example 2: This example shows how to set a new control panel password (5678) at a specific "+ 
			"password level (level 2) (applicable to the S4M printer only): "+ 
			"^XA "+ 
			"^KP5678,2 "+ 
			"^XZ "+ 
			" "+ 
			"255 "+ 
			"ZPL Commands "+ 
			"^KV "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
