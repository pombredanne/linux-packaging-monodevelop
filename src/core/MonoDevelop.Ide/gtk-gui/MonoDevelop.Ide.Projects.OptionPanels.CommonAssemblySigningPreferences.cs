
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Projects.OptionPanels
{
	internal partial class CommonAssemblySigningPreferences
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.CheckButton signAssemblyCheckbutton;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label strongNameFileLabel;
		private global::MonoDevelop.Components.FileEntry strongNameFileEntry;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Projects.OptionPanels.CommonAssemblySigningPreferences
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.Projects.OptionPanels.CommonAssemblySigningPreferences";
			// Container child MonoDevelop.Ide.Projects.OptionPanels.CommonAssemblySigningPreferences.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.signAssemblyCheckbutton = new global::Gtk.CheckButton ();
			this.signAssemblyCheckbutton.CanFocus = true;
			this.signAssemblyCheckbutton.Name = "signAssemblyCheckbutton";
			this.signAssemblyCheckbutton.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("_Sign this assembly");
			this.signAssemblyCheckbutton.DrawIndicator = true;
			this.signAssemblyCheckbutton.UseUnderline = true;
			this.vbox1.Add (this.signAssemblyCheckbutton);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.signAssemblyCheckbutton]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.strongNameFileLabel = new global::Gtk.Label ();
			this.strongNameFileLabel.Name = "strongNameFileLabel";
			this.strongNameFileLabel.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("S_trong Name File:");
			this.strongNameFileLabel.UseUnderline = true;
			this.hbox1.Add (this.strongNameFileLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.strongNameFileLabel]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.strongNameFileEntry = new global::MonoDevelop.Components.FileEntry ();
			this.strongNameFileEntry.Name = "strongNameFileEntry";
			this.hbox1.Add (this.strongNameFileEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.strongNameFileEntry]));
			w3.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
