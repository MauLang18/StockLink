namespace StockLink.Domain._6.Entities
{
    public partial class TbUsuario : BaseEntity
    {
        public string Username { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public int Rol { get; set; }

        public virtual TbRol RolNavigation { get; set; } = null!;
    }
}
