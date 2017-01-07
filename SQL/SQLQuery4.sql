select a.*,ISNULL(b.SysUserId,0) as flag1 from SysRole a left join
    SysRoleSysUser b 
    on a.Id = b.SysRoleId
    and b.SysUserId = @UserId
    order by b.SysUserId desc