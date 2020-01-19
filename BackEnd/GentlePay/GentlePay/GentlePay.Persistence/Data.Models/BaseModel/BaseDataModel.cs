﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GentlePay.Persistence.Data.Models.BaseModel
{
    public abstract class BaseDataModel : IDataModel
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}
