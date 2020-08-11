Imports System.IO
Imports HEFESTO.FIRMA.DOCUMENTO

Public Class Form1

    Private CN As String
    Private uriCaf As String
    Private uriDte As String
    Private uriEnvioDte As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        '////
        '//// Inicie el proceso de timbraje y firma de documentos

        Dim clsFirmarDocumento As New HEFFirmarDocumento

        'HEFFirmarDocumento clsFirmarDocumento = New HEFFirmarDocumento();
        clsFirmarDocumento.CN = CN
        clsFirmarDocumento.uriCaf = uriCaf
        clsFirmarDocumento.uriDte = uriDte
        clsFirmarDocumento.uriEnvioDte = uriEnvioDte
        clsFirmarDocumento.uriSchemaDte = "Schemas\\DTE_v10.xsd"
        clsFirmarDocumento.uriSchemaDteSf = "Schemas\\DTE_v10_Sf.xsd"
        clsFirmarDocumento.uriSchemaEnvioDteSf = "Schemas\\EnvioDTE_v10_Sf.xsd"
        clsFirmarDocumento.uriSchemaEnvioDte = "Schemas\\EnvioDTE_v10.xsd"

        '////
        '//// Cree el nombre de salida del documento Firmado
        Dim ArchivoFirmado As String = Path.GetFileName(Path.ChangeExtension(uriDte, ".Firmado.xml"))

    End Sub

End Class
