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
    public class zpl_cmd_c_LT : zpl_command{   //Label Top
        public string label_top                                                    = String.Empty;
                                        
        public zpl_cmd_c_LT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^LT";                   
            description="Label Top";                   
            data_format="x ";                   
            example    ="";                   
            label_top                                                   =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
x =label_top //
HC100: 0 to 120 XiIIIPlus 600dpi: -240 to 240 All other Zebra printers: -120 to 120  //a value must be specified or the command is ignored  265 ZPL Commands ^MA 11/21/16 Zebra Programming Guide P1012728-0
                                       
  **************************************************/ 
            manual=""+ 
			"^LT – Label Top "+ 
			"The ^LT command moves the entire label format a maximum of "+ 
			"120 dot rows up or down from its current position, in relation to the top edge of the label. A negative "+ 
			"value moves the format towards the top of the label; a positive value moves the format away from "+ 
			"the top of the label. "+ 
			"This command can be used to fine-tune the position of the finished label without having to change "+ 
			"any of the existing parameters. "+ 
			"Format: ^LTx "+ 
			"Comments The Accepted Value range for x might be smaller depending on the printer "+ 
			"platform. "+ 
			"The Label Top value shown on the front panel of the printer is double the value used in the ZPL "+ 
			"format. "+ 
			"The "+ 
			"^LT command does not change the media rest position. "+ 
			"Important • For some printer models, it is possible to request a negative value large enough "+ 
			"to cause the media to backup into the printer and become unthreaded from the platen. This "+ 
			"condition can result in a printer error or unpredictable results. "+ 
			"Parameters Details "+ 
			"x = label top (in dot "+ 
			"rows) "+ 
			"Values: "+ 
			"HC100: 0 to 120 "+ 
			"XiIIIPlus 600dpi: "+ 
			"-240 to 240 "+ 
			"All other Zebra printers: -120 to 120 "+ 
			"Default: a value must be specified or the command is ignored "+ 
			" "+ 
			"265 "+ 
			"ZPL Commands "+ 
			"^MA "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
