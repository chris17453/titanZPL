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
    public class zpl_cmd_c_ML : zpl_command{   //Maximum Label Length
        public string label_length_max                                             = String.Empty;
                                        
        public zpl_cmd_c_ML(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^ML";                   
            description="Maximum Label Length";                   
            data_format="a ";                   
            example    ="";                   
            label_length_max                                            =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =maximum_label_length //the dpi of the printer multiplied by two, up to the maximum length of label  //last permanently saved value  ZPL Commands ^MM 272 P1012728-011 Zebra Programming Guide 11/21/
                                       
  **************************************************/ 
            manual=""+ 
			"^ML – Maximum Label Length "+ 
			"The ^ML command lets you adjust the maximum label length. "+ 
			"Format: ^MLa "+ 
			"Comments For calibration to work properly, you must set the maximum label length equal "+ 
			"to or greater than your actual label length. "+ 
			"This command is ignored on the HC100™ printer "+ 
			"Note • This command does not apply when in continuous mode. "+ 
			"Parameters Details "+ 
			"a = maximum label "+ 
			"length (in dot "+ 
			"rows) "+ 
			"Values: the dpi of the printer multiplied by two, up to the maximum length of label "+ 
			"Default: last permanently saved value "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MM "+ 
			"272 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
