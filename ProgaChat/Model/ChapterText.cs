//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgaChat.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChapterText
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public string Text { get; set; }
    
        public virtual Chapter Chapter { get; set; }
    }
}
