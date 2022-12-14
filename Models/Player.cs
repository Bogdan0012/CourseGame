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
    
    public partial class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> HP { get; set; }
        public Nullable<int> Skin { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<System.TimeSpan> TimeInGame { get; set; }
        public Nullable<int> Progress { get; set; }
        public Nullable<bool> IsBanned { get; set; }

        public override string ToString()
        {
            return Name + "   Score: " + Score + "   Time: " + TimeInGame + "\tBan: " + IsBanned;
        }
    }
}
