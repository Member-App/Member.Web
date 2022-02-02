using System;

namespace Member.BusinessObjects
{
	public enum AccessLevel
    {
		READ,
		WRITE
    }

	public class PrivilegeDefinition
	{
		public Guid UserId { get; set; }
		public AccessLevel Access { get; set; }
		public bool CanShare { get; set; }
	}
}
