using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace TemplateCardCaptionLocalization {
    public class MyLayoutViewInfoRegistrator :LayoutViewInfoRegistrator {
        public override string ViewName {
            get { return MyLayoutView.MyLayoutViewName; }
        }

        public override BaseView CreateView(GridControl grid) {
            return new MyLayoutView(grid);
        }
    }
}