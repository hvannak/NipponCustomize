using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.GL.FinPeriods;
using PX.Objects.GL;

namespace NipponCustomize
{
    [Serializable]
    [PXCacheName("NPSalesPlanningDetails")]
    public class NPSalesPlanningDetails : IBqlTable
    {
        #region SalesPanngingNbr
        [PXDBString(15, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Sales Pannging Nbr")]
        [PXDBDefault(typeof(NPSalesPlanning.salesPanngingNbr))]
        [PXParent(typeof(SelectFrom<NPSalesPlanning>.
        Where<NPSalesPlanning.salesPanngingNbr.
        IsEqual<NPSalesPlanningDetails.salesPanngingNbr.FromCurrent>>))]
        public virtual string SalesPanngingNbr { get; set; }
        public abstract class salesPanngingNbr : PX.Data.BQL.BqlString.Field<salesPanngingNbr> { }
        #endregion

        #region WorkgroupID
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Workgroup ID")]
        [PXSelector(typeof(Search<PX.TM.EPCompanyTree.workGroupID>),
             SubstituteKey = typeof(PX.TM.EPCompanyTree.description))]
        public virtual int? WorkgroupID { get; set; }
        public abstract class workgroupID : PX.Data.BQL.BqlInt.Field<workgroupID> { }
        #endregion
        #region PeriodID
        [PXDBString(6,IsKey = true, IsFixed = true, InputMask = "")]
        [PXUIField(DisplayName = "PeriodID")]
        [PXDefault(typeof(SearchFor<MasterFinPeriod.finPeriodID>
        .Where<MasterFinPeriod.endDate.IsGreaterEqual<AccessInfo.businessDate.FromCurrent>
        .And<MasterFinPeriod.startDate.IsLessEqual<AccessInfo.businessDate.FromCurrent>>>),
        PersistingCheck = PXPersistingCheck.Nothing)]
        [FinPeriodIDFormatting]
        [PXSelector(typeof(Search<MasterFinPeriod.finPeriodID>))]
        public virtual string PeriodID { get; set; }
        public abstract class periodID : PX.Data.BQL.BqlString.Field<periodID> { }
        #endregion

        #region TargetAmount
        [PXDBDecimal()]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Target Amount")]
        [PXFormula(null, typeof(SumCalc<NPSalesPlanning.totalAmount>))]
        public virtual Decimal? TargetAmount { get; set; }
        public abstract class targetAmount : PX.Data.BQL.BqlDecimal.Field<targetAmount> { }
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