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
    public class zpl_cmd_c_FR : zpl_command{   //Field Reverse Print
                                        
        public zpl_cmd_c_FR(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FR";                   
            description="Field Reverse Print";                   
            data_format=" ";                   
            example    ="^XA"+
			            "^PR1"+
			            "^FO100,100"+
			            "^GB70,70,70,,3^FS"+
			            "^FO200,100"+
			            "^GB70,70,70,,3^FS"+
			            "^FO300,100"+
			            "^GB70,70,70,,3^FS"+
			            "^FO400,100"+
			            "^GB70,70,70,,3^FS"+
			            "^FO107,110^CF0,70,93"+
			            "^FR^FDREVERSE^FS"+
			            "^XZ";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"^FR – Field Reverse Print "+ 
			"The ^FR command allows a field to appear as white over black or black over white. When printing a "+ 
			"field and the ^FR command has been used, the color of the output is the reverse of its background. "+ 
			"Format: ^FR "+ 
			"Comments The ^FR command applies to only one field and has to be specified each time. "+ 
			"When multiple "+ 
			"^FR commands are going to be used, it might be more convenient to use the "+ 
			"^LR command. "+ 
			"Example: In this example, the ^GB command creates areas of black allowing the printing to appear "+ 
			"white: "+ 
			"^XA "+ 
			"^PR1 "+ 
			"^FO100,100 "+ 
			"^GB70,70,70,,3^FS "+ 
			"^FO200,100 "+ 
			"^GB70,70,70,,3^FS "+ 
			"^FO300,100 "+ 
			"^GB70,70,70,,3^FS "+ 
			"^FO400,100 "+ 
			"^GB70,70,70,,3^FS "+ 
			"^FO107,110^CF0,70,93 "+ 
			"^FR^FDREVERSE^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FS "+ 
			"176 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
