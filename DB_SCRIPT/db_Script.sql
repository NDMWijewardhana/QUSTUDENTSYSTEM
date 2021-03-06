SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Registration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Registration](
	[StudentId] [int] NOT NULL,
	[St_Name] [varchar](50) NOT NULL,
	[St_DOB] [datetime] NOT NULL,
	[St_GradePointAvg] [decimal](5, 2) NOT NULL,
	[St_Active] [varchar](6) NOT NULL,
 CONSTRAINT [PK_tbl_Registration] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Temp_Registration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Temp_Registration](
	[StudentId] [int] NOT NULL,
	[St_Name] [varchar](50) NOT NULL,
	[St_DOB] [datetime] NOT NULL CONSTRAINT [DF_tbl_Temp_Registration_St_DOB]  DEFAULT (getdate()),
	[St_GradePointAvg] [decimal](18, 0) NOT NULL,
	[St_Active] [varchar](3) NOT NULL,
 CONSTRAINT [PK_tbl_Temp_Registration] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DeleteTempStudentData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[sp_DeleteTempStudentData] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	TRUNCATE TABLE dbo.tbl_Temp_Registration
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_GetLastStudentId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Dushantha Madushan Wijewardhana
-- Create date: 22 Nov 2012
-- Description:	Select Student Last ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetLastStudentId] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Select statements for procedure here
	SELECT TOP 1 StudentId FROM tbl_Registration ORDER BY StudentId DESC 
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_InsertStudentData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[sp_InsertStudentData] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
INSERT INTO tbl_Registration (StudentId,St_Name,St_DOB,St_GradePointAvg,St_Active)
SELECT StudentId,St_Name,St_DOB,St_GradePointAvg,St_Active
FROM tbl_Temp_Registration
	--SELECT *  INTO tbl_Registration FROM tbl_Temp_Registration
--(StudentId,St_Name,St_DOB,St_GradePointAvg,St_Active) values (@studentId,@st_Name,@st_DOB,@st_GradePointAvg,@st_Active)
END


' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_GetCount]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[sp_GetCount]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Select statements for procedure here
	SELECT COUNT(*) FROM tbl_Temp_Registration 

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_InsertTempStudentData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[sp_InsertTempStudentData] 
	-- Add the parameters for the stored procedure here
	@studentId int,
	@st_Name varchar(50),
	@st_DOB datetime,
	@st_GradePointAvg decimal(5,2),
	@st_Active varchar(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tbl_Temp_Registration(StudentId,St_Name,St_DOB,St_GradePointAvg,St_Active) values (@studentId,@st_Name,@st_DOB,@st_GradePointAvg,@st_Active)
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_GetAllStudentdata]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[sp_GetAllStudentdata]

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Select statements for procedure here
	SELECT   StudentId As ''STUDENT ID'',St_Name As ''STUDENT NAME'', St_DOB AS ''DOB'',St_GradePointAvg AS ''GRADE AVERAGE'',St_Active AS ''ACTIVE'' FROM tbl_Temp_Registration 

END

' 
END
