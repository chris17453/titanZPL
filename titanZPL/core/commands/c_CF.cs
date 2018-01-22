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
    public class zpl_cmd_c_CF : zpl_command{   //Change Alphanumeric Default Font
        public string default_font                                                 = String.Empty;
        public    int h                                                            = 0;
        public    int w                                                            = 0;
                                        
        public zpl_cmd_c_CF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^CF";                   
            description="Change Alphanumeric Default Font";                   
            data_format="f,h,w ";                   
            example    ="^XA"+
			            "^CF0,89"+
			            "^FO20,50"+
			            "^FDA GUIDE TO^FS"+
			            "^FO20,150"+
			            "^FDTHE ZPL II^FS"+
			            "^FO20,250"+
			            "^FDPROGRAMMING^FS"+
			            "^FO20,350"+
			            "^FDLANGUAGE^FS"+
			            "^XZ";                   
            default_font                                                =(string)argument(0,data,"s","                   ",""," ");
            h                                                           =(   int)argument(1,data,"i","                   ",""," ");
            w                                                           =(   int)argument(2,data,"i","                   ",""," ");
                                    
  /*************************************************  
	
f =specified_default_font // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^CF – Change Alphanumeric Default Font "+ 
			"The ^CF command sets the default font used in your printer. You can use the ^CF command to "+ 
			"simplify your programs. "+ 
			"Format: ^CFf,h,w "+ 
			"Parameter f specifies the default font for every alphanumeric field. Parameter h is the default height "+ 
			"for every alphanumeric field, and parameter w is the default width value for every alphanumeric field. "+ 
			"The default alphanumeric font is A. If you do not change the alphanumeric default font and do not "+ 
			"use any alphanumeric field command ( "+ 
			"^AF) or enter an invalid font value, any data you specify "+ 
			"prints in font A. "+ 
			"Defining only the height or width forces the magnification to be proportional to the parameter "+ 
			"defined. If neither value is defined, the last "+ 
			"^CF values given or the default ^CF values for height and "+ 
			"width are used. "+ 
			"Comments Any font in the printer, including downloaded fonts, EPROM stored fonts, and "+ 
			"fonts A through Z and 0 to 9, can also be selected with "+ 
			"^CW. "+ 
			"Parameters Details "+ 
			"f = specified default "+ 
			"font "+ 
			"Values: A through Z and 0 to 9 "+ 
			"Initial Value at Power Up: A "+ 
			"h = individual "+ 
			"character height "+ 
			"(in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Initial Value at Power Up: 9 "+ 
			"w = individual "+ 
			"character width "+ 
			"(in dots) "+ 
			"Values: 0 to 32000 "+ 
			"Initial Value at Power Up: 5 or last permanent saved value "+ 
			"Example: This is an example of ^CF code and the result of the code: "+ 
			"^XA "+ 
			"^CF0,89 "+ 
			"^FO20,50 "+ 
			"^FDA GUIDE TO^FS "+ 
			"^FO20,150 "+ 
			"^FDTHE ZPL II^FS "+ 
			"^FO20,250 "+ 
			"^FDPROGRAMMING^FS "+ 
			"^FO20,350 "+ 
			"^FDLANGUAGE^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"129 "+ 
			"ZPL Commands "+ 
			"^CI "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
