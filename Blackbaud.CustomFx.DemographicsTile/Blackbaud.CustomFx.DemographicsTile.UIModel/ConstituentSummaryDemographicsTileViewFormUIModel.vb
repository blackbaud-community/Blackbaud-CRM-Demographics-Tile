Public Class ConstituentSummaryDemographicsTileViewFormUIModel

    Private Sub ConstituentSummaryDemographicsTileViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded

    End Sub

    Private Sub _editdemogrpahics_DataFormSaved(sender As Object, e As UIModeling.Core.DataFormSavedEventArgs) Handles _editdemographics.DataFormSaved
        'Navigate to Personal Info tab, Constituent Page.
        Me.NavigateToPage(New Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f"), New Guid("04a78290-9651-4aed-88d3-a179972eafe8"), MyBase.RecordId)
    End Sub

    Private Sub _editpersonalinfo_DataFormSaved(sender As Object, e As UIModeling.Core.DataFormSavedEventArgs) Handles _editpersonalinfo.DataFormSaved
        'Navigate to Personal Info tab, Constituent Page.
        Me.NavigateToPage(New Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f"), New Guid("04a78290-9651-4aed-88d3-a179972eafe8"), MyBase.RecordId)
    End Sub

    Private Sub _addalias_DataFormSaved(sender As Object, e As UIModeling.Core.DataFormSavedEventArgs) Handles _addalias.DataFormSaved
        'Navigate to Personal Info tab, Constituent Page.
        Me.NavigateToPage(New Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f"), New Guid("04a78290-9651-4aed-88d3-a179972eafe8"), MyBase.RecordId)
    End Sub

End Class