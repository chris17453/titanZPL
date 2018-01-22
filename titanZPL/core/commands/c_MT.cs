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
    public class zpl_cmd_c_MT : zpl_command{   //Media Type
        public string media_type_used                                              = String.Empty;
                                        
        public zpl_cmd_c_MT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MT";                   
            description="Media Type";                   
            data_format="a ";                   
            example    ="";                   
            media_type_used                                             =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =media_type_used //
T = thermal transfer media D = direct thermal media  //a value must be entered or the command is ignored  ZPL Commands ^MU 278 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^MT – Media Type "+ 
			"The ^MT command selects the type of media being used in the printer. "+ 
			"These are the choices for this command: "+ 
			"• Thermal Transfer Media – this media uses a high-carbon black or colored ribbon. The "+ 
			"ink on the ribbon is bonded to the media. "+ 
			"• Direct Thermal Media – this media is heat sensitive and requires no ribbon. "+ 
			"Format: ^MTa "+ 
			"Comments This command is ignored on the HC100™ printer. "+ 
			"Parameters Details "+ 
			"a = media type used "+ 
			"Values: "+ 
			"T = thermal transfer media "+ 
			"D = direct thermal media "+ 
			"Default: a value must be entered or the command is ignored "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MU "+ 
			"278 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
