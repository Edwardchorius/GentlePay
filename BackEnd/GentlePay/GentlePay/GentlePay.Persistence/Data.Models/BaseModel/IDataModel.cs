using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Persistence.Data.Models.BaseModel
{
    public interface IDataModel
    {
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }

        string ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }

        bool IsDeleted { get; set; }
        DateTime? DeletedOn { get; set; }
        string DeletedBy { get; set; }
    }
}
