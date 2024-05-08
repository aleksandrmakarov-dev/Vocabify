﻿using Microsoft.AspNetCore.Identity;

namespace Vocabify.API.Data.Entities
{
    public class Set:EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public string? Image { get; set; }
        public required string TextLang { get; set; }
        public required string DefinitionLang { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public List<Term> Terms { get; set; }
    }
}
