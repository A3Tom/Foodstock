﻿CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(255) NOT NULL,
	[Active] BIT NOT NULL DEFAULT(0)
);
