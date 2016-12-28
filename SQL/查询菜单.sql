select * from SysModule as m 
join SysRight r on m.Id = r.ModuleId
join SysRole as rl on r.RoleId = rl.Id
join SysRoleSysUser as rsu on rsu.SysRoleId = rl.Id
join SysUser as u on u.Id = rsu.SysUserId
where u.Id='admin' 
and r.Rightflag = 'true' 
and m.ParentId = 'RightManage'
and m.ParentId != '0'