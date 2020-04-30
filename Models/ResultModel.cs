using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class ResultModel
    {
        public ResultModel()
        {
            IsSuccess = false;
            Message = new List<string>();
        }
        public bool IsSuccess { get; set; }

        public object Data { get; set; }

        public List<string> Message { get; set; }

    }
}
