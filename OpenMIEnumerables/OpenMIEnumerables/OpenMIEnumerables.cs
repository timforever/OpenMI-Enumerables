using System.Collections.Generic;
using OpenMI.Standard;

namespace OpenMI.Extensions
{
    public static class Enumerables
    {
        public static IEnumerable<IOutputExchangeItem> GetOutputExchangeItems(this ILinkableComponent component)
        {
            for (int i = 0; i < component.OutputExchangeItemCount; i++)
            {
                yield return component.GetOutputExchangeItem(i);
            }
        }

        public static IEnumerable<IInputExchangeItem> GetInputExchangeItems(this ILinkableComponent component)
        {
            for (int i = 0; i < component.InputExchangeItemCount; i++)
            {
                yield return component.GetInputExchangeItem(i);
            }
        }

        public static IEnumerable<IDataOperation> GetDataOperations(this IOutputExchangeItem item)
        {
            for (int i = 0; i < item.DataOperationCount; i++)
            {
                yield return item.GetDataOperation(i);
            }
        }
    }
}
