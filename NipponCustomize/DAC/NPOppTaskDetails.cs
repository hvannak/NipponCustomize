using System;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace NipponCustomize
{
    [Serializable]
    [PXCacheName("NPOppTaskDetails")]
    public class NPOppTaskDetails : IBqlTable
    {
        #region OppTaskNbr
        [PXDBString(15, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Opp Task Nbr")]
        [PXDBDefault(typeof(NPOppTask.oppTaskNbr))]
        [PXParent(typeof(SelectFrom<NPOppTask>.
        Where<NPOppTask.oppTaskNbr.
        IsEqual<NPOppTaskDetails.oppTaskNbr.FromCurrent>>))]
        public virtual string OppTaskNbr { get; set; }
        public abstract class oppTaskNbr : PX.Data.BQL.BqlString.Field<oppTaskNbr> { }
        #endregion

        #region SummaryDescr
        [PXDBString(150, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Summary Description")]
        public virtual string SummaryDescr { get; set; }
        public abstract class summaryDescr : PX.Data.BQL.BqlString.Field<summaryDescr> { }
        #endregion

        #region DetailsDescr
        [PXDBString(500, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Details Description")]
        public virtual string DetailsDescr { get; set; }
        public abstract class detailsDescr : PX.Data.BQL.BqlString.Field<detailsDescr> { }
        #endregion
        #region LineNbr
        [PXDBInt(IsKey = true)]
        [PXLineNbr(typeof(NPOppTask.lineCntr))]
        [PXUIField(DisplayName = "Line Nbr.", Visible = false)]
        public virtual int? LineNbr { get; set; }
        public abstract class lineNbr : PX.Data.BQL.BqlInt.Field<lineNbr> { }
        #endregion
        #region Tstamp
        [PXDBTimestamp()]
        [PXUIField(DisplayName = "Tstamp")]
        public virtual byte[] Tstamp { get; set; }
        public abstract class tstamp : PX.Data.BQL.BqlByteArray.Field<tstamp> { }
        #endregion
        #region CreatedByID
        [PXDBCreatedByID()]
        public virtual Guid? CreatedByID { get; set; }
        public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID> { }
        #endregion

        #region CreatedByScreenID
        [PXDBCreatedByScreenID()]
        public virtual string CreatedByScreenID { get; set; }
        public abstract class createdByScreenID : PX.Data.BQL.BqlString.Field<createdByScreenID> { }
        #endregion

        #region CreatedDateTime
        [PXDBCreatedDateTime()]
        public virtual DateTime? CreatedDateTime { get; set; }
        public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
        #endregion

        #region LastModifiedByID
        [PXDBLastModifiedByID()]
        public virtual Guid? LastModifiedByID { get; set; }
        public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID> { }
        #endregion

        #region LastModifiedByScreenID
        [PXDBLastModifiedByScreenID()]
        public virtual string LastModifiedByScreenID { get; set; }
        public abstract class lastModifiedByScreenID : PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> { }
        #endregion

        #region LastModifiedDateTime
        [PXDBLastModifiedDateTime()]
        public virtual DateTime? LastModifiedDateTime { get; set; }
        public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
        #endregion
    }
}