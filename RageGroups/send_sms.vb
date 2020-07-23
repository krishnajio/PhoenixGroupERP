Imports System
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Net


''' <summary>
''' Summary description for sendsms
''' </summary>
Public Class sendsms
    Public Sub New()
        '
        ' TODO: Add constructor logic here
        '
    End Sub
    Public Function send_sms(ByVal mobileno As String, ByVal sms As String) As String
        Dim UName As [String] = "phoenixpoultry"
        Dim PWord As [String] = "886375354"
        Dim SMSText As [String] = sms
        '"Thanks";
        Dim PhoneNo As [String] = mobileno
        '"91XXXXXXXXXX";
        Dim SendId As [String] = "PhoenixSoft"
        Dim url As String = (((("http://sms.sms2india.info/sendsms.asp?user=" & UName & "&password=") + PWord & "&sender=") + SendId & "&text=") + SMSText & "&PhoneNumber=") + PhoneNo & "&track=1 &unicode=1"

        Dim result As [String] = ""
        Dim strPost As [String] = ""
        Dim myWriter As StreamWriter = Nothing

        Dim objRequest As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        objRequest.Method = "POST"
        objRequest.ContentLength = strPost.Length
        objRequest.ContentType = "application/x-www-form-urlencoded"
        myWriter = New StreamWriter(objRequest.GetRequestStream())
        myWriter.Write(strPost)
        Dim objResponse As HttpWebResponse = DirectCast(objRequest.GetResponse(), HttpWebResponse)
        Using sr As New StreamReader(objResponse.GetResponseStream())
            result = sr.ReadToEnd()
            sr.Close()
            'Close and clean up the StreamReader
            Return result
        End Using
    End Function
End Class



