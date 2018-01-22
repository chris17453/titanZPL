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
    public class zpl_cmd_t_HS : zpl_command{   //Host Status Return
                                        
        public zpl_cmd_t_HS(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="~HS";                   
            description="Host Status Return";                   
            data_format="";                   
            example    ="";                   
                                    
  /*************************************************  
                                       
  **************************************************/ 
            manual=""+ 
			"~HS – Host Status Return "+ 
			"When the host sends ~HS to the printer, the printer sends three data strings back. Each string starts "+ 
			"with an <STX> control code and is terminated by an <ETX><CR><LF> control code sequence. To "+ 
			"avoid confusion, the host prints each string on a separate line. "+ 
			"String 1 <STX>aaa,b,c,dddd,eee,f,g,h,iii,j,k,l<ETX><CR><LF> "+ 
			"The nine-digit binary number is read according to this table: "+ 
			"Note • When a ~HS command is sent the printer will not send a response to the host if the printer "+ 
			"is in one of these conditions: "+ 
			"• MEDIA OUT "+ 
			"• RIBBON OUT "+ 
			"• HEAD OPEN "+ 
			"• REWINDER FULL "+ 
			"• HEAD OVER-TEMPERATURE "+ 
			"aaa "+ 
			"= communication (interface) settings "+ 
			"a "+ 
			"b "+ 
			"= paper out flag (1 = paper out) "+ 
			"c "+ 
			"= pause flag (1 = pause active) "+ 
			"dddd "+ 
			"= label length (value in number of dots) "+ 
			"eee "+ 
			"= number of formats in receive buffer "+ 
			"f "+ 
			"= buffer full flag (1 = receive buffer full) "+ 
			"g "+ 
			"= communications diagnostic mode flag (1 = diagnostic mode active) "+ 
			"h "+ 
			"= partial format flag (1 = partial format in progress) "+ 
			"iii "+ 
			"= unused (always 000) "+ 
			"j "+ 
			"= corrupt RAM flag (1 = configuration data lost) "+ 
			"k "+ 
			"= temperature range (1 = under temperature) "+ 
			"l "+ 
			"= temperature range (1 = over temperature) "+ 
			"i. This string specifies the printer’s baud rate, number of data bits, number of stop bits, parity "+ 
			"setting, and type of handshaking. This value is a three-digit decimal representation of an eight- "+ 
			"bit binary number. To evaluate this parameter, first convert the decimal number to a binary "+ 
			"number. "+ 
			" "+ 
			"205 "+ 
			"ZPL Commands "+ 
			"~HS "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"String 2 <STX>mmm,n,o,p,q,r,s,t,uuuuuuuu,v,www<ETX><CR><LF> "+ 
			"The eight-digit binary number is read according to this table: "+ 
			"mmm "+ 
			"= function settings "+ 
			"j "+ 
			"n = unused "+ 
			"o = head up flag (1 "+ 
			"= head in up position) "+ 
			"p = ribbon out flag (1 = ribbon out) "+ 
			"q = thermal transfer mode flag (1 "+ 
			"= Thermal Transfer Mode selected) "+ 
			"r =Print Mode "+ 
			"Values 4 to 5 are only "+ 
			"supported in firmware "+ 
			"version V60.14.x, "+ 
			"V50.14.x, V53. 15.x, or "+ 
			"later. "+ 
			"0 = Rewind "+ 
			"1 = Peel-Off "+ 
			"2 = Tear -Off "+ 
			"3 = Cutter "+ 
			"4 = Applicator "+ 
			"5 = Delayed cut "+ 
			"6 = Linerless Peel "+ 
			"7 = Linerless Rewind "+ 
			"8 = Partial Cutter "+ 
			"9 = RFID "+ 
			"K = Kiosk "+ 
			"S = Stream "+ 
			"s = print width mode "+ 
			"t = label waiting flag (1 "+ 
			"= label waiting in Peel-off Mode) "+ 
			"uuuuuuuu = labels remaining in batch "+ 
			"v = format while printing flag (always 1) "+ 
			"www = number of graphic images stored in memory "+ 
			"j. This string specifies the printer’s media type, sensor profile status, and communication diagnostics "+ 
			"status. As in String 1, this is a three-digit decimal representation of an eight-bit binary number. First, "+ 
			"convert the decimal number to a binary number. "+ 
			"k. These values are only supported on the ZE500, Xi4, RXi4, ZM400/ZM600, and RZ400/RZ600 printers. "+ 
			"a a a a a = Baud "+ 
			"a "+ 
			"a "+ 
			"a "+ 
			"a "+ 
			"= Handshake "+ 
			"0 = Xon/Xoff "+ 
			"1 = DTR "+ 
			"0000=110 "+ 
			"0 001 = 300 "+ 
			"0 010 = 600 "+ 
			"0 011 = 1200 "+ 
			"0 100 = 2400 "+ 
			"0 101 = 4800 "+ 
			"0 110 = 9600 "+ 
			"0 111 = 19200 "+ 
			"1 000 = 28800 "+ 
			"1 001 = 38400 "+ 
			"1 010 = 57600 "+ 
			"1 011 = 14400 "+ 
			"(available only on certain printer models) "+ 
			"= Parity Odd/Even "+ 
			"0 = Odd "+ 
			"1 = Even "+ 
			"= Disable/Enable "+ 
			"0 = Disable "+ 
			"1 = Enable "+ 
			"=Stop Bits "+ 
			"0 = 2 Bits "+ 
			"1=1Bit "+ 
			"= Data Bits "+ 
			"0 = 7 Bits "+ 
			"1 = 8 Bits "+ 
			"78210 "+ 
			"6 "+ 
			"5 "+ 
			"4 "+ 
			"3 "+ 
			"aaa=aaaaaaaaa "+ 
			"876543210 "+ 
			"(available only on certain printer models) "+ 
			"(available only on certain printer models) "+ 
			" "+ 
			"ZPL Commands "+ 
			"~HS "+ 
			"206 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"String 3 <STX>xxxx,y<ETX><CR><LF> "+ 
			"xxxx = password "+ 
			"y = 0 (static RAM not installed) "+ 
			"1 (static RAM installed) "+ 
			"m7 "+ 
			"m6 "+ 
			"m5 "+ 
			"m4 m3 m2 m1 = Unused "+ 
			"m0 "+ 
			"= Media Type "+ 
			"0 = Die-Cut "+ 
			"1 = Continuous "+ 
			"= Sensor Profile "+ 
			"0=Off "+ 
			"= Communications Diagnostics "+ 
			"0=Off "+ 
			"1=On "+ 
			"0=Off "+ 
			"1=On "+ 
			"= Print Mode "+ 
			"0 = Direct Thermal "+ 
			"1 = Thermal Transfer "+ 
			"mmm=m7m6m5m4m3m2m1m0 "+ 
			" "+ 
			"207 "+ 
			"ZPL Commands "+ 
			"^HT "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
