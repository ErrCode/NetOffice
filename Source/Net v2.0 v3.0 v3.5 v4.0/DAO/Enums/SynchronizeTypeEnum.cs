//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary DAO 6, 12, 
	 /// </summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum SynchronizeTypeEnum
	{
		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibrary("DAO", 6,12)]
		 dbRepExportChanges = 1,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibrary("DAO", 6,12)]
		 dbRepImportChanges = 2,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByLibrary("DAO", 6,12)]
		 dbRepImpExpChanges = 4,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByLibrary("DAO", 6,12)]
		 dbRepSyncInternet = 16
	}
}