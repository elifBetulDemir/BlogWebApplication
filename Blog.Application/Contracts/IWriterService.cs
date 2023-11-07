﻿using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface IWriterService
{
	public Task Add(Writer writer);
	bool LoginPage(Writer writer);
}
