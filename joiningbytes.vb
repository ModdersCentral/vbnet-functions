Public Class Form1
    Function addtwoarraystest1(ByVal number1 As Byte(), ByVal number2 As Byte()) As Byte()
        Return number1.Concat(number2).ToArray()
    End Function
    Function addtwoarraystest2(ByVal number1 As Byte(), ByVal number2 As Byte()) As Byte()
        Dim aByte() As Byte = number1
        Dim bByte() As Byte = number2
        Dim mergedByte(aByte.Length + bByte.Length) As Byte
        aByte.CopyTo(mergedByte, 0)
        bByte.CopyTo(mergedByte, aByte.Length)
        Return (mergedByte)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '//usage: addtwoarraystest2(byte array1,byte array2)
        '//returns: bytearray3 (1+2 combined = 3)
        MsgBox(System.Text.Encoding.Default.GetString(addtwoarraystest1(System.Text.Encoding.Default.GetBytes("FirstString"), System.Text.Encoding.Default.GetBytes("SecondString"))))
        MsgBox(System.Text.Encoding.Default.GetString(addtwoarraystest2(System.Text.Encoding.Default.GetBytes("FirstString"), System.Text.Encoding.Default.GetBytes("SecondString"))))
    End Sub
End Class
