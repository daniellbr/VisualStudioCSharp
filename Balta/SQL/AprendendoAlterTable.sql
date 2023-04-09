USE [Curso]

ALTER TABLE [Aluno]
    ADD [Document] NVARCHAR(11)

ALTER TABLE [Aluno]
    DROP COLUMN [Document]

ALTER TABLE [Aluno]
    ADD [Document] CHAR(11)


DROP TABLE Aluno

