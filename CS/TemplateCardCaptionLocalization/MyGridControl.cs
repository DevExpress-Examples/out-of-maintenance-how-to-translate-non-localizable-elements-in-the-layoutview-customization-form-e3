using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;

namespace TemplateCardCaptionLocalization {
    public class MyGridControl :GridControl {
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyLayoutViewInfoRegistrator());
        }
    }
}