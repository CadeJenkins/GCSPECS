﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.93.2034.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Add Revenue To Campaign Sub Priority Global Change' data form
''' </summary>

Partial Public Class [AddRevenueToCampaignSubPriorityGlobalChangeUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.CustomUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _revenueappselectionid As Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of Guid)
    Private WithEvents _campaignid As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
    Private WithEvents _subpriorityid As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Sub New()
        MyBase.New()

        _revenueappselectionid = New Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of Guid)
        _campaignid = New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
        _subpriorityid = New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)

        'MyBase.UserInterfaceUrl = "browser/htmlforms/AddRevenueToCampaignSubPriorityGlobalChange.html"

        '
        '_revenueappselectionid
        '
        _revenueappselectionid.Name = "REVENUEAPPSELECTIONID"
        _revenueappselectionid.Caption = "Revenue Application Selection"
        _revenueappselectionid.Required = True
        _revenueappselectionid.SearchListID = New Guid("1f0e603c-1c55-4e1e-8218-bdb877b2cbe8")
        _revenueappselectionid.SystemSearchType = Global.Blackbaud.AppFx.UIModeling.Core.SystemSearchType.Selection
        Me.Fields.Add(_revenueappselectionid)
        '
        '_campaignid
        '
        _campaignid.Name = "CAMPAIGNID"
        _campaignid.Caption = "Campaign"
        _campaignid.SimpleDataListID = New Guid("2e7566f2-cc4c-44c5-aed1-4700b691cef6")
        Me.Fields.Add(_campaignid)
        '
        '_subpriorityid
        '
        _subpriorityid.Name = "SUBPRIORITYID"
        _subpriorityid.Caption = "Sub Priority"
        _subpriorityid.SimpleDataListID = New Guid("e3e9e22a-85f2-4a77-ba74-25b391252dab")
        _subpriorityid.Parameters.Add(New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListParameter("CAMPAIGNID", "Fields!CAMPAIGNID"))
        Me.Fields.Add(_subpriorityid)


		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Revenue Application Selection
    ''' </summary>
    <System.ComponentModel.Description("Revenue Application Selection")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [REVENUEAPPSELECTIONID]() As Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of Guid)
        Get
            Return _revenueappselectionid
        End Get
    End Property
    
    ''' <summary>
    ''' Campaign
    ''' </summary>
    <System.ComponentModel.Description("Campaign")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CAMPAIGNID]() As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
        Get
            Return _campaignid
        End Get
    End Property
    
    ''' <summary>
    ''' Sub Priority
    ''' </summary>
    <System.ComponentModel.Description("Sub Priority")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [SUBPRIORITYID]() As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
        Get
            Return _subpriorityid
        End Get
    End Property
    

End Class
