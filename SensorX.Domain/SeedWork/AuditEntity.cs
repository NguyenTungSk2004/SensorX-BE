using SensorX.Domain.Common.Extensions;

namespace SensorX.Domain.SeedWork
{
    public abstract class AuditEntity : Entity<VoId>, ICreationTrackable, IUpdateTrackable
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }

        protected AuditEntity(VoId id) : base(id)
        {
            this.MarkCreated();
        }
    }
}

