
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO

DECLARE @UserId Nvarchar(50) = N'cfd839bd-e90c-4551-aef7-8919e37d31b5'

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (1, N'Hyundai', N'i20', 2019, 0, CAST(37000.00 AS Decimal(18, 2)), N'\Images\1.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (2, N'Mercedes-Benz', N'Vaneo', 2004, 0, CAST(17000.00 AS Decimal(18, 2)), N'\Images\2.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (3, N'Toyota', N'Auris', 2014, 2, CAST(27500.00 AS Decimal(18, 2)), N'\Images\3.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (4, N'Renault', N'Megane', 2021, 1, CAST(53000.00 AS Decimal(18, 2)), N'\Images\4.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (5, N'Suzuki', N'Vitara', 2018, 0, CAST(39700.00 AS Decimal(18, 2)), N'\Images\5.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (6, N'Porsche', N'911', 2022, 0, CAST(146000.00 AS Decimal(18, 2)), N'\Images\6.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (7, N'Fiat', N'126p', 1996, 0, CAST(8000.00 AS Decimal(18, 2)), N'\Images\7.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (8, N'Hyundai', N'Tucson', 2017, 1, CAST(79500.00 AS Decimal(18, 2)), N'\Images\8.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (9, N'Fiat', N'500X', 2016, 1, CAST(60000.00 AS Decimal(18, 2)), N'\Images\9.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (10, N'Fiat', N'Tipo', 2020, 0, CAST(59500.00 AS Decimal(18, 2)), N'\Images\10.jpg', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (11, N'Mercedes-Benz', N'B Klasa', 2018, 2, CAST(92900.00 AS Decimal(18, 2)), N'\Images\11.jpg', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (12, N'Fiat', N'500', 2021, 2, CAST(70900.00 AS Decimal(18, 2)), N'\Images\12.jpg', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (13, N'Hyundai', N'Tucson', 2023, 0, CAST(158900.00 AS Decimal(18, 2)), N'\Images\13.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (14, N'Hyundai', N'i20', 2023, 0, CAST(86500.00 AS Decimal(18, 2)), N'\Images\14.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (15, N'Toyota', N'Auris', 2016, 2, CAST(72000.00 AS Decimal(18, 2)), N'\Images\15.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (16, N'Suzuki', N'Baleno', 2018, 0, CAST(40900.00 AS Decimal(18, 2)), N'\Images\16.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (17, N'Suzuki', N'SX4', 2021, 2, CAST(95000.00 AS Decimal(18, 2)), N'\Images\17.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (18, N'Porsche', N'Taycan', 2022, 2, CAST(832800.00 AS Decimal(18, 2)), N'\Images\18.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (19, N'Mercedes-Benz', N'GLS', 2015, 1, CAST(214900.00 AS Decimal(18, 2)), N'\Images\19.webp', @UserId)

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Year], [Fuel], [Price], [PhotoFileName], [UserId]) 
VALUES (20, N'Fiat', N'Punto Evo', 2012, 0, CAST(11800.00 AS Decimal(18, 2)), N'\Images\20.webp', @UserId)
GO

SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
