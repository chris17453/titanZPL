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
    public class zpl_cmd_c_BT : zpl_command{   //TLC39 Bar Code
        public string orientation                                                  = String.Empty;
        public    int width_of_the_code_39_bar_code                                = 0;
        public    int wide_to_narrow_bar_width_ratio_the_code_39_bar_code          = 0;
        public    int height_of_the_code_39_bar_code                               = 0;
        public    int narrow_bar_width_of_the_micropdf417_bar_code                 = 0;
        public    int row_height_of_the_micropdf417_bar_code                       = 0;
                                        
        public zpl_cmd_c_BT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BT";                   
            description="TLC39 Bar Code";                   
            data_format="o,w1,r1,h1,w2,h2 ";                   
            example    ="^XA^FO100,"+
			            "100^BT^FD123456,"+
			            "ABCd12345678901234,"+
			            "5551212,"+
			            "88899"+
			            "^FS^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            width_of_the_code_39_bar_code                               =(   int)argument(1,data,"i","                   ",""," ");
            wide_to_narrow_bar_width_ratio_the_code_39_bar_code         =(   int)argument(2,data,"i","                   ",""," ");
            height_of_the_code_39_bar_code                              =(   int)argument(3,data,"i","                   ",""," ");
            narrow_bar_width_of_the_micropdf417_bar_code                =(   int)argument(4,data,"i","                   ",""," ");
            row_height_of_the_micropdf417_bar_code                      =(   int)argument(5,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
o =orientation //
N = normal R = rotated I = inverted B = bottom up  // w
	w1 =width_of_the_Code_39_bar_code //
(in dots): 1 to 10  //
(600 dpi printers): 4 Default: (200- and 300 dpi printer): 2 r
	r1 =wide_to_narrow_bar_width_ratio_the_Code_39_bar_code //2.0 to 3.0(increments of 0.1)  //2.0 h
	h1 =height_of_the_Code_39_bar_code //
(in dots): 1 to 9999  //
(600 dpi printer): 120 Default: (300 dpi printer): 60 Default: (200 dpi printer): 40 h
	h2 =row_height_of_the_MicroPDF417_bar_code //
(in dots): 1 to 255  //
(600 dpi printer): 8 Default: (200- and 300 dpi printers): 4 w
	w2 =narrow_bar_width_of_the_MicroPDF417_bar_code //
(in dots): 1 to 10  //
(600 dpi printer): 4 Default: (200- and 300 dpi printers): 2  ZPL Commands ^BT 116 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^BT – TLC39 Bar Code "+ 
			"The ^BT bar code is the standard for the TCIF can tag telecommunications equipment. "+ 
			"The TCIF CLEI code, which is the MicroPDF417 bar code, is always four columns. The firmware "+ 
			"must determine what mode to use based on the number of characters to be encoded. "+ 
			"Format: ^BTo,w1,r1,h1,w2,h2 "+ 
			"Parameters Details "+ 
			"o = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated "+ 
			"I = inverted "+ 
			"B = bottom up "+ 
			"Default:N "+ 
			"w1 = width of the "+ 
			"Code 39 bar code "+ 
			"Values: "+ 
			"(in dots): "+ 
			"1 to 10 "+ 
			"Default: "+ 
			"(600 dpi printers): "+ 
			"4 "+ 
			"Default: "+ 
			"(200- and 300 dpi printer): "+ 
			"2 "+ 
			"r1 = wide to narrow "+ 
			"bar width ratio "+ 
			"the Code 39 bar "+ 
			"code "+ 
			"Values: 2.0 to 3.0(increments of 0.1) "+ 
			"Default: 2.0 "+ 
			"h1 = height of the "+ 
			"Code 39 bar code "+ 
			"Values: "+ 
			"(in dots): "+ 
			"1 to 9999 "+ 
			"Default: "+ 
			"(600 dpi printer): "+ 
			"120 "+ 
			"Default: "+ 
			"(300 dpi printer): "+ 
			"60 "+ 
			"Default: "+ 
			"(200 dpi printer): "+ 
			"40 "+ 
			"h2 = row height of "+ 
			"the MicroPDF417 "+ 
			"bar code "+ 
			"Values: "+ 
			"(in dots): "+ 
			"1 to 255 "+ 
			"Default: "+ 
			"(600 dpi printer): "+ 
			"8 "+ 
			"Default: "+ 
			"(200- and 300 dpi printers): "+ 
			"4 "+ 
			"w2 = narrow bar width "+ 
			"of the "+ 
			"MicroPDF417 bar "+ 
			"code "+ 
			"Values: "+ 
			"(in dots): "+ 
			"1 to 10 "+ 
			"Default: "+ 
			"(600 dpi printer): "+ 
			"4 "+ 
			"Default: "+ 
			"(200- and 300 dpi printers): "+ 
			"2 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BT "+ 
			"116 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: TLC39 Bar Code "+ 
			"This is an example on how to print TLC39 bar code. The callouts identify the key components and "+ 
			"are followed by a detailed description below: "+ 
			"Use the command defaults to get results that are in compliance with TCIF industry standards; "+ 
			"regardless of printhead density. "+ 
			"1 "+ 
			"ECI Number. If the seventh character is not a comma, only Code 39 prints. This means if "+ 
			"more than 6 digits are present, Code 39 prints for the first six digits (and no Micro-PDF "+ 
			"symbol is printed). "+ 
			"• Must be 6 digits. "+ 
			"• Firmware generates invalid character error if the firmware sees anything but "+ 
			"6 digits. "+ 
			"• This number is not padded. "+ 
			"2 "+ 
			"Serial number. The serial number can contain up to 25 characters and is variable length. "+ 
			"The serial number is stored in the Micro-PDF symbol. If a comma follows the serial "+ 
			"number, then additional data is used below. "+ 
			"• If present, must be alphanumeric (letters and numbers, no punctuation). "+ 
			"This value is used if a comma follows the ECI number. "+ 
			"3 "+ 
			"Additional data. If present, it is used for things such as a country code. "+ 
			"Data cannot exceed 150 bytes. This includes serial number commas. "+ 
			"• Additional data is stored in the Micro-PDF symbol and appended after the "+ 
			"serial number. A comma must exist between each maximum of 25 characters "+ 
			"in the additional fields. "+ 
			"• Additional data fields can contain up to 25 alphanumeric characters per "+ 
			"field. "+ 
			"The result is: "+ 
			"1 "+ 
			"2 "+ 
			"3 "+ 
			"^XA^FO100, "+ 
			"100^BT^FD123456, "+ 
			"ABCd12345678901234, "+ 
			"5551212, "+ 
			"88899 "+ 
			"^FS^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"117 "+ 
			"ZPL Commands "+ 
			"^BU "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
