//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(TPIA.Entity.News.Contexts.NewsContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets55546146c74e030819578393cb04d52a8b658be4e16dc0a125a9cf7b47bb35dc))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySets55546146c74e030819578393cb04d52a8b658be4e16dc0a125a9cf7b47bb35dc : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "55546146c74e030819578393cb04d52a8b658be4e16dc0a125a9cf7b47bb35dc"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.News")
            {
                return GetView0();
            }

            if (extentName == "NewsContext.News")
            {
                return GetView1();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.News.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing News
        [CodeFirstDatabaseSchema.News](T1.News_ID, T1.News_Category, T1.News_Title, T1.News_NewsContent, T1.News_CreateTime, T1.News_IsEnable)
    FROM (
        SELECT 
            T.ID AS News_ID, 
            T.Category AS News_Category, 
            T.Title AS News_Title, 
            T.NewsContent AS News_NewsContent, 
            T.CreateTime AS News_CreateTime, 
            T.IsEnable AS News_IsEnable, 
            True AS _from0
        FROM NewsContext.News AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for NewsContext.News.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing News
        [TPIA.Entity.News.Contexts.News](T1.News_ID, T1.News_Category, T1.News_Title, T1.News_NewsContent, T1.News_CreateTime, T1.News_IsEnable)
    FROM (
        SELECT 
            T.ID AS News_ID, 
            T.Category AS News_Category, 
            T.Title AS News_Title, 
            T.NewsContent AS News_NewsContent, 
            T.CreateTime AS News_CreateTime, 
            T.IsEnable AS News_IsEnable, 
            True AS _from0
        FROM CodeFirstDatabase.News AS T
    ) AS T1");
        }
    }
}
