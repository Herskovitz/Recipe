

delete Recipe
from Recipe r
join Cuisine c
on r.CuisineId = c.CuisineId
where c.CuisineType like 'Test%'

delete Users where Username like 'TestUser%'

delete Cuisine where CuisineType like 'Test%'


insert Users (UserFirstName,UserLastName,Username)
select 'Test', 'User','TestUser1'
union select 'Testing','User', 'TestUser2'

insert Cuisine (CuisineType)
select 'Test'
union select 'Testing'

insert Recipe (CuisineId,UserId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select CuisineId from Cuisine where CuisineType = 'Test'),(select UserId from Users where UserFirstName = 'Test'),'Test Recipe 1',500,'09/19/2024','09/20/2024',null
union select (select CuisineId from Cuisine where CuisineType = 'Test'),(select UserId from Users where UserFirstName = 'Test'),'Test Recipe 2',550,'09/19/2024',null,null
union select (select CuisineId from Cuisine where CuisineType = 'Test'),(select UserId from Users where UserFirstName = 'Test'),'Test Recipe 3',600,'09/19/2024','09/20/2024',null
union select (select CuisineId from Cuisine where CuisineType = 'Testing'),(select UserId from Users where UserFirstName = 'Testing'),'Test Recipe 4',650,'09/19/2024','09/20/2024',Getdate() - 1
union select (select CuisineId from Cuisine where CuisineType = 'Testing'),(select UserId from Users where UserFirstName = 'Testing'),'Test Recipe 5',700,'09/19/2024',null,null

