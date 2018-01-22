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
    public class zpl_cmd_c_PF : zpl_command{   //Slew Given Number of Dot Rows
        public string number_of_dots_rows_to_slew                                  = String.Empty;
                                        
        public zpl_cmd_c_PF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PF";                   
            description="Slew Given Number of Dot Rows";                   
            data_format="# ";                   
            example    ="";                   
            number_of_dots_rows_to_slew                                 =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
# =number_of_dots_rows_to_slew //
0 to 32000  //a value must be entered or the command is ignored  ZPL Commands ^PH ~PH 290 P1012728-011 Zebra Programming Guide 11/21/16 ^PH ~PH – Slew to Home Position The ^PH or ~PH command causes the printer to feed one blank label. The ~PH command feeds one label after the format currently being printed is done or when the printer is placed in pause. The ^PH command feeds one blank label after the current format prints. Format: ^PH or ~PH  291 ZPL Commands ~PL 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^PF – Slew Given Number of Dot Rows "+ 
			"The ^PF command causes the printer to slew labels (move labels at a high speed without printing) a "+ 
			"specified number of dot rows from the bottom of the label. This allows faster printing when the "+ 
			"bottom portion of a label is blank. "+ 
			"Format: ^PF# "+ 
			"Parameters Details "+ 
			"# = number of dots "+ 
			"rows to slew "+ 
			"Values: "+ 
			"0 to 32000 "+ 
			"Default: a value must be entered or the command is ignored "+ 
			" "+ 
			"ZPL Commands "+ 
			"^PH ~PH "+ 
			"290 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"^PH ~PH – Slew to Home Position "+ 
			"The ^PH or ~PH command causes the printer to feed one blank label. "+ 
			"The "+ 
			"~PH command feeds one label after the format currently being printed is done or when the "+ 
			"printer is placed in pause. "+ 
			"The "+ 
			"^PH command feeds one blank label after the current format prints. "+ 
			"Format: ^PH or ~PH "+ 
			" "+ 
			"291 "+ 
			"ZPL Commands "+ 
			"~PL "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
