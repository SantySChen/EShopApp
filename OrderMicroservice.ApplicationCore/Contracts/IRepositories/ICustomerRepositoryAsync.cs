﻿using OrderMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.ApplicationCore.Contracts.IRepositories
{
    public interface ICustomerRepositoryAsync : IRepositoryAsync<Customer>
    {
        Task<Address> GetAddressById(int id);
        Task<int> SaveCustomerAddress(Address address);
    }
}
