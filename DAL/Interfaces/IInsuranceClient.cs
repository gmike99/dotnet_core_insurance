﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInsuranceClient
    {
        Task<InsuranceClient> AddInsuranceClient(string usename, string email);

        Task<List<InsuranceClient>> GetAllInsuranceClients();
    }
}
