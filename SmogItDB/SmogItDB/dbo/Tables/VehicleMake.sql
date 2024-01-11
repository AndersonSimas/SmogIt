﻿CREATE TABLE [dbo].[VehicleMake]
(
	[MakeId] SMALLINT  IDENTITY (1, 1) NOT NULL,
    [Make] VARCHAR(50) NULL,	
    CONSTRAINT [PK_VehicleMake] PRIMARY KEY CLUSTERED ([MakeId] ASC),
)
