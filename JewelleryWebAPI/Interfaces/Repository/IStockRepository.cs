﻿using EF.Core.Repository.Interface.Repository;
using JewelleryWebAPI.Models;

namespace JewelleryWebAPI.Interfaces.Repository
{
    public interface IStockRepository:ICommonRepository<TblStockPosting>
    {
    }
}
