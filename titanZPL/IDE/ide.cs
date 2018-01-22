using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace titanZPL {
    public partial class ide : Form {
        //titanZPL label=new titanZPL();
        //file_manager file_manager=new file_manager();
        string default_zpl="Cl5YQV5MUk5eTU5ZXk1GTixOXkxIMTAsMTJeTUNZXlBPSV5QVzgxMl5DSTI3CgpeRk82MjAsMTMwMF5HRkEsMDA5NjksMDA5NjksMDE5LEZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkYwMDAwMDAwMDAwMDAxRjgwMDAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAwMDAxRjgwMDAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAzRjgxRjgzRkMwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAzRjgxRjgzRkMwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRkY5RjlGRkYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRkY5RjlGRkYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRkZGRkZGRkZDMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRkZGRkZGRkZDMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGMDdGRkZGMEZDMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGMDdGRkZGMEZDMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGQzFGRkZDM0YwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGQzFGRkZDM0YwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRkZGRkZGRkYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRkZGRkZGRkYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAzRkZGRkZGRkMwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAzRkZGRkZGRkMwMDAwMDAwMDBGMDAwMDAwMDAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDAwMDAwMDAwCkYwMDAwMDAwMDAwMUZGRkZGMDAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAwMUZGRkZGMDAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAwM0ZGRjlGQzAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAwM0ZGRjlGQzAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAzRkUxRjg3RkMwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAzRkUxRjg3RkMwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRjgxRjgzRkYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRjgxRjgzRkYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRTAxRjgwM0YwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGRTAxRjgwM0YwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGMDAxRjgwMEYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDBGMDAxRjgwMEYwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAwMDAxRjgwMDAwMDAwMDAwMDBGMDAwMDAwMDAwCkYwMDAwMDAwMDAwMDAxRjgwMDAwMDAwMDAwMDBGMEZGREMxQzAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMEZGREMxQzAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDBDMUUzQzAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDBDMUUzQzAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDBDMUEyQzAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDBDMUI2QzAwCkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGRkZGMDBDMUI2QzAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDBDMUI2QzAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDBDMTlDQzAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDBDMTlDQzAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDBDMTlDQzAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDBDMTg4QzAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwCl5ETgpeRlQyMCw3OTBeQ1ZZXkJEMl5GSF9eRkQwMDM4NDA5ODEwNDAwMDBbKT5fMUUwMV8xRDk2MVowMDAwMzAxM18xRFVQU05fMUQyVlk5MTJfMUUwN0JJTjlHTjQuME44TzRFSUtLS0VSHCYgV18wRDMoSVMjK08tHCtBQyZHRDc1S1BfMERfMUVfMDReRlMKCl5GVDE1LDE4M15BME4sMjAsMjReRlZTVE9SRSA4OTE2XkZTCl5GVDE1LDIwMl5BME4sMjAsMjReRlY4NjYzODYxNTkwXkZTCl5GVDE1LDIyMV5BME4sMjAsMjReRlZDVlNeRlMKXkZUMTUsMjQxXkEwTiwyMCwyNF5GVjM4MjEgRUxMSVNPTiBEUklWRSBOT1JUSCBXRVNUXkZTCl5GVDE1LDI2MF5BME4sMjAsMjReRlZBTEJVUVVFUlFVRSAgTk0gODcxMTReRlMKXkZUNjAsMzQxXkEwTiwyNiwzMF5GVkVOUk9VVEVeRlMKXkZUNjAsMzY4XkEwTiwyNiwzMF5GVjQxODk5NzY2MTleRlMKXkZUNjAsMzk2XkEwTiwyNiwzMF5GVkVOUk9VVEVeRlMKXkZUNjAsNDIzXkEwTiwyNiwzMF5GVjEwMSBZRVNMRVIgQVZFXkZTCl5GVDYwLDQ2N15BME4sNDUsNDReRlZTRUFUVExFICBXQSA5ODEwNF5GUwpeRlQzODAsMTkwXkEwTiwzMCwzNF5GVjYgTEJTIF5GUwpeRlQ2NzMsMTk0XkEwTiwyOCwzMl5GViAxIE9GIDFeRlMKXkZUNTAwLDIyOV5BME4sMjIsMjZeRlZEV1Q6IDUsNSw1XkZTCl5GVDYyMCw4OTZeQTBOLDEwMCw3Nl5GViAgIF5GUwpeRk82NzcsODAwXkdCMTIzLDEyMywxMjJeRlMKCl5GVDMwMCw3NzheQlkzXkJDTiwxMDMsTixOLCxBXkZWNDIwOTgxMDReRlMKCl5GVDI5MCw2NTNeQTBOLDgwLDcwXkZWV0EgOTgxIDktMDVeRlMKXkZUMTAsODY0XkEwTiw1Niw1OF5GVlVQUyBHUk9VTkReRlMKXkZUMTAsODk3XkEwTiwyNiwzMF5GVlRSQUNLSU5HICM6IDFaIDJWWSA5MTIgMDMgMDAwMCAzMDEzXkZTCl5GTzAsOTIyXkdCODAwLDQsNF5GUwoKXkZUNzkwLDExOTleQTBOLDIyLDI2XkZWIF5GUwpeRlQxMCwxMTk1XkEwTiwyMiwyNl5GVkJJTExJTkc6IF5GUwpeRlQxMjYsMTE5NV5BME4sMjIsMjZeRlZQL1AgXkZTCl5GVDEwLDEzMTFeQTBOLDIyLDI2XkZWUmVmZXJlbmNlIE5vLjE6IGN2c15GUwpeRlQxMCwxMzMzXkEwTiwyMiwyNl5GVlJlZmVyZW5jZSBOby4yOiB0ZXN0XkZTCl5GVDE1LDMxM15BME4sMjgsMzJeRlZTSElQIFRPOiBeRlMKXkZPMCw3OTdeR0I3OTgsMTQsMTReRlMKCl5GTzAsMTE1N15HQjgwMCwxNCwxNF5GUwoKXkZPMCw1NzZeR0I4MDAsNCw0XkZTCgpeRk8yNDAsNTc2XkdCMywyMjEsM15GUwoKXkZUMTkwLDEzNDheQTBOLDE0LDIwXkZWWE9MIDE2LjA4LjAyICAgICAgICAgIE5WNDUgNzguMEEgMDcvMjAxNl5GUwpeRlQxMDUsMTE0Ml5CWTNeQkNOLDIwMixOLE4sLEFeRlYxWjJWWTkxMjAzMDAwMDMwMTNeRlMKCl5GVDI3MywxMDU2XkEwTiw5NSw3NF5GVlNBTVBMRV5GUwpeRk8xMCwxMF5BRE4sMTIsNl5GRFJlZjE6IGN2c15GUw0KXkZPMTAsMzVeQUROLDEyLDZeRkRSZWYyOiB0ZXN0XkZTDQpeRk8xMCw2MF5BRE4sMTIsNl5GRFJlZjM6IF5GUw0KXkZPMTAsODVeQUROLDEyLDZeRkRSZWY0OiBeRlMNCl5GTzI3NSwxMF5BRE4sMTIsNl5GRFNocERhdGU6IDIwMTYtMDktMjBeRlMNCl5GTzI3NSwzNV5BRE4sMTIsNl5GRENtdERhdGU6IF5GUw0KXkZPMjc1LDYwXkFETiwxMiw2XkZEV2VpZ2h0OiA1LjBeRlMNCl5GTzI3NSw4NV5BRE4sMTIsNl5GRENPRDogMC4wMF5GUw0KXkZPNTQwLDEwXkFETiwxMiw2XkZERGVjbFZhbDogMTAwLjAwXkZTDQpeRk81NDAsMzVeQUROLDEyLDZeRkRCYXNlIENoZzogXkZTDQpeRk81NDAsNjBeQUROLDEyLDZeRkRTdXIgQ2hnOiBeRlMNCl5GTzU0MCw4NV5BRE4sMTIsNl5GRE5ldCBDaGc6IDExLjYzXkZTDQpeRk8yMTAsMTEwXkFETiwxMiw2XkZEU3ZjczogIEdyb3VuZF5GUw0KXkZPMjQwLDEzMF5BRE4sMTIsNl5GRFRSQ0s6IDFaMlZZOTEyMDMwMDAwMzAxM15GUw0KXlhaXlhaCg==";
        public ide() {
            InitializeComponent();
        }

        private void Form1_FormClosed(Object sender, FormClosedEventArgs e) {
        }

        //////////////////////////////
        private void new_label_Click(Object sender, EventArgs e) {
            new_tab();
        }

        private void newToolStripMenuItem_Click(Object sender, EventArgs e) {
            new_tab();
        }
        private void openToolStripMenuItem_Click(Object sender, EventArgs e) {
            open_tab();
        }
        private void open_Click(Object sender, EventArgs e) {
            open_tab();
        }
        private void save_zpl_Click(Object sender, EventArgs e) {
            save_tab();
        }        
        private void saveToolStripMenuItem_Click(Object sender, EventArgs e) {
            save_tab();
        }        
        private void close_zpl_Click(Object sender, EventArgs e) {
            close_tab();
        }
        private void closeToolStripMenuItem_Click(Object sender, EventArgs e) {
            close_tab();
        }
        private void load_default_zpl_Click(Object sender, EventArgs e) {
            load_default_zpl_text();
        }
        private void loadDefaultZPLToolStripMenuItem_Click(Object sender, EventArgs e) {
            load_default_zpl_text();
        }
        private void toggleLabelZoomToolStripMenuItem_Click(Object sender, EventArgs e) {
            toggle_label_scale();
        }
        private void toggle_scale_Click(Object sender, EventArgs e) {
            toggle_label_scale();
        }        
        private void print_ZPL_Click(Object sender, EventArgs e) {
            print_to_zpl();
        }
        private void barCodePrinterToolStripMenuItem_Click(Object sender, EventArgs e) {
            print_to_zpl();
        }
        private void print_system_Click(Object sender, EventArgs e) {
            print_os();
        }
        private void systemPrinterToolStripMenuItem_Click(Object sender, EventArgs e) {
            print_os();
        }
        private void Paste_Click(Object sender, EventArgs e) {
            paste_text();
        }
        private void pasteToolStripMenuItem_Click(Object sender, EventArgs e) {
            paste_text();
        }
        private void Copy_Click(Object sender, EventArgs e) {
            copy_text();
        }

        private void copyToolStripMenuItem_Click(Object sender, EventArgs e) {
            copy_text();
        }
        private void save_image_Click_1(Object sender, EventArgs e) {
            save_label_image();
        }

        private void saveImageToolStripMenuItem_Click(Object sender, EventArgs e) {
            save_label_image();
        }
        private void saveAsToolStripMenuItem_Click(Object sender, EventArgs e) {
            save_as();
        }
        private void aboutToolStripMenuItem_Click(Object sender, EventArgs e) {
            IDE.about a=new IDE.about();
            a.Show();
        }

        //////////////////////////////
        public IDE.document get_control() {
            if(null==label_tab.SelectedTab) {
                //label_tab.t
                return null;
            }
            if (label_tab.SelectedTab.Controls.ContainsKey("editor")) {
                IDE.document control=(IDE.document)label_tab.SelectedTab.Controls["editor"];
                return control;
            }
            return null;
        }


        public void new_tab() {
            TabPage tp = new TabPage("New Label");
            label_tab.TabPages.Add(tp);
            IDE.document document=new IDE.document();
            document.Name="editor";
            document.Dock = DockStyle.Fill;
            tp.Controls.Add(document);
            label_tab.SelectedTab=tp;
        }

        public void open_tab() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse ZPL Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|ZPL files|*.zpl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                IDE.document document=new IDE.document();
                document.Dock = DockStyle.Fill;
                document.Name ="editor";
                document.load(openFileDialog1.FileName);
                TabPage tp = new TabPage(document.name);
                label_tab.TabPages.Add(tp);
                tp.Controls.Add(document);
                label_tab.SelectedTab=tp;
            }
        }

        public void save_tab() {
            IDE.document editor=get_control();
            if(null==editor) {
                MessageBox.Show("Nothing to save my friend.");
            } else {
                if(editor.edited) {
                    var confirmResult =  MessageBox.Show("Do you want to save this?",
                                         "Confirm Save",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if(string.IsNullOrWhiteSpace(editor.path)) {
                            save_as();
                        } else {
                            editor.save();
                        }
                    }else{
                    
                    }
                }
            }
        }
        public void save_as() {
            IDE.document editor=get_control();
            if(null==editor) {
                MessageBox.Show("Nothing to save my friend.");
            } else {
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                 saveFileDialog1.Filter = "Text files (*.txt)|*.txt|ZPL files|*.zpl|All files (*.*)|*.*";
                 saveFileDialog1.FilterIndex = 1;
                 saveFileDialog1.RestoreDirectory = true ;

                 if(saveFileDialog1.ShowDialog() == DialogResult.OK){
                    editor.save_as(saveFileDialog1.FileName);
                }
            }
        }
        public void close_tab() {
            IDE.document editor=get_control();
            if(null==editor) {
                MessageBox.Show("Nothing to close my friend.");
            } else {
                if(editor.edited) {
                    save_tab();
                }
                label_tab.TabPages.Remove(label_tab.SelectedTab);
            }
        }
        public void load_default_zpl_text() {
            IDE.document editor=get_control();
            if(null==editor) {
                new_tab();
                editor=get_control();
            }
            if(null==editor) {
                MessageBox.Show("Nothing to ionsert the text into!");
            } else {
                editor.new_text(default_zpl);
            }
        }
        public void toggle_label_scale() {
            IDE.document editor=get_control();
            if(null!=editor) {
                editor.toggle_scale();
            }         
        }
        public void print_to_zpl() {
            IDE.document editor=get_control();
            if(null!=editor) {
                editor.print_to_zpl();
            }
        }
        void print_os() {
            IDE.document editor=get_control();
            if(null!=editor) {
                editor.print_to_os();
            }
        }
        public void paste_text() {
            IDE.document editor=get_control();
            if(null==editor) {
                new_tab();
                editor=get_control();
            }
            if(null!=editor) {
                IDataObject iData = Clipboard.GetDataObject();
                if(iData.GetDataPresent(DataFormats.Text)) {            // Determines whether the data is in a format you can use.
                    editor.new_text((String)iData.GetData(DataFormats.Text));
                }//end if clipboard is text type
            }
        }
        public void copy_text() {
            IDE.document editor=get_control();
            if(null!=editor) {
                string text=editor.get_text();
                if(!string.IsNullOrWhiteSpace(text)) {
                    Clipboard.SetText(text);
                } else {
                    MessageBox.Show("Nothing to copy.");
                }
            }
        }
        public void save_label_image() {
            IDE.document editor=get_control();
            if(null!=editor) {
                editor.save_image();
            }
        }
        private void label_tab_SelectedIndexChanged(Object sender, EventArgs e) {

        }//end function
    }//end class
}//end namespace
