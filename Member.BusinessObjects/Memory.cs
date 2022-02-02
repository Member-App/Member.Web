using System;

namespace Member.BusinessObjects
{
    public class Memory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ExternalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Guid LastModifiedByUserId { get; set; }
        public List<PrivilegeDefinition> PrivilegedUsers { get; set; }
    }
}
