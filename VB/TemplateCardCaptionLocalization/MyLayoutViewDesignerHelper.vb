Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid.Views.Layout.Designer
Imports DevExpress.XtraGrid.Views.Layout

Namespace TemplateCardCaptionLocalization
	Public Class MyLayoutViewDesignerHelper
		Inherits LayoutViewDesignerHelper
		Public Sub New(ByVal customizer As LayoutViewCustomizer, ByVal view As LayoutView)
			MyBase.New(customizer, view)
		End Sub

		Public Overrides Sub SynchronizeDesignerFromView(ByVal view As LayoutView)
			MyBase.SynchronizeDesignerFromView(view)
            DesignerControl.Root.Text = Global.Resources.LayoutViewDesignerHelper_DesigherControl_Root_Text
		End Sub
	End Class
End Namespace