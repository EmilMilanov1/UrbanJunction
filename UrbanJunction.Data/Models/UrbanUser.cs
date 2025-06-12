﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanJunction.Data.Models
{
	public class UrbanUser : IdentityUser
	{
		public string PreferredTheme { get; set; } // Light/Dark
		public ICollection<Post> Posts { get; set; } = new List<Post>();
	}
}
