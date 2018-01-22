using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytescout.BarCode;

namespace titanZPL.commands {

    

    public class zpl_command {
        public string       example     = String.Empty;
		public string       cmd         = String.Empty;
		public string       data        = String.Empty;
        public string       data_format = String.Empty;
        public string       description = String.Empty;
		public string       manual      = String.Empty;
		public zpl_internal _internal   = new zpl_internal();
        public Brush        brush       =Brushes.Black;
        public Pen          pen         =Pens.Black;
        public const string bytescout_registrationName = "";
        public const string bytescout_registrationKey  = "";
        public List<zpl_command> commands              =null;
        public int               command_index         =-1;

        public zpl_command() {
        }
        
        public zpl_command(List<zpl_command> commands) {
            this.commands=commands;
            command_index=commands.Count()-1;
        }

        public zpl_command find_in_field(string cmd,bool return_nothing=false) {
            for(int pos=command_index;pos>=0;pos--) {
                if(commands[pos].cmd=="^FS" ) {             //we left the field and have nothing.
                    break;
                }
                if(commands[pos].cmd==cmd) {                //we found it
                    return commands[pos];
                }
            }
            if(return_nothing) return null;
            return new_cmd(cmd,"");
        }

        public zpl_command find_last(string cmd,bool return_nothing=false) {
            for(int pos=command_index;pos>=0;pos--) {
                if(commands[pos].cmd==cmd) {                //we found it
                    return commands[pos];
                }
            }
            if(return_nothing) return null;
            return new_cmd(cmd,"");
        }

        private zpl_command new_cmd(string cmd,string data) {
            switch (cmd) {
                case "^A" : return new zpl_cmd_c_A (data,commands); ; // Scalable/Bitmapped Font
                case "^A@": return new zpl_cmd_c_A2(data,commands); ; // Use Font Name to Call Font (Only command with a symbol in the name)
                case "^B0": return new zpl_cmd_c_B0(data,commands); ; // Aztec Bar Code Parameters
                case "^B1": return new zpl_cmd_c_B1(data,commands); ; // Code 11 Bar Code
                case "^B2": return new zpl_cmd_c_B2(data,commands); ; // Interleaved 2 of 5 Bar Code
                case "^B3": return new zpl_cmd_c_B3(data,commands); ; // Code 39 Bar Code
                case "^B4": return new zpl_cmd_c_B4(data,commands); ; // Code 49 Bar Code
                case "^B5": return new zpl_cmd_c_B5(data,commands); ; // Planet Code bar code
                case "^B7": return new zpl_cmd_c_B7(data,commands); ; // PDF417 Bar Code
                case "^B8": return new zpl_cmd_c_B8(data,commands); ; // EAN-8 Bar Code
                case "^B9": return new zpl_cmd_c_B9(data,commands); ; // UPC-E Bar Code
                case "^BA": return new zpl_cmd_c_BA(data,commands); ; // Code 93 Bar Code
                case "^BB": return new zpl_cmd_c_BB(data,commands); ; // CODABLOCK Bar Code
                case "^BC": return new zpl_cmd_c_BC(data,commands); ; // Code 128 Bar Code (Subsets A, B, and C)
                case "^BD": return new zpl_cmd_c_BD(data,commands); ; // UPS MaxiCode Bar Code
                case "^BE": return new zpl_cmd_c_BE(data,commands); ; // EAN-13 Bar Code
                case "^BF": return new zpl_cmd_c_BF(data,commands); ; // MicroPDF417 Bar Code
                case "^BI": return new zpl_cmd_c_BI(data,commands); ; // Industrial 2 of 5 Bar Codes
                case "^BJ": return new zpl_cmd_c_BJ(data,commands); ; // Standard 2 of 5 Bar Code
                case "^BK": return new zpl_cmd_c_BK(data,commands); ; // ANSI Codabar Bar Code
                case "^BL": return new zpl_cmd_c_BL(data,commands); ; // LOGMARS Bar Code
                case "^BM": return new zpl_cmd_c_BM(data,commands); ; // MSI Bar Code
                case "^BO": return new zpl_cmd_c_BO(data,commands); ; // Aztec Bar Code Parameters
                case "^BP": return new zpl_cmd_c_BP(data,commands); ; // Plessey Bar Code
                case "^BQ": return new zpl_cmd_c_BQ(data,commands); ; // QR Code Bar Code
                case "^BR": return new zpl_cmd_c_BR(data,commands); ; // GS1 Databar
                case "^BS": return new zpl_cmd_c_BS(data,commands); ; // UPC/EAN Extensions
                case "^BT": return new zpl_cmd_c_BT(data,commands); ; // TLC39 Bar Code
                case "^BU": return new zpl_cmd_c_BU(data,commands); ; // UPC-A Bar Code
                case "^BX": return new zpl_cmd_c_BX(data,commands); ; // Data Matrix Bar Code
                case "^BY": return new zpl_cmd_c_BY(data,commands); ; // Bar Code Field Default
                case "^BZ": return new zpl_cmd_c_BZ(data,commands); ; // POSTAL Bar Code
                case "^CC": return new zpl_cmd_c_CC(data,commands); ; // t_CC Change Caret
                case "^CD": return new zpl_cmd_c_CD(data,commands); ; // t_CD Change Delimiter
                case "^CF": return new zpl_cmd_c_CF(data,commands); ; // Change Alphanumeric Default Font
                case "^CI": return new zpl_cmd_c_CI(data,commands); ; // Change International Font/Encoding
                case "^CM": return new zpl_cmd_c_CM(data,commands); ; // Change Memory Letter Designation
                case "^CN": return new zpl_cmd_c_CN(data,commands); ; // Cut Now
                case "^CO": return new zpl_cmd_c_CO(data,commands); ; // Cache On
                case "^CP": return new zpl_cmd_c_CP(data,commands); ; // Remove Label
                case "^CT": return new zpl_cmd_c_CT(data,commands); ; // t_CT Change Tilde
                case "^CV": return new zpl_cmd_c_CV(data,commands); ; // Code Validation
                case "^CW": return new zpl_cmd_c_CW(data,commands); ; // Font Identifier
                case "~DB": return new zpl_cmd_t_DB(data,commands); ; // Download Bitmap Font
                case "~DE": return new zpl_cmd_t_DE(data,commands); ; // Download Encoding
                case "^DF": return new zpl_cmd_c_DF(data,commands); ; // Download Format
                case "~DG": return new zpl_cmd_t_DG(data,commands); ; // Download Graphics
                case "~DN": return new zpl_cmd_t_DN(data,commands); ; // Abort Download Graphic
                case "~DS": return new zpl_cmd_t_DS(data,commands); ; // Download Intellifont (Scalable Font)
                case "~DT": return new zpl_cmd_t_DT(data,commands); ; // Download Bounded TrueType Font
                case "~DU": return new zpl_cmd_t_DU(data,commands); ; // Download Unbounded TrueType Font
                case "~DY": return new zpl_cmd_t_DY(data,commands); ; // Download Objects
                case "~EG": return new zpl_cmd_t_EG(data,commands); ; // Erase Download Graphics
                case "^FB": return new zpl_cmd_c_FB(data,commands); ; // Field Block
                case "^FC": return new zpl_cmd_c_FC(data,commands); ; // Field Clock
                case "^FD": return new zpl_cmd_c_FD(data,commands); ; // Field Data
                case "^FH": return new zpl_cmd_c_FH(data,commands); ; // Field Hexadecimal Indicator
                case "^FL": return new zpl_cmd_c_FL(data,commands); ; // Font Linking
                case "^FM": return new zpl_cmd_c_FM(data,commands); ; // Multiple Field Origin Locations
                case "^FN": return new zpl_cmd_c_FN(data,commands); ; // Field Number
                case "^FO": return new zpl_cmd_c_FO(data,commands); ; // Field Origin
                case "^FP": return new zpl_cmd_c_FP(data,commands); ; // Field Parameter
                case "^FR": return new zpl_cmd_c_FR(data,commands); ; // Field Reverse Print
                case "^FS": return new zpl_cmd_c_FS(data,commands); ; // Field Separator
                case "^FT": return new zpl_cmd_c_FT(data,commands); ; // Field Typeset
                case "^FV": return new zpl_cmd_c_FV(data,commands); ; // Field Variable
                case "^FW": return new zpl_cmd_c_FW(data,commands); ; // Field Orientation
                case "^FX": return new zpl_cmd_c_FX(data,commands); ; // Comment
                case "^GB": return new zpl_cmd_c_GB(data,commands); ; // Graphic Box
                case "^GC": return new zpl_cmd_c_GC(data,commands); ; // Graphic Circle
                case "^GD": return new zpl_cmd_c_GD(data,commands); ; // Graphic Diagonal Line
                case "^GE": return new zpl_cmd_c_GE(data,commands); ; // Graphic Ellipse
                case "^GF": return new zpl_cmd_c_GF(data,commands); ; // Graphic Field
                case "^GS": return new zpl_cmd_c_GS(data,commands); ; // Graphic Symbol
                case "~HB": return new zpl_cmd_t_HB(data,commands); ; // Battery Status
                case "~HD": return new zpl_cmd_t_HD(data,commands); ; // Head Diagnostic
                case "^HF": return new zpl_cmd_c_HF(data,commands); ; // Host Format
                case "^HG": return new zpl_cmd_c_HG(data,commands); ; // Host Graphic
                case "^HH": return new zpl_cmd_c_HH(data,commands); ; // Configuration Label Return
                case "~HI": return new zpl_cmd_t_HI(data,commands); ; // Host Identification
                case "~HM": return new zpl_cmd_t_HM(data,commands); ; // Host RAM Status
                case "~HQ": return new zpl_cmd_t_HQ(data,commands); ; // Host Query
                case "~HS": return new zpl_cmd_t_HS(data,commands); ; // Host Status Return
                case "^HT": return new zpl_cmd_c_HT(data,commands); ; // Host Linked Fonts List
                case "~HU": return new zpl_cmd_t_HU(data,commands); ; // Return ZebraNet Alert Configuration
                case "^HV": return new zpl_cmd_c_HV(data,commands); ; // Host Verification
                case "^HW": return new zpl_cmd_c_HW(data,commands); ; // Host Directory List
                case "^HY": return new zpl_cmd_c_HY(data,commands); ; // Upload Graphics
                case "^HZ": return new zpl_cmd_c_HZ(data,commands); ; // Display Description Information
                case "^ID": return new zpl_cmd_c_ID(data,commands); ; // Object Delete
                case "^IL": return new zpl_cmd_c_IL(data,commands); ; // Image Load
                case "^IM": return new zpl_cmd_c_IM(data,commands); ; // Image Move
                case "^IS": return new zpl_cmd_c_IS(data,commands); ; // Image Save
                case "~JA": return new zpl_cmd_t_JA(data,commands); ; // Cancel All
                case "^JB": return new zpl_cmd_c_JB(data,commands); ; // Initialize Flash Memory
                case "~JB": return new zpl_cmd_t_JB(data,commands); ; // Reset Optional Memory
                case "~JC": return new zpl_cmd_t_JC(data,commands); ; // Set Media Sensor Calibration
                case "~JD": return new zpl_cmd_t_JD(data,commands); ; // Enable Communications Diagnostics
                case "~JE": return new zpl_cmd_t_JE(data,commands); ; // Disable Diagnostics
                case "~JF": return new zpl_cmd_t_JF(data,commands); ; // Set Battery Condition
                case "~JG": return new zpl_cmd_t_JG(data,commands); ; // Graphing Sensor Calibration
                case "^JH": return new zpl_cmd_c_JH(data,commands); ; // Early Warning Settings
                case "^JI": return new zpl_cmd_c_JI(data,commands); ; // Start ZBI (Zebra BASIC Interpreter)
                case "~JI": return new zpl_cmd_t_JI(data,commands); ; // Start ZBI (Zebra BASIC Interpreter)
                case "^JJ": return new zpl_cmd_c_JJ(data,commands); ; // Set Auxiliary Port
                case "~JL": return new zpl_cmd_t_JL(data,commands); ; // Set Label Length
                case "^JM": return new zpl_cmd_c_JM(data,commands); ; // Set Dots per Millimeter
                case "~JN": return new zpl_cmd_t_JN(data,commands); ; // Head Test Fatal
                case "~JO": return new zpl_cmd_t_JO(data,commands); ; // Head Test Non-Fatal
                case "~JP": return new zpl_cmd_t_JP(data,commands); ; // Pause and Cancel Format
                case "~JQ": return new zpl_cmd_t_JQ(data,commands); ; // Terminate Zebra BASIC Interpreter
                case "~JR": return new zpl_cmd_t_JR(data,commands); ; // Power On Reset
                case "^JS": return new zpl_cmd_c_JS(data,commands); ; // Sensor Select
                case "~JS": return new zpl_cmd_t_JS(data,commands); ; // Change Backfeed Sequence
                case "^JT": return new zpl_cmd_c_JT(data,commands); ; // Head Test Interval
                case "^JU": return new zpl_cmd_c_JU(data,commands); ; // Configuration Update
                case "^JW": return new zpl_cmd_c_JW(data,commands); ; // Set Ribbon Tension
                case "~JX": return new zpl_cmd_t_JX(data,commands); ; // Cancel Current Partially Input Format
                case "^JZ": return new zpl_cmd_c_JZ(data,commands); ; // Reprint After Error
                case "~KB": return new zpl_cmd_t_KB(data,commands); ; // Kill Battery (Battery Discharge Mode)
                case "^KD": return new zpl_cmd_c_KD(data,commands); ; // Select Date and Time Format (for Real Time Clock)
                case "^KL": return new zpl_cmd_c_KL(data,commands); ; // Define Language
                case "^KN": return new zpl_cmd_c_KN(data,commands); ; // Define Printer Name
                case "^KP": return new zpl_cmd_c_KP(data,commands); ; // Define Password
                case "^KV": return new zpl_cmd_c_KV(data,commands); ; // Kiosk Values
                case "^LF": return new zpl_cmd_c_LF(data,commands); ; // List Font Links
                case "^LH": return new zpl_cmd_c_LH(data,commands); ; // Label Home
                case "^LL": return new zpl_cmd_c_LL(data,commands); ; // Label Length
                case "^LR": return new zpl_cmd_c_LR(data,commands); ; // Label Reverse Print
                case "^LS": return new zpl_cmd_c_LS(data,commands); ; // Label Shift
                case "^LT": return new zpl_cmd_c_LT(data,commands); ; // Label Top
                case "^MA": return new zpl_cmd_c_MA(data,commands); ; // Set Maintenance Alerts
                case "^MC": return new zpl_cmd_c_MC(data,commands); ; // Map Clear
                case "^MD": return new zpl_cmd_c_MD(data,commands); ; // Media Darkness
                case "^MF": return new zpl_cmd_c_MF(data,commands); ; // Media Feed
                case "^MI": return new zpl_cmd_c_MI(data,commands); ; // Set Maintenance Information Message
                case "^ML": return new zpl_cmd_c_ML(data,commands); ; // Maximum Label Length
                case "^MM": return new zpl_cmd_c_MM(data,commands); ; // Print Mode
                case "^MN": return new zpl_cmd_c_MN(data,commands); ; // Media Tracking
                case "^MP": return new zpl_cmd_c_MP(data,commands); ; // Mode Protection
                case "^MT": return new zpl_cmd_c_MT(data,commands); ; // Media Type
                case "^MU": return new zpl_cmd_c_MU(data,commands); ; // Set Units of Measurement
                case "^MW": return new zpl_cmd_c_MW(data,commands); ; // Modify Head Cold Warning
                case "^NC": return new zpl_cmd_c_NC(data,commands); ; // Select the Primary Network Device
                case "~NC": return new zpl_cmd_t_NC(data,commands); ; // Network Connect
                case "^ND": return new zpl_cmd_c_ND(data,commands); ; // Change Network Settings
                case "^NI": return new zpl_cmd_c_NI(data,commands); ; // Network ID Number
                case "~NR": return new zpl_cmd_t_NR(data,commands); ; // Set All Network Printers Transparent
                case "^NS": return new zpl_cmd_c_NS(data,commands); ; // Change Wired Networking Settings
                case "~NT": return new zpl_cmd_t_NT(data,commands); ; // Set Currently Connected Printer Transparent
                case "^PA": return new zpl_cmd_c_PA(data,commands); ; // Advanced Text Properties
                case "^PF": return new zpl_cmd_c_PF(data,commands); ; // Slew Given Number of Dot Rows
                case "^PH": return new zpl_cmd_c_PH(data,commands); ; // t_PH Slew to Home Position
                case "~PL": return new zpl_cmd_t_PL(data,commands); ; // Present Length Addition
                case "^PM": return new zpl_cmd_c_PM(data,commands); ; // Printing Mirror Image of Label
                case "^PN": return new zpl_cmd_c_PN(data,commands); ; // Present Now
                case "^PO": return new zpl_cmd_c_PO(data,commands); ; // Print Orientation
                case "^PP": return new zpl_cmd_c_PP(data,commands); ; // t_PP Programmable Pause
                case "^PQ": return new zpl_cmd_c_PQ(data,commands); ; // Print Quantity
                case "~PR": return new zpl_cmd_t_PR(data,commands); ; // Applicator Reprint
                case "^PR": return new zpl_cmd_c_PR(data,commands); ; // Print Rate
                case "~PS": return new zpl_cmd_t_PS(data,commands); ; // Print Start
                case "^PW": return new zpl_cmd_c_PW(data,commands); ; // Print Width
                case "~RO": return new zpl_cmd_t_RO(data,commands); ; // Reset Advanced Counters
                case "^SC": return new zpl_cmd_c_SC(data,commands); ; // Set Serial Communications
                case "~SD": return new zpl_cmd_t_SD(data,commands); ; // Set Darkness
                case "^SE": return new zpl_cmd_c_SE(data,commands); ; // Select Encoding Table
                case "^SF": return new zpl_cmd_c_SF(data,commands); ; // Serialization Field (with a Standard c_FD String)
                case "^SI": return new zpl_cmd_c_SI(data,commands); ; // Set Sensor Intensity
                case "^SL": return new zpl_cmd_c_SL(data,commands); ; // Set Mode and Language (for Real-Time Clock)
                case "^SN": return new zpl_cmd_c_SN(data,commands); ; // Serialization Data
                case "^SO": return new zpl_cmd_c_SO(data,commands); ; // Set Offset (for Real-Time Clock)
                case "^SP": return new zpl_cmd_c_SP(data,commands); ; // Start Print
                case "^SQ": return new zpl_cmd_c_SQ(data,commands); ; // Halt ZebraNet Alert
                case "^SR": return new zpl_cmd_c_SR(data,commands); ; // Set Printhead Resistance
                case "^SS": return new zpl_cmd_c_SS(data,commands); ; // Set Media Sensors
                case "^ST": return new zpl_cmd_c_ST(data,commands); ; // Set Date and Time (for Real-Time Clock)
                case "^SX": return new zpl_cmd_c_SX(data,commands); ; // Set ZebraNet Alert
                case "^SZ": return new zpl_cmd_c_SZ(data,commands); ; // Set ZPL Mode
                case "~TA": return new zpl_cmd_t_TA(data,commands); ; // Tear-off Adjust Position
                case "^TB": return new zpl_cmd_c_TB(data,commands); ; // Text Blocks
                case "^TO": return new zpl_cmd_c_TO(data,commands); ; // Transfer Object
                case "~WC": return new zpl_cmd_t_WC(data,commands); ; // Print Configuration Label
                case "^WD": return new zpl_cmd_c_WD(data,commands); ; // Print Directory Label
                case "~WQ": return new zpl_cmd_t_WQ(data,commands); ; // Write Query
                case "^XA": return new zpl_cmd_c_XA(data,commands); ; // Start Format
                case "^XB": return new zpl_cmd_c_XB(data,commands); ; // Suppress Backfeed
                case "^XF": return new zpl_cmd_c_XF(data,commands); ; // Recall Format
                case "^XG": return new zpl_cmd_c_XG(data,commands); ; // Recall Graphic
                case "^XS": return new zpl_cmd_c_XS(data,commands); ; // Set Dynamic Media Calibration
                case "^XZ": return new zpl_cmd_c_XZ(data,commands); ; // End Format
                case "^ZZ": return new zpl_cmd_c_ZZ(data,commands); ; // Printer Sleep
            }
            return  null;
        }

        public bool contains_point(Point src) {
            if(src.X>=_internal.x && 
               src.X<=_internal.x+_internal.width && 
               src.Y>=_internal.y && 
               src.Y<=_internal.y+_internal.height) return true;
            return false;
        }

        public Rectangle get_bounds() {
            Rectangle rect=new Rectangle();
            rect.X      =_internal.x;
            rect.Y      =_internal.y;
            rect.Width  =_internal.width;
            rect.Height =_internal.height;
            return rect;
        }

        public void drag_stop() {
            int diffx=_internal.drag_x-_internal.drag_start_x;
            int diffy=_internal.drag_y-_internal.drag_start_y;
            _internal.field_x+=diffx;
            _internal.field_y+=diffy;
            _internal.drag_x=0;
            _internal.drag_y=0;
            _internal.drag_start_x=0;
            _internal.drag_start_y=0;
            _internal.drag=false;
        }

        private int get_int(string data,int index) {
            int             integer_test=0;
            string  test    =data.Trim();                                      //clean up token
            bool    results =Int32.TryParse(test,out integer_test);
            if(!results) {                                                      //it failed conversion to integer so it's alpha
                _internal.error=true;
                _internal.error_msg+=String.Format("Argument failure for argument index {0} of command {1} with data {2}",index,cmd,data);
                return -1;
            }
            return  integer_test;
        }

        public class default_range{
            public string string_x  =String.Empty;
            public string string_y  =String.Empty;
            public int    int_x     =-1;
            public int    int_y     =-1;
            public bool   is_single =false;
            public bool   is_int    =true;
            public string string_value  =String.Empty;
            public int    int_value     =-1;
            
            public default_range(string data) {
                data=data.Trim();                                                                       //clean up token
                int range_index=data.IndexOf("-");
                if(range_index<0) {                                                                     //no range here.. its a single
                    is_single=true;
                    string_x=data;
                    if(!Int32.TryParse(string_x,out int_x)) {
                        is_int=false;
                    } 
                }//end range if
                if(range_index>=0) {                                                                    //its a range
                    is_single=false;
                    string [] tokens=data.Split('-');
                    if(tokens.Length==2) {
                        string_x =tokens[0];
                        string_y =tokens[1];
                        if(!Int32.TryParse(string_x,out int_x)) {
                            is_int=false;
                        }
                        if(!Int32.TryParse(string_y,out int_y)) {
                            is_int=false;
                        }
                    }
                }//end range if
            }
            public bool is_valid(string compare) {
                if(is_int) {
                    int int_compare;
                    if(Int32.TryParse(compare,out int_compare)) {
                        int_value=int_compare;
                        string_value=compare;
                        if(!is_single && int_compare>=int_x && int_compare<=int_y) return true;          //if its a range compare
                        if( is_single && int_compare==int_x) return true;                                //if its a single number compare...
                    }
                } else {
                    string_value=compare;
                    if(string_x.Length==0) return false;
                    if(!is_single && compare==string_x) return true;                                     //if its a single character compare...
                    if(string_y.Length==0) return false;
                    if( is_single && compare[0]>=string_x[0] && compare[0]<=string_y[0]) return true;    //if its a single character compare...
                }

                return false;
            }

        }

        public static byte[] hex_to_bytes(String hex){
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

        //need to add support for arrays (like 3 commands use this wierd format)
        public object argument(int index, string data, string data_type,string options, string position, string _default,string override_default="") {
            /*********************************************************
              Defaults Patterns
              Type i
              x-y : range      - numeric (integer)
              x,y : collection - individual options (integer)
              
              Type s
              x-y : range      - Alpha   (strings)
              x,y : collection - individual options (string)
              *     ALL
              
              Type f returns a float
              Type b[]
              returns an array of HEX bytes; from an ASCII hex string.

              Type drive      returns D: from d:o.x
              Type file       returns o: from d:o.x
              Type extension  returns x: from d:o.x

              a-h,v-p,0-9,j,k,l,n
              a-h
              a,b,c
              1,2,3,a,b,c
            *********************************************************/


            if (null==_internal.arguments || position=="*") {
                if (null==_internal.arguments )this.data=data;
                string temp_d=data;
                data=data.Replace("<","");
                data=data.Replace(">","");
                //data=data.Replace(".","");
                //data=data.Replace(":",",");
                /*if(position=="*") {
                    int temp_index=index;
                    int pos=0;
                    while(temp_index>0) {  pos=temp_d.IndexOf(',',pos)+1;  temp_index--;}
                    _internal.arguments[index]=temp_d.Substring(pos-1);
                }
                else {*/
                    if(_internal.argument_max!=0)  _internal.arguments=data.Split(new char[] {','},_internal.argument_max);
                    else                           _internal.arguments=data.Split(',');
                //}
            }

            if(data_type=="drive") {
                string path=_internal.arguments[index];
                int drive_index=path.IndexOf(':');
                if(drive_index!=-1) {
                    string drive=path.Substring(0,drive_index+1);
                    string[] drive_tokens=options.Split(',');
                    if(drive_tokens.Contains(drive)) return drive;
                    else                             return _default;
                }
                return _default;
            }

            if(data_type=="file") {
                string path=_internal.arguments[index];
                int drive_index=path.IndexOf(':');
                int ext_index=path.IndexOf('.');
                if(ext_index==-1) ext_index=path.Length;
                if(drive_index!=-1) {
                    string file=path.Substring(drive_index+1,ext_index-drive_index-1);
                    return file;
                }
                return _default;
            }

            if(data_type=="ext") {
                string path=_internal.arguments[index];
                int ext_index=path.IndexOf('.');
                if(ext_index!=-1) {
                    string ext=path.Substring(ext_index);
                    return ext;
                }
                return _default;
            }

            if (data_type=="f") {
                float f=0;
                if(_internal.arguments.Length>index) {
                    if(float.TryParse(_internal.arguments[index],out f)) return f;
                } else {
                    if(float.TryParse(_default,out f)) return f;
                    return (float)0;
                }
            }
            if (data_type=="b[]") {
                if(_internal.arguments.Length>index) {
                    byte[] bytes=hex_to_bytes(_internal.arguments[index]);
                    return bytes;
                } else {
                    return new byte[] { };
                }
            }
            if(data_type=="s" && options=="*") {
                if(_internal.arguments.Length>index) {
                    return _internal.arguments[index];
                } else {
                    return _default;
                }
            }

            string argument;
            if(_internal.arguments.Length>index) {
                if(data_type=="c") {
                    int pos=0;
                    if(_internal.arguments[index].Length>pos) {
                        Int32.TryParse(position,out pos);
                        argument=_internal.arguments[index][pos].ToString();
                    } else argument="";
                    return argument;
                } else {
                    argument=_internal.arguments[index];
                }
                
            } else {
                argument ="";
                _internal.error=true;
                _internal.error_msg+=String.Format("Argument failure for argument index {0} of command {1} with data {2}. Index is out of range.",index,cmd,data);
            }

            bool                is_valid        =false;
            string[]            tokens;
            int                 int_value       =-1;
            string              string_value    =String.Empty;
            List<default_range> range           =new List<default_range>();
            tokens=options.Split(',');
            foreach(string token in tokens) {                                           //create a list of ranges, single or integer/alpha
                range.Add(new default_range(token));
            }
            foreach(default_range r in range) {                                         //check to see if the value falls in range or = the option
                if(r.is_valid(argument)) {
                    is_valid=true; 
                    if(r.is_int) {
                        int_value=r.int_value;
                    }
                    string_value =r.string_value;                                       //even though it may be ing, we may have just been checking a numeric range with alpha output.
                    break;
                }//enf if valid
            }//end foreach

            if(!is_valid && !string.IsNullOrWhiteSpace(_default)) {                     //if we have a default... set it if the selection does not have valid data
                switch(data_type) {
                    case "i":   if(!Int32.TryParse(override_default,out int_value)) {
                                    if (!Int32.TryParse(_default,out int_value)) {
                                        _internal.error=true;
                                        _internal.error_msg+=String.Format("Argument failure for argument index {0} of command {1} with data {2}. Default Value invalid.",index,cmd,data);
                                        int_value =-1;
                                    }
                                }
                                break;
                    case "s":                                                           //if it doesnt have a type.. its a string
                    default : data_type="s"; string_value =_default; break;

                }//end switch
            }//end set default because its invalid
            if(data_type=="i") return int_value;
            if(data_type=="s") return string_value;
            if(data_type=="c") return string_value;
			return null;
		}
        
        public string get_field_data(char hexadecimal_indicator) {
            string _data=_internal.field_data;                           //dont work off original string.
            List<byte> bytes=new List<byte>();
            bool    inHex=false;
            string  hex="";
            int     hex_index=0;
            foreach(char c in _data){
                if(c==hexadecimal_indicator) {
                    inHex=true;
                    hex="";
                    hex_index=0;
                    continue;
                }
                if(!inHex) {
                    bytes.Add((byte)c);
                } else {
                    hex_index++;
                    hex=hex+c;
                    if(hex_index==2){
                        try {
                        bytes.Add(Convert.ToByte(hex.Substring(0, 2), 16));
                        } catch (Exception Ex) {
                        }
                    }
                }
            }
            byte[] data_bytes=bytes.ToArray();
            string new_data_string=System.Text.Encoding.ASCII.GetString(data_bytes);
            return new_data_string;
        }

        public Image draw_string(string font,int bitmapped_font_width,int bitmapped_font_height,string text,bool reverse,int bound_width,int bound_lines) {
            if(String.IsNullOrWhiteSpace(text)) return null;                    //prevent all this logic from being wasted
            //font sixe=
            /*
                dpi =152.4
                dpi =203.2
                dpi =304.8
                dpi =609.6
                d=(p*dpi)/72   //zebra programming interface II
                d*72=p*dpi
                (d*72)/dpi=p

                d=(dpi/72)*p //zebra font manual
                p=d/(dpi/72);
                */

            build_raster_fonts_from_printer.font_structure fs=new build_raster_fonts_from_printer.font_structure(font);
            float                   curent_size=bitmapped_font_width;
            Bitmap                  string_image;
            
            int field_width =fs.character_pixel_width*text.Length;
            int field_height=fs.character_pixel_height;

            string_image    =new Bitmap(field_width,field_height);
            if (fs.type=="RASTER1") {
                //This is for Raster fonts (converted to bitmaps then scaled)
                string_image    =new Bitmap(field_width,field_height);
                build_raster_fonts_from_printer.draw_string(font,string_image,0,0,bitmapped_font_width,bitmapped_font_height,text);
            } else {
                try {
                    //This is for TTF Fonts.....
                    //impliment scaling
                    Font image_font;
                    FontFamily font_family=new FontFamily("Arial");
                    float pt=1;
                    Bitmap temp_image    =new Bitmap(10,10);
                    Graphics temp_image_g=Graphics.FromImage(temp_image);
                    int char_height=0;
                    for(float cur_pt=1;cur_pt<400;cur_pt+=.1f) {
                        using(Font test_font=new Font(fs.ttf_name,pt)){

                            SizeF char_bounds=temp_image_g.MeasureString("W", test_font);
                            if(char_bounds.Width  <bitmapped_font_width &&
                                char_bounds.Height<bitmapped_font_height) {
                                pt =cur_pt;
                                char_height=(int)char_bounds.Height;
                            }
                            else break;
                        }
                    }

                    
                    image_font      =new Font(font_family,pt);
                    SizeF dimentions;
                    if(bound_lines!=0){
                        dimentions=new SizeF(bound_width,bound_lines*char_height);
                    } else {
                        dimentions=temp_image_g.MeasureString(text, image_font);
                    }

                    string_image    =new Bitmap((int)dimentions.Width,(int)dimentions.Height);
                    Graphics    string_image_g  =Graphics.FromImage(string_image);
                    Rectangle bounds_rect=new Rectangle(0,0,string_image.Width,string_image.Height);
                    float i=255;
                    string_image_g.FillRegion(new SolidBrush(
                                                Color.FromArgb(0,(int)i,(int)i,(int)i))
                                                ,new Region(
                                                new RectangleF(0,0,string_image.Width,string_image.Height) ) );
                    string_image_g.TextRenderingHint = TextRenderingHint.AntiAlias;
                    if(reverse) {
                        string_image_g.DrawString(text, image_font, Brushes.White, bounds_rect);
                    } else {
                        string_image_g.DrawString(text, image_font, Brushes.Black, bounds_rect);
                    }
                    _internal.baseline=(int)(((float)string_image.Height)*.75f);
                    _internal.image=string_image;
                    _internal.width =string_image.Width;
                    _internal.height=string_image.Height;
                }   catch (Exception ex) {
                    int x=0;
                }
                
            }
            return string_image;
        }

        public Bitmap draw_graphic(byte[] graphic_data,int graphic_field_count,int bytes_per_row) {
            int graphic_width =bytes_per_row*8;
            int graphic_height=graphic_field_count/bytes_per_row;
            if(graphic_height<1 || graphic_width<1) return null;
            Bitmap      graphic_image   =new Bitmap(graphic_width,graphic_height);
            Graphics    graphic_image_g =Graphics.FromImage(graphic_image);
            SolidBrush  graphic_brush   = new SolidBrush(Color.FromArgb(255, 0,0,0));
            int x=0,y=0;
            for (int a=0;a<graphic_field_count;a++) {
                    //if(data.Length<=a) continue;                    //prevent out of bounds err
                    if(graphic_data.Length<=a) continue;            //for reported length and actual length
                    bool bit1 = (graphic_data[a] & (1 << 1-1)) != 0;
                    bool bit2 = (graphic_data[a] & (1 << 2-1)) != 0;
                    bool bit3 = (graphic_data[a] & (1 << 3-1)) != 0;
                    bool bit4 = (graphic_data[a] & (1 << 4-1)) != 0;
                    bool bit5 = (graphic_data[a] & (1 << 5-1)) != 0;
                    bool bit6 = (graphic_data[a] & (1 << 6-1)) != 0;
                    bool bit7 = (graphic_data[a] & (1 << 7-1)) != 0;
                    bool bit8 = (graphic_data[a] & (1 << 8-1)) != 0;
                    if(bit1) graphic_image_g.FillRectangle(graphic_brush , x*8+7, y, 1, 1);
                    if(bit2) graphic_image_g.FillRectangle(graphic_brush , x*8+6, y, 1, 1);
                    if(bit3) graphic_image_g.FillRectangle(graphic_brush , x*8+5, y, 1, 1);
                    if(bit4) graphic_image_g.FillRectangle(graphic_brush , x*8+4, y, 1, 1);
                    if(bit5) graphic_image_g.FillRectangle(graphic_brush , x*8+3, y, 1, 1);
                    if(bit6) graphic_image_g.FillRectangle(graphic_brush , x*8+2, y, 1, 1);
                    if(bit7) graphic_image_g.FillRectangle(graphic_brush , x*8+1, y, 1, 1);
                    if(bit8) graphic_image_g.FillRectangle(graphic_brush , x*8+0, y, 1, 1);
                x++;
                if(x>=bytes_per_row) {
                    x=0; y++;
                }//end y counter
            }//end pixel loop
            return graphic_image;
        }

        //initial override?
        public virtual void draw() {

        }
        public void process() {
        }
	}
}//end namespace
