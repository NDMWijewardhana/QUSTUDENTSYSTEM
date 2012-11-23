
-- =============================================
-- Author:		Dushantha Madushan Wijewardhana 
-- Create date: 22 Nov 2012
-- Description:	Select Student id
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_GetLastStudentId

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Select statements for procedure here
	SELECT TOP 1 StudentId FROM dbo.tbl_Registration ORDER BY StudentId DESC 
END
GO
