using NipponCustomize;
using PX.Data;
using PX.Data.BQL;
using PX.Data.BQL.Fluent;
using PX.Objects.CS;
using PX.SM.Alias;
using System;
using System.Runtime.CompilerServices;

namespace PX.Objects.CR
{
    // Acuminator disable once PX1016 ExtensionDoesNotDeclareIsActiveMethod extension should be constantly active
    public class OpportunityMaint_Extension : PXGraphExtension<PX.Objects.CR.OpportunityMaint>
  {
    #region Event Handlers
    public delegate void PersistDelegate();
    [PXOverride]
    public void Persist(PersistDelegate baseMethod)
    {
            try
            {
                baseMethod();
                if (this.Base.Opportunity.Current != null)
                {
                    CROpportunityProbability cROpportunityProbability = SelectFrom<CROpportunityProbability>.Where<CROpportunityProbability.stageCode.IsEqual<@P.AsString>>.View.Select(this.Base, this.Base.Opportunity.Current.StageID);
                    CROpportunityProbabilityExt cROpportunityProbabilityExt = PXCache<CROpportunityProbability>.GetExtension<CROpportunityProbabilityExt>(cROpportunityProbability);
                    if(cROpportunityProbabilityExt != null)
                    {
                        PXResultset<NPOppTaskDetails> resultset = SelectFrom<NPOppTaskDetails>.InnerJoin<NPOppTask>.On<NPOppTask.oppTaskNbr.IsEqual<NPOppTaskDetails.oppTaskNbr>>
                        .Where<NPOppTask.oppTaskNbr.IsEqual<@P.AsString>>.View.Select(this.Base, cROpportunityProbabilityExt.UsrOppTaskNbr);
                        foreach (var item in resultset)
                        {
                            NPOppTaskDetails nPOppTaskDetails = (NPOppTaskDetails)item;
                            CRActivity cRActivity = SelectFrom<CRActivity>.Where<CRActivity.subject.StartsWith<@P.AsString>.And<CRActivity.refNoteID.IsEqual<@P.AsGuid>>>.View.Select(this.Base, cROpportunityProbability.Name + "-" + nPOppTaskDetails.SummaryDescr, this.Base.Opportunity.Current.NoteID);
                            if(cRActivity == null )
                            {
                                CRTaskMaint instance = PXGraph.CreateInstance<CRTaskMaint>();
                                instance.Tasks.Insert();
                                instance.Tasks.Current.Subject = cROpportunityProbability.Name + "-" + nPOppTaskDetails.SummaryDescr;
                                instance.Tasks.Current.StartDate = DateTime.Now;
                                instance.Tasks.Current.Body = nPOppTaskDetails.DetailsDescr;
                                instance.Tasks.Current.RefNoteID = this.Base.Opportunity.Current.NoteID;
                                instance.Save.Press();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                // Acuminator disable once PX1051 NonLocalizableString [Justification]
                // Acuminator disable once PX1050 HardcodedStringInLocalizationMethod [Justification]
                throw new PXException(ex.Message);
            }
    }


    #endregion
  }
}