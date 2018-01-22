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
    public class zpl_cmd_c_MC : zpl_command{   //Map Clear
        public string map_clear                                                    = String.Empty;
                                        
        public zpl_cmd_c_MC(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^MC";                   
            description="Map Clear";                   
            data_format="a ";                   
            example    ="";                   
            map_clear                                                   =(string)argument(0,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =map_clear // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^MC – Map Clear "+ 
			"In normal operation, the bitmap is cleared after the format has been printed. The ^MC command is "+ 
			"used to retain the current bitmap. This applies to current and subsequent labels until cleared with "+ 
			"^MCY. "+ 
			"Format: ^MCa "+ 
			"Comments The ^MC command retains the image of the current label after formatting. It "+ 
			"appears in the background of the next label printed. "+ 
			"Important • To produce a label template, "+ 
			"^MC must be used with ^FV. "+ 
			"Parameters Details "+ 
			"a = map clear "+ 
			"Values: Y (clear bitmap) or N (do not clear bitmap) "+ 
			"Initial Value at Power Up: Y "+ 
			" "+ 
			"ZPL Commands "+ 
			"^MD "+ 
			"268 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
