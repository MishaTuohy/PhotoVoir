﻿DECLARE @RoleIDAdmin nvarchar(50),
	@RoleIDMember nvarchar(50),
	@UserIDAdmin nvarchar(50),
	@UserIDMember nvarchar(50)
			
SET @RoleIDAdmin = NewID()
SET @RoleIDMember = NewID()
SET @UserIDAdmin = NewID()
SET @UserIDMember = NewID()
		
INSERT INTO Roles(
	ID,
	Name
)VALUES(
	@RoleIDAdmin,
	'Administrator'
)
	
INSERT INTO Roles(
	ID,
	Name
)VALUES(
	@RoleIDMember,
	'Member'
)
		
INSERT INTO Users(
	ID,
	UserName ,
	Email ,
	Password ,
	Status 
)VALUES(
	@UserIDAdmin,'admin', 'admin@example.com', '1234567', 1
)
	
INSERT INTO Users(
	ID,
	UserName ,
	Email ,
	Password ,
	Status 
)VALUES(
	@UserIDMember,'member', 'member@example.com', '1234567', 1
)
	
INSERT INTO UserRoles(
	UserRoleID,
	UserID,
	RoleID
)VALUES(
	NewID(), @UserIDAdmin, @RoleIDAdmin
)
	
INSERT INTO UserRoles(
	UserRoleID,
	UserID,
	RoleID
)VALUES(
	NewID(), @UserIDMember, @RoleIDMember
)
GO