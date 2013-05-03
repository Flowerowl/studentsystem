/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/23
 * 时间: 8:05
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
namespace 学生管理系统v1
{

    public static class Check
    {
       
        public static  bool z=true;
        public static bool Test(string CheckStr, Checked opt)
        {
        	string[] BadChar={
        						"and","exec","insert", "select","delete","update", "count","or","'","like","%"
        					};
            switch (opt)
            {
                case Checked.Int:
                    {
            			string a=CheckStr;
            			Regex r=new Regex("^[0-9]*$");
            			if(!r.IsMatch(a))
            			{
            				z=false;	
            			}
            			
                    }
                    break;
                case Checked.Text:
                    {
                        string a=CheckStr;
                        for(int i=0;i<BadChar.Length;i++)
                        {
                        	Regex r=new Regex(BadChar[i].ToString());
	            			if(!r.IsMatch(a))
	            			{
	            				z=true;	
	            			}
	            			else
	            			{
	            				z=false;
	            				break;
	            			}
                        }
                    }
                    break;
                case Checked.Word:
                    {
                        	string a=CheckStr;
                        	Regex r=new Regex(@"^[\u4e00-\u9fa5]{0,4}$");
	            			if(r.IsMatch(a))
	            			{
	            				z=true;	
	            			}
	            			else
	            			{
	            				z=false;
	            				break;
	            			}
                        
                    }
                    break;
               
                default:
                    {
                    	return true; 
                    }
                    
            }

            return z;
        }

       
        public enum Checked
        {
            Int,Text,Word
        }

    }
}