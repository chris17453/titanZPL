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
    public class zpl_cmd_c_FB : zpl_command{   //Field Block
        public    int width_of_text_block_line                                     = 0;
        public    int maximum_number_of_lines                                      = 0;
        public    int add_or_delete_space_between_lines                            = 0;
        public string text_justification                                           = String.Empty;
        public    int hanging_indent                                               = 0;
                                        
        public zpl_cmd_c_FB(string data,List<zpl_command> commands):base(commands){                    
            cmd        ="^FB";                   
            description="Field Block";                   
            data_format="a,b,c,d,e ";                   
            example    ="^XA"+
			            "^CF0,30,30^FO25,50"+
			            "^FB250,4,,"+
			            "^FDFD command that IS\\&"+
			            "preceded by an FB \\&command."+
			            "^FS"+
			            "^XZ";                   
            _internal.argument_max=5;
            width_of_text_block_line                                    =(   int)argument(0,data,"i","0-32000"     ,"","800");
            maximum_number_of_lines                                     =(   int)argument(1,data,"i","1-9999"      ,"","1");
            add_or_delete_space_between_lines                           =(   int)argument(2,data,"i","-9999-9999"  ,"","0");
            text_justification                                          =(string)argument(3,data,"s","L,C,R,J"     ,"" ,"L");
            hanging_indent                                              =(   int)argument(4,data,"i","0-9999"      ,"","0");
                                    
  /*************************************************  
	
a =width_of_text_block_line //0 to the width of the label  //0 If the value is less than font width or not specified, text does not print. 
	
b =maximum_number_of_lines_in_text_block //1 to 9999  //1 Text exceeding the maximum number of lines overwrites the last line. Changing the font size automatically increases or decreases the size of the block. 
	
c =add_or_delete_space_between_lines //-9999 to 9999  //0 Numbers are considered to be positive unless preceded by a minus sign. Positive values add space; negative values delete space. 
	
d =text_justification //
L = left C = center R = right J = justified  //L If J is used the last line is left-justified. 
	
e =hanging_indent //0 to 9999  //0  161 ZPL Commands ^FB 11/21/16 Zebra Programming Guide P1012728-011 Comments This scheme can be used to facilitate special functions: \\
	\& =carriage_return/line_feed // //-
                                       
  **************************************************/ 
            manual=""+ 
			"^FB – Field Block "+ 
			"The ^FB command allows you to print text into a defined block type format. This command formats "+ 
			"an ^FD or ^SN string into a block of text using the origin, font, and rotation specified for the text "+ 
			"string. The "+ 
			"^FB command also contains an automatic word-wrap function. "+ 
			"Format: ^FBa,b,c,d,e "+ 
			"Parameters Details "+ 
			"a = width of text "+ 
			"block line (in "+ 
			"dots) "+ 
			"Values: 0 to the width of the label "+ 
			"Default: 0 "+ 
			"If the value is less than font width or not specified, text does not print. "+ 
			"b = maximum number of "+ 
			"lines in text "+ 
			"block "+ 
			"Values: 1 to 9999 "+ 
			"Default: 1 "+ 
			"Text exceeding the maximum number of lines overwrites the last line. Changing "+ 
			"the font size automatically increases or decreases the size of the block. "+ 
			"c = add or delete "+ 
			"space between "+ 
			"lines (in dots) "+ 
			"Values: -9999 to 9999 "+ 
			"Default: 0 "+ 
			"Numbers are considered to be positive unless preceded by a minus sign. "+ 
			"Positive values add space; negative values delete space. "+ 
			"d = text "+ 
			"justification "+ 
			"Values: "+ 
			"L = left "+ 
			"C = center "+ 
			"R = right "+ 
			"J = justified "+ 
			"Default: L "+ 
			"If J is used the last line is left-justified. "+ 
			"e = hanging indent "+ 
			"(in dots) of the "+ 
			"second and "+ 
			"remaining lines "+ 
			"Values: 0 to 9999 "+ 
			"Default: 0 "+ 
			" "+ 
			"161 "+ 
			"ZPL Commands "+ 
			"^FB "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 "+ 
			"Comments "+ 
			"This scheme can be used to facilitate special functions: "+ 
			"\\& = carriage return/line feed "+ 
			"\\(*) = soft hyphen (word break with a dash) "+ 
			"\\\\ = backslash (\\) "+ 
			"Item 1: ^CI13 must be selected to print a backslash (\\). "+ 
			"Item 2: If a soft hyphen escape sequence is placed near the end of a line, the hyphen is printed. If it "+ 
			"is not placed near the end of the line, it is ignored. "+ 
			"(*) = any alphanumeric character "+ 
			"• If a word is too long to print on one line by itself (and no soft hyphen is specified), a hyphen is "+ 
			"automatically placed in the word at the right edge of the block. The remainder of the word is on "+ 
			"the next line. The position of the hyphen depends on word length, not a syllable boundary. Use "+ 
			"a soft hyphen within a word to control where the hyphenation occurs. "+ 
			"• Maximum data-string length is 3K, including control characters, carriage returns, and line feeds. "+ 
			"• Normal carriage returns, line feeds, and word spaces at line breaks are discarded. "+ 
			"• When using ^FT (Field Typeset), ^FT uses the baseline origin of the last possible line of text. "+ 
			"Increasing the font size causes the text block to increase in size from bottom to top. This could "+ 
			"cause a label to print past its top margin. "+ 
			"• When using "+ 
			"^FO (Field Origin), increasing the font size causes the text block to increase in size "+ 
			"from top to bottom. "+ 
			"• ^FS terminates an ^FB command. Each block requires its own ^FB command. "+ 
			"Example: These are examples of how the "+ 
			"^FB command affects field data. "+ 
			"While the "+ 
			"^FB command has a text justification parameter that defines the justification of the text "+ 
			"within the block, it also interacts with the justification of ^FO and ^FT that define the justification of "+ 
			"the origin. "+ 
			"The "+ 
			"^FB command does not support soft hyphens as a potential line break point. However, soft "+ 
			"hyphen characters are always printed as if they were a hyphen. "+ 
			"The "+ 
			"^FB command does not support complex text. For complex text support, use ^TB. "+ 
			"^XA "+ 
			"^CF0,30,30^FO25,50 "+ 
			"^FB250,4,, "+ 
			"^FDFD command that IS\\& "+ 
			"preceded by an FB \\&command. "+ 
			"^FS "+ 
			"^XZ "+ 
			"ZPL II CODE "+ 
			"GENERATED LABEL "+ 
			"^XA "+ 
			"^CF0,30,30^FO25,50 "+ 
			"^FDFD command that IS NOT "+ 
			"preceded by an FB command.^FS "+ 
			"^XZ "+ 
			" "+ 
			"ZPL Commands "+ 
			"^FB "+ 
			"162 "+ 
			"P1012728-011 Zebra Programming Guide 11/21/16 "+ 
			" "+ 
			"163 "+ 
			"ZPL Commands "+ 
			"^FC "+ 
			"11/21/16 Zebra Programming Guide P1012728-011 ";                           
        }//end init function                      
    }//end class                                  
}//end namespace                                  
