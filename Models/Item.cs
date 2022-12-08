//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseGame.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AssetUri { get; set; }
        public Nullable<int> Damage { get; set; }

        public static Item from(Item template)
        {
            Item item = new Item();
            item.Id = template.Id;
            item.Name = template.Name;
            item.AssetUri = template.AssetUri;
            item.Damage = template.Damage;
            return item;
        }
    }
}
