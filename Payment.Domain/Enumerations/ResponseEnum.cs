using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Enumerations
{
    public enum ResponseEnum
    {
        [EnumDisplay(Name = "Approved Or Completed Successfully", Description = "Transacion or operation was successful")]
        ApprovedOrCompletedSuccesfully = 00,

        [EnumDisplay(Name = "Status Unknown", Description = "Status of transacion or operation is unknown")]
        StatusUnknown = 01,

        [EnumDisplay(Name = "Invalid Phone Number", Description = "Phone number is invalid")]
        InvalidPhoneNumber = 02,

    }
}
