using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titanZPL.commands;

namespace titanZPL{
    public partial class titanZPL{
        public string zpl=String.Empty;
        public List<zpl_command> zpl_commands=new List<zpl_command>();
        public zpl_command      curent_zpl_command;

        
        public void load_document(string data) {
            this.zpl=data;
            string zpl=convert_base64_to_string(data);
            if (String.IsNullOrWhiteSpace(zpl)) zpl=data;      //not base64 use the init data
            //lets do this the simple way
            //remove line breaks, tabs and whitespace
            zpl_commands.Clear();
            int index=-1;
            char[] cmd_prefix=new char[] { '^','~'};
            while ( zpl.Length>=index+1 && (index=zpl.IndexOfAny(cmd_prefix,index+1))>=0) {
                int end=zpl.IndexOfAny(cmd_prefix,index+1);
                if(end==-1) end=zpl.Length;
                string token=zpl.Substring(index,end-index);
                string cmd,arguments;
                if(token.Length<=1) continue;
                if (token[0]=='^' && (token[1]=='a' || token[1]=='A') && token.Length>2 && (token[2]!='@')){      //special case only cmd that is 1 character
                    cmd=token.Substring(0,2);
                    arguments=token.Substring(2);
                } else {
                    if(token.Length>=3) { 
                        cmd=token.Substring(0,3);
                        arguments=token.Substring(3);
                    } else {
                        cmd=token;
                        arguments=String.Empty;
                    }
                }
                build_command(cmd,arguments);
            }
        }//end init document

        public void build_command(string cmd, string data) {
            switch (cmd) {
                case "^A" : zpl_commands.Add(new zpl_cmd_c_A (data,zpl_commands)); break; // Scalable/Bitmapped Font
                case "^A@": zpl_commands.Add(new zpl_cmd_c_A2(data,zpl_commands)); break; // Use Font Name to Call Font (Only command with a symbol in the name)
                case "^B0": zpl_commands.Add(new zpl_cmd_c_B0(data,zpl_commands)); break; // Aztec Bar Code Parameters
                case "^B1": zpl_commands.Add(new zpl_cmd_c_B1(data,zpl_commands)); break; // Code 11 Bar Code
                case "^B2": zpl_commands.Add(new zpl_cmd_c_B2(data,zpl_commands)); break; // Interleaved 2 of 5 Bar Code
                case "^B3": zpl_commands.Add(new zpl_cmd_c_B3(data,zpl_commands)); break; // Code 39 Bar Code
                case "^B4": zpl_commands.Add(new zpl_cmd_c_B4(data,zpl_commands)); break; // Code 49 Bar Code
                case "^B5": zpl_commands.Add(new zpl_cmd_c_B5(data,zpl_commands)); break; // Planet Code bar code
                case "^B7": zpl_commands.Add(new zpl_cmd_c_B7(data,zpl_commands)); break; // PDF417 Bar Code
                case "^B8": zpl_commands.Add(new zpl_cmd_c_B8(data,zpl_commands)); break; // EAN-8 Bar Code
                case "^B9": zpl_commands.Add(new zpl_cmd_c_B9(data,zpl_commands)); break; // UPC-E Bar Code
                case "^BA": zpl_commands.Add(new zpl_cmd_c_BA(data,zpl_commands)); break; // Code 93 Bar Code
                case "^BB": zpl_commands.Add(new zpl_cmd_c_BB(data,zpl_commands)); break; // CODABLOCK Bar Code
                case "^BC": zpl_commands.Add(new zpl_cmd_c_BC(data,zpl_commands)); break; // Code 128 Bar Code (Subsets A, B, and C)
                case "^BD": zpl_commands.Add(new zpl_cmd_c_BD(data,zpl_commands)); break; // UPS MaxiCode Bar Code
                case "^BE": zpl_commands.Add(new zpl_cmd_c_BE(data,zpl_commands)); break; // EAN-13 Bar Code
                case "^BF": zpl_commands.Add(new zpl_cmd_c_BF(data,zpl_commands)); break; // MicroPDF417 Bar Code
                case "^BI": zpl_commands.Add(new zpl_cmd_c_BI(data,zpl_commands)); break; // Industrial 2 of 5 Bar Codes
                case "^BJ": zpl_commands.Add(new zpl_cmd_c_BJ(data,zpl_commands)); break; // Standard 2 of 5 Bar Code
                case "^BK": zpl_commands.Add(new zpl_cmd_c_BK(data,zpl_commands)); break; // ANSI Codabar Bar Code
                case "^BL": zpl_commands.Add(new zpl_cmd_c_BL(data,zpl_commands)); break; // LOGMARS Bar Code
                case "^BM": zpl_commands.Add(new zpl_cmd_c_BM(data,zpl_commands)); break; // MSI Bar Code
                case "^BO": zpl_commands.Add(new zpl_cmd_c_BO(data,zpl_commands)); break; // Aztec Bar Code Parameters
                case "^BP": zpl_commands.Add(new zpl_cmd_c_BP(data,zpl_commands)); break; // Plessey Bar Code
                case "^BQ": zpl_commands.Add(new zpl_cmd_c_BQ(data,zpl_commands)); break; // QR Code Bar Code
                case "^BR": zpl_commands.Add(new zpl_cmd_c_BR(data,zpl_commands)); break; // GS1 Databar
                case "^BS": zpl_commands.Add(new zpl_cmd_c_BS(data,zpl_commands)); break; // UPC/EAN Extensions
                case "^BT": zpl_commands.Add(new zpl_cmd_c_BT(data,zpl_commands)); break; // TLC39 Bar Code
                case "^BU": zpl_commands.Add(new zpl_cmd_c_BU(data,zpl_commands)); break; // UPC-A Bar Code
                case "^BX": zpl_commands.Add(new zpl_cmd_c_BX(data,zpl_commands)); break; // Data Matrix Bar Code
                case "^BY": zpl_commands.Add(new zpl_cmd_c_BY(data,zpl_commands)); break; // Bar Code Field Default
                case "^BZ": zpl_commands.Add(new zpl_cmd_c_BZ(data,zpl_commands)); break; // POSTAL Bar Code
                case "^CC": zpl_commands.Add(new zpl_cmd_c_CC(data,zpl_commands)); break; // t_CC Change Caret
                case "^CD": zpl_commands.Add(new zpl_cmd_c_CD(data,zpl_commands)); break; // t_CD Change Delimiter
                case "^CF": zpl_commands.Add(new zpl_cmd_c_CF(data,zpl_commands)); break; // Change Alphanumeric Default Font
                case "^CI": zpl_commands.Add(new zpl_cmd_c_CI(data,zpl_commands)); break; // Change International Font/Encoding
                case "^CM": zpl_commands.Add(new zpl_cmd_c_CM(data,zpl_commands)); break; // Change Memory Letter Designation
                case "^CN": zpl_commands.Add(new zpl_cmd_c_CN(data,zpl_commands)); break; // Cut Now
                case "^CO": zpl_commands.Add(new zpl_cmd_c_CO(data,zpl_commands)); break; // Cache On
                case "^CP": zpl_commands.Add(new zpl_cmd_c_CP(data,zpl_commands)); break; // Remove Label
                case "^CT": zpl_commands.Add(new zpl_cmd_c_CT(data,zpl_commands)); break; // t_CT Change Tilde
                case "^CV": zpl_commands.Add(new zpl_cmd_c_CV(data,zpl_commands)); break; // Code Validation
                case "^CW": zpl_commands.Add(new zpl_cmd_c_CW(data,zpl_commands)); break; // Font Identifier
                case "~DB": zpl_commands.Add(new zpl_cmd_t_DB(data,zpl_commands)); break; // Download Bitmap Font
                case "~DE": zpl_commands.Add(new zpl_cmd_t_DE(data,zpl_commands)); break; // Download Encoding
                case "^DF": zpl_commands.Add(new zpl_cmd_c_DF(data,zpl_commands)); break; // Download Format
                case "~DG": zpl_commands.Add(new zpl_cmd_t_DG(data,zpl_commands)); break; // Download Graphics
                case "~DN": zpl_commands.Add(new zpl_cmd_t_DN(data,zpl_commands)); break; // Abort Download Graphic
                case "~DS": zpl_commands.Add(new zpl_cmd_t_DS(data,zpl_commands)); break; // Download Intellifont (Scalable Font)
                case "~DT": zpl_commands.Add(new zpl_cmd_t_DT(data,zpl_commands)); break; // Download Bounded TrueType Font
                case "~DU": zpl_commands.Add(new zpl_cmd_t_DU(data,zpl_commands)); break; // Download Unbounded TrueType Font
                case "~DY": zpl_commands.Add(new zpl_cmd_t_DY(data,zpl_commands)); break; // Download Objects
                case "~EG": zpl_commands.Add(new zpl_cmd_t_EG(data,zpl_commands)); break; // Erase Download Graphics
                case "^FB": zpl_commands.Add(new zpl_cmd_c_FB(data,zpl_commands)); break; // Field Block
                case "^FC": zpl_commands.Add(new zpl_cmd_c_FC(data,zpl_commands)); break; // Field Clock
                case "^FD": zpl_commands.Add(new zpl_cmd_c_FD(data,zpl_commands)); break; // Field Data
                case "^FH": zpl_commands.Add(new zpl_cmd_c_FH(data,zpl_commands)); break; // Field Hexadecimal Indicator
                case "^FL": zpl_commands.Add(new zpl_cmd_c_FL(data,zpl_commands)); break; // Font Linking
                case "^FM": zpl_commands.Add(new zpl_cmd_c_FM(data,zpl_commands)); break; // Multiple Field Origin Locations
                case "^FN": zpl_commands.Add(new zpl_cmd_c_FN(data,zpl_commands)); break; // Field Number
                case "^FO": zpl_commands.Add(new zpl_cmd_c_FO(data,zpl_commands)); break; // Field Origin
                case "^FP": zpl_commands.Add(new zpl_cmd_c_FP(data,zpl_commands)); break; // Field Parameter
                case "^FR": zpl_commands.Add(new zpl_cmd_c_FR(data,zpl_commands)); break; // Field Reverse Print
                case "^FS": zpl_commands.Add(new zpl_cmd_c_FS(data,zpl_commands)); break; // Field Separator
                case "^FT": zpl_commands.Add(new zpl_cmd_c_FT(data,zpl_commands)); break; // Field Typeset
                case "^FV": zpl_commands.Add(new zpl_cmd_c_FV(data,zpl_commands)); break; // Field Variable
                case "^FW": zpl_commands.Add(new zpl_cmd_c_FW(data,zpl_commands)); break; // Field Orientation
                case "^FX": zpl_commands.Add(new zpl_cmd_c_FX(data,zpl_commands)); break; // Comment
                case "^GB": zpl_commands.Add(new zpl_cmd_c_GB(data,zpl_commands)); break; // Graphic Box
                case "^GC": zpl_commands.Add(new zpl_cmd_c_GC(data,zpl_commands)); break; // Graphic Circle
                case "^GD": zpl_commands.Add(new zpl_cmd_c_GD(data,zpl_commands)); break; // Graphic Diagonal Line
                case "^GE": zpl_commands.Add(new zpl_cmd_c_GE(data,zpl_commands)); break; // Graphic Ellipse
                case "^GF": zpl_commands.Add(new zpl_cmd_c_GF(data,zpl_commands)); break; // Graphic Field
                case "^GS": zpl_commands.Add(new zpl_cmd_c_GS(data,zpl_commands)); break; // Graphic Symbol
                case "~HB": zpl_commands.Add(new zpl_cmd_t_HB(data,zpl_commands)); break; // Battery Status
                case "~HD": zpl_commands.Add(new zpl_cmd_t_HD(data,zpl_commands)); break; // Head Diagnostic
                case "^HF": zpl_commands.Add(new zpl_cmd_c_HF(data,zpl_commands)); break; // Host Format
                case "^HG": zpl_commands.Add(new zpl_cmd_c_HG(data,zpl_commands)); break; // Host Graphic
                case "^HH": zpl_commands.Add(new zpl_cmd_c_HH(data,zpl_commands)); break; // Configuration Label Return
                case "~HI": zpl_commands.Add(new zpl_cmd_t_HI(data,zpl_commands)); break; // Host Identification
                case "~HM": zpl_commands.Add(new zpl_cmd_t_HM(data,zpl_commands)); break; // Host RAM Status
                case "~HQ": zpl_commands.Add(new zpl_cmd_t_HQ(data,zpl_commands)); break; // Host Query
                case "~HS": zpl_commands.Add(new zpl_cmd_t_HS(data,zpl_commands)); break; // Host Status Return
                case "^HT": zpl_commands.Add(new zpl_cmd_c_HT(data,zpl_commands)); break; // Host Linked Fonts List
                case "~HU": zpl_commands.Add(new zpl_cmd_t_HU(data,zpl_commands)); break; // Return ZebraNet Alert Configuration
                case "^HV": zpl_commands.Add(new zpl_cmd_c_HV(data,zpl_commands)); break; // Host Verification
                case "^HW": zpl_commands.Add(new zpl_cmd_c_HW(data,zpl_commands)); break; // Host Directory List
                case "^HY": zpl_commands.Add(new zpl_cmd_c_HY(data,zpl_commands)); break; // Upload Graphics
                case "^HZ": zpl_commands.Add(new zpl_cmd_c_HZ(data,zpl_commands)); break; // Display Description Information
                case "^ID": zpl_commands.Add(new zpl_cmd_c_ID(data,zpl_commands)); break; // Object Delete
                case "^IL": zpl_commands.Add(new zpl_cmd_c_IL(data,zpl_commands)); break; // Image Load
                case "^IM": zpl_commands.Add(new zpl_cmd_c_IM(data,zpl_commands)); break; // Image Move
                case "^IS": zpl_commands.Add(new zpl_cmd_c_IS(data,zpl_commands)); break; // Image Save
                case "~JA": zpl_commands.Add(new zpl_cmd_t_JA(data,zpl_commands)); break; // Cancel All
                case "^JB": zpl_commands.Add(new zpl_cmd_c_JB(data,zpl_commands)); break; // Initialize Flash Memory
                case "~JB": zpl_commands.Add(new zpl_cmd_t_JB(data,zpl_commands)); break; // Reset Optional Memory
                case "~JC": zpl_commands.Add(new zpl_cmd_t_JC(data,zpl_commands)); break; // Set Media Sensor Calibration
                case "~JD": zpl_commands.Add(new zpl_cmd_t_JD(data,zpl_commands)); break; // Enable Communications Diagnostics
                case "~JE": zpl_commands.Add(new zpl_cmd_t_JE(data,zpl_commands)); break; // Disable Diagnostics
                case "~JF": zpl_commands.Add(new zpl_cmd_t_JF(data,zpl_commands)); break; // Set Battery Condition
                case "~JG": zpl_commands.Add(new zpl_cmd_t_JG(data,zpl_commands)); break; // Graphing Sensor Calibration
                case "^JH": zpl_commands.Add(new zpl_cmd_c_JH(data,zpl_commands)); break; // Early Warning Settings
                case "^JI": zpl_commands.Add(new zpl_cmd_c_JI(data,zpl_commands)); break; // Start ZBI (Zebra BASIC Interpreter)
                case "~JI": zpl_commands.Add(new zpl_cmd_t_JI(data,zpl_commands)); break; // Start ZBI (Zebra BASIC Interpreter)
                case "^JJ": zpl_commands.Add(new zpl_cmd_c_JJ(data,zpl_commands)); break; // Set Auxiliary Port
                case "~JL": zpl_commands.Add(new zpl_cmd_t_JL(data,zpl_commands)); break; // Set Label Length
                case "^JM": zpl_commands.Add(new zpl_cmd_c_JM(data,zpl_commands)); break; // Set Dots per Millimeter
                case "~JN": zpl_commands.Add(new zpl_cmd_t_JN(data,zpl_commands)); break; // Head Test Fatal
                case "~JO": zpl_commands.Add(new zpl_cmd_t_JO(data,zpl_commands)); break; // Head Test Non-Fatal
                case "~JP": zpl_commands.Add(new zpl_cmd_t_JP(data,zpl_commands)); break; // Pause and Cancel Format
                case "~JQ": zpl_commands.Add(new zpl_cmd_t_JQ(data,zpl_commands)); break; // Terminate Zebra BASIC Interpreter
                case "~JR": zpl_commands.Add(new zpl_cmd_t_JR(data,zpl_commands)); break; // Power On Reset
                case "^JS": zpl_commands.Add(new zpl_cmd_c_JS(data,zpl_commands)); break; // Sensor Select
                case "~JS": zpl_commands.Add(new zpl_cmd_t_JS(data,zpl_commands)); break; // Change Backfeed Sequence
                case "^JT": zpl_commands.Add(new zpl_cmd_c_JT(data,zpl_commands)); break; // Head Test Interval
                case "^JU": zpl_commands.Add(new zpl_cmd_c_JU(data,zpl_commands)); break; // Configuration Update
                case "^JW": zpl_commands.Add(new zpl_cmd_c_JW(data,zpl_commands)); break; // Set Ribbon Tension
                case "~JX": zpl_commands.Add(new zpl_cmd_t_JX(data,zpl_commands)); break; // Cancel Current Partially Input Format
                case "^JZ": zpl_commands.Add(new zpl_cmd_c_JZ(data,zpl_commands)); break; // Reprint After Error
                case "~KB": zpl_commands.Add(new zpl_cmd_t_KB(data,zpl_commands)); break; // Kill Battery (Battery Discharge Mode)
                case "^KD": zpl_commands.Add(new zpl_cmd_c_KD(data,zpl_commands)); break; // Select Date and Time Format (for Real Time Clock)
                case "^KL": zpl_commands.Add(new zpl_cmd_c_KL(data,zpl_commands)); break; // Define Language
                case "^KN": zpl_commands.Add(new zpl_cmd_c_KN(data,zpl_commands)); break; // Define Printer Name
                case "^KP": zpl_commands.Add(new zpl_cmd_c_KP(data,zpl_commands)); break; // Define Password
                case "^KV": zpl_commands.Add(new zpl_cmd_c_KV(data,zpl_commands)); break; // Kiosk Values
                case "^LF": zpl_commands.Add(new zpl_cmd_c_LF(data,zpl_commands)); break; // List Font Links
                case "^LH": zpl_commands.Add(new zpl_cmd_c_LH(data,zpl_commands)); break; // Label Home
                case "^LL": zpl_commands.Add(new zpl_cmd_c_LL(data,zpl_commands)); break; // Label Length
                case "^LR": zpl_commands.Add(new zpl_cmd_c_LR(data,zpl_commands)); break; // Label Reverse Print
                case "^LS": zpl_commands.Add(new zpl_cmd_c_LS(data,zpl_commands)); break; // Label Shift
                case "^LT": zpl_commands.Add(new zpl_cmd_c_LT(data,zpl_commands)); break; // Label Top
                case "^MA": zpl_commands.Add(new zpl_cmd_c_MA(data,zpl_commands)); break; // Set Maintenance Alerts
                case "^MC": zpl_commands.Add(new zpl_cmd_c_MC(data,zpl_commands)); break; // Map Clear
                case "^MD": zpl_commands.Add(new zpl_cmd_c_MD(data,zpl_commands)); break; // Media Darkness
                case "^MF": zpl_commands.Add(new zpl_cmd_c_MF(data,zpl_commands)); break; // Media Feed
                case "^MI": zpl_commands.Add(new zpl_cmd_c_MI(data,zpl_commands)); break; // Set Maintenance Information Message
                case "^ML": zpl_commands.Add(new zpl_cmd_c_ML(data,zpl_commands)); break; // Maximum Label Length
                case "^MM": zpl_commands.Add(new zpl_cmd_c_MM(data,zpl_commands)); break; // Print Mode
                case "^MN": zpl_commands.Add(new zpl_cmd_c_MN(data,zpl_commands)); break; // Media Tracking
                case "^MP": zpl_commands.Add(new zpl_cmd_c_MP(data,zpl_commands)); break; // Mode Protection
                case "^MT": zpl_commands.Add(new zpl_cmd_c_MT(data,zpl_commands)); break; // Media Type
                case "^MU": zpl_commands.Add(new zpl_cmd_c_MU(data,zpl_commands)); break; // Set Units of Measurement
                case "^MW": zpl_commands.Add(new zpl_cmd_c_MW(data,zpl_commands)); break; // Modify Head Cold Warning
                case "^NC": zpl_commands.Add(new zpl_cmd_c_NC(data,zpl_commands)); break; // Select the Primary Network Device
                case "~NC": zpl_commands.Add(new zpl_cmd_t_NC(data,zpl_commands)); break; // Network Connect
                case "^ND": zpl_commands.Add(new zpl_cmd_c_ND(data,zpl_commands)); break; // Change Network Settings
                case "^NI": zpl_commands.Add(new zpl_cmd_c_NI(data,zpl_commands)); break; // Network ID Number
                case "~NR": zpl_commands.Add(new zpl_cmd_t_NR(data,zpl_commands)); break; // Set All Network Printers Transparent
                case "^NS": zpl_commands.Add(new zpl_cmd_c_NS(data,zpl_commands)); break; // Change Wired Networking Settings
                case "~NT": zpl_commands.Add(new zpl_cmd_t_NT(data,zpl_commands)); break; // Set Currently Connected Printer Transparent
                case "^PA": zpl_commands.Add(new zpl_cmd_c_PA(data,zpl_commands)); break; // Advanced Text Properties
                case "^PF": zpl_commands.Add(new zpl_cmd_c_PF(data,zpl_commands)); break; // Slew Given Number of Dot Rows
                case "^PH": zpl_commands.Add(new zpl_cmd_c_PH(data,zpl_commands)); break; // t_PH Slew to Home Position
                case "~PL": zpl_commands.Add(new zpl_cmd_t_PL(data,zpl_commands)); break; // Present Length Addition
                case "^PM": zpl_commands.Add(new zpl_cmd_c_PM(data,zpl_commands)); break; // Printing Mirror Image of Label
                case "^PN": zpl_commands.Add(new zpl_cmd_c_PN(data,zpl_commands)); break; // Present Now
                case "^PO": zpl_commands.Add(new zpl_cmd_c_PO(data,zpl_commands)); break; // Print Orientation
                case "^PP": zpl_commands.Add(new zpl_cmd_c_PP(data,zpl_commands)); break; // t_PP Programmable Pause
                case "^PQ": zpl_commands.Add(new zpl_cmd_c_PQ(data,zpl_commands)); break; // Print Quantity
                case "~PR": zpl_commands.Add(new zpl_cmd_t_PR(data,zpl_commands)); break; // Applicator Reprint
                case "^PR": zpl_commands.Add(new zpl_cmd_c_PR(data,zpl_commands)); break; // Print Rate
                case "~PS": zpl_commands.Add(new zpl_cmd_t_PS(data,zpl_commands)); break; // Print Start
                case "^PW": zpl_commands.Add(new zpl_cmd_c_PW(data,zpl_commands)); break; // Print Width
                case "~RO": zpl_commands.Add(new zpl_cmd_t_RO(data,zpl_commands)); break; // Reset Advanced Counters
                case "^SC": zpl_commands.Add(new zpl_cmd_c_SC(data,zpl_commands)); break; // Set Serial Communications
                case "~SD": zpl_commands.Add(new zpl_cmd_t_SD(data,zpl_commands)); break; // Set Darkness
                case "^SE": zpl_commands.Add(new zpl_cmd_c_SE(data,zpl_commands)); break; // Select Encoding Table
                case "^SF": zpl_commands.Add(new zpl_cmd_c_SF(data,zpl_commands)); break; // Serialization Field (with a Standard c_FD String)
                case "^SI": zpl_commands.Add(new zpl_cmd_c_SI(data,zpl_commands)); break; // Set Sensor Intensity
                case "^SL": zpl_commands.Add(new zpl_cmd_c_SL(data,zpl_commands)); break; // Set Mode and Language (for Real-Time Clock)
                case "^SN": zpl_commands.Add(new zpl_cmd_c_SN(data,zpl_commands)); break; // Serialization Data
                case "^SO": zpl_commands.Add(new zpl_cmd_c_SO(data,zpl_commands)); break; // Set Offset (for Real-Time Clock)
                case "^SP": zpl_commands.Add(new zpl_cmd_c_SP(data,zpl_commands)); break; // Start Print
                case "^SQ": zpl_commands.Add(new zpl_cmd_c_SQ(data,zpl_commands)); break; // Halt ZebraNet Alert
                case "^SR": zpl_commands.Add(new zpl_cmd_c_SR(data,zpl_commands)); break; // Set Printhead Resistance
                case "^SS": zpl_commands.Add(new zpl_cmd_c_SS(data,zpl_commands)); break; // Set Media Sensors
                case "^ST": zpl_commands.Add(new zpl_cmd_c_ST(data,zpl_commands)); break; // Set Date and Time (for Real-Time Clock)
                case "^SX": zpl_commands.Add(new zpl_cmd_c_SX(data,zpl_commands)); break; // Set ZebraNet Alert
                case "^SZ": zpl_commands.Add(new zpl_cmd_c_SZ(data,zpl_commands)); break; // Set ZPL Mode
                case "~TA": zpl_commands.Add(new zpl_cmd_t_TA(data,zpl_commands)); break; // Tear-off Adjust Position
                case "^TB": zpl_commands.Add(new zpl_cmd_c_TB(data,zpl_commands)); break; // Text Blocks
                case "^TO": zpl_commands.Add(new zpl_cmd_c_TO(data,zpl_commands)); break; // Transfer Object
                case "~WC": zpl_commands.Add(new zpl_cmd_t_WC(data,zpl_commands)); break; // Print Configuration Label
                case "^WD": zpl_commands.Add(new zpl_cmd_c_WD(data,zpl_commands)); break; // Print Directory Label
                case "~WQ": zpl_commands.Add(new zpl_cmd_t_WQ(data,zpl_commands)); break; // Write Query
                case "^XA": zpl_commands.Add(new zpl_cmd_c_XA(data,zpl_commands)); break; // Start Format
                case "^XB": zpl_commands.Add(new zpl_cmd_c_XB(data,zpl_commands)); break; // Suppress Backfeed
                case "^XF": zpl_commands.Add(new zpl_cmd_c_XF(data,zpl_commands)); break; // Recall Format
                case "^XG": zpl_commands.Add(new zpl_cmd_c_XG(data,zpl_commands)); break; // Recall Graphic
                case "^XS": zpl_commands.Add(new zpl_cmd_c_XS(data,zpl_commands)); break; // Set Dynamic Media Calibration
                case "^XZ": zpl_commands.Add(new zpl_cmd_c_XZ(data,zpl_commands)); break; // End Format
                case "^ZZ": zpl_commands.Add(new zpl_cmd_c_ZZ(data,zpl_commands)); break; // Printer Sleep

                //Below are Wireless and RFID commands
                //Not our curent focus
              /*  case "^HL": commands.Add(new zpl_cmd_c_HL(data)); break; // or t_HL Return RFID Data Log to Host
                case "^HR": commands.Add(new zpl_cmd_c_HR(data)); break; // Calibrate RFID Tag Position
                case "^RA": commands.Add(new zpl_cmd_c_RA(data)); break; // Read AFI or DSFID Byte
                case "^RB": commands.Add(new zpl_cmd_c_RB(data)); break; // Define EPC Data Structure
                case "^RE": commands.Add(new zpl_cmd_c_RE(data)); break; // Enable/Disable EASBit
                case "^RF": commands.Add(new zpl_cmd_c_RF(data)); break; // Read or Write RFID Format
                case "^RI": commands.Add(new zpl_cmd_c_RI(data)); break; // Get RFID Tag ID
                case "^RL": commands.Add(new zpl_cmd_c_RL(data)); break; // Lock/Unlock RFID Tag Memory
                case "^RM": commands.Add(new zpl_cmd_c_RM(data)); break; // Enable RFID Motion
                case "^RN": commands.Add(new zpl_cmd_c_RN(data)); break; // Detect Multiple RFID Tags in Encoding Field
                case "^RQ": commands.Add(new zpl_cmd_c_RQ(data)); break; // Quick Write EPC Data and Passwords
                case "^RR": commands.Add(new zpl_cmd_c_RR(data)); break; // Specify RFID Retries for a Block or Enable Adaptive
                case "^RS": commands.Add(new zpl_cmd_c_RS(data)); break; // Set Up RFID Parameters
                case "^RT": commands.Add(new zpl_cmd_c_RT(data)); break; // Read RFID Tag
                case "^RU": commands.Add(new zpl_cmd_c_RU(data)); break; // Read Unique RFID Chip Serialization
                case "~RV": commands.Add(new zpl_cmd_t_RV(data)); break; // Report RFID Encoding Results
                case "^RW": commands.Add(new zpl_cmd_c_RW(data)); break; // Set RF Power Levels for Read and Write
                case "^RZ": commands.Add(new zpl_cmd_c_RZ(data)); break; // Set RFID Tag Password and Lock Tag
                case "^WF": commands.Add(new zpl_cmd_c_WF(data)); break; // Encode AFI or DSFID Byte
                case "^WT": commands.Add(new zpl_cmd_c_WT(data)); break; // Write (Encode) Tag
                case "^WV": commands.Add(new zpl_cmd_c_WV(data)); break; // Verify RFID Encoding Operation
                case "^KC": commands.Add(new zpl_cmd_c_KC(data)); break; // Set Client Identifier (Option 61)
                case "^NB": commands.Add(new zpl_cmd_c_NB(data)); break; // Search for Wired Print Server during Network Boot
                case "^NN": commands.Add(new zpl_cmd_c_NN(data)); break; // Set SNMP
                case "^NP": commands.Add(new zpl_cmd_c_NP(data)); break; // Set Primary/Secondary Device
                case "^NT": commands.Add(new zpl_cmd_c_NT(data)); break; // Set SMTP
                case "^NW": commands.Add(new zpl_cmd_c_NW(data)); break; // Set Web Authentication Timeout Value
                case "^WA": commands.Add(new zpl_cmd_c_WA(data)); break; // Set Antenna Parameters
                case "^WE": commands.Add(new zpl_cmd_c_WE(data)); break; // Set WEP Mode
                case "^WI": commands.Add(new zpl_cmd_c_WI(data)); break; // Change Wireless Network Settings
                case "^WL": commands.Add(new zpl_cmd_c_WL(data)); break; // Set LEAP Parameters
                case "~WL": commands.Add(new zpl_cmd_t_WL(data)); break; // Print Network Configuration Label
                case "^WP": commands.Add(new zpl_cmd_c_WP(data)); break; // Set Wireless Password
                case "^WR": commands.Add(new zpl_cmd_c_WR(data)); break; // Set Transmit Rate
                case "~WR": commands.Add(new zpl_cmd_t_WR(data)); break; // Reset Wireless Radio Card and Print Server
                case "^WS": commands.Add(new zpl_cmd_c_WS(data)); break; // Set Wireless Radio Card Values
                case "^WX": commands.Add(new zpl_cmd_c_WX(data)); break; // Configure Wireless Securities
                */
                default: err.Add(String.Format("{0}:{1} Not supported",cmd,data)); break;
            }//end switch 
        }//end function

        public string pretify_zpl() {
           StringBuilder new_zpl=new StringBuilder();
            foreach(zpl_command command in zpl_commands) {
                switch(command.cmd) {                   //return before
                    case "^GF": new_zpl.Append("\r\n"); break;
                }

                switch(command.cmd) {                   //return before
                    case "^GF": new_zpl.Append(command.cmd);
                                new_zpl.Append(command.data);
                                break;
                    default:    if (string.IsNullOrWhiteSpace(command.cmd)) continue;
                                new_zpl.Append(command.cmd.Replace("\n",""));
                                new_zpl.Append(command.data.Replace("\n",""));
                                break;

                }
                switch(command.cmd) {                   //return after
                    case "^DN":
                    case "^XA":
                    case "^XZ":
                    case "^FS": new_zpl.Append("\r\n"); break;
                }
            }//end loop
            return new_zpl.ToString();
        }

        public string get_Base64() {
            byte[] bytes  = Encoding.UTF8.GetBytes(zpl);
            string base64 = Convert.ToBase64String(bytes);
            return base64;
        }
        public string convert_base64_to_string(string base64_data) {
            try {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();  
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(base64_data);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);    
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);                   
                string result = new String(decoded_char);
                return result;
            } catch(Exception e){
             //  throw new Exception("Error in base64Decode" + e.Message);
             return "";
            }
        }
               
    }//end class
}//end namespace
