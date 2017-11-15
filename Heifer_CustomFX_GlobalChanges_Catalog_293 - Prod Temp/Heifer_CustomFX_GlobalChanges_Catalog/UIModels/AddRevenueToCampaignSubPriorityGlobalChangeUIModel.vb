Public Class AddRevenueToCampaignSubPriorityGlobalChangeUIModel

    Private Sub AddRevenueToCampaignSubPriorityGlobalChangeUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        _campaignid.Required = True
        _subpriorityid.Required = True
    End Sub



    Private Sub _campaignid_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs) Handles _campaignid.ValueChanged
        _subpriorityid.ResetDataSource()
    End Sub
End Class