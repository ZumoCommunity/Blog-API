﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ZumoCommunity.BlogAPI.Data.Entity
{
	public abstract class _Data
	{
		[Key]
		[Required]
		public Guid Id { get; set; }

		public virtual bool IsDataValid()
		{
			if (Id == Guid.Empty)
			{
				return false;
			}

			return true;
		}
	}
}
