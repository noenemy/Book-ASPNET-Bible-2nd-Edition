// ----------------------------------------
// NEBOARD.net COM+ ���� 1.0
// Class �� : Tx
// TrasactionOption : Supported
//
// �ۼ��� : 2003.10.02 
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
		// DB ���� ���ڿ��� web.config���� �����ͼ� ����
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
		// ������ �Խù��� �б�� ����
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
		// �Խù� ÷�������� �ٿ�ε�� ����
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
		// �Խù� ��� ���� ���
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
		// �Խù� ���� ���
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
		// �Խù� ��� ���� ����
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
			// �Խù� ���� ����
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
			// �Խù� ��� ���� ����
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
		// �Խù� ���� ����
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
		// �Խù� ��� ���� c_step �о��(�亯�ÿ� ���)
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
		// �Խù� ���� c_step �о��(�亯�ÿ� ���)
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
