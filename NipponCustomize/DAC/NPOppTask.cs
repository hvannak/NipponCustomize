using System;
using PX.Data;
using PX.Objects.CS;

namespace NipponCustomize
{
    [Serializable]
    [PXCacheName("NPOppTask")]
    public class NPOppTask : IBqlTable
    {
        #region OppTaskNbr
        [PXDBString(15, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Opp Task Nbr")]
        [AutoNumber(typeof(NPSetup.oppTaskNbr),
        typeof(AccessInfo.businessDate))]
        [PXSelector(typeof(Search<NPOppTask.oppTaskNbr>),
                typeof(NPOppTask.descr),
                DescriptionField = typeof(NPOppTask.descr))]
        public virtual string OppTaskNbr { get; set; }
        public abstract class oppTaskNbr : PX.Data.BQL.BqlString.Field<oppTaskNbr> { }
        #endregion
        #region LineCntr
        [PXDBInt()]
        [PXDefault(0)]
        public virtual int? LineCntr { get; set; }
        public abstract class lineCntr :PX.Data.BQL.BqlInt.Field<lineCntr>{ }
        #endregion
        #region Descr
        [PXDBString(150, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Description")]
        public virtual string Descr { get; set; }
        public abstract class descr : PX.Data.BQL.BqlString.Field<descr> { }
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