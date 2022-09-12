Imports System.Security.Permissions
Imports NationalInstruments.NetworkVariable
Imports System.ComponentModel

Public Class Form1
    Private BufferedWriter0 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader0 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter1 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader1 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter2 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader2 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter3 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader3 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter4 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader4 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter5 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader5 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter6 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader6 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter7 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader7 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter8 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader8 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter9 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader9 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter10 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader10 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter11 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader11 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter12 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader12 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter13 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader13 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter14 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader14 As NetworkVariableReader(Of Boolean)

    Private BufferedWriter15 As NetworkVariableBufferedWriter(Of Boolean)
    Private BufferedReader15 As NetworkVariableReader(Of Boolean)


    Dim NetworkVariableLocation As String

    Dim var0 As NetworkVariableData(Of Boolean)
    Dim var1 As NetworkVariableData(Of Boolean)
    Dim var2 As NetworkVariableData(Of Boolean)
    Dim var3 As NetworkVariableData(Of Boolean)
    Dim var4 As NetworkVariableData(Of Boolean)
    Dim var5 As NetworkVariableData(Of Boolean)
    Dim var6 As NetworkVariableData(Of Boolean)
    Dim var7 As NetworkVariableData(Of Boolean)
    Dim var8 As NetworkVariableData(Of Boolean)
    Dim var9 As NetworkVariableData(Of Boolean)
    Dim var10 As NetworkVariableData(Of Boolean)
    Dim var11 As NetworkVariableData(Of Boolean)
    Dim var12 As NetworkVariableData(Of Boolean)
    Dim var13 As NetworkVariableData(Of Boolean)
    Dim var14 As NetworkVariableData(Of Boolean)
    Dim var15 As NetworkVariableData(Of Boolean)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(1).Location

        BufferedWriter0 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter0.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(0).Location
        BufferedReader0 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader0.Connect()



        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(3).Location
        BufferedWriter1 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter1.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(2).Location
        BufferedReader1 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader1.Connect()



        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(5).Location
        BufferedWriter2 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter2.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(4).Location
        BufferedReader2 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader2.Connect()



        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(7).Location
        BufferedWriter3 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter3.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(6).Location
        BufferedReader3 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader3.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(9).Location
        BufferedWriter4 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter4.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(8).Location
        BufferedReader4 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader4.Connect()

        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(11).Location
        BufferedWriter5 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter5.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(10).Location
        BufferedReader5 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader5.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(13).Location
        BufferedWriter6 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter6.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(12).Location
        BufferedReader6 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader6.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(15).Location
        BufferedWriter7 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter7.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(14).Location
        BufferedReader7 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader7.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(17).Location
        BufferedWriter8 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter8.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(16).Location
        BufferedReader8 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader8.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(19).Location
        BufferedWriter9 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter9.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(18).Location
        BufferedReader9 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader9.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(21).Location
        BufferedWriter10 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter10.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(20).Location
        BufferedReader10 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader10.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(23).Location
        BufferedWriter11 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter11.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(22).Location
        BufferedReader11 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader11.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(25).Location
        BufferedWriter12 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter12.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(24).Location
        BufferedReader12 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader12.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(27).Location
        BufferedWriter13 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter13.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(26).Location
        BufferedReader13 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader13.Connect()

        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(29).Location
        BufferedWriter14 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter14.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(28).Location
        BufferedReader14 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader14.Connect()


        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(31).Location
        BufferedWriter15 = New NetworkVariableBufferedWriter(Of Boolean)(NetworkVariableLocation)
        BufferedWriter15.Connect()
        NetworkVariableLocation = NetworkVariableDataSource1.Bindings.Item(30).Location
        BufferedReader15 = New NetworkVariableReader(Of Boolean)(NetworkVariableLocation)
        BufferedReader15.Connect()





    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        BufferedWriter0.WriteValue(Switch1.Value)
        Led1.Value = Switch1.Value
        BufferedReader0.Connect()
        var0 = BufferedReader0.ReadData()
        Led3.Value = var0.GetValue()


        BufferedWriter1.WriteValue(Switch2.Value)
        Led2.Value = Switch2.Value
        BufferedReader1.Connect()
        var1 = BufferedReader1.ReadData()
        Led4.Value = var1.GetValue()


        BufferedWriter2.WriteValue(Switch3.Value)
        Led5.Value = Switch3.Value
        BufferedReader2.Connect()
        var2 = BufferedReader2.ReadData()
        Led6.Value = var2.GetValue()


        BufferedWriter3.WriteValue(Switch4.Value)
        Led7.Value = Switch4.Value
        BufferedReader3.Connect()
        var3 = BufferedReader3.ReadData()
        Led8.Value = var3.GetValue()


        BufferedWriter4.WriteValue(Switch5.Value)
        Led9.Value = Switch5.Value
        BufferedReader4.Connect()
        var4 = BufferedReader4.ReadData()
        Led10.Value = var4.GetValue()

        BufferedWriter5.WriteValue(Switch6.Value)
        Led11.Value = Switch6.Value
        BufferedReader5.Connect()
        var5 = BufferedReader5.ReadData()
        Led12.Value = var5.GetValue()


        BufferedWriter6.WriteValue(Switch7.Value)
        Led13.Value = Switch7.Value
        BufferedReader6.Connect()
        var6 = BufferedReader6.ReadData()
        Led14.Value = var6.GetValue()


        BufferedWriter7.WriteValue(Switch8.Value)
        Led15.Value = Switch8.Value
        BufferedReader7.Connect()
        var7 = BufferedReader7.ReadData()
        Led16.Value = var7.GetValue()


        BufferedWriter8.WriteValue(Switch9.Value)
        Led17.Value = Switch9.Value
        BufferedReader8.Connect()
        var8 = BufferedReader8.ReadData()
        Led18.Value = var8.GetValue()


        BufferedWriter9.WriteValue(Switch10.Value)
        Led19.Value = Switch10.Value
        BufferedReader9.Connect()
        var9 = BufferedReader9.ReadData()
        Led20.Value = var9.GetValue()


        BufferedWriter10.WriteValue(Switch11.Value)
        Led21.Value = Switch11.Value
        BufferedReader10.Connect()
        var10 = BufferedReader10.ReadData()
        Led22.Value = var10.GetValue()


        BufferedWriter11.WriteValue(Switch12.Value)
        Led23.Value = Switch12.Value
        BufferedReader11.Connect()
        var11 = BufferedReader11.ReadData()
        Led24.Value = var11.GetValue()


        BufferedWriter12.WriteValue(Switch13.Value)
        Led25.Value = Switch13.Value
        BufferedReader12.Connect()
        var12 = BufferedReader12.ReadData()
        Led26.Value = var12.GetValue()


        BufferedWriter13.WriteValue(Switch14.Value)
        Led27.Value = Switch14.Value
        BufferedReader13.Connect()
        var13 = BufferedReader13.ReadData()
        Led28.Value = var13.GetValue()

        BufferedWriter14.WriteValue(Switch15.Value)
        Led29.Value = Switch15.Value
        BufferedReader14.Connect()
        var14 = BufferedReader14.ReadData()
        Led30.Value = var14.GetValue()


        BufferedWriter15.WriteValue(Switch16.Value)
        Led31.Value = Switch16.Value
        BufferedReader15.Connect()
        var15 = BufferedReader15.ReadData()
        Led32.Value = var15.GetValue()



    End Sub


End Class
