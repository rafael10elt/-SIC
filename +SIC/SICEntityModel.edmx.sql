
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/03/2018 00:38:11
-- Generated from EDMX file: C:\Users\Rafa\source\repos\+SIC\+SIC\SICEntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SICDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_CustomerOrder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [JobTitle] nvarchar(max)  NULL,
    [EmployeeId] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [ADM] nvarchar(max)  NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerId] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NULL,
    [BIN] nvarchar(max)  NULL,
    [Phone] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [Province] nvarchar(max)  NULL,
    [PostalCode] nvarchar(max)  NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(max)  NULL,
    [Brand] nvarchar(max)  NULL,
    [Specification] nvarchar(max)  NULL,
    [Warehouse] nvarchar(max)  NULL,
    [Room] nvarchar(max)  NULL,
    [Aisle] nvarchar(max)  NULL,
    [ProductType] nvarchar(max)  NULL,
    [Shelf] nvarchar(max)  NULL,
    [Quantity] nvarchar(max)  NULL,
    [Currency] nvarchar(max)  NULL,
    [Price] nvarchar(max)  NULL,
    [CustomerCustomerId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- Creating primary key on [OrderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerCustomerId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_CustomerOrder]
    FOREIGN KEY ([CustomerCustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrder'
CREATE INDEX [IX_FK_CustomerOrder]
ON [dbo].[Orders]
    ([CustomerCustomerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------