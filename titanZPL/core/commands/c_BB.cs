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
    public class zpl_cmd_c_BB : zpl_command{   //CODABLOCK Bar Code
        public string orientation                                                  = String.Empty;
        public    int bar_code_height_for_individual_rows                          = 0;
        public string security_level                                               = String.Empty;
        public    int number_of_characters_per_row                                 = 0;
        public string ratio_fixed_value_3                                          = String.Empty;
        public string m                                                            = String.Empty;
                                        
        public zpl_cmd_c_BB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BB";                   
            description="CODABLOCK Bar Code";                   
            data_format="o,h,s,c,r,m ";                   
            example    ="^XA"+
			            "^BY2,3"+
			            "^FO10,10^BBN,30,,30,44,E"+
			            "^FDZebra Technologies"+
			            "Corporation strives to be"+
			            "the expert supplier of"+
			            "innovative solutions to"+
			            "speciality demand labeling"+
			            "and ticketing problems of"+
			            "business and government."+
			            "We will attract and retain"+
			            "the best people who will"+
			            "understand our customer's"+
			            "needs and provide them with"+
			            "systems, hardware, software,"+
			            "consumables and service"+
			            "offering the best value,"+
			            "high quality, and reliable"+
			            "performance, all delivered"+
			            "in a timely manner.^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            bar_code_height_for_individual_rows                         =(   int)argument(1,data,"i","                   ",""," ");
            security_level                                              =(string)argument(2,data,"s","                   ",""," ");
            number_of_characters_per_row                                =(   int)argument(3,data,"i","                   ",""," ");
            ratio_fixed_value_3                                         =(string)argument(4,data,"s","                   ",""," ");
            m                                                           =(string)argument(5,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated 90 degrees (clockwise) I = inverted 180 degrees B = read from bottom up, 270 degrees  //N 
	
h =bar_code_height_for_individual_rows //2 to 32000  //8 This number, multiplied by the module, equals the height of the individual row in dots. 
	
s =security_level //
N = no Y = yes  //Y Security level determines whether symbol check-sums are generated and added to the symbol. Check sums are never generated for single-row symbols. This can be turned off only if parameter m is set to A. 
	
c =number_of_characters_per_row //2 to 62 characters This is used to encode a CODABLOCK symbol. It gives the you control over the width of the symbol.  ZPL Commands ^BB 70 P1012728-011 Zebra Programming Guide 11/21/16 r = number of rows to encode Values: for CODABLOCK A: 1 to 22 for CODABLOCK E and F: 2 to 4 • If values for c and r are not specified, a single row is produced. • If a value for r is not specified, and c exceeds the maximum range, a single row equal to the field data length is produced. • If a value for c is not specified, the number of characters per row is derived by dividing the field data by the value of r. • If the s parameter is set to the default of Y, then the checksum characters that are included count as two data characters . For example, if c = 6, r is set to 3 and s is set to N, then up to 18 characters can be used (6 x 3). However, if s is set to Y, then only 16 character can be used. • If the data field contains primarily numeric data, fewer than the specified rows might be printed. If the field data contains several shift and code-switch characters, more than the specified number of rows might be printed. m = mode Values: A, E, F CODABLOCK A uses the Code 39 character set. CODABLOCK F uses the Code 128 character set. CODABLOCK E uses the Code 128 character set and automatically adds FNC1.  //F Parameters Details  71 ZPL Commands ^BB 11/21/16 Zebra Programming Guide P1012728-011 Special Considerations for the ^BY Command When Using ^BB The parameters for the ^BYw,r,h command, when used with a ^BB code, are as follows: 
	
w =module_width //2 to 10 (CODABLOCK A only)  //2 
	
r =ratio_Fixed_Value_3 //1 to 32,32000  //10 CODABLOCK uses this as the overall symbol height only when the row height is not specified in the ^BB h parameter. Special Considerations for ^FD Character Set When Using ^BB The character set sent to the printer depends on the mode selected in parameter m. CODABLOCK A: CODABLOCK A uses the same character set as Code 39. If any other character is used in the ^FD statement, either no bar code is printed or an error message is printed (if ^CV is active). CODABLOCK E: The Automatic Mode includes the full ASCII set except for those characters with special meaning to the printer. Function codes or the Code 128 Subset A < nul> character can be inserted using of the ^FH command
                                       
  **************************************************/ 
            manual=""+ 
			"^BB – CODABLOCK Bar Code "+ 
			"The ^BB command produces a two-dimensional, multirow, stacked symbology. It is ideally suited for "+ 
			"applications that require large amounts of information. "+ 
			"Depending on the mode selected, the code consists of one to 44 stacked rows. Each row begins and "+ 
			"ends with a start and stop pattern. "+ 
			"• CODABLOCK A supports variable print ratios. "+ 
			"• CODABLOCK E and F support only fixed print ratios. "+ 
			"Format: ^BBo,h,s,c,r,m "+ 
			"Important • If additional information about the CODABLOCK bar code is required, go to "+ 
			"www.aimglobal.org. "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated 90 degrees (clockwise) "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: N "+ 
			"h = bar code height "+ 
			"for individual "+ 
			"rows (in dots) "+ 
			"Values: 2 to 32000 "+ 
			"Default: 8 "+ 
			"This number, multiplied by the module, equals the height of the individual row in "+ 
			"dots. "+ 
			"s = security level "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: Y "+ 
			"Security level determines whether symbol check-sums are generated and added "+ 
			"to the symbol. Check sums are never generated for single-row symbols. This "+ 
			"can be turned off only if parameter "+ 
			"m is set to A. "+ 
			"c = number of "+ 
			"characters per "+ 
			"row (data "+ 
			"columns) "+ 
			"Values: 2 to 62 characters "+ 
			"This is used to encode a CODABLOCK symbol. It gives the you control over the "+ 
			"width of the symbol. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BB "+ 
			"70 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"r = number of rows to "+ 
			"encode "+ 
			"Values: "+ 
			"for CODABLOCK A: "+ 
			"1 to 22 "+ 
			"for CODABLOCK E and F: 2 to 4 "+ 
			"• If values for c and r are not specified, a single row is produced. "+ 
			"• If a value for r is not specified, and c exceeds the maximum range, a "+ 
			"single row equal to the field data length is produced. "+ 
			"• If a value for c is not specified, the number of characters per row is "+ 
			"derived by dividing the field data by the value of "+ 
			"r. "+ 
			"• If the s parameter is set to the default of Y, then the checksum "+ 
			"characters that are included count as two data characters . "+ 
			"For example, if c = 6, r is set to 3 and s is set to N, then up to 18 "+ 
			"characters can be used (6 x 3). However, if s is set to Y, then only 16 "+ 
			"character can be used. "+ 
			"• If the data field contains primarily numeric data, fewer than the "+ 
			"specified rows might be printed. If the field data contains several shift "+ 
			"and code-switch characters, more than the specified number of rows "+ 
			"might be printed. "+ 
			"m = mode "+ 
			"Values: A, E, F "+ 
			"CODABLOCK A uses the Code 39 character set. "+ 
			"CODABLOCK F uses the Code 128 character set. "+ 
			"CODABLOCK E uses the Code 128 character set and automatically adds FNC1. "+ 
			"Default: F "+ 
			"Parameters Details "+ 
			" "+ 
			"71 "+ 
			"ZPL Commands "+ 
			"^BB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Special Considerations for the ^BY Command When Using ^BB "+ 
			"The parameters for the ^BYw,r,h command, when used with a ^BB code, are as follows: "+ 
			"w = module width (in dots) "+ 
			"Values: 2 to 10 (CODABLOCK A only) "+ 
			"Default: 2 "+ 
			"r = ratio "+ 
			"Fixed Value: "+ 
			"3 (ratio has no effect on CODABLOCK E or F) "+ 
			"h = height of bars (in dots) "+ 
			"Values: 1 to 32,32000 "+ 
			"Default: 10 "+ 
			"CODABLOCK uses this as the overall symbol height only when the row height is not "+ 
			"specified in the "+ 
			"^BB h parameter. "+ 
			"Special Considerations for ^FD Character Set When Using ^BB "+ 
			"The character set sent to the printer depends on the mode selected in parameter m. "+ 
			"CODABLOCK A: CODABLOCK A uses the same character set as Code 39. If any other "+ 
			"character is used in the "+ 
			"^FD statement, either no bar code is printed or an error message "+ 
			"is printed (if "+ 
			"^CV is active). "+ 
			"CODABLOCK E: The Automatic Mode includes the full ASCII set except for those "+ 
			"characters with special meaning to the printer. Function codes or the "+ 
			"Code 128 Subset A < "+ 
			"nul> character can be inserted using of the ^FH command. "+ 
			"Example: This is an example of a CODABLOCK bar code: "+ 
			"^XA "+ 
			"^BY2,3 "+ 
			"^FO10,10^BBN,30,,30,44,E "+ 
			"^FDZebra Technologies "+ 
			"Corporation strives to be "+ 
			"the expert supplier of "+ 
			"innovative solutions to "+ 
			"speciality demand labeling "+ 
			"and ticketing problems of "+ 
			"business and government. "+ 
			"We will attract and retain "+ 
			"the best people who will "+ 
			"understand our customer's "+ 
			"needs and provide them with "+ 
			"systems, hardware, software, "+ 
			"consumables and service "+ 
			"offering the best value, "+ 
			"high quality, and reliable "+ 
			"performance, all delivered "+ 
			"in a timely manner.^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"CODABLOCK BAR CODE "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BB "+ 
			"72 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"For any other character above 84 hex, either no bar code is printed or an error message is "+ 
			"printed (if "+ 
			"^CV is active). "+ 
			"CODABLOCK F: CODABLOCK F uses the full ASCII set, except for those characters with "+ 
			"special meaning to the printer. Function codes or the Code 128 Subset A < "+ 
			"nul> character "+ 
			"can be inserted using of the "+ 
			"^FH command. "+ 
			"<fnc1> = 80 hex <fnc3> = 82 hex "+ 
			"<fnc2> = 81 hex <fnc4> = 83 hex "+ 
			"<nul> = 84 hex "+ 
			"<fnc1> = 80 hex <fnc3> = 82 hex "+ 
			"<fnc2> = 81 hex <fnc4> = 83 hex "+ 
			"<nul> = 84 hex "+ 
			" "+ 
			"73 "+ 
			"ZPL Commands "+ 
			"^BC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
