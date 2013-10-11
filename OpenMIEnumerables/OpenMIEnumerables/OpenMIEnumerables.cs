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

        public static IEnumerable<IDataOperation> GetDataOperations(this ILink link)
        {
            for (int i = 0; i < link.DataOperationsCount; i++)
            {
                yield return link.GetDataOperation(i);
            }
        }

        public static IEnumerable<IArgument> GetArguments(this IDataOperation op)
        {
            for (int i = 0; i < op.ArgumentCount; i++)
            {
                yield return op.GetArgument(i);
            }
        }

        /// <summary>
        /// Get discrete time stamps or time spans for a specific combination of ElementSet and Quantity.
        /// </summary>
        /// <param name="discreteTimes"></param>
        /// <param name="quantity">The quantity.</param>
        /// <param name="elementSet">The element.</param>
        /// <returns>Discrete time stamp or time span.</returns>
        public static IEnumerable<ITime> GetDiscreteTimes(this IDiscreteTimes discreteTimes, IQuantity quantity, IElementSet elementSet)
        {
            for (int i = 0; i < discreteTimes.GetDiscreteTimesCount(quantity, elementSet); i++)
            {
                yield return discreteTimes.GetDiscreteTime(quantity, elementSet, i);
            }
        }

        public static IEnumerable<EventType> GetAcceptedEventTypes(this IListener listener)
        {
            for (int i = 0; i < listener.GetAcceptedEventTypeCount(); i++)
            {
                yield return listener.GetAcceptedEventType(i);
            }
        }

        public static IEnumerable<EventType> GetPublishedEventTypes(this IPublisher publisher)
        {
            for (int i = 0; i < publisher.GetPublishedEventTypeCount(); i++)
            {
                yield return publisher.GetPublishedEventType(i);
            }
        }

        public static IEnumerable<double> GetScalars(this IScalarSet scalarSet)
        {
            for (int i = 0; i < scalarSet.Count; i++)
            {
                yield return scalarSet.GetScalar(i);
            }
        }

        public static IEnumerable<IVector> GetVectors(this IVectorSet vectorSet)
        {
            for (int i = 0; i < vectorSet.Count; i++)
            {
                yield return vectorSet.GetVector(i);
            }
        }
    }
}
