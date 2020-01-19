using GentlePay.Persistence.Data.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GentlePay.Persistence.Data.Models
{
    public class User : BaseDataModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public IEnumerable<Account> Accounts { get; set; }

        //public IEnumerable<Card> Cards { get; set; }

        //public IEnumerable<Transaction> Transactions {get; set; }
    }
}
