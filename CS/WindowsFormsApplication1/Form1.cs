using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Services;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {            
            richEditControl1.ReplaceService<ISyntaxHighlightService>(new HTMLSyntaxHighlightService(richEditControl1));
            using(IRichEditDocumentServer server = richEditControl1.CreateDocumentServer()) {
                server.Text = "some HTML text";
                richEditControl1.Text = server.HtmlText;
            }
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Consolas";
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 9;
        }
    }
}
