using Shop.Core;
using Shop.Core.Interfaces;

namespace Shop.Domain.Entities;

public class CatalogType : BaseEntity, IAggregateRoot
{
    public CatalogType(string type)
    {
        Type = type;
    }

    private CatalogType() { } // EF Core

    public string Type { get; private set; }
}