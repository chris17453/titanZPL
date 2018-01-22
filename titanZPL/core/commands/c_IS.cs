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
    public class zpl_cmd_c_IS : zpl_command{   //Image Save
        public string location_of_stored_object                                    = String.Empty;
        public string object_name                                                  = String.Empty;
        public string extension                                                    = String.Empty;
        public string print_image_after_storing                                    = String.Empty;
                                        
        public zpl_cmd_c_IS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^IS";                   
            description="Image Save";                   
            data_format="d,o,x,p ";                   
            example    ="^XA"+
			            "^LH10,15^FWN^BY3,3,85^CFD,36"+
			            "^GB430,750,4^FS"+
			            "^FO10,170^GB200,144,2^FS"+
			            "^FO10,318^GB410,174,2^FS"+
			            "^FO212,170^GB206,144,2^FS"+
			            "^FO10,498^GB200,120,2^FSR"+
			            "^FO212,498^GB209,120,2^FS"+
			            "^FO4,150^GB422,10,10^FS"+
			            "^FO135,20^A0,70,60"+
			            "^FDZEBRA^FS"+
			            "^FO80,100^A0,40,30"+
			            "^FDTECHNOLOGIES CORP^FS"+
			            "^FO15,180"+
			            "^FDARTICLE#^FS"+
			            "^FO218,180"+
			            "^FDLOCATION^FS"+
			            "^FO15,328"+
			            "^FDDESCRIPTION^FS"+
			            "^FO15,508"+
			            "^FDREQ.NO.^FS"+
			            "^FO220,508"+
			            "^FDWORK NUMBER^FS"+
			            "^FO15,630^AD,36,20"+
			            "^FDCOMMENTS:^FS"+
			            "^ISR:SAMPLE2.GRF,Y"+
			            "^XZ";                   
            location_of_stored_object                                   =(string)argument(0,data,"s","                   ",""," ");
            object_name                                                 =(string)argument(1,data,"s","                   ",""," ");
            extension                                                   =(string)argument(2,data,"s","                   ",""," ");
            print_image_after_storing                                   =(string)argument(3,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =location_of_stored_object //R:, E:, B:, and A:  //R: 
	
o =object_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension //.GRF or .PNG  //.GRF 
	
p =print_image_after_storing //
N = no Y = yes  //Y  219 ZPL Commands ^IS 11/21/16 Zebra Programming Guide P1012728-01
                                       
  **************************************************/ 
            manual=""+ 
			"^IS – Image Save "+ 
			"The ^IS command is used within a label format to save that format as a graphic image, rather than "+ 
			"as a ZPL II script. It is typically used toward the end of a script. The saved image can later be "+ 
			"recalled with virtually no formatting time and overlaid with variable data to form a complete label. "+ 
			"Using this technique to overlay the image of constant information with the variable data greatly "+ 
			"increases the throughput of the label format. "+ 
			"\\ "+ 
			"Format: ^ISd:o.x,p "+ 
			"Important • See ^IL on page 216. "+ 
			"Parameters Details "+ 
			"d = location of "+ 
			"stored object "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = object name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Values: .GRF or .PNG "+ 
			"Default: .GRF "+ 
			"p = print image after "+ 
			"storing "+ 
			"Values: "+ 
			"N = no "+ 
			"Y = yes "+ 
			"Default: Y "+ 
			" "+ 
			"219 "+ 
			"ZPL Commands "+ 
			"^IS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example: This is an example of using the ^IS command to save a label format to DRAM. The "+ 
			"name used to store the graphic is SAMPLE2.GRF. "+ 
			"^XA "+ 
			"^LH10,15^FWN^BY3,3,85^CFD,36 "+ 
			"^GB430,750,4^FS "+ 
			"^FO10,170^GB200,144,2^FS "+ 
			"^FO10,318^GB410,174,2^FS "+ 
			"^FO212,170^GB206,144,2^FS "+ 
			"^FO10,498^GB200,120,2^FSR "+ 
			"^FO212,498^GB209,120,2^FS "+ 
			"^FO4,150^GB422,10,10^FS "+ 
			"^FO135,20^A0,70,60 "+ 
			"^FDZEBRA^FS "+ 
			"^FO80,100^A0,40,30 "+ 
			"^FDTECHNOLOGIES CORP^FS "+ 
			"^FO15,180 "+ 
			"^FDARTICLE#^FS "+ 
			"^FO218,180 "+ 
			"^FDLOCATION^FS "+ 
			"^FO15,328 "+ 
			"^FDDESCRIPTION^FS "+ 
			"^FO15,508 "+ 
			"^FDREQ.NO.^FS "+ 
			"^FO220,508 "+ 
			"^FDWORK NUMBER^FS "+ 
			"^FO15,630^AD,36,20 "+ 
			"^FDCOMMENTS:^FS "+ 
			"^ISR:SAMPLE2.GRF,Y "+ 
			"^XZ "+ 
			"^CFD,18,10^FS "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"ZPL Commands "+ 
			"~JA "+ 
			"220 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
