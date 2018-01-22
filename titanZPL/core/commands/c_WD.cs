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
    public class zpl_cmd_c_WD : zpl_command{   //Print Directory Label
        public string source_device                                                = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension                                                    = String.Empty;
                                        
        public zpl_cmd_c_WD(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^WD";                   
            description="Print Directory Label";                   
            data_format="d,o,x ";                   
            example    ="";                   
            source_device                                               =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =source_device_—_ //R:, E:, B:, A: and Z:  //R: 
	
o =object_name_—_ //1 to 8 alphanumeric characters  //* The use of a ? (question mark) is also allowed. 
	
x =extension_—_ //any extension conforming to Zebra conventions .FNT = font .BAR = bar code .ZPL = stored ZPL format .GRF = GRF graphic .CO = memory cache .DAT = font encoding .BAS = ZBI encrypted program .BAE = ZBI encrypted program .STO = data storage .PNG = PNG graphic * = all objects . TTF = TrueType Font .TTE = True Type Extension  //* The use of a ? (question mark) is also allowed
                                       
  **************************************************/ 
            manual=""+ 
			"^WD – Print Directory Label "+ 
			"The ^WD command is used to print a label listing bar codes, objects stored in DRAM, or fonts. "+ 
			"For bar codes, the list shows the name of the bar code. For fonts, the list shows the name of the font, "+ 
			"the number to use with "+ 
			"^A command, and size. For objects stored in DRAM, the list shows the name "+ 
			"of the object, extension, size, and option flags. All lists are enclosed in a double-line box. "+ 
			"Format: ^WDd:o.x "+ 
			"Parameters Details "+ 
			"d = source device — "+ 
			"optional "+ 
			"Values: R:, E:, B:, A: and Z: "+ 
			"Default: R: "+ 
			"o = object name — "+ 
			"optional "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: * "+ 
			"The use of a "+ 
			"? (question mark) is also allowed. "+ 
			"x = extension — "+ 
			"optional "+ 
			".TTF "+ 
			"and .TTE are only "+ 
			"supported in firmware "+ 
			"version V60.14.x, V50.14.x, "+ 
			"or later. "+ 
			"Values: any extension conforming to Zebra conventions "+ 
			".FNT = font "+ 
			".BAR = bar code "+ 
			".ZPL = stored ZPL format "+ 
			".GRF = GRF graphic "+ 
			".CO = memory cache "+ 
			".DAT = font encoding "+ 
			".BAS = ZBI encrypted program "+ 
			".BAE = ZBI encrypted program "+ 
			".STO = data storage "+ 
			".PNG = PNG graphic "+ 
			"* = all objects "+ 
			". "+ 
			"TTF = TrueType Font "+ 
			".TTE = True Type Extension "+ 
			"Default: * "+ 
			"The use of a ? (question mark) is also allowed. "+ 
			"Example 1: To print a label listing all objects in DRAM, enter: "+ 
			"^XA "+ 
			"^WDR:*.* "+ 
			"^XZ "+ 
			"Example 2: To print a label listing all resident bar codes, enter: "+ 
			"^XA "+ 
			"^WDZ:*.BAR "+ 
			"^XZ "+ 
			"Example 3: To print a label listing all resident fonts, enter: "+ 
			"^XA "+ 
			"^WDZ:*.FNT "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"~WQ "+ 
			"330 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
