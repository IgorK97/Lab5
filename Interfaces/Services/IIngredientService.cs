using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IIngredientService
    {

        BindingList<IngredientShortDto> GetIngredients(int? ps);

        BindingList<IngredientShortDto> GetConcreteIngredients(int ps, int ol_id);
    }
}
