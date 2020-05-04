﻿CREATE TABLE [dbo].[User]
(
	
    [Id] NVARCHAR(128) PRIMARY KEY NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(256) NULL, 
    [CreatDate] DATETIME2 NULL DEFAULT getutctime()
)
