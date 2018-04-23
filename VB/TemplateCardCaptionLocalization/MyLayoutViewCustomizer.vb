Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Layout.Designer
Imports System.Windows.Forms

Namespace TemplateCardCaptionLocalization
	Public Class MyLayoutViewCustomizer
		Inherits LayoutViewCustomizer
		Protected Overrides Function CreateDesignerHelper() As LayoutViewDesignerHelper
			Return New MyLayoutViewDesignerHelper(Me, EditingLayoutView)
		End Function

		Protected Overrides Sub CreateTemplateCardTabPage()
			MyBase.CreateTemplateCardTabPage()
			designerSettingsControl.Dispose()
			designerSettingsControl = New MyDesignerControlSettingsManager(Me, DesignerHelper.DesignerControl)
			designerSettingsControl.Parent = designerCardSettingsScroller
			designerSettingsControl.Dock = DockStyle.Fill
		End Sub
	End Class
End Namespace