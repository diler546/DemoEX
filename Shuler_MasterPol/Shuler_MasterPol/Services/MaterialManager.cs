using Shuler_MasterPol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuler_MasterPol.Models.Services
{
    /// <summary>
    /// PKGH
    /// Расчет количества материала.
    /// </summary>
    public class MaterialManager
    {
        /// <summary>
        /// PKGH
        /// Получить данные из базы данных и рассчитать целое количество материала, 
        /// необходимого для производства указанного количества продукции, учитывая возможный брак материала.
        /// </summary>
        /// <param name="productTypeId">Идентификатор типа продукции</param>
        /// <param name="materialTypeId">Идентификатор типа материала</param>
        /// <param name="productAmount">Количество получаемой продукции. Целое положительное число.</param>
        /// <param name="param0">Произвольный параметр. Вещественное положительное число.</param>
        /// <param name="param1">Произвольный параметр. Вещественное положительное число.</param>
        /// <returns>1) Возвращает целое число — количество необходимого материала с учетом возможного брака. 
        /// 2) Возвращает -1, если в качестве параметров указаны неподходящие данные.</returns>

        public static int CalculateMaterialAmount(int productTypeId,
            int materialTypeId,
            int productAmount,
            double param0,
            double param1)
        {
            ProductType productType = Program.context.ProductType.Where(p => p.IdProductType == productTypeId).FirstOrDefault();
            Material_type materialType = Program.context.Material_type.Where(p => p.IdMaterialType == materialTypeId).FirstOrDefault();


            if ((productType is null) ||
                (materialType is null) ||
                (productAmount <= 0) ||
                (param0 <= 0) ||
                (param1 <= 0)
                )
            {
                return -1;
            }

            double defectiveMaterialCoefficient = 1 + materialType.DetectiveMaterialPercentage / 100.0;

            double integralCoefficient = param0 *
                                         param1 * productType.ProductTypeCoefficient *
                                         defectiveMaterialCoefficient;


            int result = (int)Math.Floor(integralCoefficient * productAmount);

            return result;

        }
    }
}
