﻿CREATE TABLE [dbo].[testimonial]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naslov] VARCHAR(50) NOT NULL, 
    [Tekst] VARCHAR(MAX) NOT NULL
)
