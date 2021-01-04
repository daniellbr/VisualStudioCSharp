using System;

namespace AppMVCBasica.Models
{
    public abstract class Entity
    {
        protected Guid id { get; set; }

        public Entity()
        {
            id = Guid.NewGuid();
        }
    }
}
