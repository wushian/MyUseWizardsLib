using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MyUseWizardsLib.Data
{
	/// <summary>
	/// DBConn 的摘要描述。
	/// </summary>
	public class DBConn
	{
		public DBConn()
		{
			//
			// TODO: 在此加入建構函式的程式碼
			//
		}

		public string Connect()
		{
            string cn = frmORMappingWindow.ConnectionInfo.ConnectionString; //ConfigurationManager.AppSettings["CDCDDbConfig"];
			return cn;
		}
	}
}
