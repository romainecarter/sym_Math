using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Math;

namespace XBuilder
{
    public partial class XBuilder : UserControl
    {
        Parser calc = new Parser();

        public XBuilder()
        {
            InitializeComponent();
        }

        private void XBuilder_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            calc.Parse(txtFormulaBar.Text);
            MessageBox.Show(calc.Compute().ToString());
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            InsertAtPos("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            InsertAtPos("-");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            InsertAtPos("/");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            InsertAtPos("*");
        }

        private void InsertAtPos(string input){
            txtFormulaBar.Focus();
            int Index = txtFormulaBar.SelectionStart;

            txtFormulaBar.Text = txtFormulaBar.Text.Insert(Index, input);
            txtFormulaBar.SelectionStart = Index + input.Length;
        }

        public DataTable DataSource {
           set{calc.LoadVariables(value);}            
        }

        private void btnLParen_Click(object sender, EventArgs e)
        {
             InsertAtPos("(");
        }

        private void btnRParen_Click(object sender, EventArgs e)
        {
             InsertAtPos(")");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
