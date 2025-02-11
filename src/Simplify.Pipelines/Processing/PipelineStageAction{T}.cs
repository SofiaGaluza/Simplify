﻿using System;

namespace Simplify.Pipelines.Processing
{
	[Obsolete("Please use IConveyor with exceptions")]
	/// <summary>
	/// Provides pipeline stage action delegate
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="stageType">Type of the stage.</param>
	/// <param name="item">The item.</param>
	/// <param name="stageResult">Current pipeline executing stage result.</param>
	public delegate void PipelineStageAction<in T>(Type stageType, T item, bool stageResult);
}