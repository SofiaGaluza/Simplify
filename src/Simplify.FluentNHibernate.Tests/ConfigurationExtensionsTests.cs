﻿using Microsoft.Extensions.Configuration;
using FluentNHibernate.Cfg;
using NHibernate.Dialect;
using NUnit.Framework;

namespace Simplify.FluentNHibernate.FrameworkTests;

[TestFixture]
public class ConfigurationExtensionsTests
{
	private const string ConfigSectionName = "DatabaseConnectionSettings";

	private IConfiguration _configuration;

	[SetUp]
	public void Initialize()
	{
		_configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", false)
			.Build();
	}

	[Test]
	public void InitializeFromConfigOracleClient_CorrectConfig_NoExceptions()
	{
		// Act
		Fluently.Configure().InitializeFromConfigOracleClient(_configuration);
	}

	[Test]
	public void InitializeFromConfigOracleClient_SectionNotFound_DatabaseConnectionConfigurationException()
	{
		// Act
		Assert.Throws<DatabaseConnectionConfigurationException>(() => Fluently.Configure().InitializeFromConfigOracleClient("foo"));
	}

	[Test]
	public void InitializeFromConfigOracleOdpNetNative_CorrectConfig_NoException()
	{
		// Act
		Fluently.Configure().InitializeFromConfigOracleOdpNetNative(_configuration);
	}

	[Test]
	public void InitializeFromConfigOracleOdpNet_CorrectConfig_NoExceptions()
	{
		// Act
		Fluently.Configure().InitializeFromConfigOracleOdpNet(_configuration);
	}

	[Test]
	public void InitializeFromConfigMySql_CorrectConfig_NoExceptions()
	{
		// Act
		Fluently.Configure().InitializeFromConfigMySql(_configuration);
	}

	[Test]
	public void InitializeFromConfigMsSql_CorrectConfig_NoExceptions()
	{
		// Act
		Fluently.Configure().InitializeFromConfigMsSql(_configuration);
	}

	[Test]
	public void InitializeFromConfigSqLiteInMemory_CorrectConfig_NoExceptions()
	{
		// Act

		Fluently.Configure().InitializeFromConfigSqLiteInMemory(true);
		Fluently.Configure().InitializeFromConfigSqLiteInMemory(true, c => c.Dialect<SQLiteDialect>());
	}
}