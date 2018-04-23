using DevExpress.XtraGrid.Views.Layout.Customization;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.Designer;

namespace TemplateCardCaptionLocalization {
    public class MyLayoutViewCustomizationForm :LayoutViewCustomizationForm {
        public MyLayoutViewCustomizationForm(LayoutView view) : base(view) { }

        protected override LayoutViewCustomizer CreateCustomizer() {
            return new MyLayoutViewCustomizer();
        }
    }
}