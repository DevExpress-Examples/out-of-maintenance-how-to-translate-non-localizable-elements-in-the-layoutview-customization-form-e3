Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid.Views.Layout.Customization
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.Designer

Namespace TemplateCardCaptionLocalization
	Public Class MyLayoutViewCustomizationForm
		Inherits LayoutViewCustomizationForm
		Public Sub New(ByVal view As LayoutView)
			MyBase.New(view)
		End Sub

		Protected Overrides Function CreateCustomizer() As LayoutViewCustomizer
			Return New MyLayoutViewCustomizer()
		End Function
	End Class
End Namespace