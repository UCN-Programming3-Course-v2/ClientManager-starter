CREATE TABLE [Customers] 
( 
	[Id] INT PRIMARY KEY NOT NULL, 
	[Firstname] nvarchar (50) NOT NULL, 
	[Lastname] nvarchar (50) NOT NULL, 
	[Address] nvarchar(50) NULL, 
	[City] nvarchar(50) NULL,
	[Zip] nvarchar(50) NULL,
	[Email] nvarchar(50) NULL,
	[Phone] nvarchar(50) NULL
);