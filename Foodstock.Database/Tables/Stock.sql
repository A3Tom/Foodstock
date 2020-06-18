CREATE TABLE [dbo].[Stock]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductId] INT NOT NULL,
	[StockTypeId] INT NOT NULL,
	[Value] DECIMAL NOT NULL,

	CONSTRAINT [Stock_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES Product([Id]),
	CONSTRAINT [Stock_StockType_StockTypeId] FOREIGN KEY ([StockTypeId]) REFERENCES StockType([Id]),

	CONSTRAINT [UQ_Stock] UNIQUE (ProductId, StockTypeId)
)
