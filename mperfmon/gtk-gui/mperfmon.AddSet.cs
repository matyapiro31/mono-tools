// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace mperfmon {
    
    
    public partial class AddSet {
        
        private Gtk.Table table1;
        
        private Gtk.ComboBox counterset;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView instances;
        
        private Gtk.Label label1;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget mperfmon.AddSet
            this.Name = "mperfmon.AddSet";
            this.Title = Mono.Unix.Catalog.GetString("Add a counter set");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child mperfmon.AddSet.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.counterset = Gtk.ComboBox.NewText();
            this.counterset.Name = "counterset";
            this.table1.Add(this.counterset);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.counterset]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.instances = new Gtk.TreeView();
            this.instances.CanFocus = true;
            this.instances.Name = "instances";
            this.instances.HeadersClickable = true;
            this.GtkScrolledWindow.Add(this.instances);
            this.table1.Add(this.GtkScrolledWindow);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.RightAttach = ((uint)(2));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Counter set:");
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            w1.Add(this.table1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(w1[this.table1]));
            w6.Position = 0;
            // Internal child mperfmon.AddSet.ActionArea
            Gtk.HButtonBox w7 = this.ActionArea;
            w7.Name = "dialog1_ActionArea";
            w7.Spacing = 6;
            w7.BorderWidth = ((uint)(5));
            w7.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.buttonCancel]));
            w8.Expand = false;
            w8.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.buttonOk]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.counterset.Changed += new System.EventHandler(this.OnSetSelected);
        }
    }
}
