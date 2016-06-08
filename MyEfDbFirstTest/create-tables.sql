SELECT @@VERSION
SELECT @@SERVERNAME
EXEC sp_databases

USE tempdb

IF (EXISTS(SELECT name 
FROM master.dbo.sysdatabases
WHERE name = 'mydb'))
    BEGIN
    PRINT 'mydb is existed!'
    DROP DATABASE mydb
    END
ELSE
    PRINT 'mydb is not existed!'

CREATE DATABASE mydb
USE mydb
SELECT DB_NAME()

CREATE TABLE [dbo].[Course] (
    [CourseID]  INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (50) NULL,
    [Credits]   INT           NULL,
    [Credits2]  INT           NULL,
    PRIMARY KEY CLUSTERED ([CourseID] ASC)
)

CREATE TABLE [dbo].[Student] (
    [StudentID]      INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [EnrollmentDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
)

SELECT * FROM information_schema.tables