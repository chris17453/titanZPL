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
    public class zpl_cmd_c_FH : zpl_command{   //Field Hexadecimal Indicator
        public string hexadecimal_indicator                                        = String.Empty;
                                        
        public zpl_cmd_c_FH(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FH";                   
            description="Field Hexadecimal Indicator";                   
            data_format="a ";                   
            example    ="^XA"+
			            "^CI28"+
			            "^LL500"+
			            "^FO100,100"+
			            "^AA,20,20"+
			            "^FH^FDU+00A1 in UTF8 = _C2_A1^FS"+
			            "^XZ";                   
            hexadecimal_indicator                                       =(string)argument(0,data,"s","                   ","","_");
                                    
  /*************************************************  
	
a =hexadecimal_indicator //any character except current format and control prefix (^ and ~ by default)  //_ (underscore
                                       
  **************************************************/ 
            manual=""+ 
			"^FH – Field Hexadecimal Indicator "+ 
			"The ^FH command allows you to enter the hexadecimal value for any character directly into the ^FD "+ 
			"statement. The ^FH command must precede each ^FD command that uses hexadecimals in its "+ 
			"field. "+ 
			"Within the "+ 
			"^FD statement, the hexadecimal indicator must precede each hexadecimal value. The "+ 
			"default hexadecimal indicator is _ (underscore). There must be a minimum of two characters "+ 
			"designated to follow the underscore. The "+ 
			"a parameter can be added when a different hexadecimal "+ 
			"indicator is needed. "+ 
			"This command can be used with any of the commands that have field data (that is "+ 
			"^FD, ^FV (Field "+ 
			"Variable), and ^SN (Serialized Data)). "+ 
			"Valid hexadecimal characters are: "+ 
			"0 1 2 3 4 5 6 7 8 9 A B C D E F a b c d e f "+ 
			"Format: ^FHa "+ 
			"Parameters Details "+ 
			"a = hexadecimal "+ 
			"indicator "+ 
			"Values: any character except current format and control prefix (^ and ~ by default) "+ 
			"Default: _ (underscore) "+ 
			"Example: This is an example of how to enter a hexadecimal value directly into a ^FD statement: "+ 
			"This is an example for ascii data using ^CI0. "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FH "+ 
			"166 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Examples: These are examples of how ^FH works with UTF-8 and UTF-16BE: "+ 
			"UTF-8 "+ 
			"UTF-16BE "+ 
			"^XA "+ 
			"^CI28 "+ 
			"^LL500 "+ 
			"^FO100,100 "+ 
			"^AA,20,20 "+ 
			"^FH^FDU+00A1 in UTF8 = _C2_A1^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^CI29 "+ 
			"^LL500 "+ 
			"^FO100,100 "+ 
			"^AA,20,20 "+ 
			"^FH^FDU+00A1 in UTF16BE = _00_A1^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"167 "+ 
			"ZPL Commands "+ 
			"^FL "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
