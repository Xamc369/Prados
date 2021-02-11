CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                     NVARCHAR (450)     NOT NULL,
    [UserName]               NVARCHAR (256)     NULL,
    [NormalizedUserName]     NVARCHAR (256)     NULL,
    [Email]                  NVARCHAR (256)     NULL,
    [NormalizedEmail]        NVARCHAR (256)     NULL,
    [EmailConfirmed]         BIT                NOT NULL,
    [PasswordHash]           NVARCHAR (MAX)     NULL,
    [SecurityStamp]          NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]       NVARCHAR (MAX)     NULL,
    [PhoneNumber]            NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed]   BIT                NOT NULL,
    [TwoFactorEnabled]       BIT                NOT NULL,
    [LockoutEnd]             DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]         BIT                NOT NULL,
    [AccessFailedCount]      INT                NOT NULL,
    [Pro_Lote]               NVARCHAR (3)       NOT NULL,
    [Pro_Nombres]            NVARCHAR (50)      NOT NULL,
    [Pro_Apellidos]          NVARCHAR (50)      NOT NULL,
    [Pro_Observaciones]      NVARCHAR (MAX)     NULL,
    [Pro_Telefono]           NVARCHAR (10)      NOT NULL,
    [Pro_Identificacion]     NVARCHAR (10)      NOT NULL,
    [Pro_TipoIdentificacion] NVARCHAR (50)      NULL,
    [TipIdeId]               INT                NULL,
    [TipPerId]               INT                NULL,
    [TipVivId]               INT                NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetUsers_TipoIdentificaciontbls_TipIdeId] FOREIGN KEY ([TipIdeId]) REFERENCES [dbo].[TipoIdentificaciontbls] ([Id]),
    CONSTRAINT [FK_AspNetUsers_TipoPersonastbls_TipPerId] FOREIGN KEY ([TipPerId]) REFERENCES [dbo].[TipoPersonastbls] ([Id]),
    CONSTRAINT [FK_AspNetUsers_TiposViviendatbls_TipVivId] FOREIGN KEY ([TipVivId]) REFERENCES [dbo].[TiposViviendatbls] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[AspNetUsers]([NormalizedEmail] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([NormalizedUserName] ASC) WHERE ([NormalizedUserName] IS NOT NULL);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_TipIdeId]
    ON [dbo].[AspNetUsers]([TipIdeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_TipPerId]
    ON [dbo].[AspNetUsers]([TipPerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_TipVivId]
    ON [dbo].[AspNetUsers]([TipVivId] ASC);

