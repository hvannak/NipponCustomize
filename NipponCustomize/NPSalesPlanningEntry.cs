using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.BQL.Fluent;

namespace NipponCustomize
{
  public class NPSalesPlanningEntry : PXGraph<NPSalesPlanningEntry,NPSalesPlanning>
  {
        public NPSalesPlanningEntry()
        {
            NPSetup setupAutoNumber = SetupAutoNumber.Current;
        }
        public PXSetup<NPSetup> SetupAutoNumber;
        //The primary view
        public SelectFrom<NPSalesPlanning>.View NPSalesPlanning;
        //The view for the Sales Planning Detail
        public SelectFrom<NPSalesPlanningDetails>.Where<NPSalesPlanningDetails.salesPanngingNbr.IsEqual<NPSalesPlanning.salesPanngingNbr.FromCurrent>>.View NPSalesPlanningDetails;

        protected virtual void _(Events.RowPersisting<NPSalesPlanning> e)
        {
            NPSalesPlanning cPSalesPlanning = (NPSalesPlanning)e.Row;
        }

    }
}