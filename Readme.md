<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611916/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5032)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [SyntaxHighlighting.cs](./CS/WindowsFormsApplication1/SyntaxHighlighting.cs) (VB: [SyntaxHighlighting.vb](./VB/WindowsFormsApplication1/SyntaxHighlighting.vb))
<!-- default file list end -->
# Syntax highlighting HTML markup using DevExpress CodeParser library and Syntax Highlight tokens


<p>This example demonstrates how to highlight HTML markup content using <strong>ISyntaxHighlightService</strong>.</p><p>A similar approach for highlighting C# and VB code snippets was demonstrated in the following example: <a href="https://www.devexpress.com/Support/Center/p/E2993">Syntax highlighting for C# and VB code using DevExpress CodeParser and Syntax Highlight tokens</a><br />
</p><p>In this example, the following modifications of the mentioned approach were made:</p><p>- the <strong>ITokenCategoryHelper </strong>instance was created using the <strong>ParserLanguageID.Html</strong> parameter</p><p>- the "<strong>TokenCategory.Html.....</strong>" and "<strong>TokenCategory.Css......</strong>" categories were analyzed in the HighlightCategorizedToken method.</p>

<br/>


