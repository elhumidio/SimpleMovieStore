

/****** Object:  Table [dbo].[categories]    Script Date: 24/4/2019 11:03:13 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](100) NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


