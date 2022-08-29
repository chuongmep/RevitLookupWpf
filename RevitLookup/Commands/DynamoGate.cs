using System.Diagnostics;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitLookupWpf.View;

namespace RevitLookupWpf.Commands;

[Transaction(TransactionMode.Manual)]
public class DynamoGate : IExternalCommand
{
    public ExternalCommandData ExternalCommandData { get; }

    public DynamoGate()
    {
        
    }
    public DynamoGate(ExternalCommandData commandData) : this()
    {
        ExternalCommandData = commandData;
    }

    public void Snoop<TRvtObject>(TRvtObject obj)
    {
        LookupWindow window = new LookupWindow();
        window.SetRvtInstance(obj);
        window.Show();
    }

    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        Debug.WriteLine("Hello");
        return Result.Succeeded;
    }
}