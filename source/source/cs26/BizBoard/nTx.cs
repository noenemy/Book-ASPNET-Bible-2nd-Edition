// ----------------------------------------
// NEBOARD.net COM+ 버전 1.0
// Class 명 : nTx
// TrasactionOption : NotSupported
//
// 작성일 : 2003.10.02 
//                       by noenemy
// ----------------------------------------

using System;
using System.Data;
using System.EnterpriseServices;
using System.Data.SqlClient;

namespace BizBoard
{
	/// <summary>
	/// Summary description for nTx.
	/// </summary>

	[Transaction(TransactionOption.NotSupported)]
	public class nTx : ServicedComponent
	{
		public nTx()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		// ---------------------------------------------------------
		// GetConnectionString
		// Input Parameter : 
		// Return Type : String
		//
		// DB 연결 문자열을 web.config에서 가져와서 리턴
		//----------------------------------------------------------
		private string GetConnString()
		{
			return System.Configuration.ConfigurationSettings.AppSettings["DSN"];
		}


		// ---------------------------------------------------------
		// GetArticle
		// Input Parameter : b_id, c_id, c_step
		// Return Type : dsBoard
		//
		// 지정한 게시물 내용 리턴
		//----------------------------------------------------------
		public dsBoard GetArticle(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("GetArticle", conn);
			comm.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adapter = new SqlDataAdapter(comm);

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			dsBoard ds = new dsBoard();
			try
			{
				adapter.Fill(ds, "GetArticle");

				return ds;
			}
			catch (Exception e)
			{
				throw e;
			}

		}

		// ---------------------------------------------------------
		// GetBoardInfo
		// Input Parameter : b_id
		// Return Type : dsBoard
		//
		// 게시판 정보 리턴
		//----------------------------------------------------------
		public dsBoard GetBoardInfo(string b_id)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("GetBoardInfo", conn);
			comm.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adapter = new SqlDataAdapter(comm);

			comm.Parameters.Add("@b_id", b_id);

			dsBoard ds = new dsBoard();
			try
			{
				adapter.Fill(ds, "boardmaster");

				return ds;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		// ---------------------------------------------------------
		// GetBoardList
		// Input Parameter : b_id, search_option, search_key, 
		//					 pagesize, curpage
		// Return Type : dsBoard
		//
		// 게시물 목록을 리턴
		//----------------------------------------------------------
		public dsBoard GetBoardList(string b_id, string search_option, string search_key, 
									int pagesize, int curpage)
		{
			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("GetBoardList", conn);
			comm.CommandType = CommandType.StoredProcedure;

			// 가져올 게시물 수
			int TopCount = curpage * pagesize;
			SqlDataAdapter adapter = new SqlDataAdapter(comm);

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@search_option", search_option);
			comm.Parameters.Add("@search_key", search_key);
			comm.Parameters.Add("@topcount", TopCount.ToString());

			// 페이지번호에 따른 레코드 시작위치
			int start_record = (curpage - 1) * pagesize;

			dsBoard ds = new dsBoard();
			try
			{
				adapter.Fill(ds, start_record, pagesize, "boardlist");

				return ds;
				}
			catch (Exception e)
			{
				throw e;
			}
		}


		// ---------------------------------------------------------
		// GetBoardRecordCount
		// Input Parameter : b_id, search_option, search_key
		// Return Type : Integer
		//
		// 지정한 게시판의 게시물 수를 리턴
		//----------------------------------------------------------
		public int GetBoardRecordCount(string b_id, string search_option, string search_key)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("GetBoardRecordCount", conn);
			comm.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adapter = new SqlDataAdapter(comm);

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@search_option", search_option);
			comm.Parameters.Add("@search_key", search_key);

			int result;
			try
			{
				conn.Open();
				result = (int)comm.ExecuteScalar();
				conn.Close();

				return result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		// ---------------------------------------------------------
		// GetNewArticleID
		// Input Parameter : b_id
		// Return Type : Integer
		//
		// 지정한 게시판의 새글쓰기에 사용되는 c_id 값 리턴
		//----------------------------------------------------------
		public int GetNewArticleID(string b_id)
		{


			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("GetNewArticleID", conn);
			comm.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adapter = new SqlDataAdapter(comm);

			comm.Parameters.Add("@b_id", b_id);

			int result;

			try
			{
				conn.Open();
				object objTemp = comm.ExecuteScalar();
				if (objTemp.GetType().ToString() == "System.DBNull")
					result = 1;
				else
					result = (int)objTemp;
            
				conn.Close();

				return result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}



		// ---------------------------------------------------------
		// GetReplyArticleStep
		// Input Parameter : b_id, c_id, c_step, c_depth
		// Return Type : Integer
		//
		// 답변글이 입력될 c_step 값 리턴
		//----------------------------------------------------------
		public int GetReplyArticleStep(string b_id, int c_id, int c_step, int c_depth)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("GetReplyArticleStep", conn);
			comm.CommandType = CommandType.StoredProcedure;

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);
			comm.Parameters.Add("@c_depth", c_depth);

			int result;

			try
			{
				conn.Open();
				result = (int)comm.ExecuteScalar();

				return result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}


		// ---------------------------------------------------------
		// HasEditPermission
		// Input Parameter : b_id, c_id, c_step, password
		// Return Type : bool
		//
		// 게시물을 수정/삭제할 권한이 있는지 판단해서 리턴
		//----------------------------------------------------------
		public bool HasEditPermission(string b_id, int c_id, int c_step, string password)
		{

			// 삭제 및 수정 권한 체크

			dsBoard dsBoardInfo = GetBoardInfo(b_id);
			string AdminPW, WriterPW;

			try
			{
				AdminPW = dsBoardInfo.boardmaster[0].adminpw.ToString();

				dsBoard dsArticleInfo= GetArticle(b_id, c_id, c_step);

				WriterPW = dsArticleInfo.GetArticle[0].password.ToString();

				if (password == AdminPW || password == WriterPW)
					return true;
				else
					return false;
			}
			catch (Exception e)
			{
				throw e;
			}
		}


		// ---------------------------------------------------------
		// HasWritePermission
		// Input Parameter : b_id,password
		// Return Type : bool
		//
		// 게시물을 쓰기/답변할 권한이 있는지 판단해서 리턴
		//----------------------------------------------------------
		public bool HasWritePermission(string b_id, string password)
		{

			// 쓰기 및 답변글쓰기 권한체크

			dsBoard dsBoardInfo = GetBoardInfo(b_id);
			string AdminPW, AdminOnly;

			try
			{
				AdminPW = dsBoardInfo.boardmaster[0].adminpw.ToString();
				AdminOnly = dsBoardInfo.boardmaster[0]._readonly.ToString();

				if (AdminOnly == "T" && password != AdminPW)
					return false;
				else
					return true;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

	}
}
