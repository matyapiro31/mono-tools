// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace guicompare {
    
    
    public partial class ProviderSelector {
        
        private Gtk.Table table2;
        
        private Gtk.FileChooserButton filechooserbutton1;
        
        private Gtk.FileChooserButton filechooserbutton2;
        
        private Gtk.Label label2;
        
        private Gtk.RadioButton radiobutton1;
        
        private Gtk.RadioButton radiobutton2;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget guicompare.ProviderSelector
            Stetic.BinContainer.Attach(this);
            this.Name = "guicompare.ProviderSelector";
            // Container child guicompare.ProviderSelector.Gtk.Container+ContainerChild
            this.table2 = new Gtk.Table(((uint)(4)), ((uint)(2)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            this.table2.BorderWidth = ((uint)(4));
            // Container child table2.Gtk.Table+TableChild
            this.filechooserbutton1 = new Gtk.FileChooserButton(Mono.Unix.Catalog.GetString("Select A File"), ((Gtk.FileChooserAction)(0)));
            this.filechooserbutton1.Name = "filechooserbutton1";
            this.table2.Add(this.filechooserbutton1);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table2[this.filechooserbutton1]));
            w1.TopAttach = ((uint)(1));
            w1.BottomAttach = ((uint)(2));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.filechooserbutton2 = new Gtk.FileChooserButton(Mono.Unix.Catalog.GetString("Select A File"), ((Gtk.FileChooserAction)(0)));
            this.filechooserbutton2.Name = "filechooserbutton2";
            this.table2.Add(this.filechooserbutton2);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table2[this.filechooserbutton2]));
            w2.TopAttach = ((uint)(3));
            w2.BottomAttach = ((uint)(4));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xpad = 8;
            this.label2.LabelProp = "";
            this.table2.Add(this.label2);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table2[this.label2]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.radiobutton1 = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("API Description"));
            this.radiobutton1.CanFocus = true;
            this.radiobutton1.Name = "radiobutton1";
            this.radiobutton1.Active = true;
            this.radiobutton1.DrawIndicator = true;
            this.radiobutton1.UseUnderline = true;
            this.radiobutton1.Group = new GLib.SList(System.IntPtr.Zero);
            this.table2.Add(this.radiobutton1);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table2[this.radiobutton1]));
            w4.RightAttach = ((uint)(2));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.radiobutton2 = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Assembly"));
            this.radiobutton2.CanFocus = true;
            this.radiobutton2.Name = "radiobutton2";
            this.radiobutton2.DrawIndicator = true;
            this.radiobutton2.UseUnderline = true;
            this.radiobutton2.Group = this.radiobutton1.Group;
            this.table2.Add(this.radiobutton2);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table2[this.radiobutton2]));
            w5.TopAttach = ((uint)(2));
            w5.BottomAttach = ((uint)(3));
            w5.RightAttach = ((uint)(2));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            this.Add(this.table2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.filechooserbutton2.FocusChildSet += new Gtk.FocusChildSetHandler(this.OnFilechooserbutton2FocusChildSet);
        }
    }
}
