Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Namespace TemplateCardCaptionLocalization
	Public Class MyLayoutViewInfoRegistrator
		Inherits LayoutViewInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return MyLayoutView.MyLayoutViewName
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyLayoutView(grid)
		End Function
	End Class
End Namespace