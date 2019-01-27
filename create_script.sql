CREATE TABLE Users(
    ID int IDENTITY(1,1) NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Phone varchar(10),
    Email varchar(20),
    PRIMARY KEY (ID) 
);

CREATE TABLE Cars(
    ID int IDENTITY(1,1) NOT NULL, 
    Name varchar(255) NOT NULL,
    PRIMARY KEY (ID) 
);

CREATE TABLE Supports(
    ID int IDENTITY(1,1) NOT NULL, 
    Name varchar(255) NOT NULL,
    
    PRIMARY KEY (ID) 
);

CREATE TABLE Orders(
    ID int IDENTITY(1,1) NOT NULL, 
    DateFrom varchar(16) NOT NULL,
    DateEnd varchar(16) NULL,
	CarId int NOT NULL References Cars(ID),
	UserId int NOT NULL References Users(ID),
    SupportsId int NOT NULL References Supports(ID),
	Message nvarchar (max) NULL,
    
    PRIMARY KEY (ID) 
);

