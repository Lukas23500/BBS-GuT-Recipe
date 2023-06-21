﻿namespace API.DTOs
{
    public class GetCategoryDto : IMappedDto<Category>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Title { get; set; }
    }
}
