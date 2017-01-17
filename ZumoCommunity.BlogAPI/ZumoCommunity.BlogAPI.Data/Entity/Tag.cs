using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZumoCommunity.BlogAPI.Data.Entity
{
	public class Tag : _Data
	{
		[Required]
		public string Title { get; set; }

		#region Navigation

		public virtual ICollection<Post> Posts { get; set; }

		#endregion
	}
}
