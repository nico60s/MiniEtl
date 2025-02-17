

using MiniEtl.Common;

namespace MiniEtl.Excel.Models.CellValues
{
    internal class ValueResult : IMiniEtlResponse<object>
    {
        public bool IsSuccess => throw new NotImplementedException();

        public bool IsFailure => throw new NotImplementedException();

        public Error Error => throw new NotImplementedException();

        public object Result => throw new NotImplementedException();
    }
}
