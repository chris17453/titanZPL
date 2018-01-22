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
    public class zpl_cmd_c_KN : zpl_command{   //Define Printer Name
        public string printer_name                                                 = String.Empty;
        public string printer_description                                          = String.Empty;
                                        
        public zpl_cmd_c_KN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^KN";                   
            description="Define Printer Name";                   
            data_format="a,b ";                   
            example    ="^XA"+
			            "^KNZebra1,desk_printer"+
			            "^XZ";                   
            printer_name                                                =(string)argument(0,data,"s","                   ",""," ");
            printer_description                                         =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =printer_name //up to 16 alphanumeric characters  //
• If no printer name is specified in a printer with a MAC address, the printer name will default to 'ZBRxxx,' where xxx is the last three octets of the MAC address converted into ASCII text. • For printers without a MAC address, if a value is not entered, the current stored value is erased. If more than 16 characters are entered, only the first 16 are used. 
	
b =printer_description //up to 35 alphanumeric characters  //if a value is not entered, the current stored value is erased If more than 35 characters are entered, only the first 35 are used. Note • The value of this parameter will be displayed on the printer’s web page in parentheses
                                       
  **************************************************/ 
            manual=""+ 
			"^KN – Define Printer Name "+ 
			"The printer’s network name and description can be set using the ^KN command. ^KN is designed to "+ 
			"make your Zebra printer easy for users to identify. The name the administrator designates is listed "+ 
			"on the configuration label and on the Web page generated by the printer. "+ 
			"Format: ^KNa,b "+ 
			"Note • If you issue the command ^KN, (without the a and b parameters) you are setting the "+ 
			"printer name and description to a blank string. "+ 
			"To cause the printer name and printer description settings controlled by the "+ 
			"^KN command to be "+ 
			"saved, you must issue the "+ 
			"^JUS command. "+ 
			"Parameters Details "+ 
			"a = printer name "+ 
			"Values: up to 16 alphanumeric characters "+ 
			"Default: "+ 
			"• If no printer name is specified in a printer with a MAC address, the printer name "+ 
			"will default to 'ZBRxxx,' where xxx is the last three octets of the MAC address "+ 
			"converted into ASCII text. "+ 
			"• For printers without a MAC address, if a value is not entered, the current stored "+ 
			"value is erased. "+ 
			"If more than 16 characters are entered, only the first 16 are used. "+ 
			"b = printer "+ 
			"description "+ 
			"Values: up to 35 alphanumeric characters "+ 
			"Default: if a value is not entered, the current stored value is erased "+ 
			"If more than 35 characters are entered, only the first 35 are used. "+ 
			"Note • The value of this parameter will be displayed on the printer’s web page in "+ 
			"parentheses. "+ 
			"Example: This is an example of how to change the printer’s network name and description: "+ 
			"This shows how a configuration looks before using this command and after using this command: "+ 
			"^XA "+ 
			"^KNZebra1,desk_printer "+ 
			"^XZ "+ 
			"Before using this command: After using this command: "+ 
			" "+ 
			"ZPL Commands "+ 
			"^KP "+ 
			"254 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
