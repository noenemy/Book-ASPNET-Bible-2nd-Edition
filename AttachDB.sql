/* ASPNETBible, pdashop DB CREATE*/

use master 
go
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DB_ASPNETBible_Attach]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DB_ASPNETBible_Attach]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DB_pdashop_Attach]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DB_pdashop_Attach]
GO


SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

create proc DB_ASPNETBible_Attach
@Path varchar(200)
as
begin
	declare @str varchar(500)
	
	SET @str = 'sp_attach_db @dbname = N'+ char(39)+'ASPNETBible'+ char(39)+'
	,   @filename1 = N'+ char(39)+@Path+'\aspnetbible_data.mdf'+ char(39)+'
	,   @filename2 = N'++ char(39)+@Path+'\aspnetbible_log.ldf'+ char(39)
	exec(@str)
end

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

create proc DB_pdashop_Attach
@Path varchar(200)
as
begin
	declare @str varchar(500)
	
	SET @str = 'sp_attach_db @dbname = N'+ char(39)+'pdashop'+ char(39)+'
	,   @filename1 = N'+ char(39)+@Path+'\pdashop_data.mdf'+ char(39)+'
	,   @filename2 = N'++ char(39)+@Path+'\pdashop_log.ldf'+ char(39)
	
	exec(@str)
end

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



/*Northwind¿¡ sp Ãß°¡*/
use Northwind
go
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_Products]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_Products]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_InsertShipper]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_InsertShipper]
GO


SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE  PROCEDURE sp_Products
	@ProductID int
AS
	SELECT * FROM Products
	WHERE ProductID = @ProductID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE sp_InsertShipper
	@CompanyName nvarchar(40),
	@Phone nvarchar(24),
	@ShipperID int OUTPUT	

AS

	INSERT INTO shippers(companyname,phone) 
	VALUES(@CompanyName,@Phone)

	SELECT @ShipperID = @@IDENTITY

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO


