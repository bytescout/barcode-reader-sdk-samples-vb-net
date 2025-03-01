'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<MTAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)

        ' Show barcode decoder dialog and get decoded barcode value
        Dim decodedBarcodeValue As String = WebCamBarcodeDecoder.DecodeBarcode()

        If decodedBarcodeValue IsNot Nothing Then
            MessageBox.Show("Found barcode: " & decodedBarcodeValue)
        Else
            MessageBox.Show("Decoding cancelled")
        End If

    End Sub
End Class
