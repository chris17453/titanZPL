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
using System.Collections.Generic;using System.Drawing;

namespace titanZPL.commands  {
    public class zpl_cmd_c_GF : zpl_command{   //Graphic Field
        public string compression_type                                             = String.Empty;
        public    int binary_byte_count                                            = 0;
        public int    graphic_field_count                                          = 0;
        public int    bytes_per_row                                                = 0;
        public byte[] graphic_data                                                 = null;
                                                
        public zpl_cmd_c_GF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^GF";                   
            description="Graphic Field";                   
            data_format="a,b,c,d,data ";                   
            example    ="";                   
            compression_type                                            =(string)argument(0,data,"s"," A,C"     ,"","A");
            binary_byte_count                                           =(   int)argument(1,data,"i"  ,"1-99999","","0");
            graphic_field_count                                         =(   int)argument(2,data,"i"  ,"1-99999","","0");
            bytes_per_row                                               =(   int)argument(3,data,"i"  ,"1-99999","","0");
            graphic_data                                                =(byte[])argument(4,data,"b[]",""       ,""," ");
                                    
  /*************************************************  
	
a =compression_type //
A = ASCII hexadecimal (follows the format for other download commands) B = binary (data sent after the c parameter is strictly binary) C = compressed binary (data sent after the c parameter is in compressed binary format. The data is compressed on the host side using Zebra’s compression algorithm. The data is then decompressed and placed directly into the bitmap.)  //A 
	
b =binary_byte_count //1 to 99999 This is the total number of bytes to be transmitted for the total image or the total number of bytes that follow parameter d. For ASCII download, the parameter should match parameter c. Out-of-range values are set to the nearest limit.  //command is ignored if a value is not specified 
	
c =graphic_field_count //1 to 99999 This is the total number of bytes comprising the graphic format (width x height), which is sent as parameter d. Count divided by bytes per row gives the number of lines in the image. This number represents the size of the image, not necessarily the size of the data stream (see d).  //command is ignored if a value is not specified 
	
d =bytes_per_row //1 to 99999 This is the number of bytes in the downloaded data that comprise one row of the image.  //command is ignored if a value is not specified dat
	ta =data // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^GF – Graphic Field "+ 
			"The ^GF command allows you to download graphic field data directly into the printer’s bitmap "+ 
			"storage area. This command follows the conventions for any other field, meaning a field orientation "+ 
			"is included. The graphic field data can be placed at any location within the bitmap space. "+ 
			"Format: ^GFa,b,c,d,data "+ 
			"Parameters Details "+ 
			"a = compression type "+ 
			"Values: "+ 
			"A = ASCII hexadecimal (follows the format for other download "+ 
			"commands) "+ 
			"B = binary (data sent after the c parameter is strictly binary) "+ 
			"C = compressed binary (data sent after the c parameter is in "+ 
			"compressed binary format. The data is compressed on the host side "+ 
			"using Zebra’s compression algorithm. The data is then "+ 
			"decompressed and placed directly into the bitmap.) "+ 
			"Default: A "+ 
			"b = binary byte count "+ 
			"Values: 1 to 99999 "+ 
			"This is the total number of bytes to be transmitted for the total image or the total "+ 
			"number of bytes that follow parameter "+ 
			"d. For ASCII download, the parameter "+ 
			"should match parameter c. Out-of-range values are set to the nearest limit. "+ 
			"Default: command is ignored if a value is not specified "+ 
			"c = graphic field "+ 
			"count "+ 
			"Values: 1 to 99999 "+ 
			"This is the total number of bytes comprising the graphic format (width x height), "+ 
			"which is sent as parameter "+ 
			"d. Count divided by bytes per row gives the number "+ 
			"of lines in the image. This number represents the size of the image, not "+ 
			"necessarily the size of the data stream (see "+ 
			"d). "+ 
			"Default: command is ignored if a value is not specified "+ 
			"d = bytes per row "+ 
			"Values: 1 to 99999 "+ 
			"This is the number of bytes in the downloaded data that comprise one row of the "+ 
			"image. "+ 
			"Default: command is ignored if a value is not specified "+ 
			"data = data "+ 
			"Values: "+ 
			"ASCII hexadecimal data: "+ 
			"00 to FF "+ 
			"A string of ASCII hexadecimal numbers, two digits per image byte. CR and LF "+ 
			"can be inserted as needed for readability. The number of two-digit number pairs "+ 
			"must match the above count. Any numbers sent after count is satisfied are "+ 
			"ignored. A comma in the data pads the current line with 00 (white space), "+ 
			"minimizing the data sent. "+ 
			"~DN or any caret or tilde character prematurely aborts "+ 
			"the download. "+ 
			"Binary data: Strictly binary data is sent from the host. All control prefixes are "+ 
			"ignored until the total number of bytes needed for the graphic format is sent. "+ 
			"Example: This example downloads 8,000 total bytes of data and places the graphic data at location "+ 
			"100,100 of the bitmap. The data sent to the printer is in ASCII form. "+ 
			"^FO100,100^GFA,8000,8000,80,ASCII data "+ 
			" "+ 
			"189 "+ 
			"ZPL Commands "+ 
			"^GF "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Example: This example downloads 8,000 total bytes of data and places the graphic data at location "+ 
			"100,100 of the bitmap. The data sent to the printer is in binary form. "+ 
			"^FO100,100^GFB,8000,8000,80,Binary data "+ 
			" "+ 
			"ZPL Commands "+ 
			"^GS "+ 
			"190 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 ";                           
        }//end init function         
        
        public static byte[] hextobytes(String hex){
            hex=hex.Replace("\r","");
            hex=hex.Replace("\n","");
            hex=hex.Replace("\t","");
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                if(i+1<hex.Length) { 
                    try {
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                    } catch { }

                }
            return bytes;
        }
        
        public static byte[] Hex2Byte(String hex){
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars];
            for (int i = 0; i < NumberChars; i ++)
            bytes[i ] = Convert.ToByte(hex.Substring(i, 1), 16);
            return bytes;
        }

        public override void draw() {
            if(null==graphic_data) return;
            Bitmap graphic_image=draw_graphic(graphic_data,graphic_field_count,bytes_per_row);
            _internal.image=(Bitmap)graphic_image;
            _internal.baseline=graphic_image.Height;
            _internal.width =_internal.image.Width;
            _internal.height=_internal.image.Height;
        }//end function                     
    }//end class                                  
}//end namespace                                  
