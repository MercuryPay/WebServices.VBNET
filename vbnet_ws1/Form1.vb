Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml

Public Class Form1

    Private Sub btnProcessTransaction_Click(sender As System.Object, e As System.EventArgs) Handles btnProcessTransaction.Click
        ProcessTransaction()
    End Sub


    Private Sub ProcessTransaction()

        Dim soapAction As String = ""
        Dim uriString As String = ""
        Dim returnValue As String = ""

        uriString = txtWebServicesURL.Text
        soapAction = txtSOAPAction.Text

        Try

            Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)

            ' Setup the request for SOAP
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(New Uri(uriString)), HttpWebRequest)
            request.Credentials = CredentialCache.DefaultCredentials
            request.Method = "POST"
            request.ContentType = "text/xml; charset=utf-8"
            request.Headers.Add([String].Format("SOAPAction: ""{0}""", soapAction))
            request.ContentLength = buffer.Length
            request.ReadWriteTimeout = 10
            request.ProtocolVersion = HttpVersion.Version11

            ' Create the request stream and write the buffer to the stream
            Dim newStream As Stream = request.GetRequestStream()
            newStream.Write(buffer, 0, buffer.Length)
            newStream.Close()

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            ' Get the stream associated with the response. 
            Dim receiveStream As Stream = response.GetResponseStream()

            ' Pipes the stream to a higher level stream reader with the required encoding format
            Dim readStream As New StreamReader(receiveStream, Encoding.UTF8)

            ' Write the stream to the textbox control
            TextBox4.Text = readStream.ReadToEnd()

            ' Close the response object
            response.Close()

            ' Close the StreamReader object
            readStream.Close()

        Catch ex As Exception
            returnValue = "Error : " + ex.ToString()
            MsgBox(returnValue, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        TextBox4.Clear()
    End Sub

    Private Sub btnLoadXml_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadXml.Click

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Browse XML Files"

        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True

        openFileDialog1.DefaultExt = "xml"
        openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        openFileDialog1.ReadOnlyChecked = True
        openFileDialog1.ShowReadOnly = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim fileS As FileStream
            fileS = New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            'declaring a FileStream to open the file named file.doc with access mode of reading
            Dim i As New StreamReader(fileS)
            'creating a new StreamReader and passing the filestream object fs as argument
            i.BaseStream.Seek(0, SeekOrigin.Begin)
            'Seek method is used to move the cursor to different positions in a file, in this code, to
            'the beginning
            While i.Peek() > -1
                'peek method of StreamReader object tells how much more data is left in the file
                TextBox1.Text &= i.ReadLine()
                'displaying text from doc file in the RichTextBox
            End While
            i.Close()

        End If

    End Sub


    Protected Function FormatXml(xmlNode As Xml.XmlNode) As String
        Dim sb As New StringBuilder()


        ' We will use stringWriter to push the formated xml into our StringBuilder.
        Using stringWriter As New StringWriter(sb)
            ' We will use the Formatting of our xmlTextWriter to provide our indentation.
            Using xmlTextWriter As New XmlTextWriter(stringWriter)
                xmlTextWriter.Formatting = Formatting.Indented
                xmlNode.WriteTo(xmlTextWriter)
            End Using
        End Using


        Return sb.ToString()
    End Function

End Class

