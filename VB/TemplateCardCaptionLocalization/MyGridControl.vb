Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator

Namespace TemplateCardCaptionLocalization
	Public Class MyGridControl
		Inherits GridControl
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyLayoutViewInfoRegistrator())
		End Sub
	End Class
End Namespace