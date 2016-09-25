// ----------------------------------------
// NEBOARD.net COM+ 버전 1.0
// Class 명 : Root
// TrasactionOption : Required
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
		// 지정한 게시물의 읽기수 증가
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
		// 게시물 첨부파일의 다운로드수 증가
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
		// 게시물 삭제하기
		//----------------------------------------------------------
		[AutoComplete()]
		public bool DeleteArticle(string b_id, int c_id, int c_step, string password)
		{
			BizBoard.nTx objnTx = new BizBoard.nTx();

			try
			{
				// 삭제 권한이 있는지 체크
				if (objnTx.HasEditPermission(b_id, c_id, c_step, password))
				{

					// 게시물 삭제
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
		// 게시물 수정하기
		//----------------------------------------------------------
		[AutoComplete()]
		public bool EditArticle(string b_id, int c_id, int c_step,
			string subject, string writer, string email, string filename, 
			string filesize, string content, string password)
		{

			BizBoard.nTx objnTx = new BizBoard.nTx();
			try
			{
				// 수정 권한이 있는지 체크
				if (objnTx.HasEditPermission(b_id, c_id, c_step, password))
				{

					// 게시물 삭제
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
		// 새로운 게시물 등록하기
		//----------------------------------------------------------
		[AutoComplete()]
		public bool WriteArticle(string b_id, string subject, string writer, 
			string email, string filename, string filesize,
			string content, string password)
		{
			try
			{
				BizBoard.nTx objnTx = new BizBoard.nTx();

				// 쓰기 권한이 있는지 체크
				if (objnTx.HasWritePermission(b_id, password) == false)
					return false;
				else
				{

					// 새 게시물 번호 구하기
					int c_id = objnTx.GetNewArticleID(b_id);

					// 게시물 입력
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
		// 게시물 답변하기
		//----------------------------------------------------------
		[AutoComplete()]
		public bool ReplyArticle(string b_id, int c_id, int c_step, int c_depth,
				string subject, string writer, string email, string filename, 
				string filesize, string content, string password)
		{
			try
			{
				BizBoard.nTx objnTx = new BizBoard.nTx();

				// 답변 권한이 있는지 체크
				if (objnTx.HasWritePermission(b_id, password) == false)
					return false;
				else
				{
					int p_Step; // 답변글이 입력될 위치 - step 값
					p_Step = objnTx.GetReplyArticleStep(b_id, c_id, c_step, c_depth);

					BizBoard.Tx objTx = new BizBoard.Tx();
					// 입력될 Step 값 이후의 글 밀어내기
					objTx.ReorderBoardList(b_id, c_id, p_Step);
					objTx.ReorderBoardContent(b_id, c_id, p_Step);

					// 답변글 등록하기
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
