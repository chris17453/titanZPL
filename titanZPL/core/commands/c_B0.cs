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
    public class zpl_cmd_c_B0 : zpl_command{   //Aztec Bar Code Parameters
        public string orientation                                                  = String.Empty;
        public    int magnification_factor                                         = 0;
        public string interpretation_code_indicator                                = String.Empty;
        public string error_control_indicator                                      = String.Empty;
        public string menu_symbol_indicator                                        = String.Empty;
        public    int number_of_symbols                                            = 0;
        public string _id_field                                                    = String.Empty;
                                        
        public zpl_cmd_c_B0(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^B0";                   
            description="Aztec Bar Code Parameters";                   
            data_format="a,b,c,d,e,f,g ";                   
            example    ="^XA"+
			            "^B0R,7,N,0,N,1,0"+
			            "^FD 7. This is testing label 7^FS"+
			            "^XZ";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            magnification_factor                                        =(   int)argument(1,data,"i","                   ",""," ");
            interpretation_code_indicator                               =(string)argument(2,data,"s","                   ",""," ");
            error_control_indicator                                     =(string)argument(3,data,"s","                   ",""," ");
            menu_symbol_indicator                                       =(string)argument(4,data,"s","                   ",""," ");
            number_of_symbols                                           =(   int)argument(5,data,"i","                   ",""," ");
            _id_field                                                   =(string)argument(6,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =orientation //
N = normal R = rotated I = inverted 180 degrees B = read from bottom up, 270 degrees  //current ^FW value 
	
b =magnification_factor //1 to 10  //
1 on 150 dpi printers 2 on 200 dpi printers 3 on 300 dpi printers 6 on 600 dpi printers 
	
c =extended_channel_interpretation_code_indicator //
Y = if data contains ECICs N = if data does not contain ECICs  //N 
	
d =error_control_and_symbol_size/type_indicator //
0 = default error correction level 01 to 99 = error correction percentage (minimum) 101 to 104 = 1 to 4-layer compact symbol 201 to 232 = 1 to 32-layer full-range symbol 300 = a simple Aztec “Rune”  //0 
	
e =menu_symbol_indicator //
Y = if this symbol is to be a menu (bar code reader initialization) symbol N = if it is not a menu symbol  //N 
	
f =number_of_symbols_for_structured_append //1 through 26  //1 
	
g =_ID_field // //no ID  ZPL Commands ^B0 44 P1012728-011 Zebra Programming Guide 11/21/1
                                       
  **************************************************/ 
            manual=""+ 
			"^B0 – Aztec Bar Code Parameters "+ 
			"The ^B0 command creates a two-dimensional matrix symbology made up of square modules "+ 
			"arranged around a bulls-eye pattern at the center. "+ 
			"Format: ^B0a,b,c,d,e,f,g "+ 
			"Note • The Aztec bar code works with firmware version V60.13.0.11A and V50.13.2 or later. "+ 
			"Parameters Details "+ 
			"a = orientation "+ 
			"Values: "+ 
			"N = normal "+ 
			"R = rotated "+ 
			"I = inverted 180 degrees "+ 
			"B = read from bottom up, 270 degrees "+ 
			"Default: current ^FW value "+ 
			"b = magnification "+ 
			"factor "+ 
			"Values: 1 to 10 "+ 
			"Default: "+ 
			"1 on 150 dpi printers "+ 
			"2 on 200 dpi printers "+ 
			"3 on 300 dpi printers "+ 
			"6 on 600 dpi printers "+ 
			"c = extended channel "+ 
			"interpretation "+ 
			"code indicator "+ 
			"Values: "+ 
			"Y = if data contains ECICs "+ 
			"N = if data does not contain ECICs "+ 
			"Default: N "+ 
			"d = error control and "+ 
			"symbol size/type "+ 
			"indicator "+ 
			"Values: "+ 
			"0 = default error correction level "+ 
			"01 to 99 = error correction percentage (minimum) "+ 
			"101 to 104 = 1 to 4-layer compact symbol "+ 
			"201 to 232 = 1 to 32-layer full-range symbol "+ 
			"300 = a simple Aztec “Rune” "+ 
			"Default: 0 "+ 
			"e = menu symbol "+ 
			"indicator "+ 
			"Values: "+ 
			"Y = if this symbol is to be a menu (bar code reader initialization) symbol "+ 
			"N = if it is not a menu symbol "+ 
			"Default: N "+ 
			"f = number of symbols "+ 
			"for structured "+ 
			"append "+ 
			"Values: 1 through 26 "+ 
			"Default: 1 "+ 
			"g = optional ID field "+ 
			"for structured "+ 
			"append "+ 
			"The ID field is a text string with 24-character maximum "+ 
			"Default: no ID "+ 
			" "+ 
			"ZPL Commands "+ 
			"^B0 "+ 
			"44 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example: This is an example of the ^B0 command: "+ 
			"^XA "+ 
			"^B0R,7,N,0,N,1,0 "+ 
			"^FD 7. This is testing label 7^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"45 "+ 
			"ZPL Commands "+ 
			"^B1 "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
