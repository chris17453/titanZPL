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
    public class zpl_cmd_c_SP : zpl_command{   //Start Print
                                        
        public zpl_cmd_c_SP(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SP";                   
            description="Start Print";                   
            data_format="";                   
            example    ="";                   
                                    
  /*************************************************  
	
a =dot_row_to_start_printing //0 to 32000  //
                                       
  **************************************************/ 
            manual=""+ 
			"^SP – Start Print "+ 
			"The ^SP command allows a label to start printing at a specified point before the entire label has "+ 
			"been completely formatted. On extremely complex labels, this command can increase the overall "+ 
			"throughput of the print. "+ 
			"The command works as follows: Specify the dot row at which the "+ 
			"^SP command is to begin. This "+ 
			"creates a label segment. Once the "+ 
			"^SP command is processed, all information in that segment "+ 
			"prints. During the printing process, all of the commands after the ^SP continue to be received and "+ 
			"processed by the printer. "+ 
			"If the segment after the "+ 
			"^SP command (or the remainder of the label) is ready for printing, media "+ 
			"motion does not stop. If the next segment is not ready, the printer stops mid-label and wait for the "+ 
			"next segment to be completed. Precise positioning of the ^SP command requires a trial-and-error "+ 
			"process, as it depends primarily on print speed and label complexity. "+ 
			"The "+ 
			"^SP command can be effectively used to determine the worst possible print quality. You can "+ 
			"determine whether using the "+ 
			"^SP command is appropriate for the particular application by using this "+ 
			"procedure. "+ 
			"If you send the label format up to the first "+ 
			"^SP command and then wait for printing to stop before "+ 
			"sending the next segment, the printed label is a sample of the worst possible print quality. It drops "+ 
			"any field that is out of order. "+ 
			"If the procedure above is used, the end of the label format must be: "+ 
			"^SP#^FS "+ 
			"Comments ^SPa "+ 
			"Parameters Details "+ 
			"a = dot row to start "+ 
			"printing "+ 
			"Values: 0 to 32000 "+ 
			"Default: 0 "+ 
			"Example: In this example, a label 800 dot rows in length uses ^SP500. Segment 1 prints while "+ 
			"commands in Segment 2 are being received and formatted. "+ 
			"Label Segment 2 "+ 
			"Label Segment 1 "+ 
			"Dot position 800 "+ 
			"Dot position 500 "+ 
			"Dot position 0 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SQ "+ 
			"316 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
