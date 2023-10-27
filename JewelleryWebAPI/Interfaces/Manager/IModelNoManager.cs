using EF.Core.Repository.Interface.Manager;
using JewelleryWebAPI.Models;

namespace JewelleryWebAPI.Interfaces.Manager
{
    public interface IModelNoManager:ICommonManager<TblModelNo>
    {
        string getModelNamebyId(decimal id);
    }
}
