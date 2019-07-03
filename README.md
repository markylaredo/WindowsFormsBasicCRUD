# WindowsFormsBasicCRUD
Basic CRUD Operation using dapper

## TODO
* Run Scripts 
```sql
USE [TUTStudentDb]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/3/2019 11:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Name] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[School] [nvarchar](200) NULL,
	[Status] [binary](50) NULL,
	[Recorded] [datetime] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Recorded]  DEFAULT (sysdatetime()) FOR [Recorded]
GO
```
(Sql Service 2012 or higher)
