Create table BookDetails(BookId int not null , BookName varchar(50),Author varchar(50),Publisher varchar(50),Price decimal(18,2))



Create procedure GetBooks
As
Begin
Select * from BookDetails
End



create procedure InsertBooks
@BookId As int  ,
@BookName As varchar(50) ,
@Author  As varchar(50), 
@Publisher As varchar(50) ,
@Price As decimal(18,2)
As
Begin
Insert into BookDetails Values(@BookId,@BookName,@Author,@Publisher,@Price)
End



Create Procedure DeleteBooks
@BookId As Int
As
Begin
Delete from BookDetails where BookId = @BookId
End

Create Procedure UpdateBook
@BookId As Int,
@BookName As varchar(50),
@Price As decimal(18,2)
As
Begin
Update BookDetails Set BookName = @BookName, Price = @Price  where BookId = @BookId
End

Create Procedure UpdateDemo
@BookId As Int,
@BookName As varchar(50)
As
Begin
Update BookDetails Set BookName = @BookName  where BookId = @BookId
End
