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
    public class zpl_cmd_c_KL : zpl_command{   //Define Language
        public string language                                                     = String.Empty;
                                        
        public zpl_cmd_c_KL(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^KL";                   
            description="Define Language";                   
            data_format="a ";                   
            example    ="";                   
            language                                                    =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =language //
1 = English 2 = Spanish 3 = French 4 = German 5 = Italian 6 = Norwegian 7 = Portuguese 8 = Swedish 9 = Danish 10 = Spanish2 11 = Dutch 12 = Finnish 13 = Japanese 14 = Korean l 15 = Simplified Chinese l 16 = Traditional Chinese l 17 = Russian l 18 = Polish l 19 = Czech l 20 = Romanian l  //1 l. These values are only supported on the ZT200 Series, ZE500 Series, Xi4, RXi4, ZM400/ ZM600, and RZ400/RZ600 printers.  253 ZPL Commands ^KN 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^KL – Define Language "+ 
			"The ^KL command selects the language displayed on the control panel. "+ 
			"Format: ^KLa "+ 
			"Parameters Details "+ 
			"a = language "+ 
			"Values: "+ 
			"1 = English "+ 
			"2 = Spanish "+ 
			"3 = French "+ 
			"4 = German "+ 
			"5 = Italian "+ 
			"6 = Norwegian "+ 
			"7 = Portuguese "+ 
			"8 = Swedish "+ 
			"9 = Danish "+ 
			"10 = Spanish2 "+ 
			"11 = Dutch "+ 
			"12 = Finnish "+ 
			"13 = Japanese "+ 
			"14 = Korean "+ 
			"l "+ 
			"15 = Simplified Chinese "+ 
			"l "+ 
			"16 = Traditional Chinese "+ 
			"l "+ 
			"17 = Russian "+ 
			"l "+ 
			"18 = Polish "+ 
			"l "+ 
			"19 = Czech "+ 
			"l "+ 
			"20 = Romanian "+ 
			"l "+ 
			"Default: 1 "+ 
			"l. These values are only supported on the ZT200 Series, ZE500 Series, Xi4, RXi4, ZM400/ ZM600, and RZ400/RZ600 printers. "+ 
			" "+ 
			"253 "+ 
			"ZPL Commands "+ 
			"^KN "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
