

using MiniEtl.Common;
using MiniEtl.Excel.Models;

namespace MiniEtl.Excel
{
    public record MiniEtlExcelResponse : IMiniEtlResponse<WorkBook>
    {
        private readonly bool _isSuccess = true;
        private readonly Error? _error;
        public bool IsSuccess => _isSuccess;
        public WorkBook Result => throw new NotImplementedException();
        public bool IsFailure => !_isSuccess;
        public Error Error => _error;
    }
}
