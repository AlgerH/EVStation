USE [MOTCApiDB]
GO
SET IDENTITY_INSERT [dbo].[EV_OperatorData] ON 

INSERT [dbo].[EV_OperatorData] ([UKey], [OperatorID], [OperatorName_Zh_tw], [OperatorName_En], [AuthorityCode], [AuthorityName], [Telephone], [Address], [WebURL], [LogoURL], [TsAndCsURL], [BAN], [IsDelete], [CreateName], [CreateTime], [UpdateName], [UpdateTime]) VALUES (6, N'29162550', N'裕電能源股份有限公司', N'YES-Energy Service Co., LTD.', N'TPE', N'測試資料', N'02-27026627', N'新北市新店區中興路3段3號2樓', N'https://www.findcompany.com.tw', N'https://www.findcompany.com.tw/logo.png', N'https://www.findcompany.com.tw/', N'29162550', 0, N'SYSTEM', CAST(N'2023-09-28T08:30:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[EV_OperatorData] OFF
GO
