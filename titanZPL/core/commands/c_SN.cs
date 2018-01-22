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
    public class zpl_cmd_c_SN : zpl_command{   //Serialization Data
        public string starting_value                                               = String.Empty;
        public string increment_or_decrement_value                                 = String.Empty;
        public string add_leading_zeros                                            = String.Empty;
                                        
        public zpl_cmd_c_SN(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SN";                   
            description="Serialization Data";                   
            data_format="v,n,z ";                   
            example    ="^XA"+
			            "^FO260,110"+
			            "^CFG"+
			            "^SN001,1,Y^FS"+
			            "^PQ3"+
			            "^XZ";                   
            starting_value                                              =(string)argument(0,data,"s","                   ",""," ");
            increment_or_decrement_value                                =(string)argument(1,data,"s","                   ",""," ");
            add_leading_zeros                                           =(string)argument(2,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
v =starting_value //12-digits maximum for the portion to be indexed  //1 
	
n =increment_or_decrement_value //12-digit maximum  //
1 To indicate a decrement value, precede the value with a minus (–) sign. 
	
z =add_leading_zeros //
N = no Y = yes  //
N  313 ZPL Commands ^SN 11/21/16 Zebra Programming Guide P1012728-011 Comments Incrementing and decrementing takes place for each serial-numbered field when all replicates for each serial number have been printed, as specified in parameter r of the ^PQ (print quality) command. If, during the course of printing serialized labels, the printer runs out of either paper or ribbon, the first label printed (after the media or ribbon has been replaced and calibration completed) has the same serial number as the partial label printed before the out condition occurred. This is done in case the last label before the out condition did not fully print. This is controlled by the ^JZ command. Using Leading Zeros In the ^SN command, the z parameter determines if leading zeros are printed or suppressed. Depending on which value is used (
	(Y =print_leading_zeros // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^SN – Serialization Data "+ 
			"The ^SN command allows the printer to index data fields by a selected increment or decrement "+ 
			"value, making the data fields increase or decrease by a specified value each time a label is printed. "+ 
			"This can be performed on 100 to 150 fields in a given format and can be performed on both "+ 
			"alphanumeric and bar code fields. A maximum of 12 of the right- most integers are subject to "+ 
			"indexing. "+ 
			"Format: ^SNv,n,z "+ 
			"In x.13 and earlier, the first integer found when scanning from right to left starts the "+ 
			"indexing portion of the data field. "+ 
			"In x.14 and later, the first integer found when scanning from end of the backing store "+ 
			"towards the beginning starts the indexing portion of the data field. "+ 
			"In x.13 and earlier, if the alphanumeric field to be indexed ends with an alpha character, the "+ 
			"data is scanned, character by character, from right to left until a numeric character is "+ 
			"encountered. Serialization takes place using the value of the first number found. "+ 
			"In x.14 and later, if the backing store of the alphanumeric field to be indexed ends with an "+ 
			"alpha character, the data is scanned, character by character, from the end of the backing "+ 
			"store until a numeric character is encountered. Serialization takes place using the value of "+ 
			"the first number found. "+ 
			"Parameters Details "+ 
			"v = starting value "+ 
			"Values: 12-digits maximum for the portion to be indexed "+ 
			"Default: 1 "+ 
			"n = increment or "+ 
			"decrement value "+ 
			"Values: 12-digit maximum "+ 
			"Default: "+ 
			"1 "+ 
			"To indicate a decrement value, precede the value with a minus (–) sign. "+ 
			"z = add leading zeros "+ 
			"(if needed) "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: "+ 
			"N "+ 
			" "+ 
			"313 "+ 
			"ZPL Commands "+ 
			"^SN "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments Incrementing and decrementing takes place for each serial-numbered field "+ 
			"when all replicates for each serial number have been printed, as specified in parameter "+ 
			"r of "+ 
			"the "+ 
			"^PQ (print quality) command. "+ 
			"If, during the course of printing serialized labels, the printer runs out of either paper or ribbon, the "+ 
			"first label printed (after the media or ribbon has been replaced and calibration completed) has the "+ 
			"same serial number as the partial label printed before the out condition occurred. This is done in "+ 
			"case the last label before the out condition did not fully print. This is controlled by the "+ 
			"^JZ command. "+ 
			"Using Leading Zeros "+ 
			"In the ^SN command, the z parameter determines if leading zeros are printed or suppressed. "+ 
			"Depending on which value is used (Y = print leading zeros; N = do not print leading zeros), the "+ 
			"printer either prints or suppresses the leading zeros. "+ 
			"The default value for this parameter is "+ 
			"N (do not print leading zeros). "+ 
			"Print Leading Zeros "+ 
			"Suppressing Leading Zeros "+ 
			"Example: This example shows incrementing by a specified value: "+ 
			"^XA "+ 
			"^FO260,110 "+ 
			"^CFG "+ 
			"^SN001,1,Y^FS "+ 
			"^PQ3 "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABELS "+ 
			"Note: The ZPL II code above will generate "+ 
			"three separate labels, seen to the right. "+ 
			"In x.13 and earlier, the starting value consists of the right-most consecutive sequence of "+ 
			"digits. "+ 
			"In x.14 and later, the starting value consists of the first number working backwards in the backing "+ 
			"store consecutive sequence of digits. "+ 
			"The width (number of digits in the sequence) is determined by scanning from right to left until the "+ 
			"first non-digit (space or alpha character) is encountered. To create a specific width, manually place "+ 
			"leading zeros as necessary. "+ 
			"In x.13 and earlier, the starting value consists of the right-most consecutive sequence of "+ 
			"digits, including any leading spaces. "+ 
			"In x.14 or later, the starting value consists of the first number working backwards in the "+ 
			"backing store consecutive sequence of digits, including any leading spaces. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SO "+ 
			"314 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
