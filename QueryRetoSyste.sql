
create database retoSiste

USE [retoSiste]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCredits](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](100) NULL,
	[Apellidos] [nvarchar](100) NULL,
	[Celular] [nvarchar](100) NULL,
	[Correo] [nvarchar](100) NULL,
	[TipoID] [nvarchar](100) NULL,
	[NumeroID] [nvarchar](100) NULL,
	[DireccionResidencia] [nvarchar](100) NULL,
	[Ciudad] [nvarchar](100) NULL,
	[Valor] [nvarchar](100) NULL,
	[Cuotas] [nvarchar](100) NULL,
	[Estado] [nvarchar](100) NULL
) ON [PRIMARY]
GO


