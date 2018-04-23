Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid.Views.Layout.Designer
Imports DevExpress.XtraLayout
Imports TemplateCardCaptionLocalization.Properties
Imports DevExpress.XtraEditors.Controls

Namespace TemplateCardCaptionLocalization
	Public Class MyDesignerControlSettingsManager
		Inherits DesignerControlSettingsManager
		Public Sub New(ByVal customizer As LayoutViewCustomizer, ByVal targetLayoutControl As LayoutControl)
			MyBase.New(customizer, targetLayoutControl)
		End Sub

		Protected Overrides Sub SetDefaultValues()
            ItemsCaptionLocationControl.Properties.Items.Clear()
            GroupsCaptionLocationControl.Properties.Items.Clear()
            CardTextAlignment.Properties.Items.Clear()
			MyBase.SetDefaultValues()
			LocalizeComboBoxItems(ItemsCaptionLocationControl.Properties.Items)
			LocalizeComboBoxItems(GroupsCaptionLocationControl.Properties.Items)
			LocalizeComboBoxItems(CardTextAlignment.Properties.Items)
		End Sub

		Private Sub LocalizeComboBoxItems(ByVal items As ImageComboBoxItemCollection)
			For Each item As ImageComboBoxItem In items
				item.Description = LocalizeItemCaption(item.Description)
			Next item
		End Sub

		Private Function LocalizeItemCaption(ByVal defaultCaption As String) As String
			Select Case defaultCaption
                Case "Default"
                    Return Global.Resources.Locations_Default
                Case "Left"
                    Return Global.Resources.Locations_Left
                Case "Right"
                    Return Global.Resources.Locations_Right
                Case "Top"
                    Return Global.Resources.Locations_Top
                Case "Bottom"
                    Return Global.Resources.Locations_Bottom
                Case "AlignGlobal"
                    Return Global.Resources.FieldTextAlignMode_AlignGlobal
                Case "AutoSize"
                    Return Global.Resources.FieldTextAlignMode_AutoSize
                Case "CustomSize"
                    Return Global.Resources.FieldTextAlignMode_CustomSize
				Case Else
					Return defaultCaption
			End Select
		End Function
	End Class
End Namespace