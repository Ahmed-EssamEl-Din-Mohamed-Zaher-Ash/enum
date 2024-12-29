namespace EnumProject.Enums;

[Flags]  
public enum Permission:byte
{
    
    Read = 1,
    Write = 2,
    Delete = 4,
    Execute = 8
}
