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
    
    
    public partial class MagellanExploristWidget {
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox3;
        
        private Gtk.CheckButton limitCheck;
        
        private Gtk.Entry limitEntry;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label3;
        
        private Gtk.Entry fileEntry;
        
        private Gtk.Button fileButton;
        
        private Gtk.Image image3;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.MagellanExploristWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "ocmgtk.MagellanExploristWidget";
            // Container child ocmgtk.MagellanExploristWidget.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            this.vbox3.BorderWidth = ((uint)(6));
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.limitCheck = new Gtk.CheckButton();
            this.limitCheck.CanFocus = true;
            this.limitCheck.Name = "limitCheck";
            this.limitCheck.Label = Mono.Unix.Catalog.GetString("Limit Number of Caches");
            this.limitCheck.DrawIndicator = true;
            this.limitCheck.UseUnderline = true;
            this.hbox3.Add(this.limitCheck);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox3[this.limitCheck]));
            w1.Position = 0;
            w1.Expand = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.limitEntry = new Gtk.Entry();
            this.limitEntry.Sensitive = false;
            this.limitEntry.CanFocus = true;
            this.limitEntry.Name = "limitEntry";
            this.limitEntry.Text = "1000";
            this.limitEntry.IsEditable = true;
            this.limitEntry.InvisibleChar = '•';
            this.hbox3.Add(this.limitEntry);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox3[this.limitEntry]));
            w2.Position = 1;
            this.vbox3.Add(this.hbox3);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Serial Port or File:");
            this.hbox4.Add(this.label3);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox4[this.label3]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.fileEntry = new Gtk.Entry();
            this.fileEntry.CanFocus = true;
            this.fileEntry.Name = "fileEntry";
            this.fileEntry.Text = "/dev/ttyS0";
            this.fileEntry.IsEditable = true;
            this.fileEntry.InvisibleChar = '•';
            this.hbox4.Add(this.fileEntry);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox4[this.fileEntry]));
            w5.Position = 1;
            // Container child hbox4.Gtk.Box+BoxChild
            this.fileButton = new Gtk.Button();
            this.fileButton.CanFocus = true;
            this.fileButton.Name = "fileButton";
            // Container child fileButton.Gtk.Container+ContainerChild
            this.image3 = new Gtk.Image();
            this.image3.Name = "image3";
            this.image3.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-open", Gtk.IconSize.Menu, 16);
            this.fileButton.Add(this.image3);
            this.fileButton.Label = null;
            this.hbox4.Add(this.fileButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox4[this.fileButton]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox3.Add(this.hbox4);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.Add(this.vbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}