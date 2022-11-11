﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class PodRequestDto
	{
		public string Name { get; set; }
		public int Price { get; set; }
	}

	public class PodResponseDto : PodRequestDto
	{
		public int Id { get; set; }
	}
}