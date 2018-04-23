using DevExpress.XtraGrid.Views.Layout.Designer;
using DevExpress.XtraGrid.Views.Layout;
using TemplateCardCaptionLocalization.Properties;

namespace TemplateCardCaptionLocalization {
    public class MyLayoutViewDesignerHelper :LayoutViewDesignerHelper {
        public MyLayoutViewDesignerHelper(LayoutViewCustomizer customizer, LayoutView view)
            : base(customizer, view) { }

        public override void SynchronizeDesignerFromView(LayoutView view) {
            base.SynchronizeDesignerFromView(view);
            DesignerControl.Root.Text = Resources.LayoutViewDesignerHelper_DesigherControl_Root_Text;
        }
    }
}