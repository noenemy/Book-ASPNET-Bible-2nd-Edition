// ----------------------------------------
// NEBOARD.net COM+ ���� 1.0
// Class �� : Root
// TrasactionOption : Required
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
	/// Summary description for Root.
	/// </summary>

	[Transaction(TransactionOption.Required)]
	public class Root : ServicedComponent
	{
		public Root()
		{
			//
			// TODO: Add constructor logic here
			//
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
			BizBoard.Tx objTx = new BizBoard.Tx();

			try
			{
				if (objTx.IncreaseReadCount(b_id, c_id, c_step))
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

			BizBoard.Tx objTx = new BizBoard.Tx();

			try
			{
				if (objTx.IncreaseDownCount(b_id, c_id, c_step))
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
		// DeleteArticle
		// Input Parameter : b_id, c_id, c_step, password
		// return Type : bool
		//
		// �Խù� �����ϱ�
		//----------------------------------------------------------
		[AutoComplete()]
		public bool DeleteArticle(string b_id, int c_id, int c_step, string password)
		{
			BizBoard.nTx objnTx = new BizBoard.nTx();

			try
			{
				// ���� ������ �ִ��� üũ
				if (objnTx.HasEditPermission(b_id, c_id, c_step, password))
				{

					// �Խù� ����
					BizBoard.Tx objTx = new BizBoard.Tx();
					objTx.DeleteBoardList(b_id, c_id, c_step);
					objTx.DeleteBoardContent(b_id, c_id, c_step);

					return true;
				}
				else
					return false;
				}

			catch (Exception e)
			{
				throw e;

			}

		} 


		// ---------------------------------------------------------
		// EditArticle
		// Input Parameter : b_id, c_id, c_step, subject, writer, 
		//             email, filename, filesize, content, password
		// return Type : bool
		//
		// �Խù� �����ϱ�
		//----------------------------------------------------------
		[AutoComplete()]
		public bool EditArticle(string b_id, int c_id, int c_step,
			string subject, string writer, string email, string filename, 
			string filesize, string content, string password)
		{

			BizBoard.nTx objnTx = new BizBoard.nTx();
			try
			{
				// ���� ������ �ִ��� üũ
				if (objnTx.HasEditPermission(b_id, c_id, c_step, password))
				{

					// �Խù� ����
					BizBoard.Tx objTx = new BizBoard.Tx();
					objTx.EditBoardList(b_id, c_id, c_step, subject, 
						writer, email, filename, filesize);
					objTx.EditBoardContent(b_id, c_id, c_step, content);

					return true;
				}
				else
					return false;
			}
			catch (Exception e)
			{
				throw e;
			}
		}


		// ---------------------------------------------------------
		// WriteArticle
		// Input Parameter : b_id, subject, writer, email, filename,
		//                   filesize, content, password
		// return Type : bool
		//
		// ���ο� �Խù� ����ϱ�
		//----------------------------------------------------------
		[AutoComplete()]
		public bool WriteArticle(string b_id, string subject, string writer, 
			string email, string filename, string filesize,
			string content, string password)
		{
			try
			{
				BizBoard.nTx objnTx = new BizBoard.nTx();

				// ���� ������ �ִ��� üũ
				if (objnTx.HasWritePermission(b_id, password) == false)
					return false;
				else
				{

					// �� �Խù� ��ȣ ���ϱ�
					int c_id = objnTx.GetNewArticleID(b_id);

					// �Խù� �Է�
					BizBoard.Tx objTx = new BizBoard.Tx();
					objTx.WriteBoardList(b_id, c_id, 1, 0, subject, writer,
						email, filename, filesize, password);

					objTx.WriteBoardContent(b_id, c_id, 1, content);

					return true;

				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}


		// ---------------------------------------------------------
		// ReplyArticle
		// Input Parameter : b_id, c_id, c_step, c_depth, subject,
		//     writer, email, filename, filesize, content, password
		// return Type : bool
		//
		// �Խù� �亯�ϱ�
		//----------------------------------------------------------
		[AutoComplete()]
		public bool ReplyArticle(string b_id, int c_id, int c_step, int c_depth,
				string subject, string writer, string email, string filename, 
				string filesize, string content, string password)
		{
			try
			{
				BizBoard.nTx objnTx = new BizBoard.nTx();

				// �亯 ������ �ִ��� üũ
				if (objnTx.HasWritePermission(b_id, password) == false)
					return false;
				else
				{
					int p_Step; // �亯���� �Էµ� ��ġ - step ��
					p_Step = objnTx.GetReplyArticleStep(b_id, c_id, c_step, c_depth);

					BizBoard.Tx objTx = new BizBoard.Tx();
					// �Էµ� Step �� ������ �� �о��
					objTx.ReorderBoardList(b_id, c_id, p_Step);
					objTx.ReorderBoardContent(b_id, c_id, p_Step);

					// �亯�� ����ϱ�
					objTx.WriteBoardList(b_id, c_id, p_Step, c_depth + 1, 
						subject, writer, email, filename, filesize, password);
					objTx.WriteBoardContent(b_id, c_id, p_Step, content);

					return true;

				} 
			}
			catch (Exception e)
			{
				throw e;
			}
		}

	}
}
