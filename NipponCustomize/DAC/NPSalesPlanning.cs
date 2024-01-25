using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.CS;
using PX.Objects.GL;
using PX.Objects.GL.FinPeriods;

namespace NipponCustomize
{
  [Serializable]
  [PXCacheName("NPSalesPlanning")]
  public class NPSalesPlanning : IBqlTable
  {
    #region SalesPanngingNbr
    [PXDBString(15, IsKey = true, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Sales Pannging Nbr")]
    [AutoNumber(typeof(NPSetup.salesPanngingNbr),
    typeof(NPSalesPlanning.docDate))]
        [PXSelector(typeof(Search<NPSalesPlanning.salesPanngingNbr>),
            typeof(NPSalesPlanning.docDate),
            typeof(NPSalesPlanning.totalAmount),
            typeof(NPSalesPlanning.descr),
            DescriptionField = typeof(NPSalesPlanning.descr))]
        public virtual string SalesPanngingNbr { get; set; }
    public abstract class salesPanngingNbr : PX.Data.BQL.BqlString.Field<salesPanngingNbr> { }
        #endregion

    #region DocDate
    [PXDBDate()]
    [PXUIField(DisplayName = "Doc Date")]
    [PXDefault(typeof(AccessInfo.businessDate))]
    public virtual DateTime? DocDate { get; set; }
    public abstract class docDate : PX.Data.BQL.BqlDateTime.Field<docDate> { }
    #endregion

    #region Descr
    [PXDBString(150, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Description")]
    public virtual string Descr { get; set; }
    public abstract class descr : PX.Data.BQL.BqlString.Field<descr> { }
        #endregion

    #region TargetAmount
    [PXDBDecimal()]
    [PXDefault(TypeCode.Decimal, "0.0")]
    [PXUIField(DisplayName = "Total Target Amount")]
    public virtual Decimal? TotalAmount { get; set; }
    public abstract class totalAmount : PX.Data.BQL.BqlDecimal.Field<totalAmount> { }
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