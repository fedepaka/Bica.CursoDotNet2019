USE [B_CursoDotNet]
GO

/****** Object:  Table [dbo].[Persona]    Script Date: 08/22/2019 15:18:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Persona](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](100) NOT NULL,
	[Apellidos] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](50) NULL,
	[Documento] [int] NOT NULL,
	[TipoDocumento] [int] NOT NULL,
	[TipoPersona] [int] NOT NULL,
PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]

GO

--cliente

CREATE TABLE [dbo].[Cliente](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPersona] [bigint] NOT NULL,
	[Categoria] [nvarchar](50) NULL,
	[Codigo] [nvarchar](50) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Cliente] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Persona] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Persona_Cliente]
GO

--vendedor
CREATE TABLE [dbo].[Vendedor](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPersona] [bigint] NOT NULL,
	[TipoContrato] [nvarchar](50) NULL,
	[Sueldo] [decimal](18, 6) NOT NULL,
PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Vendedor]  WITH CHECK ADD  CONSTRAINT [FK_Vendedor_Persona] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Persona] ([Id])
GO

ALTER TABLE [dbo].[Vendedor] CHECK CONSTRAINT [FK_Vendedor_Persona]
GO

ALTER TABLE [dbo].[Vendedor] ADD  DEFAULT ((0)) FOR [Sueldo]
GO

