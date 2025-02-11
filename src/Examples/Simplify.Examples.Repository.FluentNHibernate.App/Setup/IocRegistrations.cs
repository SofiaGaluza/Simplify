﻿using Simplify.DI;

namespace Simplify.Examples.Repository.FluentNHibernate.App.Setup
{
	public static class IocRegistrations
	{
		public static IDIContainerProvider RegisterSimplifyFluentNHibernateExamplesApp(this IDIContainerProvider provider)
		{
			provider.RegisterConfiguration()
				.RegisterDatabase()
				.RegisterInfrastructure();

			return provider;
		}
	}
}