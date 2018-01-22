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
    public class zpl_cmd_c_PQ : zpl_command{   //Print Quantity
        public    int total_quantity_of_labels                                     = 0;
        public string pause_and_cut_value                                          = String.Empty;
        public string replicates_of_each_serial_number                             = String.Empty;
        public string override_pause_count                                         = String.Empty;
        public string cut_on_error_label                                           = String.Empty;
                                        
        public zpl_cmd_c_PQ(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^PQ";                   
            description="Print Quantity";                   
            data_format="q,p,r,o,e ";                   
            example    ="";                   
            total_quantity_of_labels                                    =(   int)argument(0,data,"i","                   ",""," ");
            pause_and_cut_value                                         =(string)argument(1,data,"s","                   ",""," ");
            replicates_of_each_serial_number                            =(string)argument(2,data,"s","                   ",""," ");
            override_pause_count                                        =(string)argument(3,data,"s","                   ",""," ");
            cut_on_error_label                                          =(string)argument(4,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
q =total_quantity_of_labels_to_print //1 to 99,999,999  //1 
	
p =pause_and_cut_value //1 to 99,999,999  //
0 (no pause) 
	
r =replicates_of_each_serial_number //0 to 99,999,999 replicates  //
: 0 (no replicates) 
	
o =override_pause_count //
N = no Y = yes  //
N 
	
e =cut_on_error_label //
N = no - if a cutter is installed, a cut will be made after a voided RIFD label ONLY if a cut would be made after the non-voided label and this was the last retry. Y = yes - if a cutter is installed, a cut will be made after ANY voided RFID label.  //
                                       
  **************************************************/ 
            manual=""+ 
			"^PQ – Print Quantity "+ 
			"The ^PQ command gives control over several printing operations. It controls the number of labels to "+ 
			"print, the number of labels printed before printer pauses, and the number of replications of each "+ 
			"serial number. "+ 
			"Format: ^PQq,p,r,o,e "+ 
			"If the "+ 
			"o parameter is set to Y, the printer cuts but does not pause, and the printer does not pause "+ 
			"after every group count of labels has been printed. With the o parameter set to N (default), the "+ 
			"printer pauses after every group count of labels has been printed. "+ 
			"Parameters Details "+ 
			"q = total quantity of "+ 
			"labels to print "+ 
			"Values: 1 to 99,999,999 "+ 
			"Default: 1 "+ 
			"p = pause and cut "+ 
			"value (labels "+ 
			"between pauses) "+ 
			"Values: 1 to 99,999,999 "+ 
			"Default: "+ 
			"0 (no pause) "+ 
			"r = replicates of "+ 
			"each serial "+ 
			"number "+ 
			"Values: 0 to 99,999,999 replicates "+ 
			"Default: "+ 
			": "+ 
			"0 (no replicates) "+ 
			"o = override pause "+ 
			"count "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: "+ 
			"N "+ 
			"e = cut on error "+ 
			"label (RFID void "+ 
			"is an error "+ 
			"label) "+ 
			"Values: "+ 
			"N = no - if a cutter is installed, a cut will be made after a voided RIFD label "+ 
			"ONLY if a cut would be made after the non-voided label and this was the last "+ 
			"retry. "+ 
			"Y = yes - if a cutter is installed, a cut will be made after ANY voided RFID label. "+ 
			"Default: Y "+ 
			"Example: This example shows the control over print operations: "+ 
			"^PQ50,10,1,Y: This example prints a total of 50 labels with one replicate of each serial number. It "+ 
			"prints the total quantity in groups of 10, but does not pause after every group. "+ 
			"^PQ50,10,1,N: This example prints a total of 50 labels with one replicate of each serial number. It "+ 
			"prints the total quantity in groups of 10, pausing after every group. "+ 
			" "+ 
			"297 "+ 
			"ZPL Commands "+ 
			"~PR "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
