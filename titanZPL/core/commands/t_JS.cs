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
    public class zpl_cmd_t_JS : zpl_command{   //Change Backfeed Sequence
        public string backfeed_order_in_relation_to_printing                       = String.Empty;
                                        
        public zpl_cmd_t_JS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~JS";                   
            description="Change Backfeed Sequence";                   
            data_format="b ";                   
            example    ="";                   
            backfeed_order_in_relation_to_printing                      =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
b =backfeed_order_in_relation_to_printing //
A = 100 percent backfeed after printing and cutting B = 0 percent backfeed after printing and cutting, and 100 percent before printing the next label N = normal — 90 percent backfeed after label is printed O = off — turn backfeed off completely 10 to 90 = percentage value The value entered must be a multiple of 10. Values not divisible by 10 are rounded to the nearest acceptable value. For example, ~JS55 is accepted as 50 percent backfeed.  //N  245 ZPL Commands ^JT 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"~JS – Change Backfeed Sequence "+ 
			"The ~JS command is used to control the backfeed sequence. This command can be used on "+ 
			"printers with or without built-in cutters. "+ 
			"These are the primary applications: "+ 
			"• to allow programming of the rest point of the cut edge of continuous media. "+ 
			"• provide immediate backfeed after peel-off when the printer is used in a print/apply "+ 
			"application configuration. "+ 
			"This command stays in effect only until the printer is turned off, a new ~JS command is sent, or the "+ 
			"setting is changed on the control panel. When a "+ 
			"~JS command is encountered, it overrides the "+ 
			"current control panel setting for the Backfeed Sequence. "+ 
			"The most common way of eliminating backfeed is to operate in Rewind Mode. Rewind Mode does "+ 
			"not backfeed at all. After a label prints, the leading edge of the next label is placed at the print line. "+ 
			"This eliminates the need to backfeed and does not introduce a non printable area at the leading "+ 
			"edge or bottom of the label. It also does not allow the label to be taken from the printer because it is "+ 
			"not fed out from under the printhead. "+ 
			"Running in another mode with backfeed turned off allows the label to be removed and eliminates the "+ 
			"time-reduction of the backfeed sequence. "+ 
			"Comments When using a specific value, the difference between the value entered and 100 "+ 
			"percent is calculated before the next label is printed. For example, a value of 40 means 40 "+ 
			"percent of the backfeed takes place after the label is cut or removed. The remaining 60 "+ 
			"percent takes place before the next label is printed. "+ 
			"The value for this command is also reflected in the Backfeed parameter on the printer configuration "+ 
			"label. "+ 
			"For ~JSN — the Backfeed parameter is listed as DEFAULT "+ 
			"For "+ 
			"~JSA — or 100% the Backfeed parameter is listed as AFTER "+ 
			"For "+ 
			"~JSB — or 0% the Backfeed parameter is listed as BEFORE "+ 
			"For "+ 
			"~JS10 — 10% of the backfeed takes place after the label is cut or removed. The "+ 
			"remaining 90% takes place before the next label is printed. "+ 
			"This command is ignored on the HC100™ printer. "+ 
			"Format: ~JSb "+ 
			"Parameters Details "+ 
			"b = backfeed order in "+ 
			"relation to "+ 
			"printing "+ 
			"Values: "+ 
			"A = 100 percent backfeed after printing and cutting "+ 
			"B = 0 percent backfeed after printing and cutting, and "+ 
			"100 percent before printing the next label "+ 
			"N = normal — 90 percent backfeed after label is printed "+ 
			"O = off — turn backfeed off completely "+ 
			"10 to 90 = percentage value "+ 
			"The value entered must be a multiple of 10. Values not divisible by 10 are "+ 
			"rounded to the nearest acceptable value. For example, "+ 
			"~JS55 is accepted "+ 
			"as 50 percent backfeed. "+ 
			"Default: N "+ 
			" "+ 
			"245 "+ 
			"ZPL Commands "+ 
			"^JT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
