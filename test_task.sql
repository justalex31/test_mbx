drop table if exists [dbo].[ProductCategory]
drop table if exists [dbo].[Product]
drop table if exists [dbo].[Category]

create table Product (
	[Id] uniqueidentifier not null default (newid()), 
	[Name] varchar(MAX) not null,
	constraint PK_Product_Id primary key ([Id])
)

create table Category (
	[Id] uniqueidentifier not null default (newid()), 
	[Name] varchar(MAX) not null,
	constraint PK_Category_Id primary key ([Id])
)

create table ProductCategory (
	[ProductId] uniqueidentifier not null,
	[CategoryId] uniqueidentifier not null,
	constraint FK_ProductCategory_ProductId foreign key (ProductId) references Product ([Id]),
	constraint FK_ProductCategory_CategoryId foreign key (CategoryId) references Category ([Id]),
)

insert into Product ([Id], [Name]) 
values 
	('a07a38fc-581d-11ed-9b6a-0242ac120002', 'Product 1'), 
	('b33c987c-581d-11ed-9b6a-0242ac120002', 'Product 2'), 
	('ba415ad6-581d-11ed-9b6a-0242ac120002', 'Product 3'), 
	('d7a34f76-581d-11ed-9b6a-0242ac120002', 'Product 4')
insert into Category ([Id], [Name]) 
values 
	('ee38c428-581d-11ed-9b6a-0242ac120002', 'Category 1'),
	('133fb268-581e-11ed-9b6a-0242ac120002', 'Category 2'),
	('1a2ed8a6-581e-11ed-9b6a-0242ac120002', 'Category 3'), 
	('1fd6d948-581e-11ed-9b6a-0242ac120002', 'Category 4')
insert into ProductCategory (ProductId, CategoryId) 
values 
	('a07a38fc-581d-11ed-9b6a-0242ac120002', 'ee38c428-581d-11ed-9b6a-0242ac120002'), 
	('a07a38fc-581d-11ed-9b6a-0242ac120002', '133fb268-581e-11ed-9b6a-0242ac120002'), 
	('b33c987c-581d-11ed-9b6a-0242ac120002', '1a2ed8a6-581e-11ed-9b6a-0242ac120002'), 
	('d7a34f76-581d-11ed-9b6a-0242ac120002', 'ee38c428-581d-11ed-9b6a-0242ac120002')

select * from dbo.Product
select * from dbo.Category
select * from dbo.ProductCategory

select pr.[Name], c.[Name] from Product as pr
left join ProductCategory as pc on pr.Id = pc.ProductId
left join Category as c on pc.CategoryId = c.Id