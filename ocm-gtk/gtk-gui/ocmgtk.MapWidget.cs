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
    
    
    public partial class MapWidget {
        
        private Gtk.VBox mapVBox;
        
        private Gtk.ScrolledWindow mapScroll;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.MapWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "ocmgtk.MapWidget";
            // Container child ocmgtk.MapWidget.Gtk.Container+ContainerChild
            this.mapVBox = new Gtk.VBox();
            this.mapVBox.Name = "mapVBox";
            this.mapVBox.Spacing = 6;
            // Container child mapVBox.Gtk.Box+BoxChild
            this.mapScroll = new Gtk.ScrolledWindow();
            this.mapScroll.CanFocus = true;
            this.mapScroll.Name = "mapScroll";
            this.mapScroll.ShadowType = ((Gtk.ShadowType)(1));
            this.mapVBox.Add(this.mapScroll);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.mapVBox[this.mapScroll]));
            w1.Position = 0;
            this.Add(this.mapVBox);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}