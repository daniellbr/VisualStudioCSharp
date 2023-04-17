CREATE DATABASE [Cursos]


DROP TABLE Curso
CREATE TABLE [Curso](
    [Id] INT NOT NULL IDENTITY(1,1), --Começa com 1 e incrementa um a cada inserção evitando dar o MAX toda vez na tabela para saber qual é o ultimo
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL

    CONSTRAINT [PK_CURSO_ID] PRIMARY KEY([Id]),    
    CONSTRAINT [FK_CURSO_CATEGORIA] FOREIGN KEY([CategoriaId])    
        REFERENCES [Categoria]([Id])
)

DROP TABLE Categoria
CREATE TABLE [Categoria](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_CATEGORIA_ID] PRIMARY KEY([Id])    
)


--Deletando um database
-- USE [master];

-- DECLARE @kill VARCHAR(8000) = '';
-- SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'
-- FROM sys.dm_exec_sessions
-- WHERE database_id = DB_ID('Curso')

-- EXEC(@kill);
-- DROP DATABASE[Curso]

--Inserindo na tabela Categoria
INSERT INTO [Categoria]([Nome])VALUES('Backend')
INSERT INTO [Categoria]([Nome])VALUES('Frontend')
INSERT INTO [Categoria]([Nome])VALUES('Mobile')


--Inserindo na tabela Categoria
INSERT INTO [Curso]([Nome],[CategoriaId]) VALUES('Fundamentos C#',1)
INSERT INTO [Curso]([Nome],[CategoriaId]) VALUES('Fundamentos Angular',2)
INSERT INTO [Curso]([Nome],[CategoriaId]) VALUES('Fundamentos Android',3)

--Select
SELECT TOP 10 * FROM Curso
SELECT TOP 10 * FROM Categoria

SELECT TOP 10 * FROM Curso --where CategoriaId = 1
ORDER BY Nome DESC
