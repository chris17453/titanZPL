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
    public class zpl_cmd_c_JH : zpl_command{   //Early Warning Settings
        public string early_warning_media_a                                        = String.Empty;
        public string labels_per_roll_this_parameter_is_for_xiiiiplus              = String.Empty;
        public string media_replaced_this_parameter_is_for_xiiiiplus               = String.Empty;
        public string ribbon_length_this_parameter_is_for_xiiiiplus                = String.Empty;
        public string ribbon_replaced_this_parameter_is_for_xiiiiplus              = String.Empty;
        public string early_warning_maintenance_this_parameter_is_for_xi4          = String.Empty;
        public string head_cleaning_interval_accepted_value_exceptions_accepted_values_for_xiiii_printer_are_100m_through_450m = String.Empty;
        public string head_clean                                                   = String.Empty;
        public string head_life_threshold                                          = String.Empty;
        public string head_replaced                                                = String.Empty;
                                        
        public zpl_cmd_c_JH(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JH";                   
            description="Early Warning Settings";                   
            data_format="a,b,c,d,e,f,g,h,i,j ";                   
            example    ="";                   
            early_warning_media_a                                       =(string)argument(0,data,"s","                   ",""," ");
            labels_per_roll_this_parameter_is_for_xiiiiplus             =(string)argument(1,data,"s","                   ",""," ");
            media_replaced_this_parameter_is_for_xiiiiplus              =(string)argument(2,data,"s","                   ",""," ");
            ribbon_length_this_parameter_is_for_xiiiiplus               =(string)argument(3,data,"s","                   ",""," ");
            ribbon_replaced_this_parameter_is_for_xiiiiplus             =(string)argument(4,data,"s","                   ",""," ");
            early_warning_maintenance_this_parameter_is_for_xi4         =(string)argument(5,data,"s","                   ",""," ");
            head_cleaning_interval_accepted_value_exceptions_accepted_values_for_xiiii_printer_are_100m_through_450m=(string)argument(6,data,"s","                   ",""," ");
            head_clean                                                  =(string)argument(7,data,"s","                   ",""," ");
            head_life_threshold                                         =(string)argument(8,data,"s","                   ",""," ");
            head_replaced                                               =(string)argument(9,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =early_warning_media_a //
E = enable D = disable  //D 
	
b =labels_per_roll_This_parameter_is_for_XiIIIPlus //100 to 9999  //900 
	
c =media_replaced_This_parameter_is_for_XiIIIPlus //
Y = yes N = no  //N  229 ZPL Commands ^JH 11/21/16 Zebra Programming Guide P1012728-011 
	
d =ribbon_length_This_parameter_is_for_XiIIIPlus //
XiIIIPlus series printers: N = 0M 0 = 100M 4 = 300M 1 = 150M 5 = 350M 2 = 200M 6 = 400M 3 = 250M 7 = 450M PAX series printers: N = 0M 7 = 450M 0 = 100M 10 = 600M 1 = 150M 11 = 650M 2 = 200M 12 = 700M 3 = 250M 13 = 750M 4 = 300M 14 = 800M 5 = 350M 15 = 850M 6 = 400M 16 = 900M ZE500 series printers: N = 0M 4 = 300M 0 = 100M 5 = 350M 1 = 150M 6 = 400M 2 = 200M 7 = 450M 3 = 250M 10 = 600M  //
1 - for 96XiIIIPlus 7 - for all other printers 
	
e =ribbon_replaced_This_parameter_is_for_XiIIIPlus //
Y = yes N = no  //N 
	
f =early_warning_maintenance_This_parameter_is_for_Xi4 //
E = enabled D = disabled  //D Important • On G-Series printers, this parameter must be enabled for the ^MA driven system to work. Parameter Details  ZPL Commands ^JH 230 P1012728-011 Zebra Programming Guide 11/21/16 Comments To permanently save the changes to the ^JH command, send ^XA^JUS^XZ. 
	
g =head_cleaning_interval_Accepted_value_exceptions_accepted_values_for_XiIII_printer_are_100M_through_450M //
0 = 100M 11 = 650M 1 = 150M 12 = 700M 2 = 200M 13 = 750M 3 = 250M 14 = 800M 4 = 300M 15 = 850M 5 = 350M 16 = 900M 6 = 400M 7 = 450M 8 = 500M 9 = 550M 10= 600M  //
1 - for 96XiIIIPlus 7 - for all other printers 
	
h =head_clean //
N = No Y = Yes  //N 
	
i =head_life_threshold //
0 – 0 in or off 100-3500000 in  //1000000 
	
j =head_replaced //
N = no Y = yes  //N Parameter Details  231 ZPL Commands ^JI 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^JH – Early Warning Settings "+ 
			"The ^JH command configures the early warning messages that appear on the LCD. "+ 
			"Supported Devices "+ 
			"• ZE500 series "+ 
			"• XiIII, XiIIIPlus, Xi4, RXi4 "+ 
			"• PAX3, PAX4 "+ 
			"• ZM400, ZM600, RZ400, RZ600 "+ 
			"•S4M "+ 
			"• G-Series (“f” parameter only) "+ 
			"Format: ^JHa,b,c,d,e,f,g,h,i,j "+ 
			"Parameter Details "+ 
			"a = early warning "+ 
			"media "+ 
			"a = supplies "+ 
			"warning "+ 
			"(Xi4 and RXi4 "+ 
			"printers "+ 
			"only) "+ 
			"This parameter is for XiIIIPlus, Xi4, RXi4, PAX3, and PAX4 printers only. "+ 
			"Values: "+ 
			"E = enable "+ 
			"D = disable "+ 
			"Default: D "+ 
			"b = labels per "+ 
			"roll "+ 
			"This parameter is for XiIIIPlus, PAX3, and PAX4 printers only. "+ 
			"Values: 100 to 9999 "+ 
			"Default: 900 "+ 
			"c = media replaced "+ 
			"This parameter is for XiIIIPlus, PAX3, and PAX4 printers only. "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: N "+ 
			" "+ 
			"229 "+ 
			"ZPL Commands "+ 
			"^JH "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"d = ribbon length "+ 
			"This parameter is for XiIIIPlus, PAX3, PAX4, and ZE500 printers only. "+ 
			"Values: "+ 
			"XiIIIPlus series printers: "+ 
			"N = 0M "+ 
			"0 = "+ 
			"100M 4 = 300M "+ 
			"1 = 150M 5 = 350M "+ 
			"2 = 200M 6 = 400M "+ 
			"3 = 250M 7 = 450M "+ 
			"PAX series printers: "+ 
			"N = 0M 7 = 450M "+ 
			"0 = 100M 10 = 600M "+ 
			"1 = 150M 11 = 650M "+ 
			"2 = 200M 12 = 700M "+ 
			"3 = 250M 13 = 750M "+ 
			"4 = 300M 14 = 800M "+ 
			"5 = 350M 15 = 850M "+ 
			"6 = 400M 16 = 900M "+ 
			"ZE500 series printers: "+ 
			"N = 0M 4 = 300M "+ 
			"0 = 100M 5 = 350M "+ 
			"1 = 150M 6 = 400M "+ 
			"2 = 200M 7 = 450M "+ 
			"3 = 250M 10 = 600M "+ 
			"Default: "+ 
			"1 - for 96XiIIIPlus "+ 
			"7 - for all other printers "+ 
			"e = ribbon "+ 
			"replaced "+ 
			"This parameter is for XiIIIPlus, PAX3, and PAX4 printers only. "+ 
			"Values: "+ 
			"Y = yes "+ 
			"N = no "+ 
			"Default: N "+ 
			"f = early warning "+ 
			"maintenance "+ 
			"This parameter is for Xi4, RXi4, PAX4, ZM400, ZM600, RZ400, RZ600, and S4M "+ 
			"printers only. "+ 
			"Values: "+ 
			"E = enabled "+ 
			"D = disabled "+ 
			"Default: D "+ 
			"Important • On G-Series printers, this parameter must be enabled for "+ 
			"the "+ 
			"^MA driven system to work. "+ 
			"Parameter Details "+ 
			" "+ 
			"ZPL Commands "+ 
			"^JH "+ 
			"230 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments To permanently save the changes to the ^JH command, send ^XA^JUS^XZ. "+ 
			"g = head cleaning "+ 
			"interval "+ 
			"Accepted value exceptions: accepted values for XiIII printer are 100M through "+ 
			"450M; accepted values for 600 dpi XiIII printers are 100M through 150M; accepted "+ 
			"values for PAX4 series printers are up to 900M by increments of 50M; accepted "+ 
			"values for ZM400/ZM600, RZ400/RZ600, and S4M printers are 0M through 450M. "+ 
			"Values: "+ 
			"0 = 100M 11 = 650M "+ 
			"1 = 150M 12 = 700M "+ 
			"2 = 200M 13 = 750M "+ 
			"3 = 250M 14 = 800M "+ 
			"4 = 300M 15 = 850M "+ 
			"5 = 350M 16 = 900M "+ 
			"6 = 400M "+ 
			"7 = 450M "+ 
			"8 = 500M "+ 
			"9 = 550M "+ 
			"10= 600M "+ 
			"Default: "+ 
			"1 - for 96XiIIIPlus "+ 
			"7 - for all other printers "+ 
			"h = head clean "+ 
			"Values: "+ 
			"N = No "+ 
			"Y = Yes "+ 
			"Default: N "+ 
			"i = head life "+ 
			"threshold "+ 
			"Values: "+ 
			"0 – 0 in or off "+ 
			"100-3500000 in "+ 
			"Default: 1000000 "+ 
			"j = head replaced "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: N "+ 
			"Parameter Details "+ 
			" "+ 
			"231 "+ 
			"ZPL Commands "+ 
			"^JI "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
