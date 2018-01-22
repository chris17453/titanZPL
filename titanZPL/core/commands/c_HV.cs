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
    public class zpl_cmd_c_HV : zpl_command{   //Host Verification
        public string field_number_specified_with_another_command_the_value_assigned_to_this_parameter_should_be_the_same_as_the_one_used_in_another_command = String.Empty;
        public    int number_of_bytes                                              = 0;
        public string header_to_be_returned_with_the_data_delimiter_characters_terminate_the_string = String.Empty;
        public string termination_this_field_is_field_hex                          = String.Empty;
        public string a                                                            = String.Empty;
                                        
        public zpl_cmd_c_HV(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^HV";                   
            description="Host Verification";                   
            data_format="#,n,h,t,a ";                   
            example    ="^XA"+
			            "."+
			            "."+
			            "."+
			            "^FH_^HV0,8,EPC[,]_0D_0A,L^FS"+
			            "^PQ2"+
			            "^XZ";                   
            field_number_specified_with_another_command_the_value_assigned_to_this_parameter_should_be_the_same_as_the_one_used_in_another_command=(string)argument(0,data,"s","                   ",""," ");
            number_of_bytes                                             =(   int)argument(1,data,"i","                   ",""," ");
            header_to_be_returned_with_the_data_delimiter_characters_terminate_the_string=(string)argument(2,data,"s","                   ",""," ");
            termination_this_field_is_field_hex                         =(string)argument(3,data,"s","                   ",""," ");
            a                                                           =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
# =field_number_specified_with_another_command_The_value_assigned_to_this_parameter_should_be_the_same_as_the_one_used_in_another_command //0 to 9999  //0 
	
n =number_of_bytes_to_be_returned //1 to 256  //64 
	
h =header_to_be_returned_with_the_data_Delimiter_characters_terminate_the_string //0 to 3072 bytes  //no header 
	
t =termination_This_field_is_Field_Hex //0 to 3072 characters a = command applies to When ^PQ is greater than 1 or if a void label occurs, send one response for a label format or one for every label printed. Values: F =Format L =Label  //
                                       
  **************************************************/ 
            manual=""+ 
			"^HV – Host Verification "+ 
			"Use this command to return data from specified fields, along with an optional ASCII header, to the "+ 
			"host computer. You can use this command with any field that has been assigned a number with the "+ 
			"^RT command or with the ^FN and ^RF commands. "+ 
			"Format: ^HV#,n,h,t,a "+ 
			"Parameters Details "+ 
			"# = field number "+ 
			"specified with "+ 
			"another command "+ 
			"The value assigned to this parameter should be the same as the "+ 
			"one used in another command. "+ 
			"Values: 0 to 9999 "+ 
			"Default: 0 "+ 
			"n = number of bytes "+ 
			"to be returned "+ 
			"Values: 1 to 256 "+ 
			"Default: 64 "+ 
			"h = header to be "+ 
			"returned with "+ 
			"the data "+ 
			"Delimiter characters terminate the string. This field is Field Hex "+ 
			"(^FH) capable. "+ 
			"Values: 0 to 3072 bytes "+ 
			"Default: no header "+ 
			"t = termination "+ 
			"This field is Field Hex (^FH) capable. "+ 
			"Values: 0 to 3072 characters "+ 
			"a = command applies "+ 
			"to "+ 
			"When ^PQ is greater than 1 or if a void label occurs, send one "+ 
			"response for a label format or one for every label printed. "+ 
			"Values: "+ 
			"F =Format "+ 
			"L =Label "+ 
			"Default: F "+ 
			"Example: The following code: "+ 
			"^XA "+ 
			". "+ 
			". "+ 
			". "+ 
			"^FH_^HV0,8,EPC[,]_0D_0A,L^FS "+ 
			"^PQ2 "+ 
			"^XZ "+ 
			"Would return data similar to this: "+ 
			"EPC[12345678] "+ 
			"EPC[55554444] "+ 
			" "+ 
			"ZPL Commands "+ 
			"^HW "+ 
			"210 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
