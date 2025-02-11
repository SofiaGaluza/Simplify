﻿using System;

namespace Simplify.Examples.Repository.FluentNHibernate.App.Infrastructure.ConsoleImpl
{
	public class ConsoleNotifier : INotifier
	{
		public void ShowNoArgsMessage()
		{
			Console.WriteLine("No args specified, please specify user name to search.");
		}

		public void ShowTooManyArgsMessage()
		{
			Console.WriteLine("Too many args specified.");
		}
	}
}