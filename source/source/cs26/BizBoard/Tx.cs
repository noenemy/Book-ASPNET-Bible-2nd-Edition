// ----------------------------------------
// NEBOARD.net COM+ 버전 1.0
// Class 명 : Tx
// TrasactionOption : Supported
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
	/// Summary description for Tx.
	/// </summary>
	[Transaction(TransactionOption.Supported)]
	public class Tx : ServicedComponent
	{
		public Tx()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		// ---------------------------------------------------------
		// GetConnectionString
		// Input Parameter : 
		// return Type : String
		//
		// DB 연결 문자열을 web.config에서 가져와서 리턴
		//----------------------------------------------------------
		private string GetConnString()
		{
			return System.Configuration.ConfigurationSettings.AppSettings["DSN"];
		}

		// ---------------------------------------------------------
		// IncreaseReadCount
		// Input Parameter : b_id, c_id, c_step 
		// return Type : bool
		//
		// 지정한 게시물의 읽기수 증가
		//----------------------------------------------------------
		[AutoComplete()]
		public bool IncreaseReadCount(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("IncreaseReadCount", conn);
			comm.CommandType = CommandType.StoredProcedure;
			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
		// IncreaseDownCount
		// Input Parameter : b_id, c_id, c_step 
		// return Type : bool
		//
		// 게시물 첨부파일의 다운로드수 증가
		//----------------------------------------------------------
		[AutoComplete()]
		public bool IncreaseDownCount(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("IncreaseDownCount", conn);
			comm.CommandType = CommandType.StoredProcedure;
			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
		// WriteBoardList
		// Input Parameter : b_id, c_id, c_step, c_depth, subject
		//           writer, email, filename, filesize, password
		// return Type : boolean
		//
		// 게시물 목록 정보 등록
		//----------------------------------------------------------
		[AutoComplete()]
		public bool WriteBoardList(string b_id, int c_id, int c_step, int c_depth,
							string subject, string writer, string email, 
							string filename, string filesize, string password)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("WriteBoardList", conn);
			comm.CommandType = CommandType.StoredProcedure;
			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);
			comm.Parameters.Add("@c_depth", c_depth);
			comm.Parameters.Add("@subject", subject);
			comm.Parameters.Add("@writer", writer);
			comm.Parameters.Add("@email", email);
			comm.Parameters.Add("@filename", filename);
			comm.Parameters.Add("@filesize", filesize);
			comm.Parameters.Add("@password", password);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
		// WriteBoardContent
		// Input Parameter : b_id, c_id, c_step, content
		// return Type : bool
		//
		// 게시물 내용 등록
		//----------------------------------------------------------
		[AutoComplete()]
		public bool WriteBoardContent(string b_id, int c_id, int c_step, string content)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("WriteBoardContent", conn);
			comm.CommandType = CommandType.StoredProcedure;
			comm.Parameters.Add("@b_id", b_id);
				comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);
			comm.Parameters.Add("@content", content);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
		// EditBoardList
		// Input Parameter : b_id, c_id, c_step, subject, writer,
		//                   email, filename, filesize
		// return Type : bool
		//
		// 게시물 목록 정보 수정
		//----------------------------------------------------------
		[AutoComplete()]
		public bool EditBoardList(string b_id, int c_id, int c_step,
						string subject, string writer, string email,
						string filename, string filesize)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("EditBoardList", conn);
			comm.CommandType = CommandType.StoredProcedure;
			
			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);
			comm.Parameters.Add("@subject", subject);
			comm.Parameters.Add("@writer", writer);
			comm.Parameters.Add("@email", email);
			comm.Parameters.Add("@filename", filename);
			comm.Parameters.Add("@filesize", filesize);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
			// EditBoardContent
			// Input Parameter : b_id, c_id, c_step, content
			// return Type : bool
			//
			// 게시물 내용 수정
			//----------------------------------------------------------
			[AutoComplete()]
			public bool EditBoardContent(string b_id, int c_id, int c_step, string content)
			{

				SqlConnection conn = new SqlConnection(GetConnString());
				SqlCommand comm = new SqlCommand("EditBoardContent", conn);
				comm.CommandType = CommandType.StoredProcedure;
				comm.Parameters.Add("@b_id", b_id);
				comm.Parameters.Add("@c_id", c_id);
				comm.Parameters.Add("@c_step", c_step);
				comm.Parameters.Add("@content", content);

				int result;
				try
				{
					conn.Open();
					result = comm.ExecuteNonQuery();
					conn.Close();

					if (result > 0)
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
			// DeleteBoardList
			// Input Parameter : b_id, c_id, c_step
			// return Type : bool
			//
			// 게시물 목록 정보 삭제
			//----------------------------------------------------------
		[AutoComplete()]
		public bool DeleteBoardList(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("DeleteBoardList", conn);
			comm.CommandType = CommandType.StoredProcedure;
			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
		// DeleteBoardContent
		// Input Parameter : b_id, c_id, c_step
		// return Type : bool
		//
		// 게시물 내용 삭제
		//----------------------------------------------------------
		[AutoComplete()]
		public bool DeleteBoardContent(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("DeleteBoardContent", conn);
			comm.CommandType = CommandType.StoredProcedure;

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				if (result > 0)
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
		// ReorderBoardList
		// Input Parameter : b_id, c_id, c_step
		// return Type : bool
		//
		// 게시물 목록 정보 c_step 밀어내기(답변시에 사용)
		//----------------------------------------------------------
		[AutoComplete()]
		public bool ReorderBoardList(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("ReorderBoardList", conn);
			comm.CommandType = CommandType.StoredProcedure;

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				return true;
			}

			catch (Exception e)
			{
				throw e;
			}
		}



		// ---------------------------------------------------------
		// ReorderBoardContent
		// Input Parameter : b_id, c_id, c_step
		// return Type : bool
		//
		// 게시물 내용 c_step 밀어내기(답변시에 사용)
		//----------------------------------------------------------
		[AutoComplete()]
		public bool ReorderBoardContent(string b_id, int c_id, int c_step)
		{

			SqlConnection conn = new SqlConnection(GetConnString());
			SqlCommand comm = new SqlCommand("ReorderBoardContent", conn);
			comm.CommandType = CommandType.StoredProcedure;

			comm.Parameters.Add("@b_id", b_id);
			comm.Parameters.Add("@c_id", c_id);
			comm.Parameters.Add("@c_step", c_step);

			int result;
			try
			{
				conn.Open();
				result = comm.ExecuteNonQuery();
				conn.Close();

				return true;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

	}
}
