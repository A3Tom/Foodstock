CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(255),

	[CategoryId] INT NOT NULL,

	CONSTRAINT [Product_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES Category([Id])
)
