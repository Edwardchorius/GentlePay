using GentlePay.Persistence.Data.Models.BaseModel;
using GentlePay.Persistence.Data.Models.Enums;
using System;

namespace GentlePay.Persistence.Data.Models
{
    public class AccountModel : BaseDataModel
    {
        public Guid UserModelId { get; set; }
        public UserModel Holder { get; set; }
        public Currency Currency { get; set; }
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
    }
}
