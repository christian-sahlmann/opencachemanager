// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class GPXWidget {
        
        private Gtk.VBox vbox3;
        
        private Gtk.Table table1;
        
        private Gtk.CheckButton limitCheck;
        
        private Gtk.Entry limitEntry;
        
        private Gtk.CheckButton logLimitCheck;
        
        private Gtk.Entry logLimitEntry;
        
        private Gtk.Table table2;
        
        private Gtk.CheckButton attrCheck;
        
        private Gtk.RadioButton autoNameRado;
        
        private Gtk.Button fieldBrowseButton;
        
        private Gtk.Image image21;
        
        private Gtk.Entry fieldNotesEntry;
        
        private Gtk.Button fileButton2;
        
        private Gtk.Image image5;
        
        private Gtk.Entry fileEntry;
        
        private Gtk.Label label1;
        
        private Gtk.RadioButton useFileRadio;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.GPXWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "ocmgtk.GPXWidget";
            // Container child ocmgtk.GPXWidget.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            this.vbox3.BorderWidth = ((uint)(6));
            // Container child vbox3.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.limitCheck = new Gtk.CheckButton();
            this.limitCheck.CanFocus = true;
            this.limitCheck.Name = "limitCheck";
            this.limitCheck.Label = Mono.Unix.Catalog.GetString("Limit Number of Caches");
            this.limitCheck.DrawIndicator = true;
            this.limitCheck.UseUnderline = true;
            this.table1.Add(this.limitCheck);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table1[this.limitCheck]));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.limitEntry = new Gtk.Entry();
            this.limitEntry.Sensitive = false;
            this.limitEntry.CanFocus = true;
            this.limitEntry.Name = "limitEntry";
            this.limitEntry.Text = "1000";
            this.limitEntry.IsEditable = true;
            this.limitEntry.InvisibleChar = '•';
            this.table1.Add(this.limitEntry);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.limitEntry]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.logLimitCheck = new Gtk.CheckButton();
            this.logLimitCheck.CanFocus = true;
            this.logLimitCheck.Name = "logLimitCheck";
            this.logLimitCheck.Label = Mono.Unix.Catalog.GetString("Limit Number of Logs");
            this.logLimitCheck.Active = true;
            this.logLimitCheck.DrawIndicator = true;
            this.logLimitCheck.UseUnderline = true;
            this.table1.Add(this.logLimitCheck);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.logLimitCheck]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.logLimitEntry = new Gtk.Entry();
            this.logLimitEntry.CanFocus = true;
            this.logLimitEntry.Name = "logLimitEntry";
            this.logLimitEntry.Text = Mono.Unix.Catalog.GetString("5");
            this.logLimitEntry.IsEditable = true;
            this.logLimitEntry.InvisibleChar = '•';
            this.table1.Add(this.logLimitEntry);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.logLimitEntry]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox3.Add(this.table1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.table1]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(4)), ((uint)(3)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.attrCheck = new Gtk.CheckButton();
            this.attrCheck.CanFocus = true;
            this.attrCheck.Name = "attrCheck";
            this.attrCheck.Label = Mono.Unix.Catalog.GetString("Include Attributes in Description");
            this.attrCheck.Active = true;
            this.attrCheck.DrawIndicator = true;
            this.attrCheck.UseUnderline = true;
            this.table2.Add(this.attrCheck);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table2[this.attrCheck]));
            w6.RightAttach = ((uint)(2));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.autoNameRado = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Auto name on internal drive"));
            this.autoNameRado.CanFocus = true;
            this.autoNameRado.Name = "autoNameRado";
            this.autoNameRado.Active = true;
            this.autoNameRado.DrawIndicator = true;
            this.autoNameRado.UseUnderline = true;
            this.autoNameRado.Group = new GLib.SList(System.IntPtr.Zero);
            this.table2.Add(this.autoNameRado);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table2[this.autoNameRado]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.fieldBrowseButton = new Gtk.Button();
            this.fieldBrowseButton.CanFocus = true;
            this.fieldBrowseButton.Name = "fieldBrowseButton";
            // Container child fieldBrowseButton.Gtk.Container+ContainerChild
            this.image21 = new Gtk.Image();
            this.image21.Name = "image21";
            this.image21.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-open", Gtk.IconSize.Button, 20);
            this.fieldBrowseButton.Add(this.image21);
            this.fieldBrowseButton.Label = null;
            this.table2.Add(this.fieldBrowseButton);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table2[this.fieldBrowseButton]));
            w9.TopAttach = ((uint)(3));
            w9.BottomAttach = ((uint)(4));
            w9.LeftAttach = ((uint)(2));
            w9.RightAttach = ((uint)(3));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.fieldNotesEntry = new Gtk.Entry();
            this.fieldNotesEntry.CanFocus = true;
            this.fieldNotesEntry.Name = "fieldNotesEntry";
            this.fieldNotesEntry.Text = "/media/GARMIN/Garmin/geocache_visits.txt";
            this.fieldNotesEntry.IsEditable = true;
            this.fieldNotesEntry.InvisibleChar = '•';
            this.table2.Add(this.fieldNotesEntry);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table2[this.fieldNotesEntry]));
            w10.TopAttach = ((uint)(3));
            w10.BottomAttach = ((uint)(4));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.fileButton2 = new Gtk.Button();
            this.fileButton2.CanFocus = true;
            this.fileButton2.Name = "fileButton2";
            // Container child fileButton2.Gtk.Container+ContainerChild
            this.image5 = new Gtk.Image();
            this.image5.Name = "image5";
            this.image5.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-open", Gtk.IconSize.Menu, 16);
            this.fileButton2.Add(this.image5);
            this.fileButton2.Label = null;
            this.table2.Add(this.fileButton2);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table2[this.fileButton2]));
            w12.TopAttach = ((uint)(2));
            w12.BottomAttach = ((uint)(3));
            w12.LeftAttach = ((uint)(2));
            w12.RightAttach = ((uint)(3));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.fileEntry = new Gtk.Entry();
            this.fileEntry.CanFocus = true;
            this.fileEntry.Name = "fileEntry";
            this.fileEntry.Text = "/media/GARMIN/Garmin/GPX/geocaches.gpx";
            this.fileEntry.IsEditable = true;
            this.fileEntry.InvisibleChar = '•';
            this.table2.Add(this.fileEntry);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table2[this.fileEntry]));
            w13.TopAttach = ((uint)(2));
            w13.BottomAttach = ((uint)(3));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Field Notes File:");
            this.table2.Add(this.label1);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table2[this.label1]));
            w14.TopAttach = ((uint)(3));
            w14.BottomAttach = ((uint)(4));
            w14.XOptions = ((Gtk.AttachOptions)(4));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.useFileRadio = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Use specified file:"));
            this.useFileRadio.CanFocus = true;
            this.useFileRadio.Name = "useFileRadio";
            this.useFileRadio.DrawIndicator = true;
            this.useFileRadio.UseUnderline = true;
            this.useFileRadio.Group = this.autoNameRado.Group;
            this.table2.Add(this.useFileRadio);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table2[this.useFileRadio]));
            w15.TopAttach = ((uint)(2));
            w15.BottomAttach = ((uint)(3));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox3.Add(this.table2);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox3[this.table2]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            this.Add(this.vbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.logLimitCheck.Toggled += new System.EventHandler(this.OnLogLimitToggle);
            this.limitCheck.Toggled += new System.EventHandler(this.OnLimitToggle);
            this.fileButton2.Clicked += new System.EventHandler(this.OnFileClick);
        }
    }
}