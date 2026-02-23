using SensorX.Domain.SeedWork;

namespace SensorX.Domain.Common.Extensions;

public static class AuditExtensions
{
    public static void MarkCreated(this ICreationTrackable entity)
    {
        entity.CreatedAt = DateTimeOffset.UtcNow;
    }

    public static void MarkUpdated(this IUpdateTrackable entity)
    {
        entity.UpdatedAt = DateTimeOffset.UtcNow;
    }

    public static void MarkDeleted(this ISoftDeletable entity, long? deletedBy)
    {
        entity.IsDeleted = true;
        entity.DeletedBy = deletedBy;
        entity.DeletedAt = DateTimeOffset.UtcNow;
    }

    public static void Recover(this ISoftDeletable entity)
    {
        entity.IsDeleted = false;
        entity.DeletedBy = null;
        entity.DeletedAt = null;
    }

    public static void MarkExpiredIn(this IExpirable entity, TimeSpan duration)
    {
        entity.ExpiresAt = DateTimeOffset.UtcNow.Add(duration);
    }
    public static void MarkExpiredNow(this IExpirable entity)
    {
        entity.ExpiresAt = DateTimeOffset.UtcNow;
    }
    public static void MarkExpiredAt(this IExpirable entity, DateTimeOffset expiredAt)
    {
        entity.ExpiresAt = expiredAt;
    }
    public static bool IsExpired(this IExpirable entity)
        => entity.ExpiresAt <= DateTimeOffset.UtcNow;
}

