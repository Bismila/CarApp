
INSERT INTO [CarDb].[dbo].[Supports] (Name) VALUES ('Transmission');
INSERT INTO [CarDb].[dbo].[Supports] (Name) VALUES ('Vehicle Maintenance');
INSERT INTO [CarDb].[dbo].[Supports] (Name) VALUES ('Vehicle Rapair');
INSERT INTO [CarDb].[dbo].[Supports] (Name) VALUES ('Other');

INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Daewoo Lanos');
INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Chevrolet Aveo');
INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Peugeot 207');
INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Fiat 500');
INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Opel Vectra');
INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Nissan Maxima');
INSERT INTO [CarDb].[dbo].[Cars] (Name) VALUES ('Mitsubishi Colt');

INSERT INTO [CarDb].[dbo].[Users] ([LastName],[FirstName],[Phone],[Email])
     VALUES('Tom', 'Petrov', '777-555-77', 'tom@gamil.com')
INSERT INTO [CarDb].[dbo].[Users] ([LastName],[FirstName],[Phone],[Email])
     VALUES('Den', 'Petrov', '777-555-77', 'den@gamil.com')
INSERT INTO [CarDb].[dbo].[Users] ([LastName],[FirstName],[Phone],[Email])
     VALUES('Kay', 'Ivanov', '777-555-77', 'tkay@gamil.com')
INSERT INTO [CarDb].[dbo].[Users] ([LastName],[FirstName],[Phone],[Email])
     VALUES('Nill', 'Black', '777-555-77', 'nill@gamil.com')

INSERT INTO [CarDb].[dbo].[Orders]
           ([DateFrom]
           ,[DateEnd]
           ,[CarId]
           ,[UserId]
           ,[SupportsId]
           ,[Message])
     VALUES
           ('01/02/2019 11:30'
           ,'03/02/2019 12:00'
           ,1
           ,1
           ,1
           ,'Thanks')