Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Layout.Customization
Imports DevExpress.Skins
Imports System.Windows.Forms
Imports System.Reflection
Imports System

Namespace TemplateCardCaptionLocalization
	Public Class MyLayoutView
		Inherits LayoutView
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Friend Const MyLayoutViewName As String = "MyLayoutView"
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return MyLayoutViewName
			End Get
		End Property

		Protected Overrides Function CreateCustomizationForm() As LayoutViewCustomizationForm
			SkinManager.EnableFormSkins()
			Dim form As LayoutViewCustomizationForm = New MyLayoutViewCustomizationForm(Me)
			AddHandler form.FormClosing, AddressOf OnCustomizationFormClosing
			Return form
		End Function

		Private Sub OnCustomizationFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			GetType(LayoutView).GetMethod("OnCustomizationFormClosing", BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, New Type() { GetType(Object), GetType(FormClosingEventArgs) }, New ParameterModifier(){}).Invoke(Me, New Object() { sender, e })
		End Sub
	End Class
End Namespace