USE [803ca1_Sazonov_A]
CREATE  TABLE  Users( 
    [id]  INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [login] VARCHAR(60),
	[password] VARCHAR(60)
)
