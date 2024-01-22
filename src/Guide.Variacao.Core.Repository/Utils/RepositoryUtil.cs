using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Utils
{
    public static class RepositoryUtil
    {
        public static void SoftDelete<T>(this DbContext context, T entity) where T : class
        {
            context.Entry(entity).CurrentValues["IsDeleted"] = true;
            context.Entry(entity).Property("IsDeleted").IsModified = true;
        }

        public static void Detach<T>(this DbContext context, T element)
        {
            context.Entry(element!).State = EntityState.Detached;
        }

        public static void Detach<T>(this DbContext context, IQueryable<T> elements)
        {
            foreach (var element in elements)
                context.Entry(element!).State = EntityState.Detached;
        }
    }
}
