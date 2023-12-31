USE [BNP]
GO
/****** Object:  Table [dbo].[MOVIMENTO_MANUAL]    Script Date: 02/01/2024 11:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMENTO_MANUAL](
	[DAT_MES] [numeric](2, 0) NOT NULL,
	[DAT_ANO] [numeric](4, 0) NOT NULL,
	[NUM_LANCAMENTO] [numeric](18, 0) NOT NULL,
	[COD_PRODUTO] [char](4) NOT NULL,
	[COD_COSIF] [char](11) NOT NULL,
	[DES_DESCRICAO] [varchar](50) NOT NULL,
	[DAT_MOVIMENTO] [smalldatetime] NOT NULL,
	[COD_USUARIO] [varchar](15) NOT NULL,
	[VAL_VALOR] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_MOVIMENTO_MANUAL] PRIMARY KEY CLUSTERED 
(
	[DAT_MES] ASC,
	[DAT_ANO] ASC,
	[NUM_LANCAMENTO] ASC,
	[COD_PRODUTO] ASC,
	[COD_COSIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 02/01/2024 11:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUTO](
	[COD_PRODUTO] [char](4) NOT NULL,
	[DES_PRODUTO] [varchar](30) NULL,
	[STA_STATUS] [char](1) NULL,
 CONSTRAINT [PK_PRODUTO] PRIMARY KEY CLUSTERED 
(
	[COD_PRODUTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUTO_COSIF]    Script Date: 02/01/2024 11:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUTO_COSIF](
	[COD_PRODUTO] [char](4) NOT NULL,
	[COD_COSIF] [varchar](11) NOT NULL,
	[COD_CLASSIFICACAO] [char](6) NULL,
	[STA_STATUS] [char](4) NULL,
 CONSTRAINT [PK_PRODUTO_COSIF] PRIMARY KEY CLUSTERED 
(
	[COD_PRODUTO] ASC,
	[COD_COSIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ListarMovimento]    Script Date: 02/01/2024 11:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ListarMovimento]
as
	select mm.DAT_MES , mm.DAT_ANO, p.COD_PRODUTO , p.DES_PRODUTO , mm.NUM_LANCAMENTO , mm.DES_DESCRICAO , mm.VAL_VALOR  
	from MOVIMENTO_MANUAL mm
	inner join Produto p on p.COD_PRODUTO = mm.COD_PRODUTO
	order by mm.DAT_ANO, mm.DAT_MES, mm.NUM_LANCAMENTO
GO
