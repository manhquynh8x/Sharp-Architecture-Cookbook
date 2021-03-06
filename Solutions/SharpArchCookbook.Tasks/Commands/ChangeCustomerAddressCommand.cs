﻿namespace SharpArchCookbook.Tasks.Commands
{
    using System.ComponentModel.DataAnnotations;

    public class ChangeCustomerAddressCommand : AddressCommandBase
    {
        public ChangeCustomerAddressCommand(
            int id,
            string addressLine1,
            string addressLine2,
            string city,
            string stateProvince,
            string postalCode,
            string countryRegion)
            : base(addressLine1, addressLine2, city, stateProvince, postalCode, countryRegion)
        {
            this.Id = id;
        }

        [Required]
        public int Id { get; set; }
    }
}