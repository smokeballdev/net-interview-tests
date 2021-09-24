using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NUnit.Framework;

namespace Tests
{
	public class WhenBuyingBottles
	{

		[TestCase(2,10,15)]
		public void ShouldCalculateMaximumNumberOfBottles(int waterUnitPrice, int totalAmountInDollars, int expectedMaximumBottles)
		{
			Assert.AreEqual(expectedMaximumBottles, BottleCalculator.GetMaximumNumberOfBottles(waterUnitPrice, totalAmountInDollars));
		}
    }
}
