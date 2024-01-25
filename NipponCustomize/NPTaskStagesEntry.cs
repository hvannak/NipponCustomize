using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.CR;

namespace NipponCustomize
{
  public class NPTaskStagesEntry : PXGraph<NPTaskStagesEntry,NPOppTask>
  {

        public NPTaskStagesEntry()
        {
            NPSetup setupAutoNumber = SetupAutoNumber.Current;
        }
        public PXSetup<NPSetup> SetupAutoNumber;
        //The primary view
        public SelectFrom<NPOppTask>.View NPOpportunitiesTask;
        //The view for the Sales Planning Detail
        public SelectFrom<NPOppTaskDetails>.Where<NPOppTaskDetails.oppTaskNbr.IsEqual<NPOppTask.oppTaskNbr.FromCurrent>>.View NPOpportunitiesTaskDetails;


        protected virtual void _(Events.RowSelected<NPOppTaskDetails> e)
        {

        }
    }
}