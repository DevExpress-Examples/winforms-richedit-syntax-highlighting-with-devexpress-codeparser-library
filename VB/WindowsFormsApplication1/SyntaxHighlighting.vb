Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.CodeParser
Imports System.Drawing
Imports DevExpress.XtraRichEdit

Namespace WindowsFormsApplication1
	Public Class HTMLSyntaxHighlightService
		Implements ISyntaxHighlightService
		Private ReadOnly syntaxEditor As RichEditControl

		Private TokensMapping As New Dictionary(Of TokenCategory, SyntaxHighlightProperties)()

		Private textProperties As SyntaxHighlightProperties

		Private Sub AddTokensMapping(ByVal category As TokenCategory, ByVal foreColor As Color)
			Dim tokenProperties As New SyntaxHighlightProperties()
			tokenProperties.ForeColor = foreColor
			TokensMapping.Add(category, tokenProperties)
		End Sub

		Private Function GetTokensMapping(ByVal category As TokenCategory) As SyntaxHighlightProperties
			If TokensMapping.ContainsKey(category) Then
				Return TokensMapping(category)
			Else
				Return textProperties
			End If
		End Function

		Public Sub New(ByVal syntaxEditor As RichEditControl)
			Me.syntaxEditor = syntaxEditor
		End Sub

		Private Sub HighlightSyntax(ByVal tokens As TokenCollection)
			If TokensMapping.Count = 0 Then
				AddTokensMapping(TokenCategory.HtmlAttributeName, Color.Red)
				AddTokensMapping(TokenCategory.HtmlAttributeValue, Color.Blue)
				AddTokensMapping(TokenCategory.HtmlComment, Color.Green)
				AddTokensMapping(TokenCategory.HtmlElementName, Color.Brown)
				AddTokensMapping(TokenCategory.HtmlEntity, Color.Green)
				AddTokensMapping(TokenCategory.HtmlOperator, Color.Blue)
				AddTokensMapping(TokenCategory.HtmlServerSideScript, Color.Gray)
				AddTokensMapping(TokenCategory.HtmlString, Color.Black)
				AddTokensMapping(TokenCategory.HtmlTagDelimiter, Color.Blue)
				AddTokensMapping(TokenCategory.CssComment, Color.Green)
				AddTokensMapping(TokenCategory.CssKeyword, Color.Red)
				AddTokensMapping(TokenCategory.CssPropertyName, Color.Red)
				AddTokensMapping(TokenCategory.CssPropertyValue, Color.Blue)
				AddTokensMapping(TokenCategory.CssSelector, Color.Brown)
				AddTokensMapping(TokenCategory.CssStringValue, Color.Blue)

				textProperties = New SyntaxHighlightProperties()
				textProperties.ForeColor = Color.Black
			End If

			If tokens Is Nothing OrElse tokens.Count = 0 Then
				Return
			End If

			Dim document As Document = syntaxEditor.Document
			Dim syntaxTokens As New List(Of SyntaxHighlightToken)(tokens.Count)
			For Each token As Token In tokens
				HighlightCategorizedToken(CType(token, CategorizedToken), syntaxTokens)
			Next token
			document.ApplySyntaxHighlight(syntaxTokens)
		End Sub

		Private Sub HighlightCategorizedToken(ByVal token As CategorizedToken, ByVal syntaxTokens As List(Of SyntaxHighlightToken))
			Dim backColor As Color = syntaxEditor.ActiveView.BackColor
			Dim category As TokenCategory = token.Category
			syntaxTokens.Add(SetTokenColor(token, GetTokensMapping(category), backColor))

		End Sub
		Private Function SetTokenColor(ByVal token As Token, ByVal foreColor As SyntaxHighlightProperties, ByVal backColor As Color) As SyntaxHighlightToken
			If syntaxEditor.Document.Paragraphs.Count < token.Range.Start.Line Then
				Return Nothing
			End If
			Dim paragraphStart As Integer = DocumentHelper.GetParagraphStart(syntaxEditor.Document.Paragraphs(token.Range.Start.Line - 1))
			Dim tokenStart As Integer = paragraphStart + token.Range.Start.Offset - 1
			If token.Range.End.Line <> token.Range.Start.Line Then
				paragraphStart = DocumentHelper.GetParagraphStart(syntaxEditor.Document.Paragraphs(token.Range.End.Line - 1))
			End If

			Dim tokenEnd As Integer = paragraphStart + token.Range.End.Offset - 1

			Return New SyntaxHighlightToken(tokenStart, tokenEnd - tokenStart, foreColor)
		End Function

		#Region "#ISyntaxHighlightServiceMembers"
        Public Sub Execute() Implements ISyntaxHighlightService.Execute
            Dim newText As String = syntaxEditor.Text
            ' Use DevExpress.CodeParser to parse text into tokens.
            Dim tokenHelper As ITokenCategoryHelper = TokenCategoryHelperFactory.CreateHelper(ParserLanguageID.Html)
            Dim highlightTokens As TokenCollection
            highlightTokens = tokenHelper.GetTokens(newText)
            HighlightSyntax(highlightTokens)
        End Sub

        Public Sub ForceExecute() Implements ISyntaxHighlightService.ForceExecute
            Execute()
        End Sub
		#End Region ' #ISyntaxHighlightServiceMembers
	End Class
End Namespace
