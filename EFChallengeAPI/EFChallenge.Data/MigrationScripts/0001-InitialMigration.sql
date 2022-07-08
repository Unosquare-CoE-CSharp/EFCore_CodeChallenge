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

CREATE TABLE [AddressTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_AddressTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Companies] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Countries] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Identifiers] (
    [Id] uniqueidentifier NOT NULL,
    [Data] nvarchar(500) NOT NULL,
    CONSTRAINT [PK_Identifiers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [IdentifierTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_IdentifierTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemAddenda] (
    [Id] uniqueidentifier NOT NULL,
    [ItemId] uniqueidentifier NOT NULL,
    [KeyField] nvarchar(50) NOT NULL,
    [Value] nvarchar(500) NOT NULL,
    CONSTRAINT [PK_ItemAddenda] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemContainerConstraints] (
    [Id] int NOT NULL IDENTITY,
    [ItemTypeId] int NOT NULL,
    [Min] bigint NOT NULL,
    [Max] bigint NOT NULL,
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
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_ItemStatuses] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemSubTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_ItemSubTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ItemTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    CONSTRAINT [PK_ItemTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [States] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [CountryId] int NOT NULL,
    CONSTRAINT [PK_States] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_States_Countries_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Countries] ([Id]) ON DELETE CASCADE
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

CREATE TABLE [Counties] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [StateId] int NOT NULL,
    CONSTRAINT [PK_Counties] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Counties_States_StateId] FOREIGN KEY ([StateId]) REFERENCES [States] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Addresses] (
    [Id] int NOT NULL IDENTITY,
    [Line1] nvarchar(300) NOT NULL,
    [Line2] nvarchar(300) NULL,
    [ZipPostalCode] nvarchar(25) NOT NULL,
    [City] nvarchar(150) NOT NULL,
    [CountyId] int NOT NULL,
    [AddressTypeId] int NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Addresses_Counties_CountyId] FOREIGN KEY ([CountyId]) REFERENCES [Counties] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[AddressTypes]'))
    SET IDENTITY_INSERT [AddressTypes] ON;
INSERT INTO [AddressTypes] ([Id], [Name])
VALUES (1, N'Physical Address'),
(2, N'IRS Address');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[AddressTypes]'))
    SET IDENTITY_INSERT [AddressTypes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Companies]'))
    SET IDENTITY_INSERT [Companies] ON;
INSERT INTO [Companies] ([Id], [Name])
VALUES (1, N'Unosquare');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Companies]'))
    SET IDENTITY_INSERT [Companies] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [Name])
VALUES (1, N'United States of America'),
(2, N'Mexico');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[IdentifierTypes]'))
    SET IDENTITY_INSERT [IdentifierTypes] ON;
INSERT INTO [IdentifierTypes] ([Id], [Name])
VALUES (1, N'Barcode'),
(2, N'QR Code'),
(3, N'RFID Chip');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[IdentifierTypes]'))
    SET IDENTITY_INSERT [IdentifierTypes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ItemTypeId', N'Max', N'Min') AND [object_id] = OBJECT_ID(N'[ItemContainerConstraints]'))
    SET IDENTITY_INSERT [ItemContainerConstraints] ON;
INSERT INTO [ItemContainerConstraints] ([Id], [ItemTypeId], [Max], [Min])
VALUES (1, 1, CAST(1 AS bigint), CAST(1 AS bigint)),
(2, 2, CAST(24 AS bigint), CAST(1 AS bigint)),
(3, 3, CAST(4 AS bigint), CAST(1 AS bigint));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ItemTypeId', N'Max', N'Min') AND [object_id] = OBJECT_ID(N'[ItemContainerConstraints]'))
    SET IDENTITY_INSERT [ItemContainerConstraints] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ItemStatuses]'))
    SET IDENTITY_INSERT [ItemStatuses] ON;
INSERT INTO [ItemStatuses] ([Id], [Name])
VALUES (1, N'In Warehouse'),
(2, N'In Transit'),
(3, N'Delivered');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ItemStatuses]'))
    SET IDENTITY_INSERT [ItemStatuses] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ItemSubTypes]'))
    SET IDENTITY_INSERT [ItemSubTypes] ON;
INSERT INTO [ItemSubTypes] ([Id], [Name])
VALUES (1, N'Can'),
(2, N'Plastic');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ItemSubTypes]'))
    SET IDENTITY_INSERT [ItemSubTypes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ItemTypes]'))
    SET IDENTITY_INSERT [ItemTypes] ON;
INSERT INTO [ItemTypes] ([Id], [Name])
VALUES (1, N'Coke'),
(2, N'24 Cokes Package'),
(3, N'Box with 4 Cokes Package');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ItemTypes]'))
    SET IDENTITY_INSERT [ItemTypes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryId', N'Name') AND [object_id] = OBJECT_ID(N'[States]'))
    SET IDENTITY_INSERT [States] ON;
INSERT INTO [States] ([Id], [CountryId], [Name])
VALUES (1, 1, N'Oregon');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryId', N'Name') AND [object_id] = OBJECT_ID(N'[States]'))
    SET IDENTITY_INSERT [States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryId', N'Name') AND [object_id] = OBJECT_ID(N'[States]'))
    SET IDENTITY_INSERT [States] ON;
INSERT INTO [States] ([Id], [CountryId], [Name])
VALUES (2, 2, N'Jalisco');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryId', N'Name') AND [object_id] = OBJECT_ID(N'[States]'))
    SET IDENTITY_INSERT [States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'StateId') AND [object_id] = OBJECT_ID(N'[Counties]'))
    SET IDENTITY_INSERT [Counties] ON;
INSERT INTO [Counties] ([Id], [Name], [StateId])
VALUES (1, N'Washington', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'StateId') AND [object_id] = OBJECT_ID(N'[Counties]'))
    SET IDENTITY_INSERT [Counties] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'StateId') AND [object_id] = OBJECT_ID(N'[Counties]'))
    SET IDENTITY_INSERT [Counties] ON;
INSERT INTO [Counties] ([Id], [Name], [StateId])
VALUES (2, N'Guadalajara', 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'StateId') AND [object_id] = OBJECT_ID(N'[Counties]'))
    SET IDENTITY_INSERT [Counties] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AddressTypeId', N'City', N'CountyId', N'Line1', N'Line2', N'ZipPostalCode') AND [object_id] = OBJECT_ID(N'[Addresses]'))
    SET IDENTITY_INSERT [Addresses] ON;
INSERT INTO [Addresses] ([Id], [AddressTypeId], [City], [CountyId], [Line1], [Line2], [ZipPostalCode])
VALUES (1, 2, N'Portland', 1, N'4800 Meadows Road, Suite 300 Lake Oswego', NULL, N'97035');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AddressTypeId', N'City', N'CountyId', N'Line1', N'Line2', N'ZipPostalCode') AND [object_id] = OBJECT_ID(N'[Addresses]'))
    SET IDENTITY_INSERT [Addresses] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AddressTypeId', N'City', N'CountyId', N'Line1', N'Line2', N'ZipPostalCode') AND [object_id] = OBJECT_ID(N'[Addresses]'))
    SET IDENTITY_INSERT [Addresses] ON;
INSERT INTO [Addresses] ([Id], [AddressTypeId], [City], [CountyId], [Line1], [Line2], [ZipPostalCode])
VALUES (2, 1, N'Guadalajara', 2, N'Av. de las Américas 1536, Country Club', NULL, N'44637');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AddressTypeId', N'City', N'CountyId', N'Line1', N'Line2', N'ZipPostalCode') AND [object_id] = OBJECT_ID(N'[Addresses]'))
    SET IDENTITY_INSERT [Addresses] OFF;
GO

CREATE INDEX [IX_Addresses_CountyId] ON [Addresses] ([CountyId]);
GO

CREATE UNIQUE INDEX [IX_AddressTypes_Name] ON [AddressTypes] ([Name]);
GO

CREATE UNIQUE INDEX [IX_Companies_Name] ON [Companies] ([Name]);
GO

CREATE INDEX [IX_Counties_StateId] ON [Counties] ([StateId]);
GO

CREATE UNIQUE INDEX [IX_Countries_Name] ON [Countries] ([Name]);
GO

CREATE UNIQUE INDEX [IX_IdentifierTypes_Name] ON [IdentifierTypes] ([Name]);
GO

CREATE INDEX [IX_Items_ItemStatusId] ON [Items] ([ItemStatusId]);
GO

CREATE INDEX [IX_Items_ItemSubTypeId] ON [Items] ([ItemSubTypeId]);
GO

CREATE INDEX [IX_Items_ItemTypeId] ON [Items] ([ItemTypeId]);
GO

CREATE INDEX [IX_Items_ParentItemId] ON [Items] ([ParentItemId]);
GO

CREATE UNIQUE INDEX [IX_ItemStatuses_Name] ON [ItemStatuses] ([Name]);
GO

CREATE UNIQUE INDEX [IX_ItemSubTypes_Name] ON [ItemSubTypes] ([Name]);
GO

CREATE UNIQUE INDEX [IX_ItemTypes_Name] ON [ItemTypes] ([Name]);
GO

CREATE INDEX [IX_States_CountryId] ON [States] ([CountryId]);
GO

CREATE UNIQUE INDEX [IX_States_Name] ON [States] ([Name]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220708203522_InitialMigration', N'6.0.6');
GO

COMMIT;
GO

