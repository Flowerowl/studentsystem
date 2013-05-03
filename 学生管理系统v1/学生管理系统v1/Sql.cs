using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace 学生管理系统v1
{

    public static class DBHelper
    {
       
        public static string errorMessage = string.Empty;

        public static object ExecSql(string sqlStr, string connStr, OperateType opt)
        {
            object returnObj = new object();
            OleDbConnection odbConn = new OleDbConnection(connStr);
            odbConn.Open();
            switch (opt)
            {
                case OperateType.Select:
                    {
                        DataTable selectResult = new DataTable();
                        try
                        {
                            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);
                            returnObj = dataSet.Tables[0];
                            
                        }
                        catch (Exception ex)
                        {
                            returnObj = -1;
                            errorMessage = "数据查询失败：" + ex.ToString();
                        }
                        finally
                        {
                            odbConn.Close();
                        }
                    }
                    break;
                case OperateType.Insert:
                case OperateType.Update:
                case OperateType.Delete:
                    {
                        try
                        {
                            OleDbCommand odbc = new OleDbCommand(sqlStr, odbConn);
                            returnObj = odbc.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            returnObj = -1;
                            errorMessage = "数据操作失败：" + ex.ToString();
                        }
                        finally
                        {
                            odbConn.Close();
                        }
                    }
                    break;
                case OperateType.CreateTable:
                case OperateType.DropTable:
                    {
                        try
                        {
                            OleDbCommand odbc = new OleDbCommand(sqlStr, odbConn);
                            odbc.ExecuteNonQuery();
                            returnObj = true;
                        }
                        catch (Exception ex)
                        {
                            returnObj = false;
                            errorMessage = "数据操作失败：" + ex.ToString();
                        }
                        finally
                        {
                            odbConn.Close();
                        }
                    }
                    break;
                default:
                    { odbConn.Close(); }
                    break;
            }

            return returnObj;
        }

     
        public enum OperateType
        {
            Select,
            Insert,
            Update,         
            Delete,       
            CreateTable,          
            DropTable
        }

    }
}