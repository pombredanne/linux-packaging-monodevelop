
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Refactoring.IntroduceConstant
{
	public partial class IntroduceConstantDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox comboboxModifiers;
		private global::Gtk.Entry entry;
		private global::Gtk.Label label1;
		private global::Gtk.Label labelNewName;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Image imageWarning;
		private global::Gtk.Label labelWarning;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonPreview;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Refactoring.IntroduceConstant.IntroduceConstantDialog
			this.Name = "MonoDevelop.Refactoring.IntroduceConstant.IntroduceConstantDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Introduce Constant");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.Refactoring.IntroduceConstant.IntroduceConstantDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxModifiers = global::Gtk.ComboBox.NewText ();
			this.comboboxModifiers.Name = "comboboxModifiers";
			this.table1.Add (this.comboboxModifiers);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxModifiers]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry = new global::Gtk.Entry ();
			this.entry.CanFocus = true;
			this.entry.Name = "entry";
			this.entry.IsEditable = true;
			this.entry.InvisibleChar = '●';
			this.table1.Add (this.entry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Access modifier:");
			this.label1.UseUnderline = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelNewName = new global::Gtk.Label ();
			this.labelNewName.Name = "labelNewName";
			this.labelNewName.Xalign = 0F;
			this.labelNewName.LabelProp = global::Mono.Unix.Catalog.GetString ("_Constant name:");
			this.labelNewName.UseUnderline = true;
			this.table1.Add (this.labelNewName);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelNewName]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.imageWarning = new global::Gtk.Image ();
			this.imageWarning.Name = "imageWarning";
			this.imageWarning.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Button);
			this.hbox3.Add (this.imageWarning);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.imageWarning]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelWarning = new global::Gtk.Label ();
			this.labelWarning.Name = "labelWarning";
			this.hbox3.Add (this.labelWarning);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelWarning]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Internal child MonoDevelop.Refactoring.IntroduceConstant.IntroduceConstantDialog.ActionArea
			global::Gtk.HButtonBox w11 = this.ActionArea;
			w11.Name = "dialog1_ActionArea";
			w11.Spacing = 10;
			w11.BorderWidth = ((uint)(5));
			w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonCancel]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPreview = new global::Gtk.Button ();
			this.buttonPreview.CanFocus = true;
			this.buttonPreview.Name = "buttonPreview";
			this.buttonPreview.UseUnderline = true;
			this.buttonPreview.Label = global::Mono.Unix.Catalog.GetString ("_Preview");
			this.AddActionWidget (this.buttonPreview, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonPreview]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonOk]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 390;
			this.DefaultHeight = 162;
			this.labelNewName.MnemonicWidget = this.entry;
			this.Hide ();
		}
	}
}
