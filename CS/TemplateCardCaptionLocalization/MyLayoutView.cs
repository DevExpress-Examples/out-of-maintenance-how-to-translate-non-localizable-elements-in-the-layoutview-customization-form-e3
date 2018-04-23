using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Layout.Customization;
using DevExpress.Skins;
using System.Windows.Forms;
using System.Reflection;
using System;

namespace TemplateCardCaptionLocalization {
    public class MyLayoutView :LayoutView {
        public MyLayoutView() : base() { }
        public MyLayoutView(GridControl grid) : base(grid) { }

        internal const string MyLayoutViewName = "MyLayoutView";
        protected override string ViewName {
            get { return MyLayoutViewName; }
        }

        protected override LayoutViewCustomizationForm CreateCustomizationForm() {
            SkinManager.EnableFormSkins();
            LayoutViewCustomizationForm form = new MyLayoutViewCustomizationForm(this);
            form.FormClosing += OnCustomizationFormClosing;
            return form;
        }

        void OnCustomizationFormClosing(object sender, FormClosingEventArgs e) {
            typeof(LayoutView).GetMethod("OnCustomizationFormClosing", BindingFlags.Instance |
                BindingFlags.NonPublic, null, new Type[] { typeof(object), typeof(FormClosingEventArgs) },
                new ParameterModifier[0]).Invoke(this, new object[] { sender, e });
        }
    }
}