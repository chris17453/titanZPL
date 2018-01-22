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
using System.Collections.Generic;using System.Collections.Generic;
using System.Drawing;

namespace titanZPL.commands  {
    public class zpl_cmd_c_XG : zpl_command{   //Recall Graphic
        public string drive                         = String.Empty;
        public string file_name                     = String.Empty;
        public string extension                     = String.Empty;
        public string path                          = String.Empty;
        public int    mx                            = 0;
        public int    my                            = 0;
        public List<zpl_command> files              = null;
                                        
        public zpl_cmd_c_XG(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^XG";                   
            description="Recall Graphic";                   
            data_format="d:o.x,mx,my ";                   
            example    ="^XA"+
			            "^FO100,100^XGR:SAMPLE.GRF,1,1^FS"+
			            "^FO100,200^XGR:SAMPLE.GRF,2,2^FS"+
			            "^FO100,300^XGR:SAMPLE.GRF,3,3^FS"+
			            "^FO100,400^XGR:SAMPLE.GRF,4,4^FS"+
			            "^FO100,500^XGR:SAMPLE.GRF,5,5^FS"+
			            "^XZ";                   
            drive    =(string)argument(0,data,"drive"    ,"R:,E:,B:,A:","","R:");
            file_name=(string)argument(0,data,"file"     ,"*"          ,""," ");
            extension=(string)argument(0,data,"ext"      ,".GRF"       ,"",".GRF");
            mx       =(   int)argument(2,data,"i","1-10"       ,"","1");
            my       =(   int)argument(3,data,"i","1-10"       ,"","1");
            path=drive+file_name+extension;
  /*************************************************  
	
d =source_device_of_stored_image //R:, E:, B:, and A:  //search priority (R:, E:, B:, and A:) 
	
o =name_of_stored_image //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension_l_Fixed_Value //1 to 10  //1 m
	my =magnification_factor_on_the_y //1 to 10  //
                                       
  **************************************************/ 
            manual=""+ 
			"^XG – Recall Graphic "+ 
			"The ^XG command is used to recall one or more graphic images for printing. This command is used "+ 
			"in a label format to merge graphics, such as company logos and piece parts, with text data to form a "+ 
			"complete label. "+ 
			"An image can be recalled and resized as many times as needed in each format. Other images and "+ 
			"data might be added to the format. "+ 
			"Format: ^XGd:o.x,mx,my "+ 
			"Parameters Details "+ 
			"d = source device of "+ 
			"stored image "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: search priority (R:, E:, B:, and A:) "+ 
			"o = name of stored "+ 
			"image "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension l Fixed Value: .GRF "+ 
			"mx = magnification "+ 
			"factor on the x- "+ 
			"axis "+ 
			"Values: 1 to 10 "+ 
			"Default: 1 "+ 
			"my = magnification "+ 
			"factor on the y- "+ 
			"axis "+ 
			"Values: 1 to 10 "+ 
			"Default: 1 "+ 
			"Example: This is an example of using the ^XG command to recall the image SAMPLE.GRF from "+ 
			"DRAM and print it in five different sizes in five different locations on the same label: "+ 
			"^XA "+ 
			"^FO100,100^XGR:SAMPLE.GRF,1,1^FS "+ 
			"^FO100,200^XGR:SAMPLE.GRF,2,2^FS "+ 
			"^FO100,300^XGR:SAMPLE.GRF,3,3^FS "+ 
			"^FO100,400^XGR:SAMPLE.GRF,4,4^FS "+ 
			"^FO100,500^XGR:SAMPLE.GRF,5,5^FS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^XS "+ 
			"340 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function      
        public override void draw() {
            Bitmap graphic_image=null;

            foreach(zpl_command file in files) {
                switch(file.cmd) {
                    case "~DG": if(((zpl_cmd_t_DG)(file)).path==path)
                                    graphic_image =draw_graphic(((zpl_cmd_t_DG)(file)).graphic_data,
                                                                 ((zpl_cmd_t_DG)(file)).total_bytes,
                                                                 ((zpl_cmd_t_DG)(file)).bytes_per_row);  break;
                }
            }//end file loop
            if(null!=graphic_image) {
                _internal.image    =(Bitmap)graphic_image;
                _internal.baseline =graphic_image.Height;
                _internal.width    =graphic_image.Width;
                _internal.height   =graphic_image.Height;
            }
        }//end function                                     
    }//end class                                  
}//end namespace                                  
