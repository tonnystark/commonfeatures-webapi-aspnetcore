﻿using System.Data;

namespace WebApiDemo.Repositories
{
    public interface ITransactionRepository
    {
        DataTable GetTransactionsByYear(int year);
    }
}