using DevExpress.XtraGrid.Views.Layout.Designer;
using System.Windows.Forms;

namespace TemplateCardCaptionLocalization {
    public class MyLayoutViewCustomizer :LayoutViewCustomizer {
        protected override LayoutViewDesignerHelper CreateDesignerHelper() {
            return new MyLayoutViewDesignerHelper(this, EditingLayoutView);
        }

        protected override void CreateTemplateCardTabPage() {
            base.CreateTemplateCardTabPage();
            designerSettingsControl.Dispose();
            designerSettingsControl = new MyDesignerControlSettingsManager(this, DesignerHelper.DesignerControl);
            designerSettingsControl.Parent = designerCardSettingsScroller;
            designerSettingsControl.Dock = DockStyle.Fill;
        }
    }
}