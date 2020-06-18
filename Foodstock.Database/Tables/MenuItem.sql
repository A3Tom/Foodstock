CREATE TABLE [dbo].[MenuItem]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CategoryId] INT NOT NULL,
	[ProductId] INT NOT NULL,
	[Position] INT NOT NULL,

	CONSTRAINT [MenuItem_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES Category([Id]),
	CONSTRAINT [MenuItem_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES Product([Id])
)
