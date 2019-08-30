CREATE TABLE [dbo].[Aluno] (
    [Id]             INT           NOT NULL,
    [Nome]           NVARCHAR (50) NULL,
    [Id_Professores] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PROFESSOR] FOREIGN KEY ([Id_Professores]) REFERENCES [dbo].[Professor] ([Id])
);

ALTER TABLE [dbo].[Aluno]
Add DataNascimento DateTime

