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
    public class zpl_cmd_c_FN : zpl_command{   //Field Number
        public    int number                                                       = 0;
                                        
        public zpl_cmd_c_FN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FN";                   
            description="Field Number";                   
            data_format="#'a' ";                   
            example    ="";                   
            number                                                      =(   int)argument(0,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
# =number_to_be_assigned_to_the_field //0 to 9999  //0 'a
	a' =_parameter //255 alphanumeric characters maximum (a-z,A-Z,1-9 and space)  //optional paramete
                                       
  **************************************************/ 
            manual=""+ 
			"^FN – Field Number "+ 
			"The ^FN command numbers the data fields. This command is used in both ^DF (Store Format) and "+ 
			"^XF (Recall Format) commands. "+ 
			"In a stored format, use the "+ 
			"^FN command where you would normally use the ^FD (Field Data) "+ 
			"command. In recalling the stored format, use ^FN in conjunction with the ^FD command. "+ 
			"The optional "+ 
			"'a' parameter can be used with the KDU Plus to cause prompts to be displayed on the "+ 
			"KDU unit. Also, when the Print on Label link is selected on the Directory page of ZebraLink enabled "+ 
			"printers the field prompt displays. "+ 
			"The number of fields and data that can be stored is dependent in the available printer "+ 
			"memory. "+ 
			"Format: ^FN#'a' "+ 
			"* This parameter is only available on printers with firmware V50.13.2, V53.15.5Z, V60.13.0.1, or "+ 
			"later. For a complete example of the "+ 
			"^DF and ^XF command, see ^DF and ^XF — Download format "+ 
			"and recall format on page 35. "+ 
			"Comments "+ 
			"• The same ^FN value can be stored with several different fields. "+ 
			"• If a label format contains a field with "+ 
			"^FN and ^FD, the data in that field prints for any other field "+ 
			"containing the same "+ 
			"^FN value. "+ 
			"• For the "+ 
			"'a' parameter to function as a prompt the characters used in the 'a' parameter must "+ 
			"be surrounded by double quotes (see example). "+ 
			"Note • The maximum number of ^FN commands that can be used depends on the amount of data "+ 
			"that is placed in the fields on the label. It is recommended to use 400 or fewer fields. "+ 
			"Parameters Details "+ 
			"# = number to be "+ 
			"assigned to the "+ 
			"field "+ 
			"Values: 0 to 9999 "+ 
			"Default: 0 "+ 
			"'a' = optional "+ 
			"parameter* "+ 
			"Values: 255 alphanumeric characters maximum "+ 
			"(a-z,A-Z,1-9 and space) "+ 
			"Default: optional parameter "+ 
			"Example: The ^FN1'Name' would result in 'Name' being used as the prompt on the "+ 
			"KDU unit. "+ 
			" "+ 
			"173 "+ 
			"ZPL Commands "+ 
			"^FO "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
