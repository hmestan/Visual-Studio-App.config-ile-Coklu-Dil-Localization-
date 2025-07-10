Imports System.Configuration

Public Class FrmAnaForm

    Private Sub FrmAnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EkranAyarlari
    End Sub



    Private Sub BtnKapat_Click(sender As Object, e As EventArgs) Handles BtnKapat.Click
        Me.Close()
        Application.Exit()

    End Sub
    Private Sub EkranAyarlari()
        If MyData.Dil = "Tr" Then
            BtnBar.Items(0).Image = My.Resources.Turkiye
        ElseIf MyData.Dil = "Fr" Then
            BtnBar.Items(0).Image = My.Resources.Fransa
        ElseIf MyData.Dil = "En" Then
            BtnBar.Items(0).Image = My.Resources.Ingiliz
        ElseIf MyData.Dil = "Ru" Then
            BtnBar.Items(0).Image = My.Resources.Rus
        End If
        Me.Text = MyDil.GetString("Baslik")
        BtnKapat.Text = MyDil.GetString("Kapat")
    End Sub

    Private Sub BtnDil_Click(sender As Object, e As EventArgs) Handles BtnDil.Click
        If MyData.Dil = "Tr" Then
            MyData.Dil = "En"
            BtnBar.Items(0).Image = My.Resources.Ingiliz
            MyDil = My.Resources.English.ResourceManager
        ElseIf MyData.Dil = "En" Then
            MyData.Dil = "Fr"
            BtnBar.Items(0).Image = My.Resources.Fransa
            MyDil = My.Resources.France.ResourceManager
        ElseIf MyData.Dil = "Fr" Then
            MyData.Dil = "Ru"
            BtnBar.Items(0).Image = My.Resources.Rus
            MyDil = My.Resources.Rusca.ResourceManager
        ElseIf MyData.Dil = "Ru" Then
            MyData.Dil = "Tr"
            BtnBar.Items(0).Image = My.Resources.Turkiye
            MyDil = My.Resources.Turkce.ResourceManager
        End If
        Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim settings = configFile.AppSettings.Settings
        settings("Dil").Value = MyData.Dil
        configFile.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        EkranAyarlari()
    End Sub
End Class