﻿namespace StockLink.Domain._6.Entities
{
    public partial class TbRol : BaseEntity
    {
        public TbRol()
        {
            TbUsuarios = new HashSet<TbUsuario>();
        }
        public string Rol { get; set; } = null!;
        public string Privilegios { get; set; } = null!;

        public virtual ICollection<TbUsuario> TbUsuarios { get; set; }
    }
}
