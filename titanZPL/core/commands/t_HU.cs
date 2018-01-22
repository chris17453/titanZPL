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
    public class zpl_cmd_t_HU : zpl_command{   //Return ZebraNet Alert Configuration
                                        
        public zpl_cmd_t_HU(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~HU";                   
            description="Return ZebraNet Alert Configuration";                   
            data_format=" ";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~HU – Return ZebraNet Alert Configuration "+ 
			"This command returns the table of configured ZebraNet Alert settings to the host. "+ 
			"Format: ~HU "+ 
			"The first line indicates that condition B (ribbon out) is routed to destination C (e-mail address). "+ 
			"The next two characters, Y and Y, indicate that the condition set and condition clear options have "+ 
			"been set to "+ 
			"yes. "+ 
			"The following entry is the destination that the Alert e-mail should be sent to; in this example it is "+ 
			"admin@company.com. "+ 
			"The last figure seen in the first line is 0, which is the port number. "+ 
			"Each line shows the settings for a different Alert condition as defined in the ^SX command. "+ 
			"Example: If the "+ 
			"~HU command is sent to the printer with existing Alert messages set to go to e-mail "+ 
			"and SNMP traps, the data returned would look something like the information below. See ^SX "+ 
			"on page 321 for complete information on the individual parameter settings. "+ 
			"B,C,Y,Y,ADMIN@COMPANY.COM,0 "+ 
			"J,F,Y,Y,,0 "+ 
			"C,F,Y,Y,,0 "+ 
			"D,F,Y,Y,,0 "+ 
			"E,F,Y,N,,0 "+ 
			"F,F,Y,N,,0 "+ 
			"H,C,Y,N,ADMIN@COMPANY.COM,0 "+ 
			"N,C,Y,Y,ADMIN@COMPANY.COM,0 "+ 
			"O,C,Y,Y,ADMIN@COMPANY.COM,0 "+ 
			"P,C,Y,Y,ADMIN@COMPANY.COM,0 "+ 
			"Important • If there are no ^SX (alerts) set, the printer will not respond to the ~HU "+ 
			"command. "+ 
			" "+ 
			"209 "+ 
			"ZPL Commands "+ 
			"^HV "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
