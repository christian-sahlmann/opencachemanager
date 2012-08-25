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
    
    
    public partial class SetupAssistantPage3 {
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label label17;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Table table1;
        
        private Gtk.Button button180;
        
        private Gtk.Label label1;
        
        private Gtk.Label label14;
        
        private Gtk.Label label15;
        
        private ocmgtk.CoordinateWidget latEntry;
        
        private ocmgtk.CoordinateWidget lonEntry;
        
        private Gtk.Entry ownerEntry;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.SetupAssistantPage3
            Stetic.BinContainer.Attach(this);
            this.Name = "ocmgtk.SetupAssistantPage3";
            // Container child ocmgtk.SetupAssistantPage3.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            this.vbox3.BorderWidth = ((uint)(6));
            // Container child vbox3.Gtk.Box+BoxChild
            this.label17 = new Gtk.Label();
            this.label17.Name = "label17";
            this.label17.LabelProp = Mono.Unix.Catalog.GetString("Finally, you need to enter your home coordinates and user ID so that OCM can correctly calculate the distance to caches from your home and correctly identify which caches are yours. \n\nIf you don't know these settings and are a Geocaching.com user, click on <b>\"View Account Online...\"</b> to see your information from Geocaching.com\n\nYou can also set your home location later using the map in OCM. Scroll the map to your home location, right-click on the map and select <b>Set as Home</b>.");
            this.label17.UseMarkup = true;
            this.label17.Wrap = true;
            this.label17.WidthChars = 60;
            this.vbox3.Add(this.label17);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox3[this.label17]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(5)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.button180 = new Gtk.Button();
            this.button180.CanFocus = true;
            this.button180.Name = "button180";
            this.button180.UseUnderline = true;
            this.button180.Label = Mono.Unix.Catalog.GetString("View Account Online...");
            this.table1.Add(this.button180);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.button180]));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("You can enter either your account ID or user name to help OCM identify your caches and finds");
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w3.TopAttach = ((uint)(3));
            w3.BottomAttach = ((uint)(4));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(0));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label14 = new Gtk.Label();
            this.label14.Name = "label14";
            this.label14.Xalign = 0F;
            this.label14.LabelProp = Mono.Unix.Catalog.GetString("Home Latitude:");
            this.table1.Add(this.label14);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.label14]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label15 = new Gtk.Label();
            this.label15.Name = "label15";
            this.label15.Xalign = 0F;
            this.label15.LabelProp = Mono.Unix.Catalog.GetString("Home Longitude:");
            this.table1.Add(this.label15);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.label15]));
            w5.TopAttach = ((uint)(2));
            w5.BottomAttach = ((uint)(3));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.latEntry = new ocmgtk.CoordinateWidget();
            this.latEntry.Events = ((Gdk.EventMask)(256));
            this.latEntry.Name = "latEntry";
            this.table1.Add(this.latEntry);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.latEntry]));
            w6.TopAttach = ((uint)(1));
            w6.BottomAttach = ((uint)(2));
            w6.LeftAttach = ((uint)(1));
            w6.RightAttach = ((uint)(2));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.lonEntry = new ocmgtk.CoordinateWidget();
            this.lonEntry.Events = ((Gdk.EventMask)(256));
            this.lonEntry.Name = "lonEntry";
            this.table1.Add(this.lonEntry);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.lonEntry]));
            w7.TopAttach = ((uint)(2));
            w7.BottomAttach = ((uint)(3));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.ownerEntry = new Gtk.Entry();
            this.ownerEntry.CanFocus = true;
            this.ownerEntry.Name = "ownerEntry";
            this.ownerEntry.IsEditable = true;
            this.ownerEntry.InvisibleChar = '•';
            this.table1.Add(this.ownerEntry);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.ownerEntry]));
            w8.TopAttach = ((uint)(4));
            w8.BottomAttach = ((uint)(5));
            w8.RightAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            this.hbox2.Add(this.table1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox2[this.table1]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            this.vbox3.Add(this.hbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            this.Add(this.vbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.button180.Clicked += new System.EventHandler(this.OnAccountInfoClicked);
        }
    }
}