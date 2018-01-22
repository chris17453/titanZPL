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
    public class zpl_cmd_c_BR : zpl_command{   //GS1 Databar
        public string orientation                                                  = String.Empty;
        public string symbology_type_in_the_gs1_databar_family                     = String.Empty;
        public    int magnification_factor                                         = 0;
        public string d                                                            = String.Empty;
        public    int bar_code_height_the_bar_code_height_only_affects_the_linear_portion_of_the_bar_code = 0;
        public    int segment_width                                                = 0;
                                        
        public zpl_cmd_c_BR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^BR";                   
            description="GS1 Databar";                   
            data_format="a,b,c,d,e,f ";                   
            example    ="";                   
            orientation                                                 =(string)argument(0,data,"s","                   ",""," ");
            symbology_type_in_the_gs1_databar_family                    =(string)argument(1,data,"s","                   ",""," ");
            magnification_factor                                        =(   int)argument(2,data,"i","                   ",""," ");
            d                                                           =(string)argument(3,data,"s","                   ",""," ");
            bar_code_height_the_bar_code_height_only_affects_the_linear_portion_of_the_bar_code=(   int)argument(4,data,"i","                   ",""," ");
            segment_width                                               =(   int)argument(5,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
a =orientation //
N = Normal R = Rotated I = Inverted B = Bottom-up  //R 
	
b =symbology_type_in_the_GS1_DataBar_family //
1 = GS1 DataBar Omnidirectional 2 = GS1 DataBar Truncated 3 = GS1 DataBar Stacked 4 = GS1 DataBar Stacked Omnidirectional 5 = GS1 DataBar Limited 6 = GS1 DataBar Expanded 7 = UPC-A 8 = UPC-E 9 = EAN-13 10 = EAN-8 11 = UCC/EAN-128 and CC-A/B 12 = UCC/EAN-128 and CC-C  //1 
	
c =magnification_factor //1 to 10  //
24 dot
	t
=6 //1 or 2  //1 
	
e =bar_code_height_The_bar_code_height_only_affects_the_linear_portion_of_the_bar_code //1 to 32000 dots  //25 
	
f =the_segment_width //2 to 22, even numbers only, in segments per line  //22  111 ZPL Commands ^BR 11/21/16 Zebra Programming Guide P1012728-01
                                       
  **************************************************/ 
            manual=""+ 
			"^BR – GS1 Databar "+ 
			"(formerly Reduced Space Symbology) "+ 
			"The ^BR command is bar code types for space-constrained identification from EAN International and "+ 
			"the Uniform Code Council, Inc. "+ 
			"Format: ^BRa,b,c,d,e,f "+ 
			"Parameters Details "+ 
			"a = orientation "+ 
			"Values: "+ 
			"N = Normal "+ 
			"R = Rotated "+ 
			"I = Inverted "+ 
			"B = Bottom-up "+ 
			"Default: R "+ 
			"b = symbology type in "+ 
			"the GS1 DataBar "+ 
			"family "+ 
			"Values: "+ 
			"1 = GS1 DataBar Omnidirectional "+ 
			"2 = GS1 DataBar Truncated "+ 
			"3 = GS1 DataBar Stacked "+ 
			"4 = GS1 DataBar Stacked Omnidirectional "+ 
			"5 = GS1 DataBar Limited "+ 
			"6 = GS1 DataBar Expanded "+ 
			"7 = UPC-A "+ 
			"8 = UPC-E "+ 
			"9 = EAN-13 "+ 
			"10 = EAN-8 "+ 
			"11 = UCC/EAN-128 and CC-A/B "+ 
			"12 = UCC/EAN-128 and CC-C "+ 
			"Default: 1 "+ 
			"c = magnification "+ 
			"factor "+ 
			"Values: 1 to 10 "+ 
			"Default: "+ 
			"24 dot "+ 
			"= 6, 12 dot is 3, 8 dot and lower is 2 "+ 
			"12 dot = 6, > 8 dot is 3, 8 dot and less is 2 "+ 
			"d = separator height "+ 
			"Values: 1 or 2 "+ 
			"Default: 1 "+ 
			"e = bar code height "+ 
			"The bar code height only affects the linear portion of the bar code. Only UCC/EAN "+ 
			"and CC-A/B/C. "+ 
			"Values: 1 to 32000 dots "+ 
			"Default: 25 "+ 
			"f = the segment width "+ 
			"(GS1 DataBar "+ 
			"Expanded only) "+ 
			"Values: 2 to 22, even numbers only, in segments per line "+ 
			"Default: 22 "+ 
			" "+ 
			"111 "+ 
			"ZPL Commands "+ 
			"^BR "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example 1: This is an example of Symbology Type 7 - UPC-A: "+ 
			"Example 2: This is an example of Symbology Type 1 - GS1 DataBar Omnidirectional: "+ 
			"^XA "+ 
			"^FO10,10^BRN,7,5,2,100 "+ 
			"^FD12345678901|this is composite info^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^FO10,10^BRN,1,5,2,100 "+ 
			"^FD12345678901|this is composite info^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^BS "+ 
			"112 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
