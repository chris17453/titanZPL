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
    public class zpl_cmd_c_ST : zpl_command{   //Set Date and Time (for Real-Time Clock)
        public    int month                                                        = 0;
        public    int day                                                          = 0;
        public    int year                                                         = 0;
        public    int hour                                                         = 0;
        public    int minute                                                       = 0;
        public    int second                                                       = 0;
        public string format                                                       = String.Empty;
                                        
        public zpl_cmd_c_ST(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^ST";                   
            description="Set Date and Time (for Real-Time Clock)";                   
            data_format="a,b,c,d,e,f,g ";                   
            example    ="";                   
            month                                                       =(   int)argument(0,data,"i","                   ",""," ");
            day                                                         =(   int)argument(1,data,"i","                   ",""," ");
            year                                                        =(   int)argument(2,data,"i","                   ",""," ");
            hour                                                        =(   int)argument(3,data,"i","                   ",""," ");
            minute                                                      =(   int)argument(4,data,"i","                   ",""," ");
            second                                                      =(   int)argument(5,data,"i","                   ",""," ");
            format                                                      =(string)argument(6,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =month //01 to 12  //current month 
	
b =day //01 to 31  //current day 
	
c =year //1998 to 2097  //current year 
	
d =hour //00 to 23  //current hour 
	
e =minute //00 to 59  //current minute 
	
f =second //00 to 59  //current second 
	
g =format //
A = a.m. P = p.m. M = 24-hour military  //
M  321 ZPL Commands ^SX 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^ST – Set Date and Time (for Real-Time Clock) "+ 
			"The ^ST command sets the date and time of the Real-Time Clock. "+ 
			"Format: ^STa,b,c,d,e,f,g "+ 
			"For more details on set date and time, see Real Time Clock on page 1325. "+ 
			"Parameters Details "+ 
			"a = month "+ 
			"Values: 01 to 12 "+ 
			"Default: current month "+ 
			"b = day "+ 
			"Values: 01 to 31 "+ 
			"Default: current day "+ 
			"c = year "+ 
			"Values: 1998 to 2097 "+ 
			"Default: current year "+ 
			"d = hour "+ 
			"Values: 00 to 23 "+ 
			"Default: current hour "+ 
			"e = minute "+ 
			"Values: 00 to 59 "+ 
			"Default: current minute "+ 
			"f = second "+ 
			"Values: 00 to 59 "+ 
			"Default: current second "+ 
			"g = format "+ 
			"Values: "+ 
			"A = a.m. "+ 
			"P = p.m. "+ 
			"M = 24-hour military "+ 
			"Default: "+ 
			"M "+ 
			" "+ 
			"321 "+ 
			"ZPL Commands "+ 
			"^SX "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
