using GentlePay.Persistence.Data.Models.BaseModel;
using System.Collections.Generic;

namespace GentlePay.Persistence.Data.Models
{
    public class User : BaseDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Account> Accounts { get; set; }       
    }
}
