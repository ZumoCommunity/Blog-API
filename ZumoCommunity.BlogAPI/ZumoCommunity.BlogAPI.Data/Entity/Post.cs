using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZumoCommunity.BlogAPI.Data.Entity
{
	public class Post : _Data
	{
		[Required]
		[MaxLength(300)]
		[Index(IsUnique = true)]
		public string Title { get; set; }

		[NotMapped]
		public string Text { get; set; }

		public DateTime DatePublished { get; set; }

		#region Navigation

		public virtual ICollection<Tag> Tags { get; set; }

		#endregion
	}
}
