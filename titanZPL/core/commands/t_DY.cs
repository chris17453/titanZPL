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
    public class zpl_cmd_t_DY : zpl_command{   //Download Objects
        public string file_location                                                = String.Empty;
        public string file_name                                                    = String.Empty;
        public string format_downloaded_in_data_field                              = String.Empty;
        public string extension_of_stored_file                                     = String.Empty;
        public string total_number_of_bytes_in_file                                = String.Empty;
        public    int w                                                            = 0;
        public string data                                                         = String.Empty;
                                        
        public zpl_cmd_t_DY(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~DY";                   
            description="Download Objects";                   
            data_format="d,f,b,x,t,w,data ";                   
            example    ="^XA"+
			            "^FO0,0^IMR:LOGO.PNG^FS"+
			            "^XZ";                   
            file_location                                               =(string)argument(0,data,"s","                   ",""," ");
            file_name                                                   =(string)argument(1,data,"s","                   ",""," ");
            format_downloaded_in_data_field                             =(string)argument(2,data,"s","                   ",""," ");
            extension_of_stored_file                                    =(string)argument(3,data,"s","                   ",""," ");
            total_number_of_bytes_in_file                               =(string)argument(4,data,"s","                   ",""," ");
            w                                                           =(   int)argument(5,data,"i","                   ",""," ");
            data                                                        =(string)argument(6,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
d =file_location //R:, E:, B:, and A:  //R: 
	
f =file_name //1 to 8 alphanumeric characters  //if a name is not specified, UNKNOWN is used 
	
b =format_downloaded_in_data_field //
A = uncompressed (ZB64, ASCII) B = uncompressed (.TTE, .TTF, binary) C = AR-compressed (used only by Zebra’s BAR-ONE ® v5) P = portable network graphic (.PNG) - ZB64 encoded  //a value must be specified 
	
x =extension_of_stored_file //
B = bitmap E = TrueType Extension (.TTE) G = raw bitmap (.GRF) P = store as compressed (.PNG) T = TrueType (.TTF) or OpenType (.OTF) X = Paintbrush (.PCX) NRD = Non Readable File (.NRD) PAC = Protected Access Credential (.PAC) C = User defined menu file (WML) F = User defined webpage file (HTM) H = Printer feedback file (GET)  //a value other than the accepted values defaults to .GRF  157 ZPL Commands ~DY 11/21/16 Zebra Programming Guide P1012728-011 
	
t =total_number_of_bytes_in_file // //-
                                       
  **************************************************/ 
            manual=""+ 
			"~DY – Download Objects "+ 
			"The ~DY command downloads to the printer graphic objects or fonts in any supported format. This "+ 
			"command can be used in place of ~DG for more saving and loading options. ~DY is the preferred "+ 
			"command to download TrueType fonts on printers with firmware later than X.13. It is faster than "+ 
			"~DU. "+ 
			"The "+ 
			"~DY command also supports downloading wireless certificate files. "+ 
			"Format: ~DYd:f,b,x,t,w,data "+ 
			"Note • When using certificate files, your printer supports: "+ 
			"• Using Privacy Enhanced Mail (PEM) formatted certificate files. "+ 
			"• Using the client certificate and private key as two files, each downloaded separately. "+ 
			"• Using exportable PAC files for EAP-FAST. "+ 
			"• Zebra recommends using Linear style memory devices for storing larger objects. "+ 
			"Parameters Details "+ 
			"d = file location "+ 
			".NRD "+ 
			"and .PAC files reside "+ 
			"on E: in firmware versions "+ 
			"V60.15.x, V50.15.x, or later. "+ 
			"Values: R:, E:, B:, and A: "+ 
			"Default: R: "+ 
			"f = file name "+ 
			"Values: 1 to 8 alphanumeric characters "+ 
			"Default: if a name is not specified, UNKNOWN is used "+ 
			"b = format downloaded "+ 
			"in data field "+ 
			".TTE "+ 
			"and .TTF are only "+ 
			"supported in firmware "+ 
			"versions V60.14.x, V50.14.x, "+ 
			"or later. "+ 
			"Values: "+ 
			"A = uncompressed (ZB64, ASCII) "+ 
			"B = uncompressed (.TTE, .TTF, binary) "+ 
			"C = AR-compressed (used only by Zebra’s BAR-ONE "+ 
			"® "+ 
			"v5) "+ 
			"P = portable network graphic (.PNG) - ZB64 encoded "+ 
			"Default: a value must be specified "+ 
			"x = extension of "+ 
			"stored file "+ 
			".TTE "+ 
			"and .OTF are only "+ 
			"supported in firmware "+ 
			"versions V60.14.x, V50.14.x, "+ 
			"or later. "+ 
			".NRD and .PAC are only "+ 
			"supported in firmware "+ 
			"versions V60.15.x, V50.15.x, "+ 
			"or later. "+ 
			"Values: "+ 
			"B = bitmap "+ 
			"E = TrueType Extension (.TTE) "+ 
			"G = raw bitmap (.GRF) "+ 
			"P = store as compressed (.PNG) "+ 
			"T = TrueType (.TTF) or OpenType (.OTF) "+ 
			"X = Paintbrush (.PCX) "+ 
			"NRD = Non Readable File (.NRD) "+ 
			"PAC = Protected Access Credential (.PAC) "+ 
			"C = User defined menu file (WML) "+ 
			"F = User defined webpage file (HTM) "+ 
			"H = Printer feedback file (GET) "+ 
			"Default: a value other than the accepted values defaults to .GRF "+ 
			" "+ 
			"157 "+ 
			"ZPL Commands "+ 
			"~DY "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"t = total number of "+ 
			"bytes in file "+ 
			".TTE is only supported in "+ 
			"firmware versions V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			"Values: "+ 
			".BMP "+ 
			"This parameter refers to the actual size of the file, not the amount of "+ 
			"disk space. "+ 
			".GRF images: the size after decompression into memory "+ 
			"This parameter refers to the actual size of the file, not the amount of "+ 
			"disk space. "+ 
			".PCX "+ 
			"This parameter refers to the actual size of the file, not the amount of "+ 
			"disk space. "+ 
			".PNG images: "+ 
			"This parameter refers to the actual size of the file, not the amount of "+ 
			"disk space. "+ 
			".TTF "+ 
			"This parameter refers to the actual size of the file, not the amount of "+ 
			"disk space. "+ 
			".TTE "+ 
			"This parameter refers to the actual size of the file, not the amount of "+ 
			"disk space. "+ 
			"w = total number of "+ 
			"bytes per row "+ 
			".TTE "+ 
			"is only supported in "+ 
			"firmware version V60.14.x, "+ 
			"V50.14.x, or later. "+ 
			".NRD and .PAC files are "+ 
			"supported in firmware "+ 
			"version V60.15.x, V50.15.x, "+ 
			"or later. "+ 
			"Values: "+ 
			".GRF images: number of bytes per row "+ 
			".PNG images: value ignored "+ 
			".TTF images: value ignored "+ 
			".TTE images: value ignored "+ 
			".NRD images: value ignored "+ 
			".PAC images: value ignored "+ 
			"data = data "+ 
			"ASCII hexadecimal encoding, ZB64, or binary data, depending on b. "+ 
			"A, P = ASCII hexadecimal or ZB64 "+ 
			"B, C = binary "+ 
			"When binary data is sent, all control prefixes and flow control characters are ignored "+ 
			"until the total number of bytes needed for the graphic format is received. "+ 
			"Parameters Details "+ 
			"Note • When transmitting fonts or graphics, the ~DY command and the binary content can be sent "+ 
			"as two separate data streams. In cases where the "+ 
			"~DY command and data content are sent "+ 
			"separately, the connection to the printer must be maintained until both the command and data "+ 
			"content have been sent. If the command and data content are sent separately, the data light on the "+ 
			"printer will remain lit until it receives all the data called for in the "+ 
			"~DY command. The download will "+ 
			"be considered complete when the number of bytes called out in the "+ 
			"~DY command have been "+ 
			"received. "+ 
			"For best results, graphic files must be monochrome (black and white) or dithered. "+ 
			" "+ 
			"ZPL Commands "+ 
			"~DY "+ 
			"158 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Comments For more information on ZB64 encoding and compression, see "+ 
			"ZB64 Encoding and Compression on page 1315. "+ 
			"Example: This is an example of how to download a binary TrueType Font file of Size bytes using "+ 
			"the name fontfile.ttf and storing it to permanent flash memory on the printer: "+ 
			"~DYE:FONTFILE.TTF,B,T,SIZE,, "+ 
			"Examples: These examples show: "+ 
			"• that when the ^IM command is used with the ^FO command, the ^IM command (see ^IM "+ 
			"on page 217) moves the "+ 
			"logo.png file from a storage area to the 0,0 position on the label. "+ 
			"This is the ZPL code: "+ 
			"^XA "+ 
			"^FO0,0^IMR:LOGO.PNG^FS "+ 
			"^XZ "+ 
			"• that when the ^IL command (see ^IL on page 216) is used at the beginning of a label format, it "+ 
			"loads a stored image (logo.png) of a format and merges it with additional data. It is "+ 
			"automatically positioned at the 0,0 position of the label and does not require the "+ 
			"^FO command. "+ 
			"This is the ZPL code: "+ 
			"^XA "+ 
			"^ILR:LOGO.PNG "+ 
			"^XZ "+ 
			"These are some important things to know about this command in firmware version "+ 
			"V60.14.x, V50.14.x, or later: "+ 
			"• ZebraNet Bridge can be used to download fonts and graphics with this command. "+ 
			"• OpenType tables are only supported when downloading the font with this "+ 
			"command "+ 
			"• OpenType fonts ( "+ 
			".OTF) are supported if they are downloaded as a TrueType font. In "+ 
			"the printer "+ 
			".OTF fonts have the .TTF extension. "+ 
			" "+ 
			"159 "+ 
			"ZPL Commands "+ 
			"~EG "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
