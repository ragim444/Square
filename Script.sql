-- Создание БД
USE master ;  
GO  

if db_id('Test') is not null
   drop database Test
   create database Test
go
use [Test]
create table Category (Id int,  Title nvarchar(max));

insert into Category values
   (1, N'Категония 1')
  ,(2, N'Категория 2')
  ,(3, N'Категория 3')
;

create table Product (Id int,  Title nvarchar(max));
insert into Product values
   (1, 'Продукт 1')
  ,(2, 'Продукт 2')
  ,(3, 'Продукт 3')
  ,(4, 'Продукт 4')
  ,(5, 'Продукт 5')
;

create table CategoryProductLink (CategoryId int, ProductId int);
insert into CategoryProductLink values
   (1, 1)
  ,(1, 2)
  ,(1, 3)
  ,(2, 1)
  ,(2, 3)
  ,(2, 4)
  ,(3, 1)
  ,(3, 2)
;

go

-- Запрос
select c.title, p.title
from [dbo].[Category] as c
join [dbo].[CategoryProductLink] as cp on cp.CategoryId = c.Id
full join [dbo].[Product] as p on cp.ProductId = p.Id
