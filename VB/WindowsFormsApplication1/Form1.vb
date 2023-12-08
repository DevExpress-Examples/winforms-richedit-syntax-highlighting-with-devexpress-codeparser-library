Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Services

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.ReplaceService(Of ISyntaxHighlightService)(New HTMLSyntaxHighlightService(richEditControl1))
            Using server As IRichEditDocumentServer = richEditControl1.CreateDocumentServer()
                server.Text = "some HTML text"
                richEditControl1.Text = server.HtmlText
            End Using

            richEditControl1.Document.DefaultCharacterProperties.FontName = "Consolas"
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 9
        End Sub
    End Class
End Namespace
