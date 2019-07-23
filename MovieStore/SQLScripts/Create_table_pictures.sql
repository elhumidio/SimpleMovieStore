
/****** Object:  Table [dbo].[pictures]    Script Date: 24/4/2019 11:03:21 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idcategory] [int] NULL,
	[picture_path] [varchar](500) NULL,
	[thumbnail_path] [varchar](500) NULL,
	[title] [varchar](100) NULL,
	[description] [text] NULL,
	[punctuation] [int] NULL,
 CONSTRAINT [PK_pictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[pictures]  WITH CHECK ADD  CONSTRAINT [fk_category] FOREIGN KEY([idcategory])
REFERENCES [dbo].[categories] ([Id])
GO

ALTER TABLE [dbo].[pictures] CHECK CONSTRAINT [fk_category]
GO


