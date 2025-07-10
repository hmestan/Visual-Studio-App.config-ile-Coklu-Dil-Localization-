Imports System.Globalization
Module ModMain
    Public Structure MyDataYapi
        Dim AppName As String
        Dim SQLServer As String
        Dim SQLProvider As String
        Dim SQLData As String
        Dim SQLUser As String
        Dim SQLSifre As String
        Dim Dil As String
    End Structure
    Public MyData As MyDataYapi
    Public MyDil As Resources.ResourceManager
    Public Sub Main()
        AyarOku()
        If MyData.Dil = "Tr" Then
            MyDil = My.Resources.Turkce.ResourceManager
        ElseIf MyData.Dil = "En" Then
            MyDil = My.Resources.English.ResourceManager
        ElseIf MyData.Dil = "Fr" Then
            MyDil = My.Resources.France.ResourceManager
        ElseIf MyData.Dil = "Fr" Then
            MyDil = My.Resources.Rusca.ResourceManager
        Else
            MyDil = My.Resources.Turkce.ResourceManager
        End If
        Application.Run(FrmAnaForm)
    End Sub
    Private Sub AyarOku()
        MyData.AppName = System.Configuration.ConfigurationManager.AppSettings("AppName")
        MyData.SQLServer = System.Configuration.ConfigurationManager.AppSettings("SQLServer")
        MyData.SQLProvider = System.Configuration.ConfigurationManager.AppSettings("SQLProvider")
        MyData.SQLData = System.Configuration.ConfigurationManager.AppSettings("SQLData")
        MyData.SQLUser = System.Configuration.ConfigurationManager.AppSettings("SQLUser")
        MyData.SQLSifre = System.Configuration.ConfigurationManager.AppSettings("SQLSifre")
        MyData.Dil = System.Configuration.ConfigurationManager.AppSettings("Dil")
    End Sub
End Module
