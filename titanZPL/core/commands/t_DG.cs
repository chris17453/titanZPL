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
using System.Collections.Generic;using System.Text;

namespace titanZPL.commands  {
    
    public class zpl_cmd_t_DG : zpl_command{   //Download Graphics
        public string  drive                         = String.Empty;
        public string  file_name                     = String.Empty;
        public string  extension                     = String.Empty;
        public string  path                          = String.Empty;
        public int     total_bytes                   = 0;
        public int     bytes_per_row                 = 0;
        public byte[]  graphic_data                          = null;
                                        
        public zpl_cmd_t_DG(string data,List<zpl_command> commands):base(commands){                    
            cmd         ="~DG";                   
            description ="Download Graphics";                   
            data_format ="d:o.x,t,w,data ";                   
            example     ="";                   
            _internal.argument_max=4;
            drive                                                       =(string)argument(0,data,"drive","R:,E:,B:,A:"       ,"","R:");
            file_name                                                   =(string)argument(0,data,"file" ,"*"                 ,".","");
            extension                                                   =(string)argument(0,data,"ext"  ,".GRF"              ,".",".GRF");
            total_bytes                                                 =(   int)argument(1,data,"i"    ,"0-32000"           ,"","0");
            bytes_per_row                                               =(   int)argument(2,data,"i"    ,"0-32000"           ,"","0");
            string temp_data                                            =(string)argument(3,data,"s"    ,"*"                 ,"*","");
            path=drive+file_name+extension;
            if(total_bytes==temp_data.Length) { //its ascii
                graphic_data    =hex_to_bytes(temp_data);
            } else {
                zpl_RLE decoder =new zpl_RLE(temp_data,total_bytes,bytes_per_row);
                graphic_data    =hex_to_bytes(decoder.data);
            }
            //byte[] graphic=hex_to_bytes(zd.data);
                                    
  /*************************************************  
	
d =device_to_store_image //R:, E:, B:, and A:  //R: 
	
o =image_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
x =extension // //-
                                       
  **************************************************/ 
            manual=""+ 
			"~DG – Download Graphics "+ 
			"The ~DG command downloads an ASCII Hex representation of a graphic image. If .GRF is not the "+ 
			"specified file extension, .GRF is automatically appended. "+ 
			"For more saving and loading options when downloading files, see ~DY on page 156. "+ 
			"Format: ~DGd:o.x,t,w,data "+ 
			"This is the key for the examples that follow: "+ 
			"x = width of the graphic in millimeters "+ 
			"y "+ 
			"= height of the graphic in millimeters "+ 
			"z = dots/mm = print density of the printer being programmed "+ 
			"8 "+ 
			"= bits/byte "+ 
			"Parameters Details "+ 
			"d = device to store "+ 
			"image "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"o = image name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"x = extension "+ 
			"Format: .GRF "+ 
			"t = total number of "+ 
			"bytes in graphic "+ 
			"See the formula in the examples below. "+ 
			"w = number of bytes "+ 
			"per row "+ 
			"See the formula in the examples below. "+ 
			"data = ASCII "+ 
			"hexadecimal "+ 
			"string defining "+ 
			"image "+ 
			"The data string defines the image and is an ASCII hexadecimal representation of "+ 
			"the image. Each character represents a horizontal nibble of four dots. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~DG "+ 
			"150 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Examples: These are some example related to the ~DG command: "+ 
			"To determine the t parameter use this formula: "+ 
			"To determine the correct t parameter for a graphic 8 mm wide, 16 mm high, and a print density of 8 "+ 
			"dots/mm, use this formula: "+ 
			"Raise any portion of a byte to the next whole byte. "+ 
			"To determine the "+ 
			"w parameter (the width in terms of bytes per row) use this formula: "+ 
			"To determine the correct "+ 
			"w parameter for a graphic 8 mm wide and a print density of 8 dots/mm, use "+ 
			"this formula: "+ 
			"Raise any portion of a byte to the next whole byte. "+ 
			"Parameter "+ 
			"w is the first value in the t calculation. "+ 
			"The data parameter is a string of hexadecimal numbers sent as a representation of the graphic "+ 
			"image. Each hexadecimal character represents a horizontal nibble of four dots. For example, if the "+ 
			"first four dots of the graphic image are white and the next four black, the dot-by-dot binary code is "+ 
			"00001111. The hexadecimal representation of this binary value is 0F. The entire graphic image is "+ 
			"coded in this way, and the complete graphic image is sent as one continuous string of hexadecimal "+ 
			"values. "+ 
			"xz "+ 
			"8 "+ 
			"----- "+ 
			"yz totalbytes= "+ 
			"8 128 1024= "+ 
			"t 1024= "+ 
			"xz "+ 
			"8 "+ 
			"----- totalbytesrow= "+ 
			"w 8= "+ 
			"88 "+ 
			"8 "+ 
			"------------8bytes= "+ 
			"w 8= "+ 
			"This is an example of using the ~DG command to load a checkerboard pattern into DRAM. The name "+ 
			"used to store the graphic is SAMPLE.GRF: "+ 
			"~DGR:SAMPLE.GRF,00080,010, "+ 
			"FFFFFFFFFFFFFFFFFFFF "+ 
			"8000FFFF0000FFFF0001 "+ 
			"8000FFFF0000FFFF0001 "+ 
			"8000FFFF0000FFFF0001 "+ 
			"FFFF0000FFFF0000FFFF "+ 
			"FFFF0000FFFF0000FFFF "+ 
			"FFFF0000FFFF0000FFFF "+ 
			"FFFFFFFFFFFFFFFFFFFF "+ 
			"^XA "+ 
			"^FO20,20^XGR:SAMPLE.GRF,1,1^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			" "+ 
			"151 "+ 
			"ZPL Commands "+ 
			"~DG "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments Do not use spaces or periods when naming your graphics. Always use different "+ 
			"names for different graphics. "+ 
			"If two graphics with the same name are sent to the printer, the first graphic is erased and replaced by "+ 
			"the second graphic. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~DN "+ 
			"152 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function       
    }//end class                                  
}//end namespace                                  
