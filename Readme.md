<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611916/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5032)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Syntax highlighting HTML markup using DevExpress CodeParser library and Syntax Highlight tokens

This example demonstrates how to highlight HTML markup content using the [ISyntaxHighlightService](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Services.ISyntaxHighlightService).

In this example, the following modifications of the mentioned approach were made:

* the `ITokenCategoryHelper` instance was created using the `ParserLanguageID.Html` parameter
* the `TokenCategory.Html.....` and `TokenCategory.Css......` categories were analyzed in the `HighlightCategorizedToken` method.

## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [SyntaxHighlighting.cs](./CS/WindowsFormsApplication1/SyntaxHighlighting.cs) (VB: [SyntaxHighlighting.vb](./VB/WindowsFormsApplication1/SyntaxHighlighting.vb))

## Documentation

* [How to: Highlight Document Syntax in the Rich Text Editor](https://docs.devexpress.com/WindowsForms/12107/controls-and-libraries/rich-text-editor/examples/automation/how-to-highlight-document-syntax)

## More Examples

* [Rich Text Editor for WinForms - Implement ISyntaxHighlightService to Highlight C and VB Code Syntax](https://github.com/DevExpress-Examples/rich-text-editor-highlight-syntax)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-syntax-highlighting-with-devexpress-codeparser-library&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-syntax-highlighting-with-devexpress-codeparser-library&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
