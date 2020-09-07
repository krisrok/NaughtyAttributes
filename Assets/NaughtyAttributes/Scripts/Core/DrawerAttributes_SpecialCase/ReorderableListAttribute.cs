using System;

namespace NaughtyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ReorderableListAttribute : SpecialCaseDrawerAttribute
	{
		public bool DrawHeader { get; set; }
	}
}
