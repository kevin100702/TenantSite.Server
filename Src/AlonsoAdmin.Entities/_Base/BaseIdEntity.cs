
using FreeSql.DataAnnotations;

namespace AlonsoAdmin.Entities
{
	public abstract class BaseIdEntity : IBaseId, ITenant
	{
		/// <summary>
		/// 主键
		/// </summary>
		[Column(Name = "ID", Position = 1, StringLength = 64, IsPrimary = true)]
		[Snowflake]
		public string Id { get; set; }

		/// <summary>
		/// 租户ID
		/// </summary>
		[Column(Name = "TenantID", StringLength = 64)]
        public string TenantID { get; set; }
    }
}
