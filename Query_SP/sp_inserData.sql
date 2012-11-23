
-- =============================================
-- Author:		Dushantha Madushan Wijewardhana
-- Create date: 2012-11-22
-- Description:	Insert sudent data
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_InsertStudentData 
	-- Add the parameters for the stored procedure here
	@studentId int,
	@st_Name varchar(50),
	@st_DOB datetime,
	@st_GradePointAvg decimal(5,2),
	@st_Active char(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tbl_Registration(StudentId,St_Name,St_DOB,St_GradePointAvg,St_Active) values (@studentId,@st_Name,@st_DOB,@st_GradePointAvg,@st_Active)
END
GO
