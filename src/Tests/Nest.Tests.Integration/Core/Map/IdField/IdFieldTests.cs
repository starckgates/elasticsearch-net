﻿using NUnit.Framework;
using Nest.Tests.MockData.Domain;

namespace Nest.Tests.Integration.Core.Map.IdField
{
	[TestFixture]
	public class IdFieldTests : BaseMappingTests
	{
		[Test]
		public void IdFieldSerializesFully()
		{
			var result = this._client.Map<ElasticsearchProject>(m => m
				.IdField(i => i
					.SetIndex("not_analyzed")
					.SetPath("myOtherId")
					.SetStored(false)
				)
			);
			this.DefaultResponseAssertations(result);
		}
	}
}
