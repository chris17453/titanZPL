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
    public class zpl_cmd_c_PR : zpl_command{   //Print Rate
        public string print_speed                                                  = String.Empty;
        public string slew_speed                                                   = String.Empty;
        public string backfeed_speed                                               = String.Empty;
                                        
        public zpl_cmd_c_PR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PR";                   
            description="Print Rate";                   
            data_format="p,s,b ";                   
            example    ="";                   
            print_speed                                                 =(string)argument(0,data,"s","                   ",""," ");
            slew_speed                                                  =(string)argument(1,data,"s","                   ",""," ");
            backfeed_speed                                              =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
p =print_speed //
1 = 25.4 mm/sec. (1 inch/sec.) v A or 2 = 50.8 mm/sec. (2 inches/sec.) B or 3 = 76.2 mm/sec. (3 inches/sec.) C or 4 = 101.6 mm/sec. (4 inches/sec.) 5 = 127 mm/sec.(5 inches/sec.) D or 6 = 152.4 mm/sec. (6 inches/sec.) 7 = 177.8 mm/sec. (7 inches/sec.) E or 8 = 203.2 mm/sec. (8 inches/sec.) 9 = 220.5 mm/sec. 9 inches/sec.) 10 = 245 mm/sec.(10 inches/sec.) 11 = 269.5 mm/sec.(11 inches/sec.) 12 = 304.8 mm/sec. 12 inches/sec.) 13 = 13 in/sec w 14 = 14 in/sec w  //A 
	
s =slew_speed //
A or 2 = 50.8 mm/sec. (2 inches/sec.) B or 3 = 76.2 mm/sec. (3 inches/sec.) C or 4 = 101.6 mm/sec. (4 inches/sec.) 5 = 127 mm/sec. 5 inches/sec.) D or 6 = 152.4 mm/sec. (6 inches/sec.) 7 = 177.8 mm/sec. (7 inches/sec.) E or 8 = 203.2 mm/sec. (8 inches/sec.) 9 = 220.5 mm/sec. (9 inches/sec.) 10 = 245 mm/sec. (10 inches/sec.) 11 = 269.5 mm/sec. 11 inches/sec.) 12 = 304.8 mm/sec. 12 inches/sec.) 13 = 13 in/sec w 14 = 14 in/sec w  //D v. This value is supported only on the 110Xi4-600dpi, 110XiIIIPlus-600dpi , and RXi printers. w. This value is supported only on the Xi4 and RXi4 printers.  299 ZPL Commands ^PR 11/21/16 Zebra Programming Guide P1012728-011 Comments The speed setting for p, s, and b is dependent on the limitations of the printer. If a particular printer is limited to a rate of 6 ips (inches per second), a value of 12 can be entered but the printer performs only at a 6 ips rate. See your printer’s User Guide for specifics on performance. This command is ignored on the HC100 printer. 
	
b =backfeed_speed //
A or 2 = 50.8 mm/sec. (2 inches/sec.) B or 3 = 76.2 mm/sec. (3 inches/sec.) C or 4 = 101.6 mm/sec. (4 inches/sec.) 5 = 127 mm/sec.(5 inches/sec.) D or 6 = 152.4 mm/sec. (6 inches/sec.) 7 = 177.8 mm/sec. (7 inches/sec.) E or 8 = 203.2 mm/sec. (8 inches/sec.) 9 = 220.5 mm/sec. 9 inches/sec.) 10 = 245 mm/sec. 10 inches/sec.) 11 = 269.5 mm/sec. 11 inches/sec.) 12 = 304.8 mm/sec. 12 inches/sec.) 13 = 13 in/sec w 14 = 14 in/sec w  //A Parameters Details v. This value is supported only on the 110Xi4-600dpi, 110XiIIIPlus-600dpi , and RXi printers. w. This value is supported only on the Xi4 and RXi4 printers.  ZPL Commands ~PS 300 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^PR – Print Rate "+ 
			"The ^PR command determines the media and slew speed (feeding a blank label) during printing. "+ 
			"The printer operates with the selected speeds until the setting is reissued or the printer is turned off. "+ 
			"The print speed is application-specific. Because print quality is affected by media, ribbon, printing "+ 
			"speeds, and printer operating modes, it is very important to run tests for your applications. "+ 
			"Format: ^PRp,s,b "+ 
			"Important • Some models go to default print speed when power is turned off. "+ 
			"Parameters Details "+ 
			"p = print speed "+ 
			"Values: "+ 
			"1 = 25.4 mm/sec. (1 inch/sec.) "+ 
			"v "+ 
			"A or 2 = 50.8 mm/sec. (2 inches/sec.) "+ 
			"B or 3 = 76.2 mm/sec. (3 inches/sec.) "+ 
			"C or 4 = 101.6 mm/sec. (4 inches/sec.) "+ 
			"5 = 127 mm/sec.(5 inches/sec.) "+ 
			"D or 6 = 152.4 mm/sec. (6 inches/sec.) "+ 
			"7 = 177.8 mm/sec. (7 inches/sec.) "+ 
			"E or 8 = 203.2 mm/sec. (8 inches/sec.) "+ 
			"9 = 220.5 mm/sec. 9 inches/sec.) "+ 
			"10 = 245 mm/sec.(10 inches/sec.) "+ 
			"11 = 269.5 mm/sec.(11 inches/sec.) "+ 
			"12 = 304.8 mm/sec. 12 inches/sec.) "+ 
			"13 = 13 in/sec "+ 
			"w "+ 
			"14 = 14 in/sec "+ 
			"w "+ 
			"Default: A "+ 
			"s = slew speed "+ 
			"Values: "+ 
			"A or 2 = 50.8 mm/sec. (2 inches/sec.) "+ 
			"B or 3 = 76.2 mm/sec. (3 inches/sec.) "+ 
			"C or 4 = 101.6 mm/sec. (4 inches/sec.) "+ 
			"5 = 127 mm/sec. 5 inches/sec.) "+ 
			"D or 6 = 152.4 mm/sec. (6 inches/sec.) "+ 
			"7 = 177.8 mm/sec. (7 inches/sec.) "+ 
			"E or 8 = 203.2 mm/sec. (8 inches/sec.) "+ 
			"9 = 220.5 mm/sec. (9 inches/sec.) "+ 
			"10 = 245 mm/sec. (10 inches/sec.) "+ 
			"11 = 269.5 mm/sec. 11 inches/sec.) "+ 
			"12 = 304.8 mm/sec. 12 inches/sec.) "+ 
			"13 = 13 in/sec "+ 
			"w "+ 
			"14 = 14 in/sec "+ 
			"w "+ 
			"Default: D "+ 
			"v. This value is supported only on the 110Xi4-600dpi, 110XiIIIPlus-600dpi , and RXi printers. "+ 
			"w. This value is supported only on the Xi4 and RXi4 printers. "+ 
			" "+ 
			"299 "+ 
			"ZPL Commands "+ 
			"^PR "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments The speed setting for p, s, and b is dependent on the limitations of the printer. "+ 
			"If a particular printer is limited to a rate of 6 ips (inches per second), a value of 12 can be "+ 
			"entered but the printer performs only at a 6 ips rate. See your printer’s User Guide for "+ 
			"specifics on performance. "+ 
			"This command is ignored on the HC100 printer. "+ 
			"b = backfeed speed "+ 
			"Values: "+ 
			"A or 2 = 50.8 mm/sec. (2 inches/sec.) "+ 
			"B or 3 = 76.2 mm/sec. (3 inches/sec.) "+ 
			"C or 4 = 101.6 mm/sec. (4 inches/sec.) "+ 
			"5 = 127 mm/sec.(5 inches/sec.) "+ 
			"D or 6 = 152.4 mm/sec. (6 inches/sec.) "+ 
			"7 = 177.8 mm/sec. (7 inches/sec.) "+ 
			"E or 8 = 203.2 mm/sec. (8 inches/sec.) "+ 
			"9 = 220.5 mm/sec. 9 inches/sec.) "+ 
			"10 = 245 mm/sec. 10 inches/sec.) "+ 
			"11 = 269.5 mm/sec. 11 inches/sec.) "+ 
			"12 = 304.8 mm/sec. 12 inches/sec.) "+ 
			"13 = 13 in/sec "+ 
			"w "+ 
			"14 = 14 in/sec "+ 
			"w "+ 
			"Default: A "+ 
			"Parameters Details "+ 
			"v. This value is supported only on the 110Xi4-600dpi, 110XiIIIPlus-600dpi , and RXi printers. "+ 
			"w. This value is supported only on the Xi4 and RXi4 printers. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~PS "+ 
			"300 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
