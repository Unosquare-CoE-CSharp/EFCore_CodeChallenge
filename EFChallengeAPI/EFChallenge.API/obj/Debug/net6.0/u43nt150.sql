IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Addresses] (
    [Id] int NOT NULL IDENTITY,
    [Line1] nvarchar(max) NOT NULL,
    [Line2] nvarchar(max) NULL,
    [ZipPostalCode] nvarchar(max) NOT NULL,
    [City] nvarchar(max) NOT NULL,
    [CountyStateId] int NOT NULL,
    [AddressTypeId] int NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AddressTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_AddressTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Companies] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Counties] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [StateId] int NOT NULL,
    CONSTRAINT [PK_Counties] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Countries] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Identifiers] (
    [Id] uniqueidentifier NOT NULL,
    [Data] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Identifiers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [IdentifierTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_IdentifierTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemAddenda] (
    [Id] uniqueidentifier NOT NULL,
    [ItemId] uniqueidentifier NOT NULL,
    [KeyField] nvarchar(max) NOT NULL,
    [Value] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ItemAddenda] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemContainerConstraints] (
    [Id] int NOT NULL IDENTITY,
    [ItemTypeId] int NOT NULL,
    [Min] int NOT NULL,
    [Max] int NOT NULL,
    CONSTRAINT [PK_ItemContainerConstraints] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemIdentifiers] (
    [ItemIdentifierId] uniqueidentifier NOT NULL,
    [ItemId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_ItemIdentifiers] PRIMARY KEY ([ItemIdentifierId])
);
GO

CREATE TABLE [ItemStatuses] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ItemStatuses] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemSubTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ItemSubTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ItemTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [States] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [CountryId] int NOT NULL,
    CONSTRAINT [PK_States] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Items] (
    [Id] uniqueidentifier NOT NULL,
    [ItemTypeId] int NOT NULL,
    [ItemStatusId] int NOT NULL,
    [ItemSubTypeId] int NOT NULL,
    [LocationId] int NOT NULL,
    [ParentItemId] uniqueidentifier NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Items_Items_ParentItemId] FOREIGN KEY ([ParentItemId]) REFERENCES [Items] ([Id]),
    CONSTRAINT [FK_Items_ItemStatuses_ItemStatusId] FOREIGN KEY ([ItemStatusId]) REFERENCES [ItemStatuses] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Items_ItemSubTypes_ItemSubTypeId] FOREIGN KEY ([ItemSubTypeId]) REFERENCES [ItemSubTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Items_ItemTypes_ItemTypeId] FOREIGN KEY ([ItemTypeId]) REFERENCES [ItemTypes] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Items_ItemStatusId] ON [Items] ([ItemStatusId]);
GO

CREATE INDEX [IX_Items_ItemSubTypeId] ON [Items] ([ItemSubTypeId]);
GO

CREATE INDEX [IX_Items_ItemTypeId] ON [Items] ([ItemTypeId]);
GO

CREATE INDEX [IX_Items_ParentItemId] ON [Items] ([ParentItemId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220708011718_InitialMigration', N'6.0.6');
GO

COMMIT;
GO

