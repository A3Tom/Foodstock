CREATE TABLE [dbo].[TransactionLog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductId] INT NOT NULL,
	[StockId] INT NOT NULL,
	[ValueChange] DECIMAL,
	[Timestamp] DATETIMEOFFSET NOT NULL DEFAULT GETUTCDATE(),

	CONSTRAINT [TransactionLog_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES Product([Id]),
	CONSTRAINT [TransactionLog_Stock_StockId] FOREIGN KEY ([StockId]) REFERENCES Stock([Id])

)
