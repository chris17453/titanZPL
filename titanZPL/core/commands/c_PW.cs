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
    public class zpl_cmd_c_PW : zpl_command{   //Print Width
        public    int label_width                                                  = 0;
                                        
        public zpl_cmd_c_PW(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PW";                   
            description="Print Width";                   
            data_format="a ";                   
            example    ="";                   
            label_width                                                 =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
a =label_width //2, to the width of the label If the value exceeds the width of the label, the width is set to the label’s maximum size.  //last permanently saved value  ZPL Commands ~RO 302 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^PW – Print Width "+ 
			"The ^PW command allows you to set the print width. "+ 
			"Format: ^PWa "+ 
			"Comments This command is ignored on the HC100™ printer. "+ 
			"Parameters Details "+ 
			"a = label width (in "+ 
			"dots) "+ 
			"Values: 2, to the width of the label "+ 
			"If the value exceeds the width of the label, the width is set to the label’s "+ 
			"maximum size. "+ 
			"Default: last permanently saved value "+ 
			" "+ 
			"ZPL Commands "+ 
			"~RO "+ 
			"302 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
