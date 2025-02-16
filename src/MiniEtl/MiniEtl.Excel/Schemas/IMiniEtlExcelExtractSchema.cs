

using MiniEtl.Common;

namespace MiniEtl.Excel.Schemas
{
    public interface IMiniEtlExcelExtractSchema : IMiniEtlModuleContext
    {
        string FileName { get; }
        int Version { get; }
    }
}
