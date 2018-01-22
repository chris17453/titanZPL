using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace titanZPL {
    public class file_manager {
        public ListBox history=null;
        public file current_file;
        [Serializable]
        public class file {
            public string   calc_name   {get { if(edited) return "*"+name; else return name; } set { } }
            public string   type        {get; set; }   ="file";
            public string   name        {get; set; }   ="";
            public string   path        {get; set; }   ="";
            public string   ZPL         {get; set; }   ="";
            public bool     edited      {get; set; }   =false;
            public string   edited_ZPL  {get; set; }   ="";
            public bool     current_file{get; set; }   =true;

            public file() {
            }
        }


        public BindingList<file> files=new BindingList<file>();

        public void open(string filename) {
            try {
                foreach(file item in files) {                               //mark all the files NOT curent
                    item.current_file=false;
                }
                foreach(file item in files) {                               //if its already open.. just switch
                    if(item.path==filename) {
                        current_file=item;
                        current_file.current_file=true;
                        history.SelectedItem=current_file;
                        return;
                    }
                }

                string ZPL= System.IO.File.ReadAllText(filename);           //not open? lets load it and add it to the list
                file f  =new file();
                f.path  =filename;
                f.ZPL   =ZPL;
                f.type  ="file";
                f.name  =Path.GetFileName(filename);
                f.current_file=true;
                current_file=f;
                files.Add(f);

            } catch(Exception ex) {
            }
            save_history();
        }
        public void load_history() {
            try{
                using (Stream stream = File.Open("history.bin", FileMode.Open)){
                    BinaryFormatter bin = new BinaryFormatter();
                    if(stream.Length>0) {
                        files=(BindingList<file>)bin.Deserialize(stream);
                    }
                }
                foreach(file item in files) {                      //mark all the files NOT curent
                    if(item.current_file==true) {
                        current_file =item;
                        history.SelectedItem=current_file;
                    }
                }

            }catch (IOException){
            }
            //update_listbox();
            history.DataSource=files;
            history.DisplayMember="calc_name";
            history.ValueMember  ="path";
            history.SelectedItem =current_file;

        }

        public void save_history() {
            try{
                using (Stream stream = File.Open("history.bin", FileMode.Create)){
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, files);
                }
            }catch (IOException){
            }
        }
        public void load_selected() {
            foreach(file item in files) {                               //mark all the files NOT curent
                item.current_file=false;
            }
            foreach(file item in files) {                               //if its already open.. just switch
                if(history.SelectedItem==item) {
                    current_file=item;
                    current_file.current_file=true;
                    return;
                }
            }
        }
        public void close() {
            files.Remove(current_file);
            if(files.Count>0) {
                current_file =files[0];
                current_file.current_file=true;
                history.SelectedItem=current_file;
            }
            else current_file=null;
        }
        public void save() {
            System.IO.File.WriteAllText(current_file.path,current_file.edited_ZPL);
        }
        public string get_text() {
            if(current_file.edited) return current_file.edited_ZPL;
            else return current_file.ZPL;
        }
    }//end class
}//end namespace
