OpenMI-Enumerables
==================

The OpenMI Enumerables project contains extension methods to OpenMI 1.4 SDK interfaces in order to expose IEnumerables, making them much more natural to work with.

In OpenMI, the built-in way to access items in a collection requires the use of a standard for-loop. For example, to get at all of a LinkableComponent's IOutputExchangeItems:

```
ILinkableComponent component = ...
for (int i = 0; i < component.OutputExchangeItemCount; i++)
{
    IOutputExchangeItem item = component.GetOutputExchangeItem(i);
    // Do something with this item...
}
```

With the code from this project, instead you can now simply write:
```
foreach (IOutputExchangeItem item in component.GetOutputExchangeItems())
{
    // Do something with item.
}
```
Or, even better, Linq functions become available to you:
```
var meanDataOps = from dataOp in outputExchangeItem.GetDataOperations()
                  where dataOp.ID == "Mean value"
                  select dataOp;
```