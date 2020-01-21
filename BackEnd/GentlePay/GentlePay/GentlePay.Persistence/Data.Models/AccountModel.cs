using GentlePay.Persistence.Data.Models.BaseModel;
using GentlePay.Persistence.Data.Models.Enums;

namespace GentlePay.Persistence.Data.Models
{
    public class AccountModel : BaseDataModel
    {
        public UserModel Holder { get; set; }
        public Currency Currency { get; set; }
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
    }
}
