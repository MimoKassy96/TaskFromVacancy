USE [testDB]
GO

SELECT [ProductName],[CategoryName]
  FROM [dbo].[Product]
left join [ProductCategory] on  [Product].[ProductId] = [ProductCategory].[ProductId]
left join [Category] on [Category].[CategoryId] = [ProductCategory].[CategoryId]


