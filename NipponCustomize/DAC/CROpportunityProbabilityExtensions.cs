using PX.Data;
using PX.Objects.CR;
using PX.Objects;
using System.Collections.Generic;
using System;
using NipponCustomize;

namespace PX.Objects.CR
{
    // Acuminator disable once PX1016 ExtensionDoesNotDeclareIsActiveMethod extension should be constantly active
    public class CROpportunityProbabilityExt : PXCacheExtension<PX.Objects.CR.CROpportunityProbability>
    {
        #region UsrOppTaskNbr
        [PXDBString(15)]
        [PXUIField(DisplayName = "Opportunity TaskNbr")]
        [PXSelector(typeof(Search<NPOppTask.oppTaskNbr>),
                typeof(NPOppTask.descr),
                DescriptionField = typeof(NPOppTask.descr))]
        public virtual string UsrOppTaskNbr { get; set; }
        public abstract class usrOppTaskNbr : PX.Data.BQL.BqlString.Field<usrOppTaskNbr> { }
        #endregion
    }
}