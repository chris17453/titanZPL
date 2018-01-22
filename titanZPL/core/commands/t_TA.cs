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
    public class zpl_cmd_t_TA : zpl_command{   //Tear-off Adjust Position
        public    int number                                                       = 0;
                                        
        public zpl_cmd_t_TA(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~TA";                   
            description="Tear-off Adjust Position";                   
            data_format="### ";                   
            example    ="";                   
            number                                                      =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	## =change_in_media_rest_position //
–120 to 120 0 to 120 (on the HC100)  //last permanent value saved  325 ZPL Commands ^TB 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"~TA – Tear-off Adjust Position "+ 
			"The ~TA command lets you adjust the rest position of the media after a label is printed, which "+ 
			"changes the position at which the label is torn or cut. "+ 
			"Format: ~TA### "+ 
			"Comments If the parameter is missing or invalid, the command is ignored. "+ 
			"Important • These are some important facts about this command: "+ 
			"• For 600 dpi printers, the step size doubles. "+ 
			"• If the number of characters is less than 3, the command is ignored. "+ 
			"Parameters Details "+ 
			"### = change in media "+ 
			"rest position "+ 
			"(3-digit value "+ 
			"in dot rows must "+ 
			"be used.) "+ 
			"Values: "+ 
			"–120 to 120 "+ 
			"0 to 120 (on the HC100) "+ 
			"Default: last permanent value saved "+ 
			" "+ 
			"325 "+ 
			"ZPL Commands "+ 
			"^TB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
