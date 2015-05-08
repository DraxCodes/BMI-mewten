Public Class frmBMI
    Dim info As String = "This is the Body Mass Index Calculator created by: Dustin Lopez"
    Dim checker As Int32 = 0

#Region "Minimum/Maximum Body Mass"
    'Grossly Undernourished
    Dim GUndernourished As Int32 = 16
    'Min Undernourished
    Dim minUndernourished As Int32 = 17
    'Max Undernourished
    Dim maxUndernourished As Int32 = 19
    'Min Perfectly OK
    Dim minPerfect As Int32 = 20
    'Max Perfectly OK
    Dim maxPerfect As Int32 = 25
    'Min Fat
    Dim minFat As Int32 = 26
    'Max Fat
    Dim maxFat As Int32 = 29
    'Min Obese
    Dim minObese As Int32 = 30
    'Max Obese
    Dim maxObese As Int32 = 39
    'Very Obese
    Dim VeryObese As Int32 = 40

#End Region

#Region "Button calculate click action"
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        check()
    End Sub
#End Region

#Region "calculation and checking"
    Dim result, remaining As Int32
    Private Sub check()
        If Val(txtWeight.Text) < 10 Then
            lblAnswer.Text = "lower than 10"
        ElseIf Val(txtWeight.Text) > 600 Then
            lblAnswer.Text = "Weight number to large"
        Else
            result = Calc(Val(txtWeight.Text), Val(txtHeight.Text))

            Select Case result

                Case GUndernourished

                Case minUndernourished To maxUndernourished

                Case minPerfect To maxPerfect

                Case minFat To maxFat

                Case minObese To maxObese

                Case VeryObese

            End Select
        End If

    End Sub
#End Region

    Function Calc(ByVal w As Int32, ByVal h As Int32)
        Return w / (h * h)
    End Function

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
