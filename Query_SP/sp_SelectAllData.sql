
-- =============================================
-- Author:		Dushantha Madushan Wijewardhana 
-- Create date: 22 Nov 2012
-- Description:	Select all dtudent data in tempery table
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_GetAllStudentdata

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Select statements for procedure here
	SELECT  StudentId,St_Name,St_DOB,St_GradePointAvg,St_Active FROM tbl_Temp_Registration 

END
GO
