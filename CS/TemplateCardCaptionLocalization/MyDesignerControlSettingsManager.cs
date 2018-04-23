using DevExpress.XtraGrid.Views.Layout.Designer;
using DevExpress.XtraLayout;
using TemplateCardCaptionLocalization.Properties;
using DevExpress.XtraEditors.Controls;

namespace TemplateCardCaptionLocalization {
    public class MyDesignerControlSettingsManager :DesignerControlSettingsManager {
        public MyDesignerControlSettingsManager(LayoutViewCustomizer customizer, LayoutControl targetLayoutControl)
            : base(customizer, targetLayoutControl) { }

        protected override void SetDefaultValues() {
            ItemsCaptionLocationControl.Properties.Items.Clear();
            GroupsCaptionLocationControl.Properties.Items.Clear();
            CardTextAlignment.Properties.Items.Clear();
            base.SetDefaultValues();
            LocalizeComboBoxItems(ItemsCaptionLocationControl.Properties.Items);
            LocalizeComboBoxItems(GroupsCaptionLocationControl.Properties.Items);
            LocalizeComboBoxItems(CardTextAlignment.Properties.Items);
        }

        void LocalizeComboBoxItems(ImageComboBoxItemCollection items) {
            foreach (ImageComboBoxItem item in items)
                item.Description = LocalizeItemCaption(item.Description);
        }

        string LocalizeItemCaption(string defaultCaption) {
            switch (defaultCaption) {
                case "Default": return Resources.Locations_Default;
                case "Left": return Resources.Locations_Left;
                case "Right": return Resources.Locations_Right;
                case "Top": return Resources.Locations_Top;
                case "Bottom": return Resources.Locations_Bottom;
                case "AlignGlobal": return Resources.FieldTextAlignMode_AlignGlobal;
                case "AutoSize": return Resources.FieldTextAlignMode_AutoSize;
                case "CustomSize": return Resources.FieldTextAlignMode_CustomSize;
                default: return defaultCaption;
            }
        }
    }
}