using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections;

namespace Math
{
    public class Parser : XBuilder.IParser
    {
        private Hashtable precidence = new Hashtable();
        public  List<Token> calc_list = new List<Token>();
        private Dictionary<string, string> data_store = new Dictionary<string, string>();
        
        private enum type { num = 0, var, op };

        public Parser()
        {        
            precidence.Add("*", 2);
            precidence.Add("/", 2);
            precidence.Add("+", 1);
            precidence.Add("-", 1);
        }

        public string Parse(string expression){
            bool rtn = RPN(expression) == true ? true : false;
            return rtn == true ? "success" : "failed";
        }

        public double Compute(){
            Stack<Token> compu_stack = new Stack<Token>();
            try{
                foreach(Token tok in calc_list){
                    Token res = new Token();
                    
                    if(tok._class == (int)type.num || tok._class == (int)type.var){
                        compu_stack.Push(tok);
                    }else if(tok._class == (int)type.op){

                        Token rhs = compu_stack.Pop();
                        Token lhs = compu_stack.Pop();

                        switch (tok.repr)
                        {
                            case "+":
                                res.repr = (double.Parse(GetValue(lhs)) + double.Parse(GetValue(rhs))).ToString();
                                compu_stack.Push(res);
                                break;
                            case "-":
                                res.repr = (double.Parse(GetValue(lhs)) - double.Parse(GetValue(rhs))).ToString();
                                compu_stack.Push(res);
                                break;
                            case "/":
                                res.repr = (double.Parse(GetValue(lhs)) / double.Parse(GetValue(rhs))).ToString();
                                compu_stack.Push(res);
                                break;
                            case "*":
                                res.repr = (double.Parse(GetValue(lhs)) * double.Parse(GetValue(rhs))).ToString();
                                compu_stack.Push(res);
                                break;
                            default:
                                return double.Parse(compu_stack.Pop().repr);
                        }
                    }
                }                     
                return double.Parse(GetValue(compu_stack.Pop()));
            }catch(Exception ex){
                throw new Exception("Expression not well formed.", ex);
            }
        }

        private string GetValue(Token input){
            if(input._class == (int)type.num){
                return input.repr;
            }else{
                return  data_store[input.repr].ToString();
            }
        }

        private bool RPN(string expression){
            Regex reg = new Regex(@"\[\b[A-Za-z]+\b(?![\d])\]|[\+\-/\*]|[\d]+(\.[\d]+)?|[()]");
            Stack<Token> op_stack = new Stack<Token>();

            foreach(Match token in reg.Matches(expression)){
                Token tok = new Token();
                string value = token.Captures[0].Value;
 
                if(IsNumeric(value)){
                    tok._class = (int)type.num;
                    tok.repr = value;
                    calc_list.Add(tok);

                }else if(IsOperator(value)){
                    while(op_stack.Count != 0 && op_stack.Peek().repr != "("){
                        if (HasPrecidenceOrEqual(op_stack.Peek().repr, value)){                        
                            calc_list.Add(op_stack.Pop());
                        }                         
                        else break; 
                    }
                    tok._class = (int)type.op;
                    tok.repr = value;

                    op_stack.Push(tok);
                }else if (IsVariable(value)){
                    tok._class = (int)type.var;
                    tok.repr = value;
                    calc_list.Add(tok);

                }else if(value == "("){
                    tok._class = (int)type.var;
                    tok.repr = value;

                    op_stack.Push(tok);
                }else if(value == ")"){
                   while(op_stack.Count != 0 && op_stack.Peek().repr != "("){
                       calc_list.Add(op_stack.Pop());
                    }
                   if (op_stack.Count != 0) op_stack.Pop();
                }        
            }
            while(op_stack.Count != 0){
                calc_list.Add(op_stack.Pop());
            }

            return true;
        }

        private bool IsNumeric(string arg){
            double temp;
            double.TryParse(arg, out temp);

            return temp == 0 ? false : true;
        }

        private bool IsOperator(string arg){
            return new Regex(@"[+-/\*]").Match(arg).Success;
        }

        private bool IsVariable(string arg){
            return new Regex(@"\[\b[A-Za-z]+\b(?![\d])\]").Match(arg).Success;
        }

        private bool HasPrecidenceOrEqual(string lhs, string rhs){
            return ((int)precidence[lhs] >= (int)precidence[rhs]);
        }           

        public void LoadVariables(DataTable source){
           data_store.Clear();
           foreach(DataRow row in source.Rows){
               data_store.Add(row[0].ToString(), row[1].ToString());
           }
        }
    }

    public struct Token{
        public int _class;
        public string repr;
    }
}
