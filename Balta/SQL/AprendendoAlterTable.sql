USE [Curso]

ALTER TABLE [Aluno]
    ADD [Document] NVARCHAR(11)

ALTER TABLE [Aluno]
    DROP COLUMN [Document]

ALTER TABLE [Aluno]
    ADD [Document] CHAR(11)


DROP TABLE Aluno

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0) 
)

DROP TABLE Aluno

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0)

    PRIMARY KEY([Id])
)

--HE POSSIVEL NOMERAR AS CHAVES, BASTA COLOAR A CONSTRANT NA FRENTE
DROP TABLE Aluno

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0)

    CONSTRAINT [PK_ALUNO_ID] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_ALUNO_EMAIL] UNIQUE([Email])
)

DROP TABLE [Curso]
CREATE TABLE [Curso](
    [Id] INT NOT NULL IDENTITY(1,1), --Começa com 1 e incrementa um a cada inserção evitando dar o MAX toda vez na tabela para saber qual é o ultimo
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL

    CONSTRAINT [PK_CURSO_ID] PRIMARY KEY([Id]),    
    CONSTRAINT [FK_CURSO_CATEGORIA] FOREIGN KEY([CategoriaId])    
        REFERENCES [Categoria]([Id])
)

CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME DEFAULT(GETDATE())

    CONSTRAINT PK_PROGRESSO_CURSO PRIMARY KEY([AlunoId], [CursoId])

)

CREATE TABLE [Categoria](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_CATEGORIA_ID] PRIMARY KEY([Id])    
)


CREATE INDEX[IX_ALUNO_EMAIL] ON [Aluno]([Email])
DROP INDEX[IX_ALUNO_EMAIL] ON [Aluno]([Email])


USE [master];

DECLARE @kill VARCHAR(8000) = '';
SELECT @kill = @kill + 'kill' + CONVERT(varchar(5), session_id) + ';'
FROM sys.dm_exec_sessions
WHERE database_id = DB_ID('Curso')

EXEC(@kill)
DROP DATABASE[Curso]