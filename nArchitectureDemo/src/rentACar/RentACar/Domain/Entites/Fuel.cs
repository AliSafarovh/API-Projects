﻿using Core.Persistence.Repositories;

namespace Domain.Entites;
public class Fuel : Entity<Guid>
{
    public string Name { get; set; }


    public virtual ICollection<Model> Models { get; set; }
    public Fuel()
    {
        Models = new HashSet<Model>();
    }
    public Fuel(Guid id,string name)
    {
        Id = id;
        Name = name;
    }
}
