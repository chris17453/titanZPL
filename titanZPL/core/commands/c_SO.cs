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
    public class zpl_cmd_c_SO : zpl_command{   //Set Offset (for Real-Time Clock)
        public string clock_set                                                    = String.Empty;
        public string months_offset                                                = String.Empty;
        public    int days_offset                                                  = 0;
        public    int years_offset                                                 = 0;
        public    int hours_offset                                                 = 0;
        public    int minutes_offset                                               = 0;
        public    int seconds_offset                                               = 0;
                                        
        public zpl_cmd_c_SO(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SO";                   
            description="Set Offset (for Real-Time Clock)";                   
            data_format="a,b,c,d,e,f,g ";                   
            example    ="";                   
            clock_set                                                   =(string)argument(0,data,"s","                   ",""," ");
            months_offset                                               =(string)argument(1,data,"s","                   ",""," ");
            days_offset                                                 =(   int)argument(2,data,"i","                   ",""," ");
            years_offset                                                =(   int)argument(3,data,"i","                   ",""," ");
            hours_offset                                                =(   int)argument(4,data,"i","                   ",""," ");
            minutes_offset                                              =(   int)argument(5,data,"i","                   ",""," ");
            seconds_offset                                              =(   int)argument(6,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
a =clock_set //
2 = secondary 3 = third  //value must be specified 
	
b =months_offset //–32000 to 32000  //0 
	
c =days_offset //–32000 to 32000  //0 
	
d =years_offset //–32000 to 32000  //0 
	
e =hours_offset //–32000 to 32000  //0 
	
f =minutes_offset //–32000 to 32000  //0 
	
g =seconds_offset //–32000 to 32000  //0  315 ZPL Commands ^SP 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^SO – Set Offset (for Real-Time Clock) "+ 
			"The ^SO command is used to set the secondary and the tertiary offset from the primary Real-Time "+ 
			"Clock. "+ 
			"Format: ^SOa,b,c,d,e,f,g "+ 
			"For more detail on set offset, see Real Time Clock on page 1325. "+ 
			"Note • For each label only one SO2 command can be used. If more than one offset is required, "+ 
			"SO3 must be used. "+ 
			"Parameters Details "+ 
			"a = clock set "+ 
			"Values: "+ 
			"2 = secondary "+ 
			"3 = third "+ 
			"Default: value must be specified "+ 
			"b = months offset "+ 
			"Values: –32000 to 32000 "+ 
			"Default: 0 "+ 
			"c = days offset "+ 
			"Values: –32000 to 32000 "+ 
			"Default: 0 "+ 
			"d = years offset "+ 
			"Values: –32000 to 32000 "+ 
			"Default: 0 "+ 
			"e = hours offset "+ 
			"Values: –32000 to 32000 "+ 
			"Default: 0 "+ 
			"f = minutes offset "+ 
			"Values: –32000 to 32000 "+ 
			"Default: 0 "+ 
			"g = seconds offset "+ 
			"Values: –32000 to 32000 "+ 
			"Default: 0 "+ 
			" "+ 
			"315 "+ 
			"ZPL Commands "+ 
			"^SP "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
