USE [MOTCApiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EV_OperatorData](
	[UKey] [int] IDENTITY(1,1) NOT NULL,
	[OperatorID] [nvarchar](50) NULL,
	[OperatorName_Zh_tw] [nvarchar](255) NULL,
	[OperatorName_En] [nvarchar](255) NULL,
	[AuthorityCode] [varchar](8) NULL,
	[AuthorityName] [nvarchar](255) NULL,
	[Telephone] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[WebURL] [nvarchar](255) NULL,
	[LogoURL] [nvarchar](255) NULL,
	[TsAndCsURL] [nvarchar](255) NULL,
	[BAN] [nvarchar](255) NULL,
	[IsDelete] [bit] NULL,
	[CreateName] [nvarchar](255) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateName] [nvarchar](255) NULL,
	[UpdateTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EV_OperatorData] ON 

INSERT [dbo].[EV_OperatorData] ([UKey], [OperatorID], [OperatorName_Zh_tw], [OperatorName_En], [AuthorityCode], [AuthorityName], [Telephone], [Address], [WebURL], [LogoURL], [TsAndCsURL], [BAN], [IsDelete], [CreateName], [CreateTime], [UpdateName], [UpdateTime]) VALUES (6, N'29162550', N'裕電能源股份有限公司', N'YES-Energy Service Co., LTD.', N'TPE', N'測試資料', N'02-27026627', N'新北市新店區中興路3段3號2樓', N'https://www.findcompany.com.tw', N'https://www.findcompany.com.tw/logo.png', N'https://www.findcompany.com.tw/', N'29162550', 0, N'SYSTEM', CAST(N'2023-09-28T08:30:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[EV_OperatorData] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UKey' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'UKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者代碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'OperatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者中文名稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'OperatorName_Zh_tw'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者英文名稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'OperatorName_En'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'業管機關簡碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'AuthorityCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'業管機關中文名稱 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'AuthorityName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者連絡電話' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者官網網址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'WebURL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者Logo網址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'LogoURL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'營運業者服務條款網址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'TsAndCsURL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司統一編號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'BAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建檔人員' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'CreateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建檔時間' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'異動人員' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'UpdateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'異動時間' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EV_OperatorData', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
