<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [SyntaxHighlighting.cs](./CS/WindowsFormsApplication1/SyntaxHighlighting.cs) (VB: [SyntaxHighlighting.vb](./VB/WindowsFormsApplication1/SyntaxHighlighting.vb))
<!-- default file list end -->
# Syntax highlighting HTML markup using DevExpress CodeParser library and Syntax Highlight tokens


<p>This example demonstrates how to highlight HTML markup content using <strong>ISyntaxHighlightService</strong>.</p><p>A similar approach for highlighting C# and VB code snippets was demonstrated in the following example: <a href="https://www.devexpress.com/Support/Center/p/E2993">Syntax highlighting for C# and VB code using DevExpress CodeParser and Syntax Highlight tokens</a><br />
</p><p>In this example, the following modifications of the mentioned approach were made:</p><p>- the <strong>ITokenCategoryHelper </strong>instance was created using the <strong>ParserLanguageID.Html</strong> parameter</p><p>- the "<strong>TokenCategory.Html.....</strong>" and "<strong>TokenCategory.Css......</strong>" categories were analyzed in the HighlightCategorizedToken method.</p>

<br/>


