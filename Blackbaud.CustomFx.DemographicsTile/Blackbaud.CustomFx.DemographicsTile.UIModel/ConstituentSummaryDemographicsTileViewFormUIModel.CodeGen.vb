﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.5.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Constituent Summary Demographics Tile View Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "4b2d7e7a-c346-498a-94d4-93c9433f42a0", "473bed00-d274-48bd-abc1-535b27c1a24d", "Constituent")>
Partial Public Class [ConstituentSummaryDemographicsTileViewFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _ethnicity As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _religion As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _ageandgender As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _aliases As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _demoheaderlink As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
    Private WithEvents _editdemographics As Global.Blackbaud.AppFx.UIModeling.Core.ShowDataFormUIAction
    Private WithEvents _editpersonalinfo As Global.Blackbaud.AppFx.UIModeling.Core.ShowDataFormUIAction
    Private WithEvents _addalias As Global.Blackbaud.AppFx.UIModeling.Core.ShowAddFormUIAction
    Private WithEvents _aliaseslink As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public Sub New()
        MyBase.New()

        _ethnicity = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _religion = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _ageandgender = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _aliases = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _demoheaderlink = New Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        _editdemographics = New Global.Blackbaud.AppFx.UIModeling.Core.ShowDataFormUIAction
        _editpersonalinfo = New Global.Blackbaud.AppFx.UIModeling.Core.ShowDataFormUIAction
        _addalias = New Global.Blackbaud.AppFx.UIModeling.Core.ShowAddFormUIAction
        _aliaseslink = New Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New System.Guid("4b2d7e7a-c346-498a-94d4-93c9433f42a0")
        MyBase.DataFormInstanceId = New System.Guid("473bed00-d274-48bd-abc1-535b27c1a24d")
        MyBase.RecordType = "Constituent"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/ConstituentSummaryDemographicsTileViewForm.html"

        '
        '_ethnicity
        '
        _ethnicity.Name = "ETHNICITY"
        _ethnicity.Caption = "Ethnicity"
        _ethnicity.DBReadOnly = True
        _ethnicity.MaxLength = 512
        Me.Fields.Add(_ethnicity)
        '
        '_religion
        '
        _religion.Name = "RELIGION"
        _religion.Caption = "Religion"
        _religion.DBReadOnly = True
        _religion.MaxLength = 100
        Me.Fields.Add(_religion)
        '
        '_ageandgender
        '
        _ageandgender.Name = "AGEANDGENDER"
        _ageandgender.Caption = "Age/Gender"
        _ageandgender.DBReadOnly = True
        _ageandgender.MaxLength = 11
        Me.Fields.Add(_ageandgender)
        '
        '_aliases
        '
        _aliases.Name = "ALIASES"
        _aliases.Caption = "Aliases"
        _aliases.DBReadOnly = True
        _aliases.MaxLength = 512
        Me.Fields.Add(_aliases)
        '
        '_demoheaderlink
        '
        _demoheaderlink.Name = "DEMOHEADERLINK"
        _demoheaderlink.Caption = "Demographics"
        _demoheaderlink.PageId = New System.Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f")
        _demoheaderlink.TabId = New System.Guid("04a78290-9651-4aed-88d3-a179972eafe8")
        _demoheaderlink.ForceReload = False
        _demoheaderlink.ContextIdDefinition = "FORM!CURRENTRECORDID"
        Me.Actions.Add(_demoheaderlink)
        '
        '_editdemographics
        '
        _editdemographics.Name = "EDITDEMOGRAPHICS"
        _editdemographics.Caption = ""
        _editdemographics.DataFormInstanceId = New System.Guid("3b42e405-ab24-41db-a086-606be1015959")
        _editdemographics.RecordIdDefinition = "FORM!CURRENTRECORDID"
        Me.Actions.Add(_editdemographics)
        '
        '_editpersonalinfo
        '
        _editpersonalinfo.Name = "EDITPERSONALINFO"
        _editpersonalinfo.Caption = ""
        _editpersonalinfo.DataFormInstanceId = New System.Guid("788ab947-26ed-40c4-865e-8fe29577e593")
        _editpersonalinfo.RecordIdDefinition = "FORM!CURRENTRECORDID"
        Me.Actions.Add(_editpersonalinfo)
        '
        '_addalias
        '
        _addalias.Name = "ADDALIAS"
        _addalias.Caption = ""
        _addalias.DataFormInstanceId = New System.Guid("6bacaf53-93b7-4a26-8753-979b6a5b578c")
        _addalias.ContextIdDefinition = "FORM!CURRENTRECORDID"
        Me.Actions.Add(_addalias)
        '
        '_aliaseslink
        '
        _aliaseslink.Name = "ALIASESLINK"
        _aliaseslink.Caption = "Aliases:"
        _aliaseslink.PageId = New System.Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f")
        _aliaseslink.TabId = New System.Guid("04a78290-9651-4aed-88d3-a179972eafe8")
        _aliaseslink.SectionId = New System.Guid("61f261fd-bd70-4f85-a3f8-d233bf11a476")
        _aliaseslink.ForceReload = False
        _aliaseslink.ContextIdDefinition = "FORM!CURRENTRECORDID"
        Me.Actions.Add(_aliaseslink)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Ethnicity
    ''' </summary>
    <System.ComponentModel.Description("Ethnicity")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [ETHNICITY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _ethnicity
        End Get
    End Property
    
    ''' <summary>
    ''' Religion
    ''' </summary>
    <System.ComponentModel.Description("Religion")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [RELIGION]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _religion
        End Get
    End Property
    
    ''' <summary>
    ''' Age/Gender
    ''' </summary>
    <System.ComponentModel.Description("Age/Gender")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [AGEANDGENDER]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _ageandgender
        End Get
    End Property
    
    ''' <summary>
    ''' Aliases
    ''' </summary>
    <System.ComponentModel.Description("Aliases")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [ALIASES]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _aliases
        End Get
    End Property
    
    ''' <summary>
    ''' Demographics
    ''' </summary>
    <System.ComponentModel.Description("Demographics")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [DEMOHEADERLINK]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        Get
            Return _demoheaderlink
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [EDITDEMOGRAPHICS]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowDataFormUIAction
        Get
            Return _editdemographics
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [EDITPERSONALINFO]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowDataFormUIAction
        Get
            Return _editpersonalinfo
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [ADDALIAS]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowAddFormUIAction
        Get
            Return _addalias
        End Get
    End Property
    
    ''' <summary>
    ''' Aliases
    ''' </summary>
    <System.ComponentModel.Description("Aliases")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.5.0")> _
    Public ReadOnly Property [ALIASESLINK]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        Get
            Return _aliaseslink
        End Get
    End Property
    
End Class
