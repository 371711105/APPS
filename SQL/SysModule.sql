SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[SysModule]  WITH NOCHECK ADD  CONSTRAINT [FK_SysModule_SysModule] FOREIGN KEY([ParentId])
REFERENCES [dbo].[SysModule] ([Id])
GO

ALTER TABLE [dbo].[SysModule] NOCHECK CONSTRAINT [FK_SysModule_SysModule]
GO