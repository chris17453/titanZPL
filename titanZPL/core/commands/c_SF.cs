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
    public class zpl_cmd_c_SF : zpl_command{   //Serialization Field (with a Standard ^FD String)
        public string mask_string                                                  = String.Empty;
        public string b                                                            = String.Empty;
                                        
        public zpl_cmd_c_SF(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^SF";                   
            description="Serialization Field (with a Standard ^FD String)";                   
            data_format="a,b ";                   
            example    ="";                   
            mask_string                                                 =(string)argument(0,data,"s","                   ",""," ");
            b                                                           =(string)argument(1,data,"s","                   ",""," ");
                                    
  /*************************************************  
	
a =mask_string // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^SF – Serialization Field (with a Standard ^FD String) "+ 
			"The ^SF command allows you to serialize a standard ^FD string. The maximum size of the mask "+ 
			"and increment string is 3K combined. "+ 
			"Format: ^SFa,b "+ 
			"For characters that do not get incremented, the "+ 
			"% character needs to be added to the increment "+ 
			"string. "+ 
			"In firmware version x.14 and later, strings are serialized from the last character in the "+ 
			"backing store with regard to the alignment of the mask and increment strings. For "+ 
			"combining semantic clusters that do not get incremented, the mask character % needs to be "+ 
			"added to the increment string. "+ 
			"Parameters Details "+ 
			"a = mask string "+ 
			"The mask string sets the serialization scheme. The length of the string mask defines "+ 
			"the number of characters (or in firmware version x.14 and later, combining semantic "+ 
			"clusters) in the current "+ 
			"^FD string to be serialized. The mask is aligned to the "+ 
			"characters (or in firmware version x.14 and later, combining semantic clusters) in "+ 
			"the ^FD string starting with the right-most (or in firmware x.14 and later, last) in the "+ 
			"backing store position. "+ 
			"Mask String placeholders: "+ 
			"D or d – Decimal numeric 0–9 "+ 
			"H or h – Hexadecimal 0–9 plus a-f or A-F "+ 
			"O or o – Octal 0–7 "+ 
			"A or a – Alphabetic A–Z or a–z "+ 
			"N or n – Alphanumeric 0–9 plus A–Z or a–z "+ 
			"% – Ignore character or skip "+ 
			"b = increment string "+ 
			"The increment string is the value to be added to the field on each label. The default "+ 
			"value is equivalent to a decimal value of one. The string is composed of any "+ 
			"characters (or in firmware version x.14 and later, combining semantic clusters) "+ 
			"defined in the serial string. Invalid characters (or in firmware version x.14 and later, "+ 
			"combining semantic clusters) are assumed to be equal to a value of zero in that "+ 
			"characters (or in firmware version x.14 and later, combining semantic clusters) "+ 
			"position. "+ 
			"The increment value for alphabetic strings start with ‘ "+ 
			"A’ or ‘a’ as the zero "+ 
			"placeholder. This means to increment an alphabetic character (or in firmware "+ 
			"version x.14 and later, combining semantic cluster) by one, a value of ‘ "+ 
			"B’ or ‘b’ must "+ 
			"be in the increment string. "+ 
			" "+ 
			"307 "+ 
			"ZPL Commands "+ 
			"^SF "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"This mask has the first characters (or in firmware version x.14 and later, the first combining semantic "+ 
			"clusters) as alphanumeric (nn = 12) and the last digit as uppercase alphabetic (A). The decimal "+ 
			"value of the increment number is equivalent to 5 (F). The number of labels generated depends on "+ 
			"the number specified by the "+ 
			"^PQ command. "+ 
			"In a similar instance, the "+ 
			"^FD string could be replaced with either of the ^FD strings below to "+ 
			"generate a series of label, determined by ^PQ. "+ 
			"Using this ZPL code: "+ 
			"^FDBL0000^SFAAdddd,1 "+ 
			"The print sequence on this series of labels is: "+ 
			"BL0000, BL0001,...BL0009, BL0010,... "+ 
			"BL0099, BL0100,...BL9999, BM0000... "+ 
			"Using this ZPL code: "+ 
			"^FDBL00-0^SFAAdd%d,1%1 "+ 
			"The print sequence on this series of labels is: "+ 
			"BL00-0, BL01-1, BL02-2,...BL09-9, "+ 
			"BL11-0, BL12-1... "+ 
			"The following examples show the importance of capitalization and location within the mask. "+ 
			"Example 1: This is an example of serializing a ^FD string. The ZPL II code generates three "+ 
			"separate labels as seen in Generated Labels: "+ 
			"Important notes about masking for firmware version V60.14.x, V50.14.x, or later: "+ 
			"• A single % masks an entire combining semantic cluster rather than a single code "+ 
			"point. "+ 
			"• The mask string and increment string should be aligned at the last code point in "+ 
			"their respective backing stores. "+ 
			"• Control and bidirectional characters do not require a mask and are ignored for "+ 
			"serialization purposes. "+ 
			"^XA "+ 
			"^FO100,100 "+ 
			"^CF0,100 "+ 
			"^FD12A^SFnnA,F^FS "+ 
			"^PQ3 "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABELS "+ 
			" "+ 
			"ZPL Commands "+ 
			"^SF "+ 
			"308 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			"Example 2: In this example, the printer cycles with every two printed labels and alternates "+ 
			"between H (position 18), and then Z (position 36). With n or N, the serial number increments "+ 
			"from 0 - 9 and a–z or A–Z (36 positions overall). With each completed cycle, the second "+ 
			"cluster (nn) increments one position (from 00, 01, 02 …) per cycle: "+ 
			"Example 3: In this example, lower case i increments with a mask string of nnN. Nothing "+ 
			"changes because the first cluster (Z) never triggers the second cluster (zz) to change. "+ 
			"GENERATED LABELS "+ 
			"ZPL II CODE "+ 
			"^XA "+ 
			"^FO100,50^A0N,50,50^FDzzZ^SFnnN,I^FS "+ 
			"^PQ10 "+ 
			"^XZ "+ 
			"GENERATED LABELS "+ 
			"ZPL II CODE "+ 
			"^XA "+ 
			"^FO100,50^A0N,50,50^FDzzZ^SFnnN,i^FS "+ 
			"^PQ10 "+ 
			"^XZ "+ 
			" "+ 
			"309 "+ 
			"ZPL Commands "+ 
			"^SI "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
