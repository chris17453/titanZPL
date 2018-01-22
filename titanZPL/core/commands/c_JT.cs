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
    public class zpl_cmd_c_JT : zpl_command{   //Head Test Interval
        public    int number                                                       = 0;
        public string elements_to_test                                             = String.Empty;
        public string b                                                            = String.Empty;
        public string c                                                            = String.Empty;
                                        
        public zpl_cmd_c_JT(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^JT";                   
            description="Head Test Interval";                   
            data_format="####,a,b,c ";                   
            example    ="";                   
            number                                                      =(   int)argument(0,data,"i","                   ",""," ");
            elements_to_test                                            =(string)argument(1,data,"s","                   ",""," ");
            b                                                           =(string)argument(2,data,"s","                   ",""," ");
            c                                                           =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	## =four //0000 to 9999 If a value greater than 9999 is entered, it is ignored.  //
0000 (off) 
	
a =manually_select_range_of_elements_to_test // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^JT – Head Test Interval "+ 
			"The ^JT command allows you to change the printhead test interval from every 100 labels to any "+ 
			"desired interval. With the ^JT command, the printer is allowed to run the test after printing a label. "+ 
			"When a parameter is defined, the printer runs the test after printing a set amount of labels. "+ 
			"The printer’s default head test state is off. Parameters for running the printhead test are defined by "+ 
			"the user. "+ 
			"Format: ^JT####,a,b,c "+ 
			"Comments The ^JT command supports testing a range of print elements. The printer "+ 
			"automatically selects the test range by tracking which elements have been used since the "+ 
			"previous test. "+ 
			"^JT also turns on Automatic Mode to specify the first and last elements for the head test. This "+ 
			"makes it possible to select any specific area of the label or the entire print width. "+ 
			"If the last element selected is greater than the print width selected, the test stops at the selected print "+ 
			"width. "+ 
			"Whenever the head test command is received, a head test is performed on the next label unless the "+ 
			"count is set to 0 (zero). "+ 
			"Parameters Details "+ 
			"#### = four-digit "+ 
			"number of labels "+ 
			"printed between "+ 
			"head tests "+ 
			"Values: 0000 to 9999 "+ 
			"If a value greater than 9999 is entered, it is ignored. "+ 
			"Default: "+ 
			"0000 (off) "+ 
			"a = manually select "+ 
			"range of "+ 
			"elements to test "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Initial Value at Power Up: N "+ 
			"b = first element to "+ 
			"check when "+ 
			"parameter a is Y "+ 
			"Values: 0 to 9999 "+ 
			"Initial Value at Power Up: 0 "+ 
			"c = last element to "+ 
			"check when "+ 
			"parameter a is Y "+ 
			"Values: 0 to 9999 "+ 
			"Initial Value at Power Up: 9999 "+ 
			" "+ 
			"ZPL Commands "+ 
			"^JU "+ 
			"246 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
