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
    public class zpl_cmd_c_KD : zpl_command{   //Select Date and Time Format (for Real Time
        public string date_and_time_format                                         = String.Empty;
                                        
        public zpl_cmd_c_KD(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^KD";                   
            description="Select Date and Time Format (for Real Time";                   
            data_format="a ";                   
            example    ="";                   
            date_and_time_format                                        =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =value_of_date_and_time_format //
0 = normal, displays Version Number of firmware 1 = MM/DD/YY (24-hour clock) 2 = MM/DD/YY (12-hour clock) 3 = DD/MM/YY (24-hour clock) 4 = DD/MM/YY (12-hour clock)  //0  ZPL Commands ^KL 252 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^KD – Select Date and Time Format (for Real Time "+ 
			"Clock) "+ 
			"The ^KD command selects the format that the Real-Time Clock’s date and time information presents "+ 
			"as on a configuration label. This is also displayed on the Printer Idle LCD control panel display, and "+ 
			"displayed while setting the date and time. "+ 
			"Format: ^KDa "+ 
			"Comments If the Real-Time Clock hardware is not present, Display Mode is set to 0 (Version "+ 
			"Number). "+ 
			"If Display Mode is set to 0 (Version Number) and the Real-Time Clock hardware is present, the date "+ 
			"and time format on the configuration label is presented in format 1. "+ 
			"If Display Mode is set to 0 (Version Number) and the Real-Time Clock hardware is present, the date "+ 
			"and time format on the control panel display is presented in format 1. "+ 
			"For more details on select date and time format for the Real Time Clock, see Real Time Clock "+ 
			"on page 1325. "+ 
			"Parameters Details "+ 
			"a = value of date and "+ 
			"time format "+ 
			"Values: "+ 
			"0 = normal, displays Version Number of firmware "+ 
			"1 = MM/DD/YY (24-hour clock) "+ 
			"2 = MM/DD/YY (12-hour clock) "+ 
			"3 = DD/MM/YY (24-hour clock) "+ 
			"4 = DD/MM/YY (12-hour clock) "+ 
			"Default: 0 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^KL "+ 
			"252 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
