create table UserRegistration    
(    
 UserId int not null primary key identity(1,1),    
 Username nvarchar(150),    
 Pwd nvarchar(100),    
 Confirmpwd nvarchar(100),    
 Email nvarchar(150),    
 Gender char,    
 MaritalStatus nvarchar(100)    
);  